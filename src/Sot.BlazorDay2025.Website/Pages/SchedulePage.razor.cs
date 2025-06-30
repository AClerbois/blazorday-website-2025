// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Pages;

/// <summary />
public partial class SchedulePage
{
    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    private IEnumerable<Session> Sessions => DataBase.Sessions.OrderBy(i => i.Time);

    /// <summary />
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await DataBase.InitializeTimeZoneAsync();
            StateHasChanged();
        }
    }
}
