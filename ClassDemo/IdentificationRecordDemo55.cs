using ClassDemo.Base;
using System;

namespace ClassDemo
{
    public class IdentificationRecordDemo55 : IdentificationRecord
    {
        protected override string filecod => "55";

        public IdentificationRecordDemo55(DateTime generationdate, DateTime billingCycleDate)
            : base(generationdate, billingCycleDate)
        { }

        public IdentificationRecordDemo55(int sequence, DateTime billingCycleDate)
            : base(sequence, billingCycleDate)
        { }
    }
}
