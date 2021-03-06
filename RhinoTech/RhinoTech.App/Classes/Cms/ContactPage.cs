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
    public partial class ContactPage : Viewmaster
    {

		public ContactPage(): base()		
		{
			this.Header = new StringProperty(){ Alias = "header" };
			this.BodyText = new HtmlStringProperty(){ Alias = "bodyText" };
			this.EmailTemplate = new HtmlStringProperty(){ Alias = "emailTemplate" };
				
		}

		[Obsolete("Use the implicit operator... Just remove the .DocTypeAlias")]
		new public readonly string DocTypeAlias = "ContactPage";

		public static implicit operator string(ContactPage doctype)
		{
			return "ContactPage";
		}
	 		
				
		/// <summary>
		///		<para>Datatype: Textstring</para>
		/// </summary>
		public StringProperty Header { get; private set; }		
				
		/// <summary>
		///		<para>Datatype: Richtext editor</para>
		/// </summary>
		public HtmlStringProperty BodyText { get; private set; }		
				
		/// <summary>
		///		<para>Datatype: Richtext editor</para>
		///		<para>Description: Use the following replace values to mix form data into the reply: ##name## ##email## ##phone## ##address## ##postalcity## ##message##</para>
		/// </summary>
		public HtmlStringProperty EmailTemplate { get; private set; }
	}
}
