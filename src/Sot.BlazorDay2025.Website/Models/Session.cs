// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public record Session
{
    private readonly DataBase _dataBase;

    /// <summary />
    internal Session(DataBase database)
    {
        _dataBase = database;
    }

    /// <summary />
    public required string Id { get; set; }

    /// <summary />
    public required DateTimeOffset Time { get; set; }

    /// <summary />
    public required int Duration { get; set; } = 30;        // Default to 30 minutes

    /// <summary />
    public required string Title { get; set; }

    /// <summary />
    public required string Description { get; set; }

    /// <summary />
    public required string[] SpeakerIds { get; set; }

    /// <summary />
    public Speaker[] Speakers => _dataBase.Speakers
                                          .Where(s => SpeakerIds.Contains(s.Id, StringComparer.OrdinalIgnoreCase))
                                          .ToArray();
}
