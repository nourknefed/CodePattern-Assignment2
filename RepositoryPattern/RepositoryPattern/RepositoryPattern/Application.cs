using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class Application
    {
        
        private IRepository Repository {get;set;}

        public Application(IRepository repository)
        {
            Repository = repository;
        }

       

        public void Run()
        {
            Console.WriteLine("***Repository***");
            Console.WriteLine("--------------------");
            Console.WriteLine("  Select an action  ");
            Console.WriteLine("--------------------");
            Console.WriteLine("1: Load Data");
            Console.WriteLine("2: search Data");
            Console.WriteLine("3: Save Data");

            Console.WriteLine("4: Exit Program");


            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Repository.Load();
                        break;
                    case '2':

                        Console.WriteLine("Enter the data you want to search");
                        var name = Console.ReadLine();
                        Repository.SearchData(name);
                        break;
                    case '3':
                        Console.WriteLine("Enter the data you want to save");
                        var newdata = Console.ReadLine();
                        Repository.Save(newdata);
                        break;
                }
            }
        }

    }
}
