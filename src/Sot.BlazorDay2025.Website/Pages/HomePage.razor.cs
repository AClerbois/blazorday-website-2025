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
    private static readonly DateTime CallForPaperDeadline = new(2025, 8, 1);
    private static readonly DateTimeOffset ReminderDeadLine = new(2025, 9, 24, 14, 0, 0, TimeSpan.Zero); // 2025-09-24 - 16:00 UTC+2

    private static bool IsCallForPaperOpen => DateTime.UtcNow.Date <= CallForPaperDeadline;

    private static bool IsReminderOpen => DateTimeOffset.UtcNow <= ReminderDeadLine;

    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    private async Task GetReminderAsync()
    {
        await JSRuntime.InvokeVoidAsync("openInNewTab", DataBase.ReminderUrl);
    }

    private async Task CallForPaperAsync()
    {
        await JSRuntime.InvokeVoidAsync("openInNewTab", DataBase.CallForPaperUrl);
    }

    private async Task WatchLiveStreamAsync()
    {
        await JSRuntime.InvokeVoidAsync("openInNewTab", DataBase.LiveStreamUrl);
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
        else
        {
            NavigationManager.NavigateTo(url);
        }
    }
}
