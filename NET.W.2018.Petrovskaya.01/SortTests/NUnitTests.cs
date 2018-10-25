using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SortTests
{
    [TestFixture]
    public class NUnitTests
    {
          [Test]
          public void QuickSortTest()
          {
               int[] checkedArray = new int[] { -3, 6, 12, 7, 1001 };
               int[] expectedArray = new int[] { -3, 6, 7, 12, 1001};
               Sorting.SortingArray.QuickSort(ref checkedArray);
               Assert.AreEqual(expectedArray, checkedArray);
          }

          [Test]
          public void MergeSortTest()
          {
               int[] checkedArray = new int[] { -3, 6, 12, 7, 1001 };
               int[] expectedArray = new int[] { -3, 6, 7, 12, 1001 };
               Sorting.SortingArray.MergeSort(ref checkedArray);
               Assert.AreEqual(expectedArray, checkedArray);
          }

          [Test]
          public void QuickSortExceptionTest()
          {
               int[] checkedArray = new int[0];
               Assert.Throws<ArgumentException>(() => Sorting.SortingArray.QuickSort(ref checkedArray));
               checkedArray = null;
               Assert.Throws<ArgumentException>(() => Sorting.SortingArray.QuickSort(ref checkedArray));
          }

          [Test]
          public void MergeSortExceptionTest()
          {
               int[] checkedArray = new int[0];
               Assert.Throws<ArgumentException>(() => Sorting.SortingArray.MergeSort(ref checkedArray));
               checkedArray = null;
               Assert.Throws<ArgumentException>(() => Sorting.SortingArray.MergeSort(ref checkedArray));
          }

     }
}
