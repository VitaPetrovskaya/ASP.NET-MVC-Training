using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookExtension;
using BookLibrary;
using NUnit.Framework;

namespace ExtensionTest
{
     /// <summary>
     /// Class for testing extension of type Book.
     /// </summary>
     [TestFixture]
     public class NUnitTests
     {
          private Book checkingBook1, checkingBook2, nullBook;
          [SetUp]
          public void Init()
          {
               checkingBook1 = new Book("Pride and Prejudice", "Jane Austen", "Sun", "5", "280", "20 y.e.", "1960");
               checkingBook2 = new Book("Jane Eyre", "Charlotte Bronte", "Star", "4", "500", "30 y.e.", "2016");
               nullBook = null;
          }

          [Test]
          public void CheckCentury()
          {
               Assert.AreEqual("20", checkingBook1.GetСentury());
               Assert.AreEqual("21", checkingBook2.GetСentury());
          }

          [Test]
          public void CheckNull()
          {
               Assert.Throws<ArgumentNullException>(() => nullBook.GetСentury());
          }
     }
}
