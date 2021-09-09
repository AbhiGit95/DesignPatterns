using SimpleFactory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.ConcreteGuitar
{
    class Ibanez : IGuitar
    {
        int _strings;
        GuitarType _guitarType;
        public Ibanez(int num_strings, GuitarType guitarType)
        {
            _strings = num_strings;
            _guitarType = guitarType;
        }

        public GuitarBrand getBrand()
        {
            return GuitarBrand.Ibanez;
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
