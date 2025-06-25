// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
public class DataBase
{
    /// <summary />
    public DataBase()
    {
#if DEBUG
        PreviewMode = true;
#endif
    }

    /// <summary>
    /// URL to the live stream of the event
    /// </summary>
    public string LiveUrl = "https://www.youtube.com/live/4xDzrJKXOOY";

    /// <summary>
    /// URL to the Call for Paper page
    /// </summary>
    public string CallForPaperUrl = "https://sessionize.com/blazor-day-2025/";

    /// <summary>
    /// Gets or sets a value indicating whether the application is in preview mode.
    /// </summary>
    public bool PreviewMode { get; set; }

    /// <summary />
    public IEnumerable<Speaker> Speakers { get; set; } =
    [
        new Speaker
        {
            Order = 1,
            Id = "daniel-roth",
            Name = "Daniel Roth",
            Title = "",
            Company = "Microsoft",
            Description = "Daniel Roth is a Principal Product Manager for ASP.NET Core & Blazor on the .NET team at Microsoft.",
            Email = "Daniel.Roth@microsoft.com",
            Linkedin = "https://linkedin.com/in/danroth27/",
            PhotoUrl = "/img/speakers/daniel-roth.jpg",
        },

        new Speaker
        {
            Order = 2,
            Id = "ed-charbeneau",
            Name = "Ed Charbeneau",
            Title = "Ed is a Microsoft MVP and an international speaker, writer, online influencer, a Developer Advocate for Progress.",
            Company = "Telerik.com",
            Description = "Ed is a Microsoft MVP and an international speaker, writer, online influencer, a Developer Advocate for Progress, and expert on all things web development. Ed enjoys geeking out to cool new tech, brainstorming about future technology, and admiring great design.\r\n\r\nEd has shared his insights, experiences, and advice around collaboration, knowledge management, social computing, and training at many industry events around the United States. Highly ethical and engaging with an uncanny business acumen, he is a creative community builder and outside the box thinker. Long term business relationships throughout the world within internal communications, employee engagement and marketing as well as IT. Focusing on Financial, Healthcare, Manufacturing, Agency and Professional Services. He has defined, architected, implemented line of business solutions with a touch of style and UX best practices.",
            Email = "ed.charbeneau@gmail.com",
            Linkedin = "https://www.linkedin.com/in/edcharbeneau/",
            WebSite = "https://edcharbeneau.com/",
            PhotoUrl = "/img/speakers/ed-charbeneau.jpg",
        },

        new Speaker
        {
            Order = 3,
            Id = "vincent-baaij",
            Name = "Vincent Baaij",
            Title = "Fluent UI Blazor library maintainer",
            Company = "",
            Description = "Vincent has been working as a developer/consultant/architect in the IT industry for over almost 30 years and is still learning new things every day. He currently works as a Cloud Solution Architect at Microsoft where he helps customers to be successful on the Azure platform. He is also the maintainer of the official Microsoft Fluent UI Blazor library, an open-source component package that offers seamless integration of Fluent UI with Blazor for building web and mobile applications.",
            Email = "vnbaaij@outlook.com",
            Linkedin = "https://www.linkedin.com/in/vincentbaaij/",
            WebSite = "https://baaijte.net/",
            PhotoUrl = "/img/speakers/vincent-baaij.jpg",
        },

        new Speaker
        {
            Id = "john-doe",
            Name = "John Doe",
            Title = "Software Engineer",
            Company = "Tech Solutions Inc.",
            Description = "John is a seasoned software engineer with over 10 years of experience in building scalable web applications. John is a seasoned software engineer with over 10 years of experience in building scalable web applications. John is a seasoned software engineer with over 10 years of experience in building scalable web applications. John is a seasoned software engineer with over 10 years of experience in building scalable web applications.",
            Email = "john@tech-solutions.com",
            Linkedin = "https://www.linkedin.com/in/johndoe/",
            WebSite = "https://www.johndoe.com",
            PhotoUrl = "/img/speakers/anonymous.png",
        },

        new Speaker
        {
            Id = "jane-smith",
            Name = "Jane Smith",
            Title = "Web Developer",
            Company = "Innovative Web Co.",
            Description = "Jane specializes in front-end development and has a passion for creating user-friendly interfaces.",
            Linkedin = "https://www.linkedin.com/in/janesmith/",
            WebSite = "https://www.janesmith.com",
            PhotoUrl = "/img/speakers/anonymous.png",
        },

        new Speaker
        {
            Id = "alice-johnson",
            Name = "Alice Johnson",
            Title = "Cloud Architect",
            Company = "Cloud Solutions Ltd.",
            Description = "Alice is an expert in cloud architecture and has helped numerous companies migrate to the cloud.",
            Linkedin = "https://www.linkedin.com/in/alicejohnson/",
            WebSite = "https://www.alicejohnson.com",
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
