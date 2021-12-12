using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern
{
    public class DefaultText : IDefaultText
    {
        public string TextInput { get; set; }
        public string TagSelection1 { get; set; }
        public string TagSelection2 { get; set; }


        public DefaultText()
        {
            TagSelection1 = "";
            TagSelection2 = "";
        }

        public string GetText(string textinput)
        {


            return TagSelection1 + textinput + TagSelection2;
        }
    }
}
