﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:v4.0.30319
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//---
using System;
using APE.Umbraco;
namespace RhinoTech.App.Classes.Cms
{
    public partial class NewsSection : Viewmaster
    {

		public NewsSection(): base()		
		{
			this.Header = new StringProperty(){ Alias = "header" };
			this.BodyText = new HtmlStringProperty(){ Alias = "bodyText" };
				
		}

		[Obsolete("Use the implicit operator... Just remove the .DocTypeAlias")]
		new public readonly string DocTypeAlias = "NewsSection";

		public static implicit operator string(NewsSection doctype)
		{
			return "NewsSection";
		}
	 		
				
		/// <summary>
		///		<para>Datatype: Textstring</para>
		/// </summary>
		public StringProperty Header { get; private set; }		
				
		/// <summary>
		///		<para>Datatype: Richtext editor</para>
		/// </summary>
		public HtmlStringProperty BodyText { get; private set; }
	}
}
