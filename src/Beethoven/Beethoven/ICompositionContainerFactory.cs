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
 * File Name: ICompositionContainerFactory.cs
 * 
 * File Authors:
 * 		Mehmetali N. Shaqiri, m.shaqiri@spartansoft.org
 * 
 * Date Created:
 *      29.07.2011 06:04 PM
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace Beethoven
{
    /// <summary>
    /// Defines the required contract for implementing a container factory.
    /// </summary>
    public interface ICompositionContainerFactory
    {

        /// <summary>
        /// Creates a <see cref="CompositionContainer"/>
        /// </summary>
        /// <param name="path">The path of the assemblies.</param>
        /// <returns>An instance of <see cref="CompositionContainer"/></returns>
        CompositionContainer CreateCompositionContainer(Assembly currentAssembly);

    }
}
