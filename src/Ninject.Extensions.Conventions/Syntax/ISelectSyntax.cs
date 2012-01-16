﻿//-------------------------------------------------------------------------------
// <copyright file="ISelectSyntax.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2012 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.Extensions.Conventions.Syntax
{
    using System;

    /// <summary>
    /// Syntax to select the types
    /// </summary>
    public interface ISelectSyntax
    {
        /// <summary>
        /// Selects the types using the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>The fluent syntax</returns>
        IFromExcludeIncludeBindSyntax Select(Func<Type, bool> filter);

        /// <summary>
        /// Selects all types.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax SelectAllTypes();

        /// <summary>
        /// Selects all none abstract classes.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax SelectAllClasses();

        /// <summary>
        /// Selects all calsses including abstract ones.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax SelectAllIncludingAbstractClasses();

        /// <summary>
        /// Selects all abstract classes.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax SelectAllAbstractClasses();

        /// <summary>
        /// Selects all interfaces.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax SelectAllInterfaces();
    }
}