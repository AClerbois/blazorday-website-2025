# Copilot Instructions for BlazorDay 2025 Website

## Project Overview

This is the official website for BlazorDay 2025, built with **Blazor WebAssembly** (.NET 9, targeting .NET 10 features) and **Fluent UI** for styling. The codebase is organized for a single-page conference site with dynamic content, custom animations, and a strong focus on maintainability and data integrity.

## Architecture & Key Patterns

- **Entry Point:**  
  - `Program.cs` configures the Blazor WebAssembly app, registers Fluent UI, and injects a singleton `DataBase` service for all event/session/speaker data.
- **Component Structure:**  
  - UI is split into `Components/` (cards, animations), `Pages/` (routeable pages), and `Layout/` (main layout, navigation).
  - Each major component/page often has `.razor`, `.razor.cs` (code-behind), and `.razor.css` files for separation of markup, logic, and style.
- **Data Model:**  
  - All event data (sessions, speakers, team) is hardcoded in `Models/DataBase.cs` and loaded at startup.  
  - Data integrity is enforced at runtime (duplicate IDs, missing references throw exceptions).
- **JavaScript Interop:**  
  - Custom JS in `wwwroot/js/app.js` provides time zone, local time, and theme helpers, called from C# via JSInterop.
- **Styling:**  
  - Uses Fluent UI Blazor components and custom CSS in `wwwroot/css/app.css` and per-component `.razor.css` files.

## Developer Workflows

- **Build & Run:**  
  - Open `src/Sot.BlazorDay2025.sln` in Visual Studio or VS Code with C# extension.
  - Build and run the `Sot.BlazorDay2025.Website` project (F5 or `dotnet run` in the project directory).
- **Debugging:**  
  - Use browser dev tools for UI/JS issues.
  - C# breakpoints work in code-behind and model files.
- **Hot Reload:**  
  - Supported for `.razor`, `.cs`, and `.css` changes.
- **Data Updates:**  
  - To add sessions/speakers, update the relevant methods in `DataBase.cs` and ensure IDs are unique.
- **JS Interop:**  
  - Add new JS functions to `wwwroot/js/app.js` and call via `IJSRuntime` in C#.

## Project-Specific Conventions

- **Preview Mode:**  
  - Controlled by the `PreviewMode` property in `DataBase`. Enables special UI states for development.
- **Animation Toggle:**  
  - Home animation is toggled via localStorage and JSInterop (`ShowAnimation` property).
- **Component Naming:**  
  - Use PascalCase for all components and files.
- **No External API Calls:**  
  - All data is local/static; no backend or external API integration.

## Integration Points

- **Fluent UI:**  
  - Registered in `Program.cs` and used throughout for layout and controls.
- **Sessionize/YouTube:**  
  - External links for Call for Papers and live stream are stored in `DataBase.cs`.

## Examples

- **Add a new speaker:**  
  - Edit `GetSpeakers()` in `DataBase.cs`, add a new `Speaker` object, and ensure the ID is unique.
- **Add a new page:**  
  - Create a `.razor` file in `Pages/`, optionally add `.razor.cs` and `.razor.css`, and update navigation if needed.

## Key Files & Directories

- `src/Sot.BlazorDay2025.Website/Program.cs` – App startup/config
- `src/Sot.BlazorDay2025.Website/Models/DataBase.cs` – All event data and integrity checks
- `src/Sot.BlazorDay2025.Website/Components/` – Reusable UI components
- `src/Sot.BlazorDay2025.Website/Pages/` – Routeable pages
- `src/Sot.BlazorDay2025.Website/Layout/` – Main layout and navigation
- `src/Sot.BlazorDay2025.Website/wwwroot/js/app.js` – JS helpers for interop

---
