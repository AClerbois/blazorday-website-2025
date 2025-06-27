// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public class TeamMember
{
    private readonly DataBase _dataBase;

    /// <summary />
    internal TeamMember(DataBase database)
    {
        _dataBase = database;
    }

    /// <summary />
    public required string Name { get; set; }

    /// <summary />
    public required string Title { get; set; }

    /// <summary />
    public required string ImageUrl { get; set; }

    /// <summary />
    public required string LinkedIn { get; set; }
}
