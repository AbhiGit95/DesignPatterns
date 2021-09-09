using Factory.ConcreteGuitar;
using Factory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.GuitarFactory
{
    public class IbanezFactory : IGuitarFactory
    {
        int _strings;
        GuitarType _guitarType;
        public IbanezFactory(int numStrings, GuitarType type)
        {
            _strings = numStrings;
            _guitarType = type;
        }
        public IGuitar GetGuitar(GuitarModels guitarModel)
        {
            switch (guitarModel)
            {
                case GuitarModels.Prestige:
                    return new Prestige(_strings, _guitarType);
                case GuitarModels.RGX5:
                    return new RGX5(_strings, _guitarType);
                default:
                    throw new Exception("Invalid Jackson Guitar Model");

            }
        }
    }
}
