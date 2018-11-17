using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearch;
using NUnit.Framework;

namespace BinarySearchTest
{
    /// <summary>
    /// Class for testing binary searcher.
    /// </summary>
    [TestFixture]
    public class NUnitTests
    {
          /// <summary>
          /// Correct and incorrect tests with number sequence.
          /// </summary>
          [Test]
          public void TestNumbers()
          {
               BinarySearcher<int> search = new BinarySearcher<int>(new int[5] { 3, 7, 9, 1, -5 });
               Assert.AreEqual(2, search.BinarySearch(3));
               Assert.AreEqual(-1, search.BinarySearch(100));
          }

          /// <summary>
          /// Correct and incorrect tests with string sequence.
          /// </summary>
          [Test]
          public void TestStrings()
          {
               BinarySearcher<string> search = new BinarySearcher<string>(new string[5] { "w", "d", "a", "r", "z" });
               Assert.AreEqual(0, search.BinarySearch("a"));
               Assert.AreEqual(-1, search.BinarySearch("test"));
          }

          /// <summary>
          /// Check null in constructor and main method.
          /// </summary>
          [Test]
          public void TestException()
          {
               Assert.Throws<ArgumentNullException>(() => new BinarySearcher<string>(null).BinarySearch("test"));
               Assert.Throws<ArgumentNullException>(() => new BinarySearcher<string>(new string[2] { "new", "test" }).BinarySearch(null));
          }
    }
}
