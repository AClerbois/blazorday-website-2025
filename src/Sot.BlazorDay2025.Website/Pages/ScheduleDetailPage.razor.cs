// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Pages;

/// <summary />
public partial class ScheduleDetailPage
{
    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary>
    /// Identifier of the session to display details for.
    /// </summary>
    [Parameter]
    public string? Id { get; set; }

    /// <summary>
    /// Gets the session details based on the provided Id.
    /// </summary>
    public Session? Session => DataBase.Sessions.FirstOrDefault(i => string.Equals(i.Id, Id, StringComparison.Ordinal));
}
