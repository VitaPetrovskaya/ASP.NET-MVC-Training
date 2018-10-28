﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class BookListStorage
     {
          private string path;
          public string Path
          {
               get { return path; }
               set
               {
                    if(value == null || value == "")
                         throw new ArgumentException();
                    path = value;
               }
          }
          public BookListStorage(string path)
          {
               Path = path;
          }

          public List<Book> GetBookList()
          {
               List<Book> books = new List<Book>();

               using (BinaryReader reader = new BinaryReader(File.Open(Path, FileMode.OpenOrCreate)))
               {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                         var isbn = reader.ReadString();
                         var author = reader.ReadString();
                         var title = reader.ReadString();
                         var publisher = reader.ReadString();
                         var year = reader.ReadInt32();
                         var numOfPages = reader.ReadInt32();
                         var price = reader.ReadDouble();
                         Book book = new Book(isbn, author, title, publisher, year, numOfPages, price);
                         books.Add(book);
                    }
               }
               return books;
          }

          public void Save(List<Book> books)
          {
               if (new FileInfo(Path).Length != 0)
               {
                    System.IO.File.WriteAllText(Path, string.Empty);
               }
               using (BinaryWriter writer = new BinaryWriter(File.Open(Path, FileMode.OpenOrCreate)))
               {
                    foreach (Book book in books)
                    {
                         writer.Write(book.ISBN);
                         writer.Write(book.Author);
                         writer.Write(book.Title);
                         writer.Write(book.Publisher);
                         writer.Write(book.Year);
                         writer.Write(book.NumOfPages);
                         writer.Write(book.Price);
                    }
               }
          }
     }
}