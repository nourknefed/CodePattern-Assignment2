using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Emphasized : Decorator,IEmphasized
    {
        public Emphasized(IDefaultText Text):base(Text)
        {
            TagSelection1 = "<em>";
            TagSelection2 = "</em>";
        }
    }
}
