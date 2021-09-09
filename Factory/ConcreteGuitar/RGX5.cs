using Factory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.ConcreteGuitar
{
    class RGX5 : IGuitar
    {
        int _strings;
        GuitarType _guitarType;

        public RGX5(int numStrings, GuitarType type)
        {
            _strings = numStrings;
            _guitarType = type;
        }
        public GuitarBrand getBrand()
        {
            return GuitarBrand.Ibanez;
        }

        public GuitarModels getGuitarModel()
        {
            return GuitarModels.RGX5;
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
