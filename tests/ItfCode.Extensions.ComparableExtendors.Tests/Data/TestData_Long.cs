namespace ItfCode.Extensions.ComparableExtendors.Tests.Data
{
    internal static partial class TestData
    {
        public static IEnumerable<object[]> GetLongWithinValues()
            => GetRange().Select(v => new object[]
            {
                GetRandomLong()
            });

        public static IEnumerable<object[]> GetLongWithinAnyValues()
            => throw new NotImplementedException();

        public static IEnumerable<object[]> GetLongWithinEveryValues()
            => throw new NotImplementedException();
    }
}