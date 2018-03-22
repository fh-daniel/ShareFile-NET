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
	public class TenantZoneUsageReport : ODataObject 
	{
		public IDictionary<string, ZoneUsageBreakdown> TenantsToZones { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as TenantZoneUsageReport;
			if(typedSource != null)
			{
				TenantsToZones = typedSource.TenantsToZones;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("TenantsToZones", out token) && token.Type != JTokenType.Null)
				{
					TenantsToZones = (IDictionary<string, ZoneUsageBreakdown>)serializer.Deserialize(token.CreateReader(), typeof(IDictionary<string, ZoneUsageBreakdown>));
				}
			}
		}
	}
}