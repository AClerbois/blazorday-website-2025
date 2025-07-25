// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Components;

/// <summary />
public partial class SpeakerBanner
{
    private const string SpeakerWidth = "160px";

    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    /// <summary />
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("startHorizontalScroll", "speaker-scroll-container", 0.5); // Adjust speed as needed
        }
    }

    /// <summary>
    /// Display the speaker detail page
    /// </summary>
    internal async Task OpenSpeakerDetailAsync(string id)
    {
        NavigationManager.NavigateTo($"/speakers/{id}");
        await Task.CompletedTask;
    }
}
