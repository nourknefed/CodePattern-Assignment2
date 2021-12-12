
using Autofac;
using DecoratorPatttern.decorators;
using System;

namespace DecoratorPatttern
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var container = AFConfig.Configure();

           
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();




        }
    }
}
