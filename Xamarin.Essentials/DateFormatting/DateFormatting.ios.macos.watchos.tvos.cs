using System;
using Foundation;

namespace Xamarin.Essentials
{
    public static partial class DateFormatting
    {
        static string PlatformToPlatformShortDateString(DateTime datetime)
        {
            var nativeDate = (NSDate)datetime;

            var formatter = new NSDateFormatter();
            formatter.DateStyle = NSDateFormatterStyle.Short;
            formatter.TimeStyle = NSDateFormatterStyle.None;
            formatter.Locale = NSLocale.AutoUpdatingCurrentLocale;

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // NSDateFormatter formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = NSTimeZone.FromAbbreviation("UTC");
            }

            return formatter.ToString(nativeDate);
        }

        static string PlatformToPlatformShortTimeString(DateTime datetime)
        {
            var nativeDate = (NSDate)datetime;

            var formatter = new NSDateFormatter();
            formatter.DateStyle = NSDateFormatterStyle.None;
            formatter.TimeStyle = NSDateFormatterStyle.Short;
            formatter.Locale = NSLocale.AutoUpdatingCurrentLocale;

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // NSDateFormatter formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = NSTimeZone.FromAbbreviation("UTC");
            }

            return formatter.ToString(nativeDate);
        }

        static string PlatformToPlatformLongDateString(DateTime datetime)
        {
            var nativeDate = (NSDate)datetime;

            var formatter = new NSDateFormatter();
            formatter.DateStyle = NSDateFormatterStyle.Long;
            formatter.TimeStyle = NSDateFormatterStyle.None;
            formatter.Locale = NSLocale.AutoUpdatingCurrentLocale;

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // NSDateFormatter formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = NSTimeZone.FromAbbreviation("UTC");
            }

            return formatter.ToString(nativeDate);
        }

        static string PlatformToPlatformLongTimeString(DateTime datetime)
        {
            var nativeDate = (NSDate)datetime;

            var formatter = new NSDateFormatter();
            formatter.DateStyle = NSDateFormatterStyle.None;
            formatter.TimeStyle = NSDateFormatterStyle.Medium;
            formatter.Locale = NSLocale.AutoUpdatingCurrentLocale;

            if (datetime.Kind == DateTimeKind.Utc)
            {
                // NSDateFormatter formats the date in local time by default.
                // If the original DateTime instance was UTC, make sure the formatter generates UTC as well to match .NET behaviour
                formatter.TimeZone = NSTimeZone.FromAbbreviation("UTC");
            }

            return formatter.ToString(nativeDate);
        }
    }
}
