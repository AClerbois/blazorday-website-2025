// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using Sot.BlazorDay2025.Website.Extensions;

namespace Sot.BlazorDay2025.Website.Models;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "MA0048:File name must match type name", Justification = "To simplify the code")]
public partial class DataBase
{
    /// <summary />
    private IEnumerable<Session> GetSessions() =>
    [
        new Session(this, "The future of web development with ASP.NET Core & Blazor")
        {
            Time = EventDateUtc.ForSlot(1),
            Duration = DataBase.SlotDuration,
            Description = @$"Explore the future of web development with ASP.NET Core & Blazor in .NET 10,
                             including major improvements for security, observability & diagnostics, performance,
                             and productivity.{CrLf}{CrLf}We’ll look at the new support for Blazor state persistence,
                             new Blazor diagnostics, startup performance improvements, validation for minimal APIs & Blazor,
                             OpenWebAuth & Passkey support, enhanced authentication tooling, and much more!",
            SpeakerIds = ["daniel-roth"],
        },

        new Session(this, "Exploring the Fluent UI Blazor Library v5: Next-Gen Web Components and Architectural Innovations")
        {
            Time = EventDateUtc.ForSlot(2),
            Duration = DataBase.SlotDuration,
            Description = @$"Join me for an in-depth session on the upcoming new major version of the Fluent UI Blazor library. It introduces cutting-edge new (Fluent) Web Components and significant architectural changes.
                             This session will cover:
                             {CrLf}- **Overview of New Features**: Discover the enhancements in the new Fluent UI Blazor library, including updated Web Components
                             {CrLf}- **Architectural Changes**: Learn about the major architectural shifts that improve performance, scalability, and maintainability.
                             {CrLf}- **Migration Guide**: Yes, there will be a lot of breaking changes! But we will guide you with practical tips and best practices for migrating your existing projects to the new version
                             {CrLf}- **Hands-On Demos**: See the new features in action with live coding demonstrations.",
            SpeakerIds = ["vincent-baaij"],
        },

        new Session(this, "Designing for AI First: Natural Language UX with Blazor")
        {
            Time = EventDateUtc.ForSlot(3),
            Duration = DataBase.SlotDuration,
            Description = @$"Natural Language is the new default user experience. In this session, we’ll explore what it means to design
                             for an AI First UX—where AI isn’t an add-on, but a central part of the experience.
                             You’ll see how to build intelligent, natural-language-driven interfaces using Blazor,
                             and discover the tools and services that can bring your next AI-powered application to life.",
            SpeakerIds = ["ed-charbeneau"],
        },

        new Session(this, "Build hybrid apps with .NET MAUI & Blazor")
        {
            Time = EventDateUtc.ForSlot(4),
            Duration = DataBase.SlotDuration,
            Description = @$"In this session learn why you would choose a hybrid web approach to building native apps with .NET MAUI.
                            Learn about Blazor hybrid and how you can build full-featured native apps for Windows, Mac, iOS and Android
                            within a single codebase that can take advantage of your web skills. Take a tour of the Blazor hybrid tools
                            and templates and see how you can reuse UI to build solutions that target the web at the same time.
                            We'll also take a look at how you can infuse intelligence into your client apps.",
            SpeakerIds = ["beth-massi"],
        },

        new Session(this, "Building a production level Blazor web app with GitHub Copilot")
        {
            Time = EventDateUtc.ForSlot(5),
            Duration = DataBase.SlotDuration,
            Description = @$"At the beginning of the year, I set out to build my very first production web app leveraging Blazor.
                            The only thing is... I am a mobile developer, so I decided to leverage GitHub Copilot to completely build,
                            test, and deploy it. In this session I will walk through my experience, lessons learned,
                            and what the future of my app is.",
            SpeakerIds = ["james-montemagno"],
        },
    ];
}
