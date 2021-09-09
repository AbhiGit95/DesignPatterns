using AbstractFactory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ConcreteStrings
{
    class Nylon : IStrings
    {
        public StringType GetStringType()
        {
            return StringType.Nylon;
        }
    }
}
