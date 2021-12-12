using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    public class Inserted : Decorator,IInserted
    {
        public Inserted(IDefaultText Text): base(Text)
        {
            TagSelection1 = "<ins>";
            TagSelection2 = "</ins>";
        }
    }
}
