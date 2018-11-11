using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     public class BookListService
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

          public List<Book> ListOfBooks
          {
               get { return listOfBooks; }
               private set { }
          }

          /// <summary>
          /// Add book to list.
          /// </summary>
          /// <param name="book"></param>
          public void AddBook(Book book)
          {
               if (IsExist(book))
               {
                    throw new ArgumentException();
               }

               listOfBooks.Add(book);
          }

          /// <summary>
          /// Remove book from list.
          /// </summary>
          /// <param name="book"></param>
          public void RemoveBook(Book book)
          {
               if (IsExist(book))
               {
                    throw new ArgumentException();
               }

               listOfBooks.Remove(book);
          }

          /// <summary>
          /// Find book by criterial with the help of interface variable.
          /// </summary>
          /// <param name="criterion">
          /// Interface variable that implements the search method.
          /// </param>
          /// <returns>
          /// Required book.
          /// </returns>
          public Book FindBookByTag(IFindBookBy criterion)
          {
               if (criterion == null)
               {
                    throw new ArgumentNullException();
               }

               return criterion.FindBookByTag(listOfBooks);
          }

          /// <summary>
          /// Sort list of books by criterion.
          /// </summary>
          /// <param name="criterion">
          /// Interface variable that implements the sorting method.
          /// </param>
          public void SortBooksByTag(ISortBooksBy criterion)
          {
               if (criterion == null)
               {
                    throw new ArgumentNullException();
               }

               listOfBooks = criterion.SortBooksByTag(listOfBooks).ToList();
          }

          /// <summary>
          /// Save list to file.
          /// </summary>
          public void SaveToStorage()
          {
               bookStorage.Save(listOfBooks);
          }

          /// <summary>
          /// Check existence of the book.
          /// </summary>
          /// <param name="book"></param>
          /// <returns></returns>
          private bool IsExist(Book book)
          {
               if (book == null)
               {
                    return false;
               }

               foreach (Book bookInList in listOfBooks)
               {
                    if (book.Equals(bookInList))
                    {
                         return true;
                    }
               }

               return false;
          }
     }
}
