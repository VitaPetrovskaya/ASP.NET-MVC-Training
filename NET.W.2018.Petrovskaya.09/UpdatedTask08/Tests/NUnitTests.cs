using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UpdatingPreviousTasks;

namespace Tests
{
     [TestFixture]
     public class NUnitTests
     {
          private Book checkingBook, nullBook;
          [SetUp]
          public void Init()
          {
               checkingBook = new Book("ISBN978-5-98901-592-9", "Достоевский", "Преступление и наказание", "Солнышко", 1976, 300, 12);
          }

          [Test]
          public void CheckFullFormat()
          {
               Assert.AreEqual("Book record: ISBN978-5-98901-592-9, Достоевский, Преступление и наказание, Солнышко, 1976, 300, 12", checkingBook.ToString(new FullStringFormat()));
          }

          [Test]
          public void CheckAuthorTitleFormat()
          {
               Assert.AreEqual("Book record: Достоевский, Преступление и наказание", checkingBook.ToString(new AuthorTitleStringFormat()));
          }

          [Test]
          public void CheckAuthorTitleYearFormat()
          {
               Assert.AreEqual("Book record: Достоевский, Преступление и наказание, 1976", checkingBook.ToString(new AuthorTitleYearStringFormat()));
          }

          [Test]
          public void CheckTitleFormat()
          {
               Assert.AreEqual("Book record: Преступление и наказание", checkingBook.ToString(new TitleStringFormat()));
          }

          [Test]
          public void CheckTitleYearPublishFormat()
          {
               Assert.AreEqual("Book record: Преступление и наказание, 1976, Солнышко", checkingBook.ToString(new TitleYearPublishStringFormat()));
          }

          [Test]
          public void CheckExtension()
          {
               Assert.AreEqual("Книга Преступление и наказание автор Достоевский. Издательством Солнышко она была напечатана в 1976. Всего 300 страниц.", checkingBook.GetBookDescription());
          }

          [Test]
          public void CheckExtensionNull()
          {
               Assert.Throws<ArgumentNullException>(() => nullBook.GetBookDescription());
          }
     }
}
