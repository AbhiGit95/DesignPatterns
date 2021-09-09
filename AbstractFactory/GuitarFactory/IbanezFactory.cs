using AbstractFactory.ConcreteGuitar;
using AbstractFactory.ConcreteStrings;
using AbstractFactory.Guitar;
using System;

namespace AbstractFactory.GuitarFactory
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

        public IStrings GetStringType(StringType stringType)
        {
            switch (stringType)
            {
                case StringType.Aluminium:
                    return new Aluminium();
                case StringType.Nylon:
                    return new Nylon();
                default:
                    throw new Exception("Invalid String type");
            }
        }
    }
}
