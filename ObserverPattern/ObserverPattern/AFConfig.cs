using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("observer"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();
            return builder.Build();
        }
 
}  }
