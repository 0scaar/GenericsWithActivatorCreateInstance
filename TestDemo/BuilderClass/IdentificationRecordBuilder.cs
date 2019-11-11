using TestDemo.Interfaces;

namespace TestDemo.BuilderClass
{
    public abstract class IdentificationRecordBuilder<IdentificationRecord> //: IIdentificationRecordBuilder<IdentificationRecord>
    {
        protected IdentificationRecord identificationRecord;

        public IdentificationRecordBuilder()
        {
            Defaults();
        }

        public virtual void Defaults()
        {
        }

        public IdentificationRecord Build()
        {
            return identificationRecord;
        }

        //public string FileName;
        //public DateTime GenerationDate;
        //public DateTime BillingCycleDate;

        //public static IdentificationRecordBuilder New()
        //{
        //    return new IdentificationRecordBuilder
        //    {
        //        GenerationDate = new DateTime(2019, 03, 13, 23, 51, 13), //13/03/2019 23:51:13
        //        BillingCycleDate = new DateTime(2019, 03, 31, 23, 51, 13) //31/03/2019 23:51:13
        //    };
        //}

        //public IdentificationRecordBuilder WithFileName(string filename)
        //{
        //    FileName = filename;
        //    return this;
        //}

        //public IdentificationRecordBuilder WithGenerationDate(DateTime generationdate)
        //{
        //    GenerationDate = generationdate;
        //    return this;
        //}

        //public IdentificationRecordBuilder WithBillingCycleDate(DateTime billingcycledate)
        //{
        //    BillingCycleDate = billingcycledate;
        //    return this;
        //}

        //public IIdentificationRecord Build()
        //{
        //    return (IIdentificationRecord)Activator.CreateInstance(typeof(IIdentificationRecord), GenerationDate, BillingCycleDate);
        //}
    }
}
