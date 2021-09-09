using System;
using System.Collections.Generic;
using System.Text;
using SimpleFactory.Guitar;

namespace SimpleFactory.ConcreteGuitar
{
    class Jackson : IGuitar
    {
        int _strings;
        GuitarType _guitarType;

        public Jackson(int num_strings, GuitarType guitarType)
        {
            _strings = num_strings;
            _guitarType = guitarType;
        }

        public GuitarBrand getBrand()
        {
            return GuitarBrand.Jackson;
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
