﻿// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.SemanticKernel.Orchestration;

namespace Microsoft.SemanticKernel.SemanticFunctions;

/// <summary>
/// Interface for prompt template.
/// </summary>
public interface IPromptTemplate
{
    /// <summary>
    /// The list of parameters required by the template, using configuration and template info.
    /// </summary>
    IReadOnlyList<ParameterView> Parameters { get; }

    /// <summary>
    /// Render the template using the information in the context
    /// </summary>
    /// <param name="executionContext">Kernel execution context helpers</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> to monitor for cancellation requests. The default is <see cref="CancellationToken.None"/>.</param>
    /// <returns>Prompt rendered to string</returns>
    public Task<string> RenderAsync(SKContext executionContext, CancellationToken cancellationToken = default);
}
