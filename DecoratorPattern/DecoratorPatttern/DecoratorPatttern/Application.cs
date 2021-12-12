using DecoratorPatttern.decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern
{
    public class Application : IApplication
    {
        public IDefaultText Text { get; set; }
        public Application(IDefaultText text)
        {
            Text = text;
        }


        public void Run()
        {
            Console.WriteLine("Text Decorator.");
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter Text");
            var input = Console.ReadLine();
            Text.TextInput = input;
        
            
            Console.WriteLine("  Select text Style  ");
            Console.WriteLine("---------------------");
            Console.WriteLine("R: Result");
            Console.WriteLine("b: Bold");
            Console.WriteLine("d:Deleted");
            Console.WriteLine("e:Emphasized");
            Console.WriteLine("m:Important");
            Console.WriteLine("n:inserted");
            Console.WriteLine("t:italic");
            Console.WriteLine("m:marked");
            Console.WriteLine("s:smaller");
            Console.WriteLine("u:subscript");
            Console.WriteLine("p:superscript");






            while (true)
            {
                var choice = Console.ReadKey(true).Key;
             

                switch (choice)
                {
                    case ConsoleKey.R:
                        Console.WriteLine(Text.GetText(input));
                        break;
                    case ConsoleKey.B:
                        Text = new Bold(Text);
                        break;
                    case ConsoleKey.D:
                        Text = new Deleted(Text);
                        break;
                    case ConsoleKey.E:
                        Text = new Emphasized(Text);
                        break;
                    case ConsoleKey.I:
                        Text = new Important(Text);
                        break;
                    case ConsoleKey.N:
                        Text = new Inserted(Text);
                        break;
                    case ConsoleKey.T:
                        Text = new Italic(Text);
                        break;
                    case ConsoleKey.M:
                        Text = new Marked(Text);
                        break;
                    case ConsoleKey.S:
                        Text = new Smaller(Text);
                        break;
                    case ConsoleKey.U:
                        Text = new Subscript(Text);
                        break;
                    case ConsoleKey.P:
                        Text = new Superscript(Text);
                        break;

                }
            }

           

        }
    }
}
