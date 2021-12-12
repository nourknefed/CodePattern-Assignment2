using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Important : Decorator,IImportant
    {
        public Important(IDefaultText Text):base(Text)
        {
            TagSelection1 = "<strong>";
            TagSelection2 = "</strong>";
        }
    }
}
