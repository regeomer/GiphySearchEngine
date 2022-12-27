using Autofac;
using DataLogic;
using DataLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;
using System;

namespace GiphyAPI.Configuration.IOCConfig
{
    public class DIConfig
    {
        public static IServiceProvider Configure(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ServiceManager>().As<IServiceManager>().SingleInstance();
            builder.Populate(services);

            var container = builder.Build();
            return new AutofacServiceProvider(container);
        }
    }
}
