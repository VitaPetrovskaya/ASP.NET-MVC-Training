using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GDCTests
{
     /// <summary>
     /// Test searching GDC.
     /// </summary>
     [TestFixture]
     public class NUnitTests
     {
          /// <summary>
          /// Check Euclidean algorithm in correct numbers.
          /// </summary>
          /// <param name="nums">
          /// Input numbers.
          /// </param>
          /// <returns>
          /// GDC.
          /// </returns>
          [TestCase(111, 100, 10, 43, 37, 8, ExpectedResult = 1)]
          [TestCase(44, 55, 0, 99, 110, ExpectedResult = 11)]
          [TestCase(2, 4, 8, 16, 32, 64, 128, 256, ExpectedResult = 2)]
          public int FindEuclideanGCDTest(params int[] nums)
          {
               TimeSpan time = new TimeSpan();
               return GreatestCommonDivisor.GCD.GetGDCEuclidean(out time, nums);
          }

          /// <summary>
          /// Check Binary Euclidean algorithm in correct numbers.
          /// </summary>
          /// <param name="nums">
          /// Input numbers.
          /// </param>
          /// <returns>
          /// GDC.
          /// </returns>
          [TestCase(111, 100, 10, 43, 37, 8, ExpectedResult = 1)]
          [TestCase(44, 55, 0, 99, 110, ExpectedResult = 11)]
          [TestCase(2, 4, 8, 16, 32, 64, 128, 256, ExpectedResult = 2)]
          public int FindBinaryEuclideanGCDTest(params int[] nums)
          {
               TimeSpan time = new TimeSpan();
               return GreatestCommonDivisor.GCD.GetGDCBinaryEuclidean(out time, nums);
          }

          /// <summary>
          /// Check Euclidean algorithm in incorrect numbers.
          /// </summary>
          /// <param name="nums">
          /// Input numbers.
          /// </param>
          /// <returns>
          /// GDC.
          /// </returns>
          [Test]
          public void FindEuclideanGCDTestException()
          {
               TimeSpan time = new TimeSpan();
               int[] nums = new int[] { 1 };
               Assert.Throws<ArgumentException>(() => GreatestCommonDivisor.GCD.GetGDCEuclidean(out time, nums));
          }

          /// <summary>
          /// Check Binary Euclidean algorithm in incorrect numbers.
          /// </summary>
          /// <param name="nums">
          /// Input numbers.
          /// </param>
          /// <returns>
          /// GDC.
          /// </returns>
          [Test]
          public void FindBinaryEuclideanGCDTestException()
          {
               TimeSpan time = new TimeSpan();
               int[] nums = new int[] { 1 };
               Assert.Throws<ArgumentException>(() => GreatestCommonDivisor.GCD.GetGDCBinaryEuclidean(out time, nums));
          }
     }
}
