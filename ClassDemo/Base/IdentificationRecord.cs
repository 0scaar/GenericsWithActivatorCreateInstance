using ClassDemo.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassDemo.Base
{
    public abstract class IdentificationRecord : IIdentificationRecord
    {
        private const string linetype = "ID";
        private const string billingCycleFormat = "{0:ddyyyyMMdd}";
        private const string generationDateFormat = " {0:ddMMyyyyHHmmss}";
        private const string generationDateYearFormat = "{0:yy}";
        private const string sequenceFormat = "{0:0000}";
        private const string companyMin = "TB";
        private const string divisionNumber = "29";

        protected abstract string filecod { get; }

        [Required]
        [MaxLength(2)]
        public string LineType { get => linetype; }

        [Required]
        [MaxLength(29)]
        public string FileName => $"FAT{filecod}{companyMin}{divisionNumber}{string.Format(generationDateYearFormat, GenerationDate)}{string.Format(sequenceFormat, Sequence)}{string.Format(billingCycleFormat, BillingCycleDate)}.TXT";

        [Required]
        [Format(generationDateFormat)]
        public DateTime GenerationDate { get; private set; }

        [NotMapped]
        public int Sequence { get; private set; }

        [NotMapped]
        [Format(billingCycleFormat)]
        public DateTime BillingCycleDate { get; set; }

        public IdentificationRecord(DateTime generationdate, DateTime billingCycleDate)
        {
            this.GenerationDate = generationdate;
            this.BillingCycleDate = billingCycleDate;
        }

        public IdentificationRecord(int sequence, DateTime billingCycleDate)
        {
            this.Sequence = sequence;
            this.GenerationDate = DateTime.UtcNow;
            this.BillingCycleDate = billingCycleDate;
        }
    }
}
