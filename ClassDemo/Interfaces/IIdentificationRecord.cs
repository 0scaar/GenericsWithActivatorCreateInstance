using System;

namespace ClassDemo.Interfaces
{
    public interface IIdentificationRecord
    {
        string LineType { get; }
        string FileName { get; }
        DateTime GenerationDate { get; }
        int Sequence { get; }
        DateTime BillingCycleDate { get; set; }
    }
}
