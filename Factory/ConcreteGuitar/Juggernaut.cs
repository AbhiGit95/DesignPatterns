using Factory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.ConcreteGuitar
{
    class Juggernaut : IGuitar
    {
        int _strings;
        GuitarType _guitarType;

        public Juggernaut(int numStrings, GuitarType type)
        {
            _strings = numStrings;
            _guitarType = type;
        }
        public GuitarBrand getBrand()
        {
            return GuitarBrand.Jackson;
        }

        public GuitarModels getGuitarModel()
        {
            return GuitarModels.Juggernaut;
        }

        public GuitarType getGuitarType()
        {
            return _guitarType;
        }

        public int getStrings()
        {
            return _strings;
        }
    }
}
