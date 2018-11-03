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
    [TestFixture]
    public class NUnitTests
     {
          Book checkingBook1, checkingBook2;
          [SetUp]
          public void Init()
          {
               checkingBook1 = new Book("Pride and Prejudice", "Jane Austen", "Sun", "5", "280", "20 y.e.", "1960");
               checkingBook2 = new Book("Jane Eyre", "Charlotte Bronte", "Star", "4", "500", "30 y.e.", "2016");
          }
          [Test]
          public void CheckCentury()
          {
               Assert.AreEqual("20", checkingBook1.GetСentury());
               Assert.AreEqual("21", checkingBook2.GetСentury());
          }
     }
}
