using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
     /// <summary>
     /// Instead of the Notify method use event in base class.
     /// </summary>
     public class Stock : Observable
     {
          private readonly List<IObserver> observers;
          private StockInfo stocksInfo;

          public Stock()
          {
               this.observers = new List<IObserver>();
               this.stocksInfo = new StockInfo();
          }

          public override void Register(IObserver observer) => this.observers.Add(observer);

          public override void Unregister(IObserver observer) => this.observers.Remove(observer);

          public void Market()
          {
               Random rnd = new Random();
               this.stocksInfo.USD = rnd.Next(20, 40);
               this.stocksInfo.Euro = rnd.Next(30, 50);
               this.OnNewMarket(this.stocksInfo);
          }
     }
}
