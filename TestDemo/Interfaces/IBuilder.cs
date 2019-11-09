using ClassDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Interfaces
{
    public interface IBuilder<T>
    {
        T Execute();
    }
}
