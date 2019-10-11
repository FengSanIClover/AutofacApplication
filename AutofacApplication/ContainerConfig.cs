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
            // 建立 ContainerBuilder 用來註冊 Component 及 Service
            var builder = new ContainerBuilder();

            // 註冊 Component(類別)、對應的 Service(介面)
            builder.RegisterType<BasicCalculatorService>().As<ICalculatorService>();

            // 回傳 Container
            return builder.Build();
        }
    }
}
