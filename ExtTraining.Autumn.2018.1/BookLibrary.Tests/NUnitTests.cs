using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookExtension;
using BookLibrary;
using NUnit.Framework;

namespace BookTest
{
    [TestFixture]
    public class NUnitTests
    {
          Book checkingBook;
          [SetUp]
          public void Init()
          {
               checkingBook = new Book("Pride and Prejudice", "Jane Austen", "Sun", "5", "280", "20 y.e.", "1960");
          }

          [Test]
          public void CheckFullFormat()
          {
               Assert.AreEqual("Book record:Jane Austen, Pride and Prejudice, 1960, Sun", checkingBook.ToString(new FullStringFormat()));
          }

          [Test]
          public void CheckAuthorTitleFormat()
          {
               Assert.AreEqual("Book record:Jane Austen, Pride and Prejudice", checkingBook.ToString(new AuthorTitleStringFormat()));
          }

          [Test]
          public void CheckAuthorTitleYearFormat()
          {
               Assert.AreEqual("Book record:Jane Austen, Pride and Prejudice, 1960", checkingBook.ToString(new AuthorTitleYearStringFormat()));
          }

          [Test]
          public void CheckTitleFormat()
          {
               Assert.AreEqual("Book record:Pride and Prejudice", checkingBook.ToString(new TitleStringFormat()));
          }

          [Test]
          public void CheckTitleYearPublishFormat()
          {
               Assert.AreEqual("Book record:Pride and Prejudice, 1960, Sun", checkingBook.ToString(new TitleYearPublishStringFormat()));
          }
     }
}
