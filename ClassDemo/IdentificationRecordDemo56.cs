using ClassDemo.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class IdentificationRecordDemo56 : IdentificationRecord
    {
        protected override string filecod => "55";

        public IdentificationRecordDemo56(DateTime generationdate, DateTime billingCycleDate)
            : base(generationdate, billingCycleDate)
        { }

        public IdentificationRecordDemo56(int sequence, DateTime billingCycleDate)
            : base(sequence, billingCycleDate)
        { }
    }
}
