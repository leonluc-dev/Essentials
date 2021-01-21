using System;
using Xamarin.Essentials;

namespace Samples.ViewModel
{
    public class DateTimeFormattingViewModel : BaseViewModel
    {
        readonly DateTime currentDate = DateTime.Now;

        // .NET formatting
        public string CurrentLongDate => currentDate.ToLongDateString();

        public string CurrentShortDate => currentDate.ToShortDateString();

        public string CurrentLongTime => currentDate.ToLongTimeString();

        public string CurrentShortTime => currentDate.ToShortTimeString();

        // Platform formatting
        public string CurrentPlatformLongDate => currentDate.ToPlatformLongDateString();

        public string CurrentPlatformShortDate => currentDate.ToPlatformShortDateString();

        public string CurrentPlatformLongTime => currentDate.ToPlatformLongTimeString();

        public string CurrentPlatformShortTime => currentDate.ToPlatformShortTimeString();
    }
}
