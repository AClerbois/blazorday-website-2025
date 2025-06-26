// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Components;

/// <summary />
public partial class HomeAnimation
{
    private const string JAVASCRIPT_FILE = "./Components/HomeAnimation.razor.js";

    /// <summary />
    [Inject]
    private DataBase DataBase { get; set; } = default!;

    /// <summary />
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = default!;

    /// <summary />
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    /// <summary />
    private IJSObjectReference JsModule { get; set; } = default!;

    /// <summary />
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (firstRender)
        {
            if (JsModule == null)
            {
                JsModule = await JsRuntime.InvokeAsync<IJSObjectReference>("import", JAVASCRIPT_FILE);
            }

            await JsModule.InvokeVoidAsync("initialize_animation");
        }
    }

    /// <summary />
    private async Task SkipAnimationAsync()
    {
        await DataBase.SaveShowAnimationAsync(false);
        NavigationManager.NavigateTo("/");
    }
}
