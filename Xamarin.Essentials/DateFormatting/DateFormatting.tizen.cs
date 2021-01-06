using System;

namespace Xamarin.Essentials
{
    public static partial class DateFormatting
    {
        static string PlatformToPlatformShortDateString(DateTime datetime)
        {
            return datetime.ToShortDateString();
        }

        static string PlatformToPlatformShortTimeString(DateTime datetime)
        {
            return datetime.ToShortTimeString();
        }

        static string PlatformToPlatformLongDateString(DateTime datetime)
        {
            return datetime.ToLongDateString();
        }

        static string PlatformToPlatformLongTimeString(DateTime datetime)
        {
            return datetime.ToLongTimeString();
        }
    }
}
