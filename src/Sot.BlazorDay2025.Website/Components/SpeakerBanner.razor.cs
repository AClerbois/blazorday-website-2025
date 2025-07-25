// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Components;

/// <summary />
public partial class SpeakerBanner
{
    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary>
    /// Display the speaker detail page
    /// </summary>
    internal async Task OpenSpeakerDetailAsync(string id)
    {
        NavigationManager.NavigateTo($"/speakers/{id}");
        await Task.CompletedTask;
    }
}
