//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace MBran.Core.Models
{
	// Mixin content Type 1081 with alias "metaTagImage"
	/// <summary>_MetaTagImage</summary>
	public partial interface IMetaTagImage : IPublishedContent
	{
		/// <summary>Image</summary>
		IPublishedContent MetaImage { get; }
	}

	/// <summary>_MetaTagImage</summary>
	[PublishedContentModel("metaTagImage")]
	public partial class MetaTagImage : PublishedContentModel, IMetaTagImage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "metaTagImage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MetaTagImage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MetaTagImage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("metaImage")]
		public IPublishedContent MetaImage
		{
			get { return GetMetaImage(this); }
		}

		/// <summary>Static getter for Image</summary>
		public static IPublishedContent GetMetaImage(IMetaTagImage that) { return that.GetPropertyValue<IPublishedContent>("metaImage"); }
	}
}