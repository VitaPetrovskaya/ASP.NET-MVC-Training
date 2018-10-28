using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class BookListService
     {
          private List<Book> listOfBooks = new List<Book>();
          private BookListStorage bookStorage;

          public BookListService(BookListStorage storage)
          {
               if (ReferenceEquals(storage, null))
               {
                    throw new ArgumentException();
               }
               bookStorage = storage;
               listOfBooks = bookStorage.GetBookList();
          }

          public void AddBook(Book book)
          {
               if(IsExist(book))
                    throw new ArgumentException();
               listOfBooks.Add(book);
          }

          public void RemoveBook(Book book)
          {
               if (IsExist(book))
                    throw new ArgumentException();
               listOfBooks.Remove(book);
          }

          public Book FindBookByTag(IFindBookBy criterion)
          {
               if (criterion == null)
                    throw new ArgumentNullException();
               return criterion.FindBookByTag();
          }

          public void SortBooksByTag(ISortBooksBy criterion)
          {
               if (criterion == null)
                    throw new ArgumentNullException();
               listOfBooks = criterion.SortBooksByTag();
          }

          private bool IsExist(Book book)
          {
               if (book == null)
                    return false;
               foreach (Book bookInList in listOfBooks)
                    if (book.Equals(bookInList))
                         return true;
               return false;
          }

          public void SaveToStorage()
          {
               bookStorage.Save(listOfBooks);
               //listOfBooks = bookStorage.GetBookList();
          }
     }
}
