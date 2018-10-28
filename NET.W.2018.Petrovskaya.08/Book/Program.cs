using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class Program
     {
          static void Main(string[] args)
          {
               Book b1 = new Book("ISBN978-5-98901-592-9", "Достоевский", "Преступление и наказание", "Солнышко", 1976, 300, 12);
               Book b2 = new Book("ISBN978-5-99025-792-4", "Достоевский", "Идиот", "Звезда", 1979, 500, 23);
               Console.WriteLine(b1.ToString());
               Console.WriteLine(b2.ToString());
               Console.WriteLine(b1.Equals(b2));
               Console.WriteLine(b1.CompareTo(b2));
               BookListStorage storage = new BookListStorage(@"C:\Disk-D\new\newList.bin");
               BookListService service = new BookListService(storage);
               service.AddBook(b1);
               service.AddBook(b2);
               service.SaveToStorage();
               Console.ReadLine();
          }
     }
}
