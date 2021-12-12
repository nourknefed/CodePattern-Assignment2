using ObserverPattern.observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Application : IApplication
    {

        public IEmail Email { get; set; }
        public IObserver Observer { get; set; }

        public Application(IEmail email, IObserver observer)
        {
            Email = email;
            Observer = observer;
        }

        public void Run()
        {
            Email.RegisterObserver(Observer);

            Console.WriteLine("Even Minute Watch");
            Console.WriteLine("----------------------");
            Console.WriteLine("   Select an action   ");
            Console.WriteLine("----------------------");
            Console.WriteLine("W: Watch Even Minute");
            Console.WriteLine("S: Subscribe/Unsubscribe");
            Console.WriteLine("E: Exit Program");

            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'w' or 'W':
                       // ClearRow();
                        Email.Check();

                        break;

                    case 's' or 'S':
                        ClearRow();
                        if (Email.Observers.Contains(Observer))
                        {
                            Email.UnRegisterObserver(Observer);
                        }
                        else
                        {
                            Email.RegisterObserver(Observer);
                        }
                        break;

                    case 'e' or 'E':
                       // ClearRow();
                        Environment.Exit(0);
                        break;

                    default:
                       // ClearRow();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }

        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }

    }


}
