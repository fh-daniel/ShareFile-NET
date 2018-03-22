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
	/// EncryptedEmail Reply Params
	/// </summary>
	public class EncryptedEmailReplyParams : EncryptedEmailParams 
	{
		/// <summary>
		/// To Recipients
		/// </summary>
		public IEnumerable<Principal> ToRecipients { get; set; }
		/// <summary>
		/// CC Recipients
		/// </summary>
		public IEnumerable<Principal> CcRecipients { get; set; }
		/// <summary>
		/// BCC Recipients
		/// </summary>
		public IEnumerable<Principal> BccRecipients { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as EncryptedEmailReplyParams;
			if(typedSource != null)
			{
				ToRecipients = typedSource.ToRecipients;
				CcRecipients = typedSource.CcRecipients;
				BccRecipients = typedSource.BccRecipients;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ToRecipients", out token) && token.Type != JTokenType.Null)
				{
					ToRecipients = (IEnumerable<Principal>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Principal>));
				}
				if(source.TryGetProperty("CcRecipients", out token) && token.Type != JTokenType.Null)
				{
					CcRecipients = (IEnumerable<Principal>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Principal>));
				}
				if(source.TryGetProperty("BccRecipients", out token) && token.Type != JTokenType.Null)
				{
					BccRecipients = (IEnumerable<Principal>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Principal>));
				}
			}
		}
	}
}