using Factory.ConcreteGuitar;
using Factory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.GuitarFactory
{
    public class JacksonFactory : IGuitarFactory
    {
        int _strings;
        GuitarType _guitarType;
        public JacksonFactory(int numStrings, GuitarType type)
        {
            _strings = numStrings;
            _guitarType = type;
        }

        public IGuitar GetGuitar(GuitarModels guitarModel)
        {
            switch(guitarModel)
            {
                case GuitarModels.Dinky:
                    return new Dinky(_strings, _guitarType);
                case GuitarModels.Juggernaut:
                    return new Juggernaut(_strings, _guitarType);
                default:
                    throw new Exception("Invalid Jackson Guitar Model");

            }
        }
    }
}
