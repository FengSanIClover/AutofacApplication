using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Interfaces;
using Services;

namespace AutofacApplication
{
    public static class ContainerConfig
    {
        public static IContainer Congigure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BasicCalculatorService>().As<ICalculatorService>();

            return builder.Build();
        }
    }
}
