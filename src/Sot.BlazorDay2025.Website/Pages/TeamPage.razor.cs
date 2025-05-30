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
    private static readonly TeamMember[] TeamMembers =
    [
        new TeamMember
        {
            Name = "Laurent Bugnion",
            Title = "Principal Cloud Developer Advocate @ Microsoft",
            ImageUrl = "/img/team-laurent.jpg",
            LinkedIn = "https://www.linkedin.com/in/lbugnion/",
        },
         new TeamMember
        {
            Name = "Adrien Clerbois",
            Title = "Microsoft MVP & .NET Technical Architect",
            ImageUrl = "/img/team-adrien.jpg",
            LinkedIn = "https://www.linkedin.com/in/aclerbois/",
        },
         new TeamMember
        {
            Name = "Christophe Peugnet",
            Title = "Microsoft MVP & .NET / Blazor Dev | Formateur",
            ImageUrl = "/img/team-christophe.jpg",
            LinkedIn = "https://www.linkedin.com/in/christophepeugnet/",
        },
         new TeamMember
        {
            Name = "Denis Voituron",
            Title = "Principal Software Engineer @ Microsoft",
            ImageUrl = "/img/team-denis.jpg",
            LinkedIn = "https://www.linkedin.com/in/denisvoituron/",
        },
    ];

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    /// <summary>
    /// Display the speaker detail page
    /// </summary>
    private async Task OpenTeamDetailAsync(string url)
    {
        await JSRuntime.InvokeVoidAsync("openInNewTab", url);
    }
}
