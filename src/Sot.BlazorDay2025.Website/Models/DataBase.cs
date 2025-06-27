// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using System.Collections.Concurrent;
using Microsoft.JSInterop;
using Sot.BlazorDay2025.Website.Extensions;

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "MA0051:Method is too long", Justification = "Required to fill all data items")]
public class DataBase
{
    private readonly IJSRuntime _jsRuntime;

    /// <summary>
    /// Gets or sets the date (without time) of the event.
    /// </summary>
    public static DateTimeOffset EventDateUtc { get; } = new DateTimeOffset(2025, 9, 25, 0, 0, 0, TimeSpan.Zero);  // 2025-09-25

    /// <summary />
    public DataBase(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;

#if DEBUG
        PreviewMode = true;
#endif

        // Load data from the database.
        Speakers = GetSpeakers();
        Sessions = GetSessions();
        TeamMembers = GetTeamMembers();

        // Validate the integrity of the database:
        // check for duplicate IDs and ensure all referenced speaker IDs exist.
        ValidateDatabaseIntegrity();
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
    private IEnumerable<Speaker> GetSpeakers() =>
    [
        new Speaker(this)
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

        new Speaker(this)
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

        new Speaker(this)
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

        new Speaker(this)
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

        new Speaker(this)
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

        new Speaker(this)
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

        new Speaker(this)
        {
            Id = "bob-brown",
            Name = "Bob Brown",
            Title = "Data Scientist",
            PhotoUrl = "/img/speakers/anonymous.png",
        },
    ];

    /// <summary />
    private IEnumerable<Session> GetSessions() =>
    [
        new Session(this)
        {
            Id = "1",
            Time = EventDateUtc.AddTime("16:00"),
            Duration = 30,
            Title = "Keynote: The Future of Blazor",
            Description = "Join us for the keynote session where we will explore the future of Blazor and its impact on web development.",
            SpeakerIds = ["daniel-roth"],
        },
        new Session(this)
        {
            Id = "2",
            Time = EventDateUtc.AddTime("17:00"),
            Duration = 30,
            Title = "Building Modern Web Apps with Blazor",
            Description = "Learn how to build modern web applications using Blazor and its powerful features.",
            SpeakerIds = ["ed-charbeneau", "vincent-baaij"],
        },
    ];

    /// <summary />
    private IEnumerable<TeamMember> GetTeamMembers() =>
    [
        new TeamMember(this)
        {
            Name = "Laurent Bugnion",
            Title = "Principal Cloud Developer Advocate @ Microsoft",
            ImageUrl = "/img/team-laurent.jpg",
            LinkedIn = "https://www.linkedin.com/in/lbugnion/",
        },
         new TeamMember(this)
        {
            Name = "Adrien Clerbois",
            Title = "Microsoft MVP & .NET Technical Architect",
            ImageUrl = "/img/team-adrien.jpg",
            LinkedIn = "https://www.linkedin.com/in/aclerbois/",
        },
         new TeamMember(this)
         {
             Name = "Christophe Peugnet",
             Title = "Microsoft MVP & .NET / Blazor Dev | Formateur",
             ImageUrl = "/img/team-christophe.jpg",
             LinkedIn = "https://www.linkedin.com/in/christophepeugnet/",
         },
         new TeamMember(this)
         {
             Name = "Denis Voituron",
             Title = "Principal Software Engineer @ Microsoft",
             ImageUrl = "/img/team-denis.jpg",
             LinkedIn = "https://www.linkedin.com/in/denisvoituron/",
         },
    ];

    /// <summary />
    public IEnumerable<Speaker> Speakers { get; }

    /// <summary />
    public IEnumerable<Session> Sessions { get; }

    /// <summary />
    public IEnumerable<TeamMember> TeamMembers { get; }

    private readonly ConcurrentDictionary<string, string> TimeDetails = new(StringComparer.Ordinal);

    /// <summary>
    /// Returns the UTC offset of the local time zone as a string. E.g. "UTC+2" or "UTC-5".
    /// </summary>
    public string UtcOffset => TimeDetails.GetValueOrDefault(nameof(UtcOffset), "");

    /// <summary>
    /// Returns the browser's time zone as a string. E.g. "Europe/Paris" or "America/New_York".
    /// </summary>
    public string BrowserTimeZone => TimeDetails.GetValueOrDefault(nameof(BrowserTimeZone), "");

    /// <summary>
    /// Initializes the local time zone offset by retrieving it from the JavaScript runtime.
    /// </summary>
    public async Task<(string LocalOffset, string BrowserTimeZone)> InitializeTimeZoneAsync()
    {
        if (!TimeDetails.IsEmpty)
        {
            return (UtcOffset, BrowserTimeZone);
        }

        var localOffset = await _jsRuntime.InvokeAsync<string>("getLocalUtcOffset");
        var utcOffset = $"UTC{localOffset}";
        var browserTimeZone = await _jsRuntime.InvokeAsync<string>("getBrowserTimeZone");

        TimeDetails.AddOrUpdate(nameof(UtcOffset), utcOffset, (key, oldValue) => utcOffset);
        TimeDetails.AddOrUpdate(nameof(BrowserTimeZone), browserTimeZone, (key, oldValue) => browserTimeZone);

        return (localOffset, browserTimeZone);
    }

    /// <summary>
    /// Converts a DateTimeOffset value to a local date and time string using JavaScript.
    /// </summary>
    public async Task<string> GetLocalDateTimeAsync(DateTimeOffset value)
    {
        var result = await _jsRuntime.InvokeAsync<string>("getLocalDateTime", value.ToString("o"));
        return result;
    }

    /// <summary>
    /// Validates the integrity of the database by checking for duplicate IDs and ensuring all referenced speaker IDs exist.
    /// </summary>
    private void ValidateDatabaseIntegrity()
    {
        // Check the validity of Database content
        var duplicateSpeakerIds = Speakers.GroupBy(s => s.Id, StringComparer.Ordinal).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        if (duplicateSpeakerIds.Count > 0)
        {
            throw new InvalidOperationException($"Duplicate Speaker Id(s) found: {string.Join(", ", duplicateSpeakerIds)}");
        }

        var duplicateSessionIds = Sessions.GroupBy(s => s.Id, StringComparer.Ordinal).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        if (duplicateSessionIds.Count > 0)
        {
            throw new InvalidOperationException($"Duplicate Session Id(s) found: {string.Join(", ", duplicateSessionIds)}");
        }

        // Verify all Session.SpeakerIds exist in Speakers
        var speakerIdSet = new HashSet<string>(Speakers.Select(s => s.Id), StringComparer.Ordinal);
        var missingSpeakerIds = Sessions.SelectMany(session => session.SpeakerIds.Select(id => (SessionId: session.Id, SpeakerId: id)))
                                        .Where(x => !speakerIdSet.Contains(x.SpeakerId))
                                        .ToList();

        if (missingSpeakerIds.Count > 0)
        {
            var details = string.Join(", ", missingSpeakerIds.Select(x => $"Session '{x.SessionId}' references missing SpeakerId '{x.SpeakerId}'"));
            throw new InvalidOperationException($"Invalid SpeakerId(s) referenced in Sessions: {details}");
        }
    }
}
