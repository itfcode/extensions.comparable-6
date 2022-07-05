namespace ItfCode.Extensions.ComparableExtendors.Tests.Data
{
    internal static partial class TestData
    {
        public static IEnumerable<object[]> GetDecimalWithinValues()
            => GetRange().Select(v => new object[]
            {
                GetRandomDecimal()
            });

        public static IEnumerable<object[]> GetDecimalWithinAnyValues()
            => throw new NotImplementedException();

        public static IEnumerable<object[]> GetDecimalWithinEveryValues()
            => throw new NotImplementedException();

    }
}