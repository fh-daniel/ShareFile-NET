// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	/// <summary>
	/// UserInfo
	/// </summary>
	public class UserInfo : ODataObject 
	{
		/// <summary>
		/// Company Name
		/// </summary>
		public string CompanyName { get; set; }
		/// <summary>
		/// Plan Name
		/// </summary>
		public string PlanName { get; set; }
		/// <summary>
		/// Plan Features
		/// </summary>
		public PlanFeatures PlanFeatures { get; set; }
		/// <summary>
		/// Application URL
		/// </summary>
		public string ApplicationUrl { get; set; }
		/// <summary>
		/// Default Storage Center Url
		/// </summary>
		public string StorageCenterUrl { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as UserInfo;
			if(typedSource != null)
			{
				CompanyName = typedSource.CompanyName;
				PlanName = typedSource.PlanName;
				PlanFeatures = typedSource.PlanFeatures;
				ApplicationUrl = typedSource.ApplicationUrl;
				StorageCenterUrl = typedSource.StorageCenterUrl;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("CompanyName", out token) && token.Type != JTokenType.Null)
				{
					CompanyName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("PlanName", out token) && token.Type != JTokenType.Null)
				{
					PlanName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("PlanFeatures", out token) && token.Type != JTokenType.Null)
				{
					PlanFeatures = (PlanFeatures)serializer.Deserialize(token.CreateReader(), typeof(PlanFeatures));
				}
				if(source.TryGetProperty("ApplicationUrl", out token) && token.Type != JTokenType.Null)
				{
					ApplicationUrl = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("StorageCenterUrl", out token) && token.Type != JTokenType.Null)
				{
					StorageCenterUrl = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}