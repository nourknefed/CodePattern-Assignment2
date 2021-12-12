using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new();
            Application application = new(repository);

            application.Run();

          

            
        }
    }
}
