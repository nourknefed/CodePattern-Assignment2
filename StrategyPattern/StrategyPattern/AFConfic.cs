using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AFConfic
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();


            // Register Strategey classes
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("strategy"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
