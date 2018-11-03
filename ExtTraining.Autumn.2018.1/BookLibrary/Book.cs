using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
          private string title;
          public string Title
          {
               get { return title; }
               set { title = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string author;
          public string Author
          {
               get { return author; }
               set { author = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string publishingHous;
          public string PublishingHous
          {
               get { return publishingHous; }
               set { publishingHous = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string edition;
          public string Edition
          {
               get { return edition; }
               set { edition = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string pages;
          public string Pages
          {
               get { return pages; }
               set { pages = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string price;
          public string Price
          {
               get { return price; }
               set { price = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }
          private string year;
          public string Year
          {
               get { return year; }
               set { year = value ?? throw new ArgumentException($"Invalid {nameof(value)}"); }
          }

          public Book(string input_title, string input_author, string input_publishingHous, string input_edition, string input_pages, string input_price, string input_year)
          {
               Title = input_title;
               Author = input_author;
               PublishingHous = input_publishingHous;
               Edition = input_edition;
               Pages = input_pages;
               Price = input_price;
               Year = input_year;
          }

          public string ToString(IStringFormat stringFormat)
          {
               if (stringFormat == null)
                    throw new ArgumentNullException();
               return stringFormat.PresentToString(this);
          }
     }
}
