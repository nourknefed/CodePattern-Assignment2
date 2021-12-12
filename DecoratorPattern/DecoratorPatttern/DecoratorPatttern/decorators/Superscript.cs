using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
   public class Superscript: Decorator,ISuperscript
    {
        public Superscript(IDefaultText Text):base(Text)
        {
            TagSelection1 = "<sup>";
            TagSelection2 = "</sup>";
        }
    }
}
