// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public record Speaker
{
    /// <summary />
    public required string Id { get; init; }

    /// <summary />
    public required string Name { get; init; }

    /// <summary />
    public required string Title { get; init; }

    /// <summary />
    public required string PhotoUrl { get; init; }
}
