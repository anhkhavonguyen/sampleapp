using Autofac;
using SampleApp.Core.DbContext;
using SampleApp.Core.Repositories;
using SampleApp.Core.Services;
using SampleApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterGeneric(typeof(Repositories.Repository<>)).As(typeof(Repositories.IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            //builder.RegisterType<SimpleAppContext>().As(typeof(ISimpleAppDbContext)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork.UnitOfWork>().As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}
