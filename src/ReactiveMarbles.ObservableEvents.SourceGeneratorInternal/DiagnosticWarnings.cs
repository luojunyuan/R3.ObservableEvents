﻿// Copyright (c) 2019-2023 ReactiveUI Association Incorporated. All rights reserved.
// ReactiveUI Association Incorporated licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;

namespace R3.PropertyChanged.SourceGenerator;

internal static class DiagnosticWarnings
{
    internal static readonly DiagnosticDescriptor EventsNotFound = new(
        id: "RXPHARM001",
        title: "Events not found",
        messageFormat: "Events not be found on the target type",
        category: "Compiler",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);
}
