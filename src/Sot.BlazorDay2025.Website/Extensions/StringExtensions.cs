// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Markdig;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace Sot.BlazorDay2025.Website.Extensions;

/// <summary />
public static class StringExtensions
{
    private static readonly MarkdownPipeline MarkdownPipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

    private static readonly Regex NonAlphanumericRegex = new Regex("[^a-z0-9\\s-]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private static readonly Regex WhitespaceAndHyphenRegex = new Regex("[\\s-]+", RegexOptions.Compiled);

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

    /// <summary>
    /// Converts a string to a URL-friendly slug (lowercase, alphanumeric, hyphens).
    /// </summary>
    public static string ToSlug(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }
        
        var slug = value.ToLowerInvariant();
        slug = NonAlphanumericRegex.Replace(slug, "");
        slug = WhitespaceAndHyphenRegex.Replace(slug, "-");
        slug = slug.Trim('-');
        return slug;
    }
}
