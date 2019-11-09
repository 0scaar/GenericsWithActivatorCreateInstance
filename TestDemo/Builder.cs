using ClassDemo;
using TestDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo
{
    public class Builder<T> : IBuilder<T>
    {
        private IIdentificationRecordBuilder<T> identificationRecordBuilder;

        public Builder(IIdentificationRecordBuilder<T> identificationRecordBuilder)
        {
            this.identificationRecordBuilder = identificationRecordBuilder;
        }

        public T Execute()
        {
            return identificationRecordBuilder.Build();
        }

    }
}
