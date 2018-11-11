using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BubbleSortTests
{
     /// <summary>
     /// Test bubble sort.
     /// </summary>
     [TestFixture]
     public class NUnitTests
     {
          /// <summary>
          /// Check sort by sum of rows.
          /// </summary>
          [Test]
          public void SortBySumTest()
          {
               int[][] checkedArray = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 6 }, new int[] { -9 } };
               BubbleSort.ArraySorting.BubbleSortOfSumRowsInc(ref checkedArray);
               int[][] expectedArrayInc = new int[][] { new int[] { -9 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 6 } };
               CollectionAssert.AreEqual(expectedArrayInc, checkedArray);
               BubbleSort.ArraySorting.BubbleSortOfSumRowsDec(ref checkedArray);
               expectedArrayInc = new int[][] { new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4 }, new int[] { -9 } };
               CollectionAssert.AreEqual(expectedArrayInc, checkedArray);
          }

          /// <summary>
          /// Check sort by max element in rows.
          /// </summary>
          [Test]
          public void SortByMaxTest()
          {
               int[][] checkedArray = new int[][] { new int[] { 55, 0, 10  }, new int[] { 4, 5}, new int[] { -99, 100, 1 } };
               BubbleSort.ArraySorting.BubbleSortOfMaxElemInc(ref checkedArray);
               int[][] expectedArrayInc = new int[][] { new int[] { 4, 5 }, new int[] { 55, 0, 10 }, new int[] { -99, 100, 1 } };
               CollectionAssert.AreEqual(expectedArrayInc, checkedArray);
               BubbleSort.ArraySorting.BubbleSortOfMaxElemDec(ref checkedArray);
               expectedArrayInc = new int[][] { new int[] { -99, 100, 1 }, new int[] { 55, 0, 10 }, new int[] { 4, 5 } };
               CollectionAssert.AreEqual(expectedArrayInc, checkedArray);
          }

          /// <summary>
          /// Check sort by min element in rows.
          /// </summary>
          [Test]
          public void SortByMinTest()
          {
               int[][] checkedArray = new int[][] { new int[] { -88, 99, 7, 10, 20 }, new int[] { 9, 100, 4 }, new int[] { 200, 100, 1 } };
               BubbleSort.ArraySorting.BubbleSortOfMinElemInc(ref checkedArray);
               int[][] expectedArrayInc = new int[][] { new int[] { 9, 100, 4 }, new int[] { 200, 100, 1 }, new int[] { -88, 99, 7, 10, 20 } };
               CollectionAssert.AreEqual(expectedArrayInc, checkedArray);
               BubbleSort.ArraySorting.BubbleSortOfMinElemDec(ref checkedArray);
               expectedArrayInc = new int[][] { new int[] { -88, 99, 7, 10, 20 }, new int[] { 200, 100, 1 }, new int[] { 9, 100, 4 } };
               CollectionAssert.AreEqual(expectedArrayInc, checkedArray);
          }

          /// <summary>
          /// Check sort in incorrect data.
          /// </summary>
          [Test]
          public void ExceptionZeroArrayTest()
          {
               int[][] checkedArray = new int[0][];
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfSumRowsInc(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfSumRowsDec(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMaxElemInc(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMaxElemDec(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMinElemInc(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMinElemDec(ref checkedArray));
          }

          /// <summary>
          /// Check sort in incorrect data.
          /// </summary>
          [Test]
          public void ExceptionNullArrayTest()
          {
               int[][] checkedArray = null;
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfSumRowsInc(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfSumRowsDec(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMaxElemInc(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMaxElemDec(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMinElemInc(ref checkedArray));
               Assert.Throws<ArgumentException>(() => BubbleSort.ArraySorting.BubbleSortOfMinElemDec(ref checkedArray));
          }
     }
}
