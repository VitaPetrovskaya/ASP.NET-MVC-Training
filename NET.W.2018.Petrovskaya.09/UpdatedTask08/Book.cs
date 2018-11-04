using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     public class Book : IEquatable<Book>, IComparable, IComparable<Book>
     {
          private string isbn;
          private string author;
          private string title;
          private string publisher;
          private int year;
          private int numOfPages;
          private double price;

          public Book(string input_isbn, string input_author, string input_title, string input_publisher, int input_year, int input_numOfPages, double input_price)
          {
               ISBN = input_isbn;
               Author = input_author;
               Title = input_title;
               Publisher = input_publisher;
               Year = input_year;
               NumOfPages = input_numOfPages;
               Price = input_price;
          }

          public string ISBN
          {
               get
               {
                    return isbn;
               }

               set
               {
                    var regex = new System.Text.RegularExpressions.Regex("ISBN978-[0-9]{1}-[0-9]{5}-[0-9]{3}-[0-9]{1}");
                    if (!regex.IsMatch(value))
                    {
                         throw new ArgumentException($"Invalid {nameof(value)}");
                    }

                    isbn = value;
               }
          }

          public string Author
          {
               get { return author; }
               set { author = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }

          public string Title
          {
               get { return title; }
               set { title = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }

          public string Publisher
          {
               get { return publisher; }
               set { publisher = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }

          public int Year
          {
               get
               {
                    return year;
               }

               set
               {
                    if (value < 0)
                    {
                         throw new ArgumentException($"Invalid {nameof(value)}");
                    }

                    year = value;
               }
          }

          public int NumOfPages
          {
               get
               {
                    return numOfPages;
               }

               set
               {
                    if (value < 0)
                    {
                         throw new ArgumentException($"Invalid {nameof(value)}");
                    }

                    numOfPages = value;
               }
          }

          public double Price
          {
               get
               {
                    return price;
               }

               set
               {
                    if (value < 0)
                    {
                         throw new ArgumentException($"Invalid {nameof(value)}");
                    }

                    price = value;
               }
          }

          public string ToString(IStringFormat stringFormat)
          {
               if (stringFormat == null)
               {
                    throw new ArgumentNullException();
               }

               return stringFormat.PresentToString(this);
          }

          /// <summary>
          /// Present the book as a string.
          /// </summary>
          /// <returns>
          /// String with book's characteristic.
          /// </returns>
          public override string ToString()
          {
               return "ISBN:" + ISBN + " Author:" + Author + " Title:" + Title + " Publisher:" + Publisher + " Year:" + Year.ToString() + " Number of pages:" + NumOfPages.ToString() + " Price:" + Math.Round(Price, 2).ToString();
          }

          /// <summary>
          /// Check input object and current book for equality.
          /// </summary>
          /// <param name="obj">
          /// Object for checking.
          /// </param>
          /// <returns>
          /// True if they are equal. False if they are not.
          /// </returns>
          public override bool Equals(object obj)
          {
               var book = obj as Book;
               if (book == null)
               {
                    return false;
               }
                    
               if (ISBN == book.ISBN && Author == book.Author && Title == book.Title
                      && Publisher == book.Publisher && Year == book.Year && NumOfPages == book.NumOfPages)
               {
                    return true;
               }
                    
               return false;
          }

          /// <summary>
          /// Find hash by ISBN
          /// </summary>
          /// <returns></returns>
          public override int GetHashCode()
          {
               return ISBN.GetHashCode();
          }

          /// <summary>
          /// Check input book and current book for equality.
          /// </summary>
          /// <param name="book">
          /// Book for checking.
          /// </param>
          /// <returns>
          /// True if they are equal. False if they are not.
          /// </returns>
          public bool Equals(Book book)
          {
               if (book == null)
               {
                    return false;
               }
                    
               if (ISBN == book.ISBN && Author == book.Author && Title == book.Title
                      && Publisher == book.Publisher && Year == book.Year && NumOfPages == book.NumOfPages)
               {
                    return true;
               }
                    
               return false;
          }

          public int CompareTo(object obj)
          {
               var book = obj as Book;
               return CompareTo(book);
          }

          /// <summary>
          /// Compare books by author and title alphabetically.
          /// </summary>
          /// <param name="book"></param>
          /// <returns></returns>
          public int CompareTo(Book book)
          {
               if (book == null)
               {
                    return 1;
               }
                    
               int result = string.Compare(Author, book.Author, true);
               if (result == 0)
               {
                    result = string.Compare(Title, book.Title);
                    return result;
               }
               else
               {
                    return result;
               }
          }
     }
}
