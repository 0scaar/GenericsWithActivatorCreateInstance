using Autofac;
using ClassDemo;
using ClassDemo.Base;
using ClassDemo.Interfaces;
using TestDemo.BuilderClass;
using TestDemo.Interfaces;

namespace TestDemo.Fixture
{
    public class ApplicationFixture
    {
        public IContainer Container { get; private set; }

        public ApplicationFixture()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClassDemo.Modules.ApplicationModule>();


            //builder.RegisterType<IdentificationRecord>().As<IIdentificationRecord>();
            //builder.RegisterType<IdentificationRecordDemo55>().As<IIdentificationRecord>().InstancePerLifetimeScope();
            //builder.RegisterType<IdentificationRecordDemo56>().As<IIdentificationRecord>().InstancePerLifetimeScope();

            builder.RegisterType<IdentificationRecordBuilder>().As<IIdentificationRecordBuilder<IIdentificationRecord>>();
            builder.RegisterType<Builder<IdentificationRecordDemo55>>().As<IBuilder<IdentificationRecordDemo55>>();

            Container = builder.Build();
        }
    }
}
