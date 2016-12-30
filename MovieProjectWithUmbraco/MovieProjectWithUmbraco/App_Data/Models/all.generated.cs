using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "f6d68cb1811c6eea")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Career</summary>
	[PublishedContentModel("career")]
	public partial class Career : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "career";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Career(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Career, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Country</summary>
	[PublishedContentModel("country")]
	public partial class Country : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "country";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Country(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Country, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About
		///</summary>
		[ImplementPropertyType("about")]
		public IHtmlString About
		{
			get { return this.GetPropertyValue<IHtmlString>("about"); }
		}

		///<summary>
		/// Image: Upload image for home page
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Film</summary>
	[PublishedContentModel("film")]
	public partial class Film : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "film";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Film(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Film, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Box Office: Enter box office of movie
		///</summary>
		[ImplementPropertyType("boxOffice")]
		public string BoxOffice
		{
			get { return this.GetPropertyValue<string>("boxOffice"); }
		}

		///<summary>
		/// Budget: Enter budget of movie
		///</summary>
		[ImplementPropertyType("budget")]
		public string Budget
		{
			get { return this.GetPropertyValue<string>("budget"); }
		}

		///<summary>
		/// Cast: All people starring in this movie
		///</summary>
		[ImplementPropertyType("cast")]
		public Newtonsoft.Json.Linq.JArray Cast
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("cast"); }
		}

		///<summary>
		/// Composers: Add composers of movie
		///</summary>
		[ImplementPropertyType("composers")]
		public Newtonsoft.Json.Linq.JArray Composers
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("composers"); }
		}

		///<summary>
		/// Countries: Select countries of production
		///</summary>
		[ImplementPropertyType("countries")]
		public object Countries
		{
			get { return this.GetPropertyValue("countries"); }
		}

		///<summary>
		/// Directors: Add directors of movie
		///</summary>
		[ImplementPropertyType("directors")]
		public Newtonsoft.Json.Linq.JArray Directors
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("directors"); }
		}

		///<summary>
		/// Distributors: Add distributors of movie
		///</summary>
		[ImplementPropertyType("distributors")]
		public Newtonsoft.Json.Linq.JArray Distributors
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("distributors"); }
		}

		///<summary>
		/// Image: Select image for film
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Plot: Enter plot of movie
		///</summary>
		[ImplementPropertyType("plot")]
		public IHtmlString Plot
		{
			get { return this.GetPropertyValue<IHtmlString>("plot"); }
		}

		///<summary>
		/// Producers: Add producers of movie
		///</summary>
		[ImplementPropertyType("producers")]
		public Newtonsoft.Json.Linq.JArray Producers
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("producers"); }
		}

		///<summary>
		/// Title: Title of movie
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Writers: Add screenplay writers of movie
		///</summary>
		[ImplementPropertyType("writers")]
		public Newtonsoft.Json.Linq.JArray Writers
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("writers"); }
		}

		///<summary>
		/// Date of Release: Enter the year of film release
		///</summary>
		[ImplementPropertyType("yearOfRelease")]
		public DateTime YearOfRelease
		{
			get { return this.GetPropertyValue<DateTime>("yearOfRelease"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Theatre</summary>
	[PublishedContentModel("theatre")]
	public partial class Theatre : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "theatre";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Theatre(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Theatre, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Distributor</summary>
	[PublishedContentModel("distributor")]
	public partial class Distributor : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "distributor";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Distributor(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Distributor, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Company name: Enter distribution company name
		///</summary>
		[ImplementPropertyType("companyName")]
		public string CompanyName
		{
			get { return this.GetPropertyValue<string>("companyName"); }
		}

		///<summary>
		/// Date of foundation: Enter date of foundation of company
		///</summary>
		[ImplementPropertyType("dateOfFoundation")]
		public DateTime DateOfFoundation
		{
			get { return this.GetPropertyValue<DateTime>("dateOfFoundation"); }
		}

		///<summary>
		/// Founders: Select founders of company
		///</summary>
		[ImplementPropertyType("founders")]
		public Newtonsoft.Json.Linq.JArray Founders
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("founders"); }
		}

		///<summary>
		/// History: Enter history of company-distributor
		///</summary>
		[ImplementPropertyType("history")]
		public IHtmlString History
		{
			get { return this.GetPropertyValue<IHtmlString>("history"); }
		}

		///<summary>
		/// Image: Select image for distributor
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Person</summary>
	[PublishedContentModel("person")]
	public partial class Person : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "person";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Person(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Person, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Biography: Enter biography of person
		///</summary>
		[ImplementPropertyType("biography")]
		public IHtmlString Biography
		{
			get { return this.GetPropertyValue<IHtmlString>("biography"); }
		}

		///<summary>
		/// Careers: Select careers
		///</summary>
		[ImplementPropertyType("careers")]
		public object Careers
		{
			get { return this.GetPropertyValue("careers"); }
		}

		///<summary>
		/// Countries: Select countries
		///</summary>
		[ImplementPropertyType("countries")]
		public object Countries
		{
			get { return this.GetPropertyValue("countries"); }
		}

		///<summary>
		/// Date of Birth: Enter date of birth of person
		///</summary>
		[ImplementPropertyType("dateOfBirth")]
		public DateTime DateOfBirth
		{
			get { return this.GetPropertyValue<DateTime>("dateOfBirth"); }
		}

		///<summary>
		/// Full Name: Enter full name of person
		///</summary>
		[ImplementPropertyType("fullName")]
		public string FullName
		{
			get { return this.GetPropertyValue<string>("fullName"); }
		}

		///<summary>
		/// Image: Select image for person
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Short Name: Enter short name of person
		///</summary>
		[ImplementPropertyType("shortName")]
		public string ShortName
		{
			get { return this.GetPropertyValue<string>("shortName"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	// Mixin content Type 1077 with alias "navigationBarControls"
	/// <summary>Navigation Bar Controls</summary>
	public partial interface INavigationBarControls : IPublishedContent
	{
		/// <summary>Hide from navigation?</summary>
		bool HideFromNavigation { get; }
	}

	/// <summary>Navigation Bar Controls</summary>
	[PublishedContentModel("navigationBarControls")]
	public partial class NavigationBarControls : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "navigationBarControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NavigationBarControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NavigationBarControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return GetHideFromNavigation(this); }
		}

		/// <summary>Static getter for Hide from navigation?</summary>
		public static bool GetHideFromNavigation(INavigationBarControls that) { return that.GetPropertyValue<bool>("hideFromNavigation"); }
	}

	/// <summary>Films</summary>
	[PublishedContentModel("films")]
	public partial class Films : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "films";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Films(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Films, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>People</summary>
	[PublishedContentModel("people")]
	public partial class People : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "people";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public People(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<People, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Distributors</summary>
	[PublishedContentModel("distributors")]
	public partial class Distributors : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "distributors";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Distributors(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Distributors, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>HomePageIntro</summary>
	[PublishedContentModel("homePageIntro")]
	public partial class HomePageIntro : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePageIntro";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePageIntro(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePageIntro, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author: Upload author photo
		///</summary>
		[ImplementPropertyType("author")]
		public Umbraco.Web.Models.ImageCropDataSet Author
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("author"); }
		}

		///<summary>
		/// Quote: Enter quote phrase
		///</summary>
		[ImplementPropertyType("quote")]
		public IHtmlString Quote
		{
			get { return this.GetPropertyValue<IHtmlString>("quote"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Register</summary>
	[PublishedContentModel("register")]
	public partial class Register : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "register";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Register(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Register, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Login</summary>
	[PublishedContentModel("login")]
	public partial class Login : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "login";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Login(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Login, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>News</summary>
	[PublishedContentModel("news")]
	public partial class News : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "news";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public News(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<News, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content: Enter content for news
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return this.GetPropertyValue<IHtmlString>("content"); }
		}

		///<summary>
		/// Image: Select image for news
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Title: Enter title for news
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>News ticker</summary>
	[PublishedContentModel("newsTicker")]
	public partial class NewsTicker : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "newsTicker";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NewsTicker(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsTicker, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Feedback</summary>
	[PublishedContentModel("feedback")]
	public partial class Feedback : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "feedback";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Feedback(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Feedback, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Feedback text: Content of feedback
		///</summary>
		[ImplementPropertyType("feedbackText")]
		public string FeedbackText
		{
			get { return this.GetPropertyValue<string>("feedbackText"); }
		}

		///<summary>
		/// Member: If of author of comment
		///</summary>
		[ImplementPropertyType("member")]
		public string Member
		{
			get { return this.GetPropertyValue<string>("member"); }
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Search</summary>
	[PublishedContentModel("search")]
	public partial class Search : PublishedContentModel, INavigationBarControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "search";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Search(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Search, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from navigation?: Tick this if you don't want this page appear in the top
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return NavigationBarControls.GetHideFromNavigation(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
