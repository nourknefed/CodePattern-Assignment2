using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.strategy
{
    public class Facebook : IFacebook
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        }
    }
}
