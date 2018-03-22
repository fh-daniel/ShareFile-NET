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
namespace ShareFile.Api.Client.Models 
{
    
    /// <summary>
    /// Data Loss Prevention file scan status.
    /// </summary>
    public enum DlpStatus
    {
        
        /// <summary>
        /// The file has not been scanned for policy violations.
        /// </summary>
        Unscanned = 0,
        
        /// <summary>
        /// The file has been scanned and no policy violations were found.
        /// </summary>
        ScannedOK = 1,
        
        /// <summary>
        /// The file has been scanned and a policy violation was found.
        /// </summary>
        ScannedRejected = 2
    }
}
