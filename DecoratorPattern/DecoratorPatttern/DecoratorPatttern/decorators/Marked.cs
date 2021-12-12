using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Marked: Decorator,IMarked
    {
        public Marked(IDefaultText Text):base(Text)
        {
            TagSelection1 = "<mark>";
            TagSelection2 = "</mark>";
        }
    }
}
