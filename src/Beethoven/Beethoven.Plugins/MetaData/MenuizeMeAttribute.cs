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
 * File Name: MenuizeMeAttribute.cs
 * 
 * File Authors:
 * 		Mehmetali N. Shaqiri, m.shaqiri@spartansoft.org
 * 
 * Date Created:
 *      29.07.2011 09:00 PM
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Beethoven.Plugins.MetaData
{
    /// <summary>
    /// Meta data about menu items
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class MenuizeMeAttribute : ExportAttribute, IMenuItemMetadata
    {
        #region Class Constructors


        public MenuizeMeAttribute() : base(typeof(IMenuItemMetadata)) { }


        #endregion

        #region IMenuItemMetadata Members

        public string PluginID { get; set; }

        public string DisplayText { get; set; }

        public string ParentID { get; set; }       

        public int OrderNumber { get; set; }

        public string Action { get; set; }

        public string Controller { get; set; }

        public object Params { get; set; }

        public bool IsDefault { get; set; }

        #endregion

    }
}
