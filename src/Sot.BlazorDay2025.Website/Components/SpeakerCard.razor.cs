// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Components;

/// <summary />
public partial class SpeakerCard
{
    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Parameter]
    public string Width { get; set; } = "270px";

    /// <summary />
    [Parameter]
    public string Height { get; set; } = "520px";

    /// <summary />
    [Parameter]
    public required string Id { get; set; }

    /// <summary />
    private Speaker? Speaker { get; set; }

    /// <summary />
    protected override void OnInitialized()
    {
        Speaker = DataBase.Speakers.FirstOrDefault(s => string.Equals(s.Id, Id, StringComparison.OrdinalIgnoreCase));
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
