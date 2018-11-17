using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Book
{
     public class BookListService
     {
          private List<Book> listOfBooks = new List<Book>();
          private BookListStorage bookStorage;
          private Logger logger;

          public BookListService(BookListStorage storage)
          {
               logger = LogManager.GetCurrentClassLogger();
               if (ReferenceEquals(storage, null))
               {
                    logger.Error("Specified storage is null.");
                    throw new ArgumentNullException();
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
                    logger.Error("The book has already been added.");
                    throw new ArgumentException();
               }
                    
               listOfBooks.Add(book);
               logger.Info("The book was successfully added.");
          }

          /// <summary>
          /// Remove book from list.
          /// </summary>
          /// <param name="book"></param>
          public void RemoveBook(Book book)
          {
               if (!IsExist(book))
               {
                    logger.Error("The book for removal was not found.");
                    throw new ArgumentException();
               }
                    
               listOfBooks.Remove(book);
               logger.Info("The book was successfully removed.");
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
                    logger.Error("Specified searching criterion is null.");
                    throw new ArgumentNullException();
               }

               logger.Debug("Book search.");
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
                    logger.Error("Specified sorting criterion is null.");
                    throw new ArgumentNullException();
               }

               logger.Debug("Book sort.");
               listOfBooks = criterion.SortBooksByTag(listOfBooks).ToList();
          }

          /// <summary>
          /// Save list to file.
          /// </summary>
          public void SaveToStorage()
          {
               try
               {
                    bookStorage.Save(listOfBooks);
                    logger.Info("List of books was saved.");
               }
               catch(Exception e)
               {
                    logger.Error("List of books wasn't saved. Error: {0}", e.Message);
               }
          }

          /// <summary>
          /// Check existence of the book.
          /// </summary>
          /// <param name="book"></param>
          /// <returns></returns>
          private bool IsExist(Book book)
          {
               logger.Trace("Check book on the existence in list.");
               if (book == null)
               {
                    return false;
               }
                    
               foreach (Book bookInList in listOfBooks)
               {
                    if (book.Equals(bookInList))
                    {
                         logger.Debug("Checked book exists.");
                         return true;
                    }
               }

               logger.Debug("Checked book doesn't exists.");
               return false;
          }
     }
}
