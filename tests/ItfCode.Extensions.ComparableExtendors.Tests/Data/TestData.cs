namespace ItfCode.Extensions.ComparableExtendors.Tests.Data
{
    internal static partial class TestData
    {
        private static byte GetRandomByte(byte min = byte.MinValue, byte max = byte.MaxValue) => (byte)new Random().Next(min, max);

        private static int GetRandomInt(int min = int.MinValue, int max = int.MaxValue) => new Random().Next(min, max);

        private static long GetRandomLong(long min = long.MinValue, long max = long.MaxValue) => new Random().NextInt64(min, max);

        private static float GetRandomFloat() => new Random().NextSingle() * GetRandomInt();

        private static double GetRandomDouble() => new Random().NextDouble() * GetRandomInt();

        private static decimal GetRandomDecimal() => (decimal)GetRandomLong() / GetRandomLong(min: 1);

        private static IEnumerable<int> GetRange(int start = -5, int count = 100) => Enumerable.Range(start, count);
    }
}
