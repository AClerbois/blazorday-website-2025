// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.JSInterop;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Components;

/// <summary />
public partial class SessionCard
{
    internal static readonly Icon OpenIcon = new Microsoft.FluentUI.AspNetCore.Components.Icons.Regular.Size20.Open();
    
    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    [Inject]
    public required IJSRuntime JSRuntime { get; set; }

    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Parameter]
    public required string Id { get; set; }

    /// <summary />
    [Parameter]
    public string Height { get; set; } = "75px";

    /// <summary />
    private Session? Session { get; set; }

    /// <summary />
    private Speaker? Speaker => Session?.Speakers.FirstOrDefault();

    /// <summary />
    private string? SessionLocalTime { get; set; }

    /// <summary />
    protected override void OnInitialized()
    {
        Session = DataBase.Sessions.FirstOrDefault(s => string.Equals(s.Id, Id, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary />
    protected override async Task OnParametersSetAsync()
    {
        if (Session?.Time != null)
        {
            SessionLocalTime = await DataBase.GetLocalDateTimeAsync(Session.Time);
        }
    }

    /// <summary />
    public async Task OpenSessionDetailAsync()
    {
        await Task.CompletedTask;
    }
}
