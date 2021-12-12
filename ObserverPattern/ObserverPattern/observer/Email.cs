using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.observer
{
   public  class Email:IEmail
    {
        public List<IObserver> Observers { get; set; }
        public int EvenMinute { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);

        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);

        }


        public void NotifyObservers()
        {
            foreach(var observer in Observers)
            {

                observer.WatchEvenMinute(EvenMinute);
                
            }

        }

        public string Check()
        {

            var email = "";

            EvenMinute = DateTime.Now.Minute % 2;
                if (EvenMinute == 0)
                {
                  Console.WriteLine("no new minute");


                
                }
                if (EvenMinute == 1)
                {
                    email = " Email sent to Observer";
                    NotifyObservers();
                }
                return email;

            

        }
    }
}
