﻿using MovieProjectWithUmbraco.Extensions;
using MovieProjectWithUmbraco.Models;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace MovieProjectWithUmbraco.Controllers.Account
{
    public class AccountController : SurfaceController
    {
        private const string PathToAccountPages = "~/Views/Partials/Account/";

        public ActionResult RenderRegisterForm()
        {
            return PartialView(PathToAccountPages + "_Register.cshtml");
        }

        public ActionResult RenderLoginForm()
        {
            return PartialView(PathToAccountPages +  "_Login.cshtml");
        }

        [Authorize]
        public ActionResult RenderProfile()
        {
            var profileModel = GetProfileModel();

            return PartialView(PathToAccountPages + "_Profile.cshtml", profileModel);
        }

        public ActionResult MemberLogOut()
        {
            Session.Clear();
            FormsAuthentication.SignOut();

            return Redirect("/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitRegisterForm(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var memberService = Services.MemberService;
            if (memberService.GetByEmail(model.Email) != null)
            {
                ModelState.AddModelError("", "Member already exists");
                return CurrentUmbracoPage();
            }

            var member = memberService.CreateMemberWithIdentity(model.Login, model.Email, model.FullName, "Member");

            memberService.Save(member);
            memberService.SavePassword(member, model.Password);

            Members.Login(model.Login, model.Password);

            return Redirect("/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLoginForm(LoginModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var memberService = Services.MemberService;
            var member = memberService.GetByEmail(model.Login);

            if (member == null)
            {
                ModelState.AddModelError("", "This member doesn't exist or locked out.");
                return CurrentUmbracoPage();
            }

            var result = Members.Login(member.Username, model.Password);

            if (!result)
            {
                ModelState.AddModelError("", "Incorrect password.");
                return CurrentUmbracoPage();
            }

            return Redirect("/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ProfileModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var user = Membership.GetUser();

            if (user == null)
                return Redirect("/login");

            var memberService = Services.MemberService;
            var member = memberService.GetByUsername(user.UserName);

            if (member == null)
                return Redirect("/login");

            return PasswordValidation(memberService, member, model.ChangePassword.OldPassword, model.ChangePassword.NewPassword);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveContactInfo(ProfileModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var user = Membership.GetUser();

            if (user == null)
                return Redirect("/login");

            var memberService = Services.MemberService;
            var member = memberService.GetByUsername(user.UserName);

            if (member == null)
                return Redirect("/login");

            SetContactValues(member, model.ContactInfo);

            memberService.Save(member);

            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveBasicInfo(ProfileModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var user = Membership.GetUser();

            if (user == null)
                return Redirect("/login");

            var memberService = Services.MemberService;
            var member = memberService.GetByUsername(user.UserName);

            if (member == null)
                return Redirect("/login");

            SetBasicInfoValues(member, model.BasicInfo);

            memberService.Save(member);

            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeAvatar(HttpPostedFileBase avatar)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var user = Membership.GetUser();

            if (user == null)
                return Redirect("/login");

            var memberService = Services.MemberService;
            var member = memberService.GetByUsername(user.UserName);

            if (member == null)
                return Redirect("/login");

            if (avatar != null && avatar.ContentLength > 0)
            {
                DeleteExistingAvatar(member);
                SetNewAvatar(member, avatar.FileName, avatar.InputStream);

                memberService.Save(member);
            }

            return RedirectToCurrentUmbracoPage();
        }

        private void DeleteExistingAvatar(IMember member)
        {
            var currentAvatar = member.GetValue<string>("avatar");

            if (currentAvatar != null)
            {
                var avatarMedia = Services.MediaService.GetById(int.Parse(currentAvatar));

                if (avatarMedia != null)
                    Services.MediaService.Delete(avatarMedia);
            }
        }

        private void SetNewAvatar(IMember member, string fileName, Stream fileStream)
        {
            var avatarsFolderId = Umbraco
                .TypedMediaAtRoot()
                .FirstOrDefault(m => m.Name.InvariantEquals("User Avatars"))?.Id;

            if (avatarsFolderId != null)
            {
                var media = Services.MediaService.CreateMedia($"{fileName}", avatarsFolderId.Value, "avatar");

                media.SetValue("image", fileName, fileStream);
                Services.MediaService.Save(media);
                member.SetValue("avatar", media.Id);

                Services.MediaService.Save(media);
            }
        }

        private ActionResult PasswordValidation(
            IMemberService memberService, 
            IMember member, 
            string oldPassword, 
            string newPassword)
        {
            if (HashPassword(oldPassword) != member.RawPasswordValue)
            {
                ModelState.AddModelError("", "Old password was incorrect.");
                return CurrentUmbracoPage();
            }

            try
            {
                memberService.SavePassword(member, newPassword);
            }
            catch
            {
                ModelState.AddModelError("", "Password doesn't satisfy the requirements.");
                return CurrentUmbracoPage();
            }

            return RedirectToCurrentUmbracoPage();
        }

        private void SetContactValues(IMember member, ContactInfoModel model)
        {
            member.SetValue("city", model.City);
            member.SetValue("country", model.Country);
            member.SetValue("skype", model.Skype);
            member.SetValue("website", model.Website);
            member.SetValue("phoneNumber", model.PhoneNumber);
        }

        private void SetBasicInfoValues(IMember member, BasicInfoModel model)
        {
            member.SetValue("firstName", model.FirstName);
            member.SetValue("lastName", model.LastName);
            member.SetValue("hometown", model.Hometown);
        }

        private string HashPassword(string password)
        {
            HMACSHA1 hash = new HMACSHA1
            {
                Key = Encoding.Unicode.GetBytes(password)
            };
            string encodedPassword = Convert.ToBase64String(hash.ComputeHash(Encoding.Unicode.GetBytes(password)));

            return encodedPassword;
        }

        private ProfileModel GetProfileModel()
        {
            var user = Membership.GetUser();

            if (user == null)
                return null;

            var member = Services.MemberService.GetByUsername(user.UserName);

            if (member == null)
                return null;

            return new ProfileModel
            {
                BasicInfo = GetBasicInfo(member),
                ContactInfo = GetContactInfo(member),
                ChangePassword = new ChangePassword()
            };
        }

        private BasicInfoModel GetBasicInfo(IMember member)
        {
            return new BasicInfoModel
            {
                UserName = member.Username,
                FirstName = member.GetValue<string>("firstName"),
                LastName = member.GetValue<string>("lastName"),
                Hometown = member.GetValue<string>("hometown"),
                Avatar = member.GetAvatarUrl("avatarNormalSize")
            };
        }

        private ContactInfoModel GetContactInfo(IMember member)
        {
            return new ContactInfoModel
            {
                City = member.GetValue<string>("city"),
                Country = member.GetValue<string>("country"),
                Skype = member.GetValue<string>("skype"),
                Website = member.GetValue<string>("website"),
                PhoneNumber = member.GetValue<string>("phoneNumber")
            };
        }
    }
}