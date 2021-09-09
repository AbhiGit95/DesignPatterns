using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Guitar
{
    public interface IStrings
    {
        StringType GetStringType();
    }

    public enum StringType
    {
        Nylon,
        Aluminium
    }
}
