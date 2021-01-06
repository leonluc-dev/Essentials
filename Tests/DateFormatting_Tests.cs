using Xamarin.Essentials;
using Xunit;

namespace Tests
{
    public class DateFormatting_Tests
    {
        [Fact]
        public void Long_Date_String_On_NetStandard() =>
           Assert.Throws<NotImplementedInReferenceAssemblyException>(() => DateFormatting.ToPlatformLongDateString(default));

        [Fact]
        public void Short_Date_String_On_NetStandard() =>
            Assert.Throws<NotImplementedInReferenceAssemblyException>(() => DateFormatting.ToPlatformShortDateString(default));

        [Fact]
        public void Long_Time_String_On_NetStandard() =>
            Assert.Throws<NotImplementedInReferenceAssemblyException>(() => DateFormatting.ToPlatformLongTimeString(default));

        [Fact]
        public void Short_Time_String_On_NetStandard() =>
            Assert.Throws<NotImplementedInReferenceAssemblyException>(() => DateFormatting.ToPlatformShortTimeString(default));
    }
}
