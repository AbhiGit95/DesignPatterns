using AbstractFactory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IGuitarFactory
    {
        IGuitar GetGuitar(GuitarModels guitarModel);
        IStrings GetStringType(StringType stringType);
    }
}
