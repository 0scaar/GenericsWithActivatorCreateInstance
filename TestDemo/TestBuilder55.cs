using Autofac;
using ClassDemo;
using System;
using TestDemo.Interfaces;
using Xunit;

namespace TestDemo
{
    
    public class TestBuilder55 : IClassFixture<Fixture.ApplicationFixture>
    {
        private readonly IBuilder<IdentificationRecordDemo55> builder;

        public TestBuilder55(Fixture.ApplicationFixture fixture) //
        {
            this.builder = fixture.Container.Resolve<IBuilder<IdentificationRecordDemo55>>();
        }

        [Fact]
        public void Test1()
        {
            var model = builder.Execute();
            Assert.True(true);
        }
    }
}
