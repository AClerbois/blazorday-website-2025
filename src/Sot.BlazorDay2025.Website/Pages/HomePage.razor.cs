// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.JSInterop;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Pages;

/// <summary />
public partial class HomePage
{
    private static readonly Icon OpenIcon = new Microsoft.FluentUI.AspNetCore.Components.Icons.Regular.Size20.Open();

    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    private async Task FollowLiveAsync()
    {
        await JSRuntime.InvokeVoidAsync("openInNewTab", DataBase.LiveUrl);
    }

    /// <summary>
    /// Display the Home Card detail page
    /// </summary>
    private async Task OpenHomeDetailAsync(string url)
    {
        if (url.StartsWith("http", StringComparison.Ordinal))
        {
            await JSRuntime.InvokeVoidAsync("openInNewTab", url);
        }

        NavigationManager.NavigateTo(url);
    }
}
