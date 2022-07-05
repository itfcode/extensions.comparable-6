namespace ItfCode.Extensions.ComparableExtendors
{
    public static class ComparableExtensions
    {
        public static bool Within<T>(this T self, T start, T finish) where T : IComparable, IComparable<T>
            => self != null ? self.CompareTo(start) >= 0 && self.CompareTo(finish) <= 0 : throw new ArgumentNullException(nameof(self));

        public static bool WithinAny<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => self != null ? values.Any(x => self.CompareTo(x.Item1) >= 0 && self.CompareTo(x.Item2) <= 0) : throw new ArgumentNullException(nameof(self));

        public static bool WithinAll<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => self != null ? values.All(x => self.CompareTo(x.Item1) >= 0 && self.CompareTo(x.Item2) <= 0) : throw new ArgumentNullException(nameof(self));

        public static bool Without<T>(this T self, T start, T finish) where T : IComparable, IComparable<T>
            => !self.Within(start, finish);

        public static bool WithoutAny<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => !self.WithinAny(values);

        public static bool WithoutAll<T>(this T self, params (T, T)[] values) where T : IComparable, IComparable<T>
            => !self.WithoutAll(values);
    }
}