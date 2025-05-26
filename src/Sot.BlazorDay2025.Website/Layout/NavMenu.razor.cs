// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Sot.BlazorDay2025.Website.Layout;

/// <summary />
public partial class NavMenu
{
    /// <summary />
    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    /// <summary />
    [Parameter]
    public FluentLayoutHamburger? Hamburger { get; set; }

    /// <summary>
    /// Navigate to the specified page.
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    private async Task GoToPageAsync(string page)
    {
        NavigationManager.NavigateTo(page);

        if (Hamburger is not null)
        {
            await Hamburger.HideAsync();
        }
    }
}
