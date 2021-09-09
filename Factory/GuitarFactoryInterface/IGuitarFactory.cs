using Factory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IGuitarFactory
    {
        IGuitar GetGuitar(GuitarModels guitarModel);
    }
}
