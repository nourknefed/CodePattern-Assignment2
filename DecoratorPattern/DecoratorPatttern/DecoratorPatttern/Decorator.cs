using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern
{
    public class Decorator : IDefaultText
    {


        public IDefaultText Text { get; set; }
        public string TagSelection1 { get; set; }
        public string TagSelection2 { get; set; }
        public string TextInput { get; set; }

        public Decorator(IDefaultText text)
        {
            Text = text;
        }



        public string GetText(string textinput)
        {
            return TagSelection1 + Text.GetText(textinput) + TagSelection2;
            
        }
    }
}
