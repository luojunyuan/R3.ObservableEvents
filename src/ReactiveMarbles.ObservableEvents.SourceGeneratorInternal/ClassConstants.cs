﻿// Copyright (c) 2019-2023 ReactiveUI Association Incorporated. All rights reserved.
// ReactiveUI Association Incorporated licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace R3.ObservableEvents.SourceGenerator;

internal static class ClassConstants
{
    public const string ExtensionMethodText = @"
// <auto-generated />
using System;
namespace R3.ObservableEvents
{
    /// <summary>
    /// Extension methods to generate IObservable for contained events on the class.
    /// </summary>
    internal static partial class ObservableGeneratorExtensions
    {
        /// <summary>
        /// Gets observable wrappers for all the events contained within the class.
        /// </summary>
        /// <returns>The events if available.</returns>
        public static NullEvents Events<T>(this T eventHost)
        {
            return default(NullEvents);
        }
    }

    /// <summary>
    /// Generates a IObservable`T` wrapper for the specified type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    internal class GenerateStaticEventObservablesAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref=""GenerateStaticEventObservablesAttribute""/> class.
        /// </summary>
        /// <param name=""type"">The static type to generate event observable wrappers for.</param>
        public GenerateStaticEventObservablesAttribute(Type type)
        {
            Type = type;
        }
        
        /// <summary>Gets the Type to generate the static event observable wrappers for.</summary>
        public Type Type { get; }
    }

    internal struct NullEvents
    {
    }
}";
}
