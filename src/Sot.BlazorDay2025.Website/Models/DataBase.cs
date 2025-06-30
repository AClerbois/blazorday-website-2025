// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using System.Collections.Concurrent;
using Microsoft.JSInterop;

namespace Sot.BlazorDay2025.Website.Models;

/// <summary />
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "MA0051:Method is too long", Justification = "Required to fill all data items")]
public partial class DataBase
{
    private const string CrLf = "\r\n";
    private readonly IJSRuntime _jsRuntime;

    /// <summary>
    /// Gets or sets the date (without time) of the event.
    /// </summary>
    public static DateTimeOffset EventDateUtc { get; } = new DateTimeOffset(2025, 9, 25, 15, 0, 0, TimeSpan.Zero);  // 2025-09-25 - 15:00 UTC

    /// <summary>
    /// Duration of each time slot in minutes
    /// </summary>
    public const int SlotDuration = 30;
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

    /// <summary>
    /// Gets or sets a value indicating whether the home animation should be shown.
    /// </summary>
    public bool ShowAnimation { get; set; }

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

    /// <summary>
    /// Call this to load the value from localStorage
    /// </summary>
    /// <returns></returns>
    public async Task<bool> LoadShowAnimationAsync()
    {
        var value = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "ShowAnimation");
        ShowAnimation = !string.Equals(value, "false", StringComparison.OrdinalIgnoreCase);

        return ShowAnimation;
    }

    /// <summary>
    /// Call this to save the value to localStorage
    /// </summary>
    /// <returns></returns>
    public async Task SaveShowAnimationAsync(bool value)
    {
        ShowAnimation = value;
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "ShowAnimation", ShowAnimation ? "true" : "false");
    }
}
