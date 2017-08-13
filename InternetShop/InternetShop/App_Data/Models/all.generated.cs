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
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "fff1630fdf4a7f14")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header format: Size of a header
		///</summary>
		[ImplementPropertyType("headerFormat")]
		public string HeaderFormat
		{
			get { return this.GetPropertyValue<string>("headerFormat"); }
		}

		///<summary>
		/// Header Picture
		///</summary>
		[ImplementPropertyType("headerPicture")]
		public Umbraco.Web.Models.ImageCropDataSet HeaderPicture
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("headerPicture"); }
		}

		///<summary>
		/// Page title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}
	}

	/// <summary>Layout-12-cols</summary>
	[PublishedContentModel("layout12Cols")]
	public partial class Layout12Cols : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "layout12Cols";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Layout12Cols(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Layout12Cols, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Layout-3-9-cols</summary>
	[PublishedContentModel("layout39Cols")]
	public partial class Layout39Cols : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "layout39Cols";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Layout39Cols(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Layout39Cols, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Left Widgets: Contains all widgets to be displayed on the left
		///</summary>
		[ImplementPropertyType("leftWidgets")]
		public IEnumerable<IPublishedContent> LeftWidgets
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("leftWidgets"); }
		}
	}

	/// <summary>Start Page</summary>
	[PublishedContentModel("startPage")]
	public partial class StartPage : Layout12Cols
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "startPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public StartPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<StartPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Layout-9-3-cols</summary>
	[PublishedContentModel("layout93Cols")]
	public partial class Layout93Cols : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "layout93Cols";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Layout93Cols(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Layout93Cols, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Right Widgets: Contains all widgets to be displayed on the right
		///</summary>
		[ImplementPropertyType("rightWidgets")]
		public IEnumerable<IPublishedContent> RightWidgets
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("rightWidgets"); }
		}
	}

	/// <summary>Layout-3-6-3-cols</summary>
	[PublishedContentModel("layout363Cols")]
	public partial class Layout363Cols : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "layout363Cols";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Layout363Cols(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Layout363Cols, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Left Widgets: Contains all widgets to be displayed on the left
		///</summary>
		[ImplementPropertyType("leftWidgets")]
		public IEnumerable<IPublishedContent> LeftWidgets
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("leftWidgets"); }
		}

		///<summary>
		/// Right Widgets: Contains all widgets to be displayed on the right
		///</summary>
		[ImplementPropertyType("rightWidgets")]
		public IEnumerable<IPublishedContent> RightWidgets
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("rightWidgets"); }
		}
	}

	/// <summary>Intermediate category</summary>
	[PublishedContentModel("intermediateCategory")]
	public partial class IntermediateCategory : Layout39Cols
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "intermediateCategory";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public IntermediateCategory(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<IntermediateCategory, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner
		///</summary>
		[ImplementPropertyType("banner")]
		public IPublishedContent Banner
		{
			get { return this.GetPropertyValue<IPublishedContent>("banner"); }
		}
	}

	/// <summary>Product category</summary>
	[PublishedContentModel("productCategory")]
	public partial class ProductCategory : Layout39Cols
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "productCategory";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProductCategory(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductCategory, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner
		///</summary>
		[ImplementPropertyType("banner")]
		public IPublishedContent Banner
		{
			get { return this.GetPropertyValue<IPublishedContent>("banner"); }
		}

		///<summary>
		/// Properties' List: List of properties shared by all products of this category
		///</summary>
		[ImplementPropertyType("propertiesList")]
		public TableEditor.Models.TableEditorModel PropertiesList
		{
			get { return this.GetPropertyValue<TableEditor.Models.TableEditorModel>("propertiesList"); }
		}
	}

	/// <summary>Categories</summary>
	[PublishedContentModel("categories")]
	public partial class Categories : Layout12Cols
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "categories";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Categories(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Categories, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Product</summary>
	[PublishedContentModel("product")]
	public partial class Product : ProductCategory
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "product";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Product(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Product, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Carousel
		///</summary>
		[ImplementPropertyType("carousel")]
		public IEnumerable<IPublishedContent> Carousel
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("carousel"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Discount: Discount (in %) for one item of product
		///</summary>
		[ImplementPropertyType("discount")]
		public int Discount
		{
			get { return this.GetPropertyValue<int>("discount"); }
		}

		///<summary>
		/// In Stock: Items available in stock
		///</summary>
		[ImplementPropertyType("inStock")]
		public int InStock
		{
			get { return this.GetPropertyValue<int>("inStock"); }
		}

		///<summary>
		/// Price: Price of one item of product
		///</summary>
		[ImplementPropertyType("price")]
		public int Price
		{
			get { return this.GetPropertyValue<int>("price"); }
		}

		///<summary>
		/// Properties' Values: Defines values for properties defined in "Properties' List"
		///</summary>
		[ImplementPropertyType("propertiesValues")]
		public TableEditor.Models.TableEditorModel PropertiesValues
		{
			get { return this.GetPropertyValue<TableEditor.Models.TableEditorModel>("propertiesValues"); }
		}
	}

	/// <summary>Carousel</summary>
	[PublishedContentModel("carousel")]
	public partial class Carousel : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "carousel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Carousel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Carousel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// MyCarousel
		///</summary>
		[ImplementPropertyType("myCarousel")]
		public IEnumerable<IPublishedContent> MyCarousel
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("myCarousel"); }
		}
	}

	/// <summary>Carousel Item</summary>
	[PublishedContentModel("carouselItem")]
	public partial class CarouselItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "carouselItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CarouselItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CarouselItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public IPublishedContent Link
		{
			get { return this.GetPropertyValue<IPublishedContent>("link"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Basket</summary>
	[PublishedContentModel("basket")]
	public partial class Basket : Layout12Cols
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basket";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Basket(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Basket, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Widget</summary>
	[PublishedContentModel("widget")]
	public partial class Widget : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "widget";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Widget(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Widget, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Custom Property Alias: Alias of the property to be displayed. Fill in only in cas you chose "Custom property" as widget type
		///</summary>
		[ImplementPropertyType("customPropertyAlias")]
		public string CustomPropertyAlias
		{
			get { return this.GetPropertyValue<string>("customPropertyAlias"); }
		}

		///<summary>
		/// Custom widget display type: Choose the way you want your custom widget information to be displayed
		///</summary>
		[ImplementPropertyType("customWidgetDisplayType")]
		public string CustomWidgetDisplayType
		{
			get { return this.GetPropertyValue<string>("customWidgetDisplayType"); }
		}

		///<summary>
		/// Type: Type of the widget. Choose "Custom property" to display text value of a specific document property
		///</summary>
		[ImplementPropertyType("type")]
		public string Type
		{
			get { return this.GetPropertyValue<string>("type"); }
		}

		///<summary>
		/// Widget title: Title of the widget that will be displayed. Defaults to an empty string
		///</summary>
		[ImplementPropertyType("widgetTitle")]
		public string WidgetTitle
		{
			get { return this.GetPropertyValue<string>("widgetTitle"); }
		}
	}

	/// <summary>Comment</summary>
	[PublishedContentModel("comment")]
	public partial class Comment : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "comment";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Comment(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Comment, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Adding Time
		///</summary>
		[ImplementPropertyType("addingTime")]
		public DateTime AddingTime
		{
			get { return this.GetPropertyValue<DateTime>("addingTime"); }
		}

		///<summary>
		/// Advantages
		///</summary>
		[ImplementPropertyType("advantages")]
		public string Advantages
		{
			get { return this.GetPropertyValue<string>("advantages"); }
		}

		///<summary>
		/// Disadvantages
		///</summary>
		[ImplementPropertyType("disadvantages")]
		public string Disadvantages
		{
			get { return this.GetPropertyValue<string>("disadvantages"); }
		}

		///<summary>
		/// Estimate
		///</summary>
		[ImplementPropertyType("estimate")]
		public int Estimate
		{
			get { return this.GetPropertyValue<int>("estimate"); }
		}

		///<summary>
		/// Message Text
		///</summary>
		[ImplementPropertyType("messageText")]
		public string MessageText
		{
			get { return this.GetPropertyValue<string>("messageText"); }
		}

		///<summary>
		/// Response
		///</summary>
		[ImplementPropertyType("response")]
		public string Response
		{
			get { return this.GetPropertyValue<string>("response"); }
		}

		///<summary>
		/// Sender Email
		///</summary>
		[ImplementPropertyType("senderEmail")]
		public string SenderEmail
		{
			get { return this.GetPropertyValue<string>("senderEmail"); }
		}

		///<summary>
		/// Sender Name
		///</summary>
		[ImplementPropertyType("senderName")]
		public string SenderName
		{
			get { return this.GetPropertyValue<string>("senderName"); }
		}
	}

	/// <summary>Purchase</summary>
	[PublishedContentModel("purchase")]
	public partial class Purchase : Layout363Cols
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "purchase";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Purchase(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Purchase, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
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
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
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
