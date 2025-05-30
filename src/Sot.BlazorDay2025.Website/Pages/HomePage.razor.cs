// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Sot.BlazorDay2025.Website.Pages;

/// <summary />
public partial class HomePage
{
    private static readonly Icon OpenIcon = new Microsoft.FluentUI.AspNetCore.Components.Icons.Regular.Size20.Open();

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    /// <summary>
    /// Display the speaker detail page
    /// </summary>
    private async Task OpenTeamDetailAsync(string url)
    {
        if (url.StartsWith("http", StringComparison.Ordinal))
        {
            await JSRuntime.InvokeVoidAsync("openInNewTab", url);
        }

        NavigationManager.NavigateTo(url);
    }
}
