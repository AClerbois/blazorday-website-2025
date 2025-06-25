// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public record Speaker
{
    /// <summary />
    public int Order { get; set; } = Random.Shared.Next(int.MaxValue - 99999, int.MaxValue);

    /// <summary />
    public required string Id { get; init; }

    /// <summary />
    public required string Name { get; init; }

    /// <summary />
    public required string Title { get; init; }

    /// <summary />
    public string? Company { get; set; }

    /// <summary />
    public string? Description { get; set; }

    /// <summary />
    public string? Email{ get; set; }

    /// <summary />
    public string? Linkedin { get; set; }

    /// <summary />
    public string? WebSite { get; set; }

    /// <summary />
    public required string PhotoUrl { get; init; }
}
