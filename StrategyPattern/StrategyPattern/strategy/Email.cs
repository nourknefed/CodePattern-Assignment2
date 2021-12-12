using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.strategy
{
    public class Email : IEmail
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($" sending \"{message}\" as an email");
        }
    }
}
