// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.JSInterop;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Pages;

/// <summary />
public partial class TeamPage
{
    private static readonly Icon OpenIcon = new Microsoft.FluentUI.AspNetCore.Components.Icons.Regular.Size20.Open();

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    public IEnumerable<TeamMember> TeamMembers => DataBase.TeamMembers;

    /// <summary>
    /// Display the speaker detail page
    /// </summary>
    private async Task OpenTeamDetailAsync(string url)
    {
        await JSRuntime.InvokeVoidAsync("openInNewTab", url);
    }
}
