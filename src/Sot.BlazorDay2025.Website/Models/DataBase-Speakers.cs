// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

namespace Sot.BlazorDay2025.Website.Models;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "MA0048:File name must match type name", Justification = "To simplify the code")]
public partial class DataBase
{
    /// <summary />    
    private IEnumerable<Speaker> GetSpeakers() =>
    [
        new Speaker(this)
        {
            Order = 1,
            Id = "daniel-roth",
            Name = "Daniel Roth",
            Title = "",
            Company = "Microsoft",
            Description = @$"Daniel Roth is a Principal Product Manager for ASP.NET Core & Blazor on the .NET team at Microsoft.",
            Email = "Daniel.Roth@microsoft.com",
            Linkedin = "https://linkedin.com/in/danroth27/",
            PhotoUrl = "/img/speakers/daniel-roth.jpg",
        },

        new Speaker(this)
        {
            Order = 2,
            Id = "ed-charbeneau",
            Name = "Ed Charbeneau",
            Title = "Ed is a Microsoft MVP and an international speaker, writer, online influencer, a Developer Advocate for Progress.",
            Company = "Telerik.com",
            Description = @$"Ed is a Microsoft MVP and an international speaker, writer, online influencer, a Developer Advocate for Progress,
                             and expert on all things web development. Ed enjoys geeking out to cool new tech, brainstorming
                             about future technology, and admiring great design.{CrLf}{CrLf}Ed has shared his insights, experiences, and advice around
                             collaboration, knowledge management, social computing, and training at many industry events around the United States.
                             Highly ethical and engaging with an uncanny business acumen, he is a creative community builder and outside the box thinker.
                             Long term business relationships throughout the world within internal communications, employee engagement and marketing
                             as well as IT. Focusing on Financial, Healthcare, Manufacturing, Agency and Professional Services. He has defined,
                             architected, implemented line of business solutions with a touch of style and UX best practices.",
            Email = "ed.charbeneau@gmail.com",
            Linkedin = "https://www.linkedin.com/in/edcharbeneau/",
            WebSite = "https://edcharbeneau.com/",
            PhotoUrl = "/img/speakers/ed-charbeneau.jpg",
        },

        new Speaker(this)
        {
            Order = 3,
            Id = "vincent-baaij",
            Name = "Vincent Baaij",
            Title = "Fluent UI Blazor library maintainer",
            Company = "",
            Description = @$"Vincent has been working as a developer/consultant/architect in the IT industry
                             for over almost 30 years and is still learning new things every day. He currently works as a Cloud Solution
                             Architect at Microsoft where he helps customers to be successful on the Azure platform. He is also
                             the maintainer of the official Microsoft Fluent UI Blazor library, an open-source component package that
                             offers seamless integration of Fluent UI with Blazor for building web and mobile applications.",
            Email = "vnbaaij@outlook.com",
            Linkedin = "https://www.linkedin.com/in/vincentbaaij/",
            WebSite = "https://baaijte.net/",
            PhotoUrl = "/img/speakers/vincent-baaij.jpg",
        },

        new Speaker(this)
        {
            Order = 4,
            Id = "beth-massi",
            Name = "Beth Massi",
            Title = "Principal Product Manager, .NET MAUI @Microsoft",
            Company = "Microsoft",
            Description = @$"Beth is a Product Manager on the .NET MAUI team at Microsoft and responsible for making native
                            device and hybrid web development in Visual Studio a delightful experience. Formerly the
                            Marketing Director and Community Manager for .NET as well as serving on the Board of Directors
                            for the .NET Foundation, she’s spent her career helping .NET developers be successful.
                            You can find her on Twitter and GitHub @BethMassi",
            Email = "bethma@microsoft.com",
            Linkedin = "https://www.linkedin.com/in/beth-massi/",
            WebSite = "https://dot.net/",
            PhotoUrl = "/img/speakers/beth-massi.jpg",
        },

        new Speaker(this)
        {
            Order = 5,
            Id = "james-montemagno",
            Name = "James Montemagno",
            Title = "Principal Program Manager - Developer Community, Microsoft",
            Company = "Microsoft",
            Description = @$"James Montemagno is a Principal Lead Program Manager for Developer Community at Microsoft.
                            He has been a .NET developer since 2005 and has been crafting multi-platform apps for iOS,
                            Android, Mac, and Windows since 2011 with Xamarin and now .NET MAUI. In his spare time,
                            he is most likely cycling or guzzling gallons of coffee at a local coffee shop. He can
                            be found on [YouTube](https://youtube.com/@jamesmontemagno), blogs code regularly on his
                            personal blog https://www.montemagno.com, and co-hosts the weekly development podcast
                            Merge Conflict https://mergeconflict.fm.",
            Email = "james.montemagno@gmail.com",
            Linkedin = "https://www.linkedin.com/in/jamesmontemagno/",
            WebSite = "https://www.montemagno.com/",
            PhotoUrl = "/img/speakers/james-montemagno.jpg",
        },
    ];
}
