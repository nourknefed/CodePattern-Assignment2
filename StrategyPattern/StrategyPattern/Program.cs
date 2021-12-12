using Autofac;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AFConfic.Configure();

            // Create an instance of IApplication since we are not using a constructor here
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }
    }
}
