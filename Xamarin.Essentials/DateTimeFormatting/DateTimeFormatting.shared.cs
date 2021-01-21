using System;

namespace Xamarin.Essentials
{
    public static partial class DateTimeFormatting
    {
        public static string ToPlatformShortDateString(this DateTime dateTime)
        {
            return PlatformToPlatformShortDateString(dateTime);
        }

        public static string ToPlatformShortTimeString(this DateTime dateTime)
        {
            return PlatformToPlatformShortTimeString(dateTime);
        }

        public static string ToPlatformLongDateString(this DateTime dateTime)
        {
            return PlatformToPlatformLongDateString(dateTime);
        }

        public static string ToPlatformLongTimeString(this DateTime dateTime)
        {
            return PlatformToPlatformLongTimeString(dateTime);
        }
    }
}
