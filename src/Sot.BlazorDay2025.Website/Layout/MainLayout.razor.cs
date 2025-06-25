// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.FluentUI.AspNetCore.Components;
using Sot.BlazorDay2025.Website.Models;

namespace Sot.BlazorDay2025.Website.Layout;

/// <summary />
public partial class MainLayout
{
    /// <summary />
    [Inject]
    public required DataBase DataBase { get; set; }

    /// <summary />
    private FluentLayoutHamburger? _hamburger;

    /// <summary />
    private void SwitchPreviewMode(MouseEventArgs e)
    {
        if (e.CtrlKey)
        {
            DataBase.PreviewMode = !DataBase.PreviewMode;
        }
    }
}
