using Autofac;
using ClassDemo.Base;
using ClassDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in Gcsb.Connect.SAP.Application
            //
            builder.RegisterAssemblyTypes(typeof(Application.ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<IdentificationRecord>().As<IIdentificationRecord>();
            builder.RegisterType<IdentificationRecordDemo55>().As<IIdentificationRecord>().InstancePerLifetimeScope();
            builder.RegisterType<IdentificationRecordDemo56>().As<IIdentificationRecord>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
