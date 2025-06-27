// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Markdig;
using Microsoft.AspNetCore.Components;

namespace Sot.BlazorDay2025.Website.Extensions;

/// <summary />
public static class StringExtensions
{
    private static readonly MarkdownPipeline MarkdownPipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

    /// <summary>
    /// Converts a markdown string into a MarkupString object. Returns null if the input is null.
    /// </summary>
    /// <param name="markdown">The input string containing markdown content to be converted.</param>
    /// <returns>A MarkupString representation of the converted markdown or null if the input was null.</returns>
    public static MarkupString? FormatMarkdown(this string? markdown)
    {
        if (markdown is null)
        {
            return null;
        }

        return (MarkupString)Markdown.ToHtml(markdown, MarkdownPipeline);
    }
}
