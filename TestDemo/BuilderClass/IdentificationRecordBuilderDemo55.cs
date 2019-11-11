using ClassDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.BuilderClass
{
    public class IdentificationRecordBuilderDemo55 : IdentificationRecordBuilder<IdentificationRecordDemo55>
    {
        public string FileName;
        public DateTime GenerationDate;
        public DateTime BillingCycleDate;

        public static IdentificationRecordBuilderDemo55 New()
        {
            return new IdentificationRecordBuilderDemo55
            {
                GenerationDate = new DateTime(2019, 03, 13, 23, 51, 13), //13/03/2019 23:51:13
                BillingCycleDate = new DateTime(2019, 03, 31, 23, 51, 13) //31/03/2019 23:51:13
            };
        }

        public IdentificationRecordBuilderDemo55 WithFileName(string filename)
        {
            FileName = filename;
            return this;
        }

        public IdentificationRecordBuilderDemo55 WithGenerationDate(DateTime generationdate)
        {
            GenerationDate = generationdate;
            return this;
        }

        public IdentificationRecordBuilderDemo55 WithBillingCycleDate(DateTime billingcycledate)
        {
            BillingCycleDate = billingcycledate;
            return this;
        }

        public new IdentificationRecordDemo55 Build()
        {
            return new IdentificationRecordDemo55(GenerationDate, BillingCycleDate);
        }
    }
}
