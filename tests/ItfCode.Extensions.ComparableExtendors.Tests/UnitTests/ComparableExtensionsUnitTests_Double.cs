using ItfCode.Extensions.ComparableExtendors.Tests.Data;

namespace ItfCode.Extensions.ComparableExtendors.Tests.UnitTests
{
    public partial class ComparableExtensionsUnitTests
    {
        public static IEnumerable<object[]> DoubleWithinValues => TestData.GetDoubleWithinValues();
        public static IEnumerable<object[]> DoubleWithinAnyValues => TestData.GetDoubleWithinAnyValues();
        public static IEnumerable<object[]> DoubleWithinAllValues => TestData.GetDoubleWithinEveryValues();

        [Theory]
        [MemberData(nameof(DoubleWithinValues))]
        public void WithinWithout_For_Double_Test(double value, (double Min, double Max) interval)
        {
            if (value >= interval.Min && value <= interval.Max)
            {
                Assert.True(value.Within(interval.Min, interval.Max));
                Assert.False(value.Without(interval.Min, interval.Max));
            }
            else
            {
                Assert.False(value.Within(interval.Min, interval.Max));
                Assert.True(value.Without(interval.Min, interval.Max));
            }
        }

        [Theory]
        [MemberData(nameof(DoubleWithinAnyValues))]
        public void WithinWithoutAny_For_Double_Test(double value, (double Min, double Max)[] intervals)
        {
            var res = false;

            foreach (var interval in intervals)
            {
                res = res || value >= interval.Min && value <= interval.Max;
            }

            Assert.Equal(res, value.WithinAny(intervals));
        }

        [Theory]
        [MemberData(nameof(DoubleWithinAllValues))]
        public void WithinWithoutAll_For_Double_Test(double value, (double Min, double Max)[] intervals)
        {
            var res = true;

            foreach (var interval in intervals)
            {
                res = res && value >= interval.Min && value <= interval.Max;
            }

            Assert.Equal(res, value.WithinAll(intervals));
        }

    }
}