using System;

namespace Zeats.Legacy.Random
{
    public static class RandomGenerator
    {
        private static System.Random Random => new System.Random(Guid.NewGuid().GetHashCode());

        public static bool NextBool(double chance = 0.5)
        {
            return NextDouble() <= chance;
        }

        public static double NextDouble()
        {
            return Random.NextDouble();
        }

        public static int NextInt32(int min, int max)
        {
            return Random.Next(min, max);
        }

        public static DateTime NextDate(DateTime min, DateTime max)
        {
            var range = (max - min).Days;
            var days = Random.Next(range);

            return min.AddDays(days);
        }

        public static decimal NextDecimal(int min, int max)
        {
            return (decimal) (NextInt32(min, max) + NextDouble());
        }

        public static T NextEnum<T>()
        {
            var values = Enum.GetValues(typeof(T));
            var index = Random.Next(values.Length);
            var value = (T) values.GetValue(index);

            return value;
        }
    }
}