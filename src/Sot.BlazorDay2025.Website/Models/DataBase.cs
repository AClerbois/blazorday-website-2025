// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public class DataBase
{
    /// <summary />
    public IEnumerable<Speaker> Speakers { get; set; } =
    [
        new Speaker
        {
            Id = "john-doe",
            Name = "John Doe",
            Title = "Software Engineer",
            PhotoUrl = "/img/team-denis.jpg",
        },
        new Speaker
        {
            Id = "jane-smith",
            Name = "Jane Smith",
            Title = "Web Developer",
            PhotoUrl = "/img/team-adrien.jpg",
        },
        new Speaker
        {
            Id = "alice-johnson",
            Name = "Alice Johnson",
            Title = "Cloud Architect",
            PhotoUrl = "/img/team-christophe.jpg",
        },
        new Speaker
        {
            Id = "bob-brown",
            Name = "Bob Brown",
            Title = "Data Scientist",
            PhotoUrl = "/img/team-laurent.jpg",
        },
    ];

}
