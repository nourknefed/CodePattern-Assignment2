using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Subscript: Decorator,ISubscript
    {
        public Subscript(IDefaultText Text):base(Text)
        {
            TagSelection1 = "<sub>";
            TagSelection2 = "</sub>";
        }
    }
}
