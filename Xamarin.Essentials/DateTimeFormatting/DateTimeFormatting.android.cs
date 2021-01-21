using System;
using JavaDate = Java.Util.Date;
using JavaDateFormat = Java.Text.DateFormat;
using JavaLocale = Java.Util.Locale;
using JavaTimeZone = Java.Util.TimeZone;

namespace Xamarin.Essentials
{
    public static partial class DateTimeFormatting
    {
        static string PlatformToPlatformShortDateString(DateTime datetime)
        {
            var nativeDate = DateTimeToNativeDate(datetime);

            var formatter = JavaDateFormat.GetDateInstance(JavaDateFormat.Short, JavaLocale.Default);

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // Java.Text.DateFormat formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = JavaTimeZone.GetTimeZone("UTC");
            }

            return formatter.Format(nativeDate);
        }

        static string PlatformToPlatformShortTimeString(DateTime datetime)
        {
            var nativeDate = DateTimeToNativeDate(datetime);

            var formatter = JavaDateFormat.GetTimeInstance(JavaDateFormat.Short, JavaLocale.Default);

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // Java.Text.DateFormat formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = JavaTimeZone.GetTimeZone("UTC");
            }

            return formatter.Format(nativeDate);
        }

        static string PlatformToPlatformLongDateString(DateTime datetime)
        {
            var nativeDate = DateTimeToNativeDate(datetime);

            var formatter = JavaDateFormat.GetDateInstance(JavaDateFormat.Long, JavaLocale.Default);

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // Java.Text.DateFormat formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = JavaTimeZone.GetTimeZone("UTC");
            }

            return formatter.Format(nativeDate);
        }

        static string PlatformToPlatformLongTimeString(DateTime datetime)
        {
            var nativeDate = DateTimeToNativeDate(datetime);

            var formatter = JavaDateFormat.GetTimeInstance(JavaDateFormat.Medium, JavaLocale.Default);

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // Java.Text.DateFormat formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = JavaTimeZone.GetTimeZone("UTC");
            }

            return formatter.Format(nativeDate);
        }

        static JavaDate DateTimeToNativeDate(DateTime date)
        {
            var dateTimeAsMilliseconds = (long)date.ToUniversalTime().Subtract(
                new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
            .TotalMilliseconds;
            return new JavaDate(dateTimeAsMilliseconds);
        }
    }
}
