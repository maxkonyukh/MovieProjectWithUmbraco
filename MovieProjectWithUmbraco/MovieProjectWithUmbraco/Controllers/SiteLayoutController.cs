﻿using MovieProjectWithUmbraco.Models;
using System.Collections.Generic;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using System.Linq;
using Umbraco.Core.Models;
using System.Web.Mvc;
using System;
using System.Web.Security;
using MovieProjectWithUmbraco.Extensions;
using Examine.LuceneEngine.SearchCriteria;

namespace MovieProjectWithUmbraco.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private const int RECENT_MOVIES = 1;
        private const int RECENT_PEOPLE = 1;
        private const int SEARCH_PAGE_ID = 2160;
        private const string PARTIALS_LAYOUT_PATH = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderHeader()
        {
            var layoutModel = GetNavigationModelFromDatabase();
            return PartialView(PARTIALS_LAYOUT_PATH + "_Header.cshtml", layoutModel);
        }

        public ActionResult RenderIntro()
        {
            var intro = GetIntro();
            return PartialView(PARTIALS_LAYOUT_PATH + "_Intro.cshtml", intro);
        }

        public ActionResult RenderInfoSection()
        {
            var infoSection = GetInfoSection();
            return PartialView(PARTIALS_LAYOUT_PATH + "_InfoSection.cshtml", infoSection);
        }

        public ActionResult RenderSearch()
        {
            return PartialView(PARTIALS_LAYOUT_PATH + "_Search.cshtml", new Models.Search());
        }

        [HttpGet]
        public ActionResult RenderSearchResults(Models.Search model)
        {
            var rootNodes = Umbraco.TypedContentAtRoot();
            var homeNodeByAlias = rootNodes.First(x => x.DocumentTypeAlias == "home");

            var searchPageUrl = homeNodeByAlias.Children.FirstOrDefault(p => p.Id == SEARCH_PAGE_ID).Url;
            var cuttedUrl = searchPageUrl.Substring(0, searchPageUrl.Length - 1);
            var queryParam = !string.IsNullOrEmpty(model.Query) ? string.Format("?query={0}", model.Query) : string.Empty;

            return Redirect(Uri.EscapeUriString(string.Format("{0}{1}", cuttedUrl, queryParam)));
;        }

        private Intro GetIntro()
        {
            var document = CurrentPage.Children.Where(x => x.DocumentTypeAlias == "homePageIntro").FirstOrDefault();

            return new Intro
            {
                ImagePath = document.GetCropUrl("author", "smSzImgCropper"),
                QuoteText = document.GetPropertyValue<string>("quote")
            };
        }

        private InfoSection GetInfoSection()
        {
            var rootNodes = Umbraco.TypedContentAtRoot();
            var homeNodeByAlias = rootNodes.First(x => x.DocumentTypeAlias == "home");
            
            return new InfoSection
            {
                RecentMovies = GetRecentlyAddedFilms(homeNodeByAlias),
                RecentPeople = GetRecentlyAddedPeople(homeNodeByAlias)
            };
        }

        private IEnumerable<InfoItem> GetRecentlyAddedFilms(IPublishedContent page)
        {
            var filmsPage = page.Children.Where(x => x.DocumentTypeAlias == "films").FirstOrDefault();

            foreach (var item in filmsPage.Children.OrderByDescending(p => p.CreateDate).Take(RECENT_MOVIES))
            {
                yield return new InfoItem()
                {
                    Title = item.GetPropertyValue<string>("title"),
                    ImagePath = item.GetCropUrl("image", "homeItemSzImgCropper"),
                    Url = item.Url
                };
            }
        }

        private IEnumerable<InfoItem> GetRecentlyAddedPeople(IPublishedContent page)
        {
            var peoplePage = page.Children.Where(x => x.DocumentTypeAlias == "people").FirstOrDefault();

            foreach (var item in peoplePage.Children.OrderByDescending(p => p.CreateDate).Take(RECENT_PEOPLE))
            {
                yield return new InfoItem()
                {
                    Title = item.GetPropertyValue<string>("shortName"),
                    ImagePath = item.GetCropUrl("image", "homeItemSzImgCropper"),
                    Url = item.Url
                };
            }
        }

        private Layout GetNavigationModelFromDatabase()
        {
            var homePage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "home").FirstOrDefault();

            var nav = new List<NavigationListItem>();
            nav.Add(new NavigationListItem(new NavigationLink(homePage.Url, homePage.Name)));
            nav.AddRange(GetChildNavigationList(homePage));

            IMember member = null;
            var user = Membership.GetUser();

            if (user != null)
                member = Services.MemberService.GetByUsername(user.UserName);

            var layoutModel = new Layout
            {
                Links = nav,
                UserImage = member?.GetAvatarUrl("avatarSmallSize"),
                UserName = member?.Username
            };

            return layoutModel;
        }

        private IEnumerable<NavigationListItem> GetChildNavigationList(IPublishedContent page)
        {
            var childPages = page.Children.Where("Visible").Where(x => !x.HasValue("hideFromNavigation") || 
                (x.HasValue("hideFromNavigation") && !x.GetPropertyValue<bool>("hideFromNavigation")));

            if (childPages != null && childPages.Any() && childPages.Count() > 0)
            {
                foreach (var childPage in childPages)
                {
                    var listItem = new NavigationListItem(new NavigationLink(childPage.Url, childPage.Name));
                    listItem.Items = GetChildNavigationList(childPage);

                    yield return listItem;
                }
            }
        }
    }
}