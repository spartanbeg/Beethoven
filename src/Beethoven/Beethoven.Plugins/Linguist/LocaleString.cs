﻿/*
 * Beethoven - A lightweight framework for building plugin based 
 * web applications using Asp.Net MVC and MEF.
 * 
 * Written for .NET 4.0 in C#
 * 
 * Copyright (C) 2009, 2010, 2011. All Right Reserved, Spartansoft L.L.C.
 * http://spartansoft.org
 * 
 * Proprietary and Confidential information of Spartansoft L.L.C. 
 * Redistribution and use in source and binary forms, with or without modification, 
 * without the authorization of Spartansoft L.L.C.  is prohibited. * 
 * 
 * "Whatever happens SPARTAN's code must stand ... or at least crash responsibly."
 *  
 * File Name: LocaleString.cs
 * 
 * File Authors:
 * 		Mehmetali N. Shaqiri, m.shaqiri@spartansoft.org
 * 
 * Date Created:
 *      01.08.2011 09:30 PM
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beethoven.Plugins.Linguist
{
    /// <summary>
    /// Implements the ILocaleString Interface
    /// </summary>
    public class LocaleString : ILocaleString
    {
        #region ILocaleString Members

        /// <summary>
        /// The unique identifier of the locale string
        /// </summary>
        public int ID { get; set; }


        /// <summary>
        /// The value of the locale string
        /// </summary>
        public string Value { get; set; }

        #endregion
    }
}
