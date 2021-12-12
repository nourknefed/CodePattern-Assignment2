using StrategyPattern.strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Application : IApplication
    {
        public ISend Send { get; set; }
        public IEmail Email { get; set; }
        public ISMS SMS { get; set; }
        public IFacebook FacebookMessage { get; set; }

        public Application(IEmail email, ISMS sMS, IFacebook facebookMessage, ISend send)
        {
            Email = email;
            SMS = sMS;
            FacebookMessage = facebookMessage;
            Send = send;
            Send.Message = Email;

        }



        public void Run()
        {



            Console.WriteLine("*********** Strategy ***********");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("        Select an action        ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("e: Send Email");
            Console.WriteLine("s: Send SMS");
            Console.WriteLine("f: Send Facebook Message");


            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'e' or 'E':
                        ClearRow();
                        Console.Write("Email");
                        Send.Message = Email;
                        Send.SendMessage();
                        break;

                    case 's' or 'S':
                        ClearRow();
                        Console.Write("Sms");
                        Send.Message = SMS;
                        Send.SendMessage();
                        break;

                    case 'f' or 'F':
                        ClearRow();
                        Console.Write("Facebook message");
                        Send.Message = FacebookMessage;
                        Send.SendMessage();
                        break;

                    default:
                        ClearRow();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }

        private static void ClearRow()
        {
            Console.SetCursorPosition(1, 9);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }

    }
}
