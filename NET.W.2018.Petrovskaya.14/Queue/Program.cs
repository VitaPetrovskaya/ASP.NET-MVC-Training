using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
     public class Program
     {
          public static void Main(string[] args)
          {
               Queue<int> intQueue = new Queue<int>();
               intQueue.Enqueue(100);
               intQueue.Enqueue(200);
               intQueue.Enqueue(300);
               intQueue.Enqueue(400);
               foreach (int elem in intQueue)
               {
                    Console.WriteLine(elem);
               }

               intQueue.Dequeue();
               intQueue.Dequeue();
               foreach (int elem in intQueue)
               {
                    Console.WriteLine(elem);
               }

               Console.ReadLine();
          }
     }
}
