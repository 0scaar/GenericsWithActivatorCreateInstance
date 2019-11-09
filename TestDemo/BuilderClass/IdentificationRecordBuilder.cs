using ClassDemo.Interfaces;
using TestDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.BuilderClass
{
    public class IdentificationRecordBuilder : IIdentificationRecordBuilder<IIdentificationRecord>
    {
        public string FileName;
        public DateTime GenerationDate;
        public DateTime BillingCycleDate;

        public static IdentificationRecordBuilder New()
        {
            return new IdentificationRecordBuilder
            {
                GenerationDate = new DateTime(2019, 03, 13, 23, 51, 13), //13/03/2019 23:51:13
                BillingCycleDate = new DateTime(2019, 03, 31, 23, 51, 13) //31/03/2019 23:51:13
            };
        }

        public IdentificationRecordBuilder WithFileName(string filename)
        {
            FileName = filename;
            return this;
        }

        public IdentificationRecordBuilder WithGenerationDate(DateTime generationdate)
        {
            GenerationDate = generationdate;
            return this;
        }

        public IdentificationRecordBuilder WithBillingCycleDate(DateTime billingcycledate)
        {
            BillingCycleDate = billingcycledate;
            return this;
        }

        public IIdentificationRecord Build()
        {
            return (IIdentificationRecord)Activator.CreateInstance(typeof(IIdentificationRecord), GenerationDate, BillingCycleDate);
        }
    }
}
