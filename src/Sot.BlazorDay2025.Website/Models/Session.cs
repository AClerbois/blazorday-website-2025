// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Sot.BlazorDay2025.Website.Extensions;

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public record Session
{
    private readonly DataBase _dataBase;
    private readonly string _id;

    /// <summary />
    internal Session(DataBase database, string title)
    {
        _dataBase = database;
        Title = title;
        _id = title.ToSlug();
    }

    /// <summary />
    public string Id => _id;

    /// <summary />
    public required DateTimeOffset Time { get; set; }

    /// <summary />
    public required int Duration { get; set; } = DataBase.SlotDuration;        // Default to 30 minutes

    /// <summary />
    public string Title { get; set; }

    /// <summary />
    public required string Description { get; set; }

    /// <summary />
    public required string[] SpeakerIds { get; set; }

    /// <summary />
    public Speaker[] Speakers => _dataBase.Speakers
                                          .Where(s => SpeakerIds.Contains(s.Id, StringComparer.OrdinalIgnoreCase))
                                          .ToArray();
}
