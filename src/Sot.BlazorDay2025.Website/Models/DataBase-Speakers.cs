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
            Title = "Principal Product Manager, ASP.NET Core & Blazor",
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

        new Speaker(this)
        {
            Order = 6,
            Id = "johan-smarius",
            Name = "Johan Smarius",
            Title = "Microsoft MVP, Coach/Trainer",
            Company = "bergler.nl",
            Description = @$"Johan has been developing software since 1996 and has worked with .NET since version 1.0. 
                            With extensive experience as a lead developer and architect for .NET solutions, 
                            he is deeply passionate about clean coding and test-driven development. 
                            At JMAC Software Solutions and Bergler, he designs architectures for .NET solutions 
                            and coaches and trains developers in the domain of software engineering 
                            in general and Microsoft technologies in particular.",
            Email = "jsmarius@gmail.com",
            Linkedin = "https://www.linkedin.com/in/johansmarius/",
            WebSite = "https://www.bergler.nl/",
            PhotoUrl = "/img/speakers/johan-smarius.jpg",
        },

        new Speaker(this)
        {
            Order = 7,
            Id = "rockford-lhotka",
            Name = "Rockford Lhotka",
            Title = "Author, Speaker, OSS creator",
            Company = "xpirit.com",
            Description = @$"Rockford Lhotka is VP of Strategy at Xebia. He is the creator of the widely used CSLA 
                            .NET open-source software framework, the author of numerous books, and regularly speaks at major 
                            conferences around the world. Rockford is a member of the Microsoft Regional Director and MVP programs. 
                            For more information go to https://lhotka.net.",
            Email = "rocky@lhotka.net",
            Linkedin = "https://www.linkedin.com/in/rockfordlhotka/",
            WebSite = "https://lhotka.net/",
            PhotoUrl = "/img/speakers/rockford-lhotka.jpg",
        },

        new Speaker(this)
        {
            Order = 8,
            Id = "tim-purdum",
            Name = "Tim Purdum",
            Title = "Creative GIS and Web-based .NET Engineer",
            Company = "Dymaptic",
            Description = @$"Tim Purdum is the visionary behind the GeoBlazor mapping library and serves as the Director of Product Development 
                            at Dymaptic. With a robust background in .NET and web technologies, Tim has been focused on Geographic Information 
                            Systems (GIS) since 2021. His expertise and passion for technology have made him a sought-after speaker 
                            at numerous conferences, including Visual Studio Live, TechBash, Iowa Code Camp, and DevUp. 
                            Tim lives in Cedar Falls, Iowa.",
            Email = "tim.purdum@dymaptic.com",
            Linkedin = "https://www.linkedin.com/in/crttim/",
            WebSite = "https://dymaptic.com/",
            PhotoUrl = "/img/speakers/tim-purdum.jpg",
        },

        new Speaker(this)
        {
            Order = 9,
            Id = "sergi-ortiz-gomez",
            Name = "Sergi Ortiz Gomez",
            Title = "DrUalcman Programación",
            Company = "sergiortizgomez.com",
            Description = @$"I am a Net programmer almost from the beginning with Visual Basic Net and using C# from 2015.
                            I am using Blazor from first version Released and creating few nuget to share with a community.
                            In last few years I spend a lot time to learn and share my skills about Blazor
                            Check [my portfolio](https://aprende-a-programar.com/Animus/), of course, its Blazor WebAssembly.",
            Email = "drualcman@msn.com",
            Linkedin = "https://www.linkedin.com/in/sergi-ortiz-gomez/",
            WebSite = "https://sergiortizgomez.com/",
            PhotoUrl = "/img/speakers/sergi-ortiz-gomez.jpg",
        },
    ];
}
