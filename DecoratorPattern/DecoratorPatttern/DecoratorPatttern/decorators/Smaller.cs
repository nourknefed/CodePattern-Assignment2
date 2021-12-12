using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Smaller : Decorator,ISmaller
    {
        public Smaller(IDefaultText Text): base(Text)
        {
            TagSelection1 = "<small>";
            TagSelection2 = "</small>";
        }
    }
}
