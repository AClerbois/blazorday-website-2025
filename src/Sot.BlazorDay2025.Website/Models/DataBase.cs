// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public class DataBase
{
    /// <summary>
    /// URL to the live stream of the event
    /// </summary>
    public string LiveUrl = "https://www.youtube.com/live/4xDzrJKXOOY";

    /// <summary />
    public IEnumerable<Speaker> Speakers { get; set; } =
    [
        new Speaker
        {
            Id = "john-doe",
            Name = "John Doe",
            Title = "Software Engineer",
            PhotoUrl = "/img/speakers/anonymous.png",
        },
        new Speaker
        {
            Id = "jane-smith",
            Name = "Jane Smith",
            Title = "Web Developer",
            PhotoUrl = "/img/speakers/anonymous.png",
        },
        new Speaker
        {
            Id = "alice-johnson",
            Name = "Alice Johnson",
            Title = "Cloud Architect",
            PhotoUrl = "/img/speakers/anonymous.png",
        },
        new Speaker
        {
            Id = "bob-brown",
            Name = "Bob Brown",
            Title = "Data Scientist",
            PhotoUrl = "/img/speakers/anonymous.png",
        },
    ];

    /// <summary />
    public IEnumerable<TeamMember> TeamMembers =
    [
        new TeamMember
        {
            Name = "Laurent Bugnion",
            Title = "Principal Cloud Developer Advocate @ Microsoft",
            ImageUrl = "/img/team-laurent.jpg",
            LinkedIn = "https://www.linkedin.com/in/lbugnion/",
        },
         new TeamMember
        {
            Name = "Adrien Clerbois",
            Title = "Microsoft MVP & .NET Technical Architect",
            ImageUrl = "/img/team-adrien.jpg",
            LinkedIn = "https://www.linkedin.com/in/aclerbois/",
        },
         new TeamMember
        {
            Name = "Christophe Peugnet",
            Title = "Microsoft MVP & .NET / Blazor Dev | Formateur",
            ImageUrl = "/img/team-christophe.jpg",
            LinkedIn = "https://www.linkedin.com/in/christophepeugnet/",
        },
         new TeamMember
        {
            Name = "Denis Voituron",
            Title = "Principal Software Engineer @ Microsoft",
            ImageUrl = "/img/team-denis.jpg",
            LinkedIn = "https://www.linkedin.com/in/denisvoituron/",
        },
    ];

}
