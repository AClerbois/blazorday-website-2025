// ------------------------------------------------------------------------
// MIT License - Copyright (c) BlazorDay 2025. All rights reserved.
// ------------------------------------------------------------------------

using System.Globalization;

namespace Sot.BlazorDay2025.Website.Extensions;

/// <summary />
public static class DateTimeExtensions
{
    /// <summary>
    /// Adds the specified number of hours and minutes to the given <see cref="DateTimeOffset"/> value.
    /// </summary>
    /// <remarks>This method calculates the total time to add by converting the hours to minutes and then
    /// adding the specified minutes.</remarks>
    /// <param name="dateTime">The <see cref="DateTimeOffset"/> instance to which the time will be added.</param>
    /// <param name="hours">The number of hours to add. Can be positive or negative.</param>
    /// <param name="minutes">The number of minutes to add. Can be positive or negative.</param>
    /// <returns>A new <see cref="DateTimeOffset"/> instance that represents the original date and time plus the specified hours
    /// and minutes.</returns>
    public static DateTimeOffset AddTime(this DateTimeOffset dateTime, int hours, int minutes)
    {
        return dateTime.AddMinutes(60 * hours + minutes);
    }

    /// <summary>
    /// Adds a specified amount of time, in hours and minutes, to the given <see cref="DateTimeOffset"/>.
    /// </summary>
    /// <remarks>This method parses the <paramref name="time"/> string and adds the specified hours and
    /// minutes to the <paramref name="dateTime"/>. The method expects the time string to be in a strict "HH:MM" format,
    /// where "HH" represents hours and "MM" represents minutes.</remarks>
    /// <param name="dateTime">The <see cref="DateTimeOffset"/> to which the time will be added.</param>
    /// <param name="time">A string representing the time to add, in the format "HH:MM".  The hours and minutes must be separated by a
    /// colon, and both components must be valid integers.</param>
    /// <returns>A new <see cref="DateTimeOffset"/> that represents the original date and time plus the specified hours and
    /// minutes.</returns>
    /// <exception cref="FormatException">Thrown if the <paramref name="time"/> string is not in the "HH:MM" format, or if the hours or minutes components
    /// are invalid.</exception>
    public static DateTimeOffset AddTime(this DateTimeOffset dateTime, string time)
    {
        var parts = time.Split(':');
        if (parts.Length != 2)
        {
            throw new FormatException("Time string must be in 'HH:MM' format.");
        }

        if (!int.TryParse(parts[0], CultureInfo.InvariantCulture, out var hours))
        {
            throw new FormatException("Invalid hours component in time string.");
        }

        if (!int.TryParse(parts[1], CultureInfo.InvariantCulture, out var minutes))
        {
            throw new FormatException("Invalid minutes component in time string.");
        }

        return dateTime.AddMinutes(60 * hours + minutes);
    }
}
