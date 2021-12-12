using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern.decorators
{
    class Deleted : Decorator,IDeleted
    {
        public Deleted(IDefaultText Text): base(Text)
        {
            TagSelection1 = "<del>";
            TagSelection2 = "</del>";
        }
    }
}
