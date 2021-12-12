using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatttern
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

         
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<DefaultText>().As<IDefaultText>();



            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("decorators"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name));






            return builder.Build();
        }
    }
}
