using Autofac;
using SampleApp.Sale.Persistance;
using SampleApp.Sale.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Sale
{
    public class SaleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<SaleDbContext>().As<ISaleDbContext>().SingleInstance();
            builder.RegisterType<SaleService>().As<ISaleService>().InstancePerLifetimeScope();
        }
    }
}
