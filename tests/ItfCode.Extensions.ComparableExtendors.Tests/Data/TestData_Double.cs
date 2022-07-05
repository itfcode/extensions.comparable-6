namespace ItfCode.Extensions.ComparableExtendors.Tests.Data
{
    internal static partial class TestData
    {
        public static IEnumerable<object[]> GetDoubleWithinValues()
            => GetRange().Select(v => (GetRandomDouble(), GetRandomDouble(), GetRandomDouble()))
            .Select(v => new object[]
            {
                v.Item1,
                (Math.Min(v.Item2, v.Item3), Math.Max(v.Item2, v.Item3))
            });

        public static IEnumerable<object[]> GetDoubleWithinAnyValues()
            => GetRange().Select(v =>
            (
                GetRandomDouble(),
                (GetRandomDouble(), GetRandomDouble()),
                (GetRandomDouble(), GetRandomDouble()),
                (GetRandomDouble(), GetRandomDouble())
            ))
            .Select(v => new object[]
            {
                v.Item1,
                new (double,double)[]
                {
                    (Math.Min(v.Item2.Item1, v.Item2.Item2), Math.Max(v.Item2.Item1, v.Item2.Item2)),
                    (Math.Min(v.Item3.Item1, v.Item3.Item2), Math.Max(v.Item3.Item1, v.Item3.Item2)),
                    (Math.Min(v.Item4.Item1, v.Item4.Item2), Math.Max(v.Item4.Item1, v.Item4.Item2)),
                }
            })
            .Union(GetRange().Select(v => GetRandomDouble()).
                Select(v => new object[]
                {
                    v,
                    new (double,double)[]
                    {
                        (v - 0.1, v + 0.1),
                        (v - 0.2, v + 0.2),
                        (v - 0.3, v + 0.3),
                        (v - 0.4, v - 0.3),
                        (v - 0.9, v - 0.1),
                    }
                }))
            .Union(GetRange().Select(v => GetRandomDouble()).
                Select(v => new object[]
                {
                    v,
                    new (double,double)[]
                    {
                        (v - 0.1, v + 0.1),
                        (v - 0.2, v + 0.2),
                        (v - 0.3, v + 0.3),
                        (v - 0.4, v + 0.4),
                        (v - 0.9, v + 0.9),
                    }
                }))
            .Union(GetRange().Select(v => GetRandomDouble()).
                Select(v => new object[]
                {
                    v,
                    new (double,double)[]
                    {
                        (v - 0.9, v - 0.01),
                        (v - 0.7, v - 0.11),
                        (v - 0.6, v - 0.21),
                        (v - 0.8, v - 0.31),
                    }
                }));

        public static IEnumerable<object[]> GetDoubleWithinEveryValues()
            => GetDoubleWithinAnyValues();
    }
}