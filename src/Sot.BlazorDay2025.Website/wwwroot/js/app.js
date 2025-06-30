// TODO: Update in the FluentUI-Blazor library.
(function waitForTheme() {
  if (window.Blazor && Blazor.theme && typeof Blazor.theme.setLightTheme === "function") {
    console.log("Force the Light theme.");
    Blazor.theme.setLightTheme();
  } else {
    setTimeout(waitForTheme, 50);
  }
})();

// Used to open an URL in a new tab
window.openInNewTab = function (url) {
  window.open(url, '_blank', 'noopener');
};

// Get the browser's time zone (e.g., "America/New_York"))
window.getBrowserTimeZone = function () {
  return Intl.DateTimeFormat().resolvedOptions().timeZone;
};

// Get the browser's local date and time in "HH:mm" format (24-hour format)
window.getLocalDateTime = function (dateTimeString) {  
  const date = new Date(dateTimeString);  // dateTimeString should be in ISO format
  return date.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit', hour12: false });
};

// Get the browser's local UTC offset in hours (e.g., "+2" or "-5")
window.getLocalUtcOffset = function () {
  const offsetMinutes = -new Date().getTimezoneOffset();
  const sign = offsetMinutes >= 0 ? "+" : "-";
  const hours = Math.floor(Math.abs(offsetMinutes) / 60);
  return sign + hours;
};
