using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Bold : Decorator,IBold
    {
        

        public Bold(IDefaultText Text) : base(Text)
        {
           
            TagSelection1 = "<b>";
            TagSelection2 = "</b>";

         

        }
    }
}
