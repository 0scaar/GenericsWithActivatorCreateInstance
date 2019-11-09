using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Interfaces
{
    public interface IIdentificationRecordBuilder<T>
    {
        T Build();
    }
}
