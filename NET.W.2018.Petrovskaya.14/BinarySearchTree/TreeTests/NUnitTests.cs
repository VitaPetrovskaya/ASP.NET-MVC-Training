using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;
using NUnit.Framework;

namespace NUnitTests
{
     [TestFixture]
     public class NUnitTests
     {
          /// <summary>
          /// Test integer with default comparer.
          /// </summary>
          [Test]
          public void TestInt()
          {
               BinaryTree<int> intTree = new BinaryTree<int>(Comparer<int>.Default, new int[] { 15, 43, 8, 10, 25, 50 });
               int[] expectedArray = new int[] { 15, 8, 10, 43, 25, 50 };
               CollectionAssert.AreEqual(expectedArray, intTree.GetPreorderRound().ToArray());
               expectedArray = new int[] { 8, 10, 15, 25, 43, 50 };
               CollectionAssert.AreEqual(expectedArray, intTree.GetInorderRound().ToArray());
               expectedArray = new int[] { 10, 8, 25, 50, 43, 15 };
               CollectionAssert.AreEqual(expectedArray, intTree.GetPostorderRound().ToArray());
          }

          /// <summary>
          /// Test strings with default comparer. 
          /// </summary>
          [Test]
          public void TestString()
          {
               BinaryTree<string> stringTree = new BinaryTree<string>(Comparer<string>.Default, new string[] { "b", "c", "a", "d" });
               string[] expectedArray = new string[] { "b", "a", "c", "d" };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetPreorderRound().ToArray());
               expectedArray = new string[] { "a", "b", "c", "d" };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetInorderRound().ToArray());
               expectedArray = new string[] { "a", "d", "c", "b" };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetPostorderRound().ToArray());
          }

          /// <summary>
          /// Test strings with new comparer. 
          /// </summary>
          [Test]
          public void TestStringNewComparer()
          {
               BinaryTree<string> stringTree = new BinaryTree<string>(new CompareStringsByLength(), new string[] { "bbb", "cccc", "a", "dd" });
               string[] expectedArray = new string[] { "bbb", "a", "dd", "cccc" };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetPreorderRound().ToArray());
               expectedArray = new string[] { "a", "dd", "bbb", "cccc" };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetInorderRound().ToArray());
               expectedArray = new string[] { "dd", "a", "cccc", "bbb" };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetPostorderRound().ToArray());
          }

          /// <summary>
          /// Test Books with default comparer. 
          /// </summary>
          [Test]
          public void TestBook()
          {
               Book.Book[] inputArray = new Book.Book[4];
               Book.Book b1 = new Book.Book("ISBN978-5-98901-592-9", "Достоевский", "Преступление и наказание", "Солнышко", 1976, 300, 12);
               Book.Book b2 = new Book.Book("ISBN978-5-98901-592-8", "Достоевский", "Идиот", "Солнышко", 1990, 300, 19);
               Book.Book b3 = new Book.Book("ISBN978-5-98901-592-7", "Достоевский", "Записки из подполья", "Солнышко", 1985, 200, 15);
               Book.Book b4 = new Book.Book("ISBN978-5-98901-592-7", "Достоевский", "Братья Карамазовы", "Солнышко", 1985, 200, 14);

               inputArray[0] = b1;
               inputArray[1] = b2;
               inputArray[2] = b3;
               inputArray[3] = b4;
               BinaryTree<Book.Book> bookTree = new BinaryTree<Book.Book>(Comparer<Book.Book>.Default, inputArray);
                    
               Book.Book[] expectedArray = new Book.Book[] { b1, b2, b3, b4 };
               CollectionAssert.AreEqual(expectedArray, bookTree.GetPreorderRound().ToArray());
               expectedArray = new Book.Book[] { b4, b3, b2, b1 };
               CollectionAssert.AreEqual(expectedArray, bookTree.GetInorderRound().ToArray());
               expectedArray = new Book.Book[] { b4, b3, b2, b1 };
               CollectionAssert.AreEqual(expectedArray, bookTree.GetPostorderRound().ToArray());
          }

          /// <summary>
          /// Test Books with new comparer. 
          /// </summary>
          [Test]
          public void TestBookNewComparer()
          {
               Book.Book[] inputArray = new Book.Book[4];
               Book.Book b1 = new Book.Book("ISBN978-5-98901-592-9", "Достоевский", "Преступление и наказание", "Солнышко", 1976, 300, 12);
               Book.Book b2 = new Book.Book("ISBN978-5-98901-592-8", "Достоевский", "Идиот", "Солнышко", 1990, 300, 19);
               Book.Book b3 = new Book.Book("ISBN978-5-98901-592-7", "Достоевский", "Записки из подполья", "Солнышко", 1985, 200, 15);
               Book.Book b4 = new Book.Book("ISBN978-5-98901-592-7", "Достоевский", "Братья Карамазовы", "Солнышко", 1985, 200, 14);

               inputArray[0] = b1;
               inputArray[1] = b2;
               inputArray[2] = b3;
               inputArray[3] = b4;
               BinaryTree<Book.Book> bookTree = new BinaryTree<Book.Book>(new CompareBooksByTitle(), inputArray);

               Book.Book[] expectedArray = new Book.Book[] { b1, b2, b3, b4 };
               CollectionAssert.AreEqual(expectedArray, bookTree.GetPreorderRound().ToArray());
               expectedArray = new Book.Book[] { b4, b3, b2, b1 };
               CollectionAssert.AreEqual(expectedArray, bookTree.GetInorderRound().ToArray());
               expectedArray = new Book.Book[] { b4, b3, b2, b1 };
               CollectionAssert.AreEqual(expectedArray, bookTree.GetPostorderRound().ToArray());
          }

          /// <summary>
          /// Test Points with new comparer.
          /// </summary>
          [Test]
          public void TestPointNewComparer()
          {
               Point[] inputArray = new Point[4];
               Point p1 = new Point(10, 4);
               Point p2 = new Point(2, 7);
               Point p3 = new Point(1, 1);
               Point p4 = new Point(5, 9);

               inputArray[0] = p1;
               inputArray[1] = p2;
               inputArray[2] = p3;
               inputArray[3] = p4;
               BinaryTree<Point> stringTree = new BinaryTree<Point>(new ComparePoints(), inputArray);

               Point[] expectedArray = new Point[] { p1, p2, p3, p4 };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetPreorderRound().ToArray());
               expectedArray = new Point[] { p3, p2, p4, p1 };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetInorderRound().ToArray());
               expectedArray = new Point[] { p3, p4, p2, p1 };
               CollectionAssert.AreEqual(expectedArray, stringTree.GetPostorderRound().ToArray());
          }
     }
}
