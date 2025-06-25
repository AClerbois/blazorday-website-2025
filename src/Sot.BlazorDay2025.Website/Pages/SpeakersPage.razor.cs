// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Pages;

/// <summary />
public partial class SpeakersPage
{
    internal static readonly Icon OpenIcon = new Microsoft.FluentUI.AspNetCore.Components.Icons.Regular.Size20.Open();

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    private IEnumerable<Speaker> Speakers => DataBase.Speakers.OrderBy(i => i.Order);
}
