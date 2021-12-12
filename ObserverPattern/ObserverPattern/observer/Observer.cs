using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.observer
{
    public class Observer: IObserver
    {
        public void WatchEvenMinute(int EvenMinute)
        {
            Console.WriteLine($"The time watcher says :It´s {EvenMinute} minute now");
        }
    }
}
