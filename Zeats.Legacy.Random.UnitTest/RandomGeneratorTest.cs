using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.Random.UnitTest
{
    [TestClass]
    public class RandomGeneratorTest
    {
        [TestMethod]
        public void NextBool()
        {
            const double chance = .3;

            var trueCount = 0d;

            for (var i = 0; i < 1_000_000; i++)
            {
                var nextBool = RandomGenerator.NextBool(chance);

                if (nextBool)
                    trueCount++;
            }

            Assert.IsTrue(Math.Round(trueCount / 1_000_000, 2) <= chance);
        }

        [TestMethod]
        public void NextDouble()
        {
            for (var i = 0; i < 1_000_000; i++)
            {
                var nextDouble = RandomGenerator.NextDouble();
                Assert.IsTrue(nextDouble <= 1);
            }
        }

        [TestMethod]
        public void NextInt32()
        {
            for (var i = 0; i < 1_000_000; i++)
            {
                var nextInt32 = RandomGenerator.NextInt32(10, 30);
                Assert.IsTrue(nextInt32 >= 10 && nextInt32 <= 30);
            }

            for (var i = 0; i < 1_000_000; i++)
            {
                var nextInt32 = RandomGenerator.NextInt32(1, 1);
                Assert.IsTrue(nextInt32 >= 1 && nextInt32 <= 1);
            }

            for (var i = 0; i < 1_000_000; i++)
            {
                var nextInt32 = RandomGenerator.NextInt32(100, 200);
                Assert.IsTrue(nextInt32 >= 100 && nextInt32 <= 200);
            }
        }

        [TestMethod]
        public void NextDate()
        {
            for (var i = 0; i < 1_000; i++)
            {
                var min = new DateTime(2020, 9, 5, 8, 0, 0);
                var max = new DateTime(2020, 9, 15, 8, 0, 0);
                var nextDate = RandomGenerator.NextDate(min, max);

                Assert.IsTrue(nextDate >= min && nextDate <= max);
            }

            for (var i = 0; i < 1_000; i++)
            {
                var min = new DateTime(2020, 9, 5, 8, 0, 0);
                var max = new DateTime(2020, 9, 5, 8, 0, 0);
                var nextDate = RandomGenerator.NextDate(min, max);

                Assert.IsTrue(nextDate >= min && nextDate <= max);
            }

            for (var i = 0; i < 1_000; i++)
            {
                var min = new DateTime(2000, 9, 5, 8, 0, 0);
                var max = new DateTime(2020, 9, 5, 8, 0, 0);
                var nextDate = RandomGenerator.NextDate(min, max);

                Assert.IsTrue(nextDate >= min && nextDate <= max);
            }
        }

        [TestMethod]
        public void NextDecimal()
        {
            for (var i = 0; i < 1_000_000; i++)
            {
                var nextDecimal = RandomGenerator.NextDecimal(10, 30);
                Assert.IsTrue(nextDecimal >= 10 && nextDecimal <= 30);
            }

            for (var i = 0; i < 1_000_000; i++)
            {
                var nextDecimal = RandomGenerator.NextDecimal(0, 1);
                Assert.IsTrue(nextDecimal >= 0 && nextDecimal <= 1);
            }

            for (var i = 0; i < 1_000_000; i++)
            {
                var nextDecimal = RandomGenerator.NextDecimal(100, 200);
                Assert.IsTrue(nextDecimal >= 100 && nextDecimal <= 200);
            }
        }

        [TestMethod]
        public void NextEnum()
        {
            var values = new HashSet<SampleEnum>();

            for (var i = 0; i < 1_000_000; i++)
            {
                var sampleEnum = RandomGenerator.NextEnum<SampleEnum>();

                Assert.IsTrue(sampleEnum == SampleEnum.Value01
                              || sampleEnum == SampleEnum.Value02
                              || sampleEnum == SampleEnum.Value03);

                if (!values.Contains(sampleEnum))
                    values.Add(sampleEnum);
            }

            Assert.AreEqual(3, values.Count);
        }

        private enum SampleEnum
        {
            Value01,
            Value02,
            Value03
        }
    }
}