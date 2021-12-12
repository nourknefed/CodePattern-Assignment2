using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class Repository : IRepository
    {
        private List<string> Data = new();


        public void Load()
        {
            Console.WriteLine(".........Loading Data...........");
            if (Data.Count > 0)
            {
                foreach (var item in Data)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine(" No Data found  ");
            }


        }

        public void SearchData(string name)
        {
            Console.WriteLine("......searching data......");

            var dataFound = Data.Where(x => x.Contains(name));
            if(dataFound != null)
            {
                Console.WriteLine(dataFound.FirstOrDefault());
            }
            else
            {
                Console.WriteLine("No Data found ");
            }

            

        }

        public void Save(string newdata)
        {
            Console.WriteLine($"....Saving data {newdata}......");

            Data.Add(newdata);

            Console.WriteLine(".... data is saved......");
        }


    }
}
