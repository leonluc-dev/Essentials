using System;

namespace Xamarin.Essentials
{
    public static partial class DateTimeFormatting
    {
        /*
         * Note: ToShortDateString() etc. are not supported yet as of .NET Standard 1.0/UWP build 16299
         * Using equivalent format strings instead
         */

        static string PlatformToPlatformShortDateString(DateTime datetime)
        {
            return datetime.ToString("d");
        }

        static string PlatformToPlatformShortTimeString(DateTime datetime)
        {
            return datetime.ToString("t");
        }

        static string PlatformToPlatformLongDateString(DateTime datetime)
        {
            return datetime.ToString("D");
        }

        static string PlatformToPlatformLongTimeString(DateTime datetime)
        {
            return datetime.ToString("T");
        }
    }
}
