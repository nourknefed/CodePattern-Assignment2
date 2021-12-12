using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.strategy
{
   public class Send : ISend
    {
        public IMessage Message { get; set; }


        public void SendMessage()
        {
            var messagae = "This is a messssssssssage";

            Message.SendMessage(messagae);
        }

    }
}
