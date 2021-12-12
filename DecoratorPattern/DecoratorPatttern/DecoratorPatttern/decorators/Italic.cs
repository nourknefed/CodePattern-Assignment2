using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
   public class Italic:Decorator, IItalic
    {
        public Italic(IDefaultText Text):base(Text)
        {
            TagSelection1 = "<i>";
            TagSelection2 = "</i>";
        }
    }
}
