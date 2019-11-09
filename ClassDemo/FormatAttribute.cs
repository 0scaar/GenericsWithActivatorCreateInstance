using System;

namespace ClassDemo
{
    public class FormatAttribute : Attribute
    {
        public string Format { get; set; }

        public FormatAttribute(string format)
        {
            this.Format = format;
        }
    }
}
