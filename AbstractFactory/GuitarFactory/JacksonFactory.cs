using AbstractFactory.ConcreteGuitar;
using AbstractFactory.ConcreteStrings;
using AbstractFactory.Guitar;
using System;

namespace AbstractFactory.GuitarFactory
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

        public IStrings GetStringType(StringType stringType)
        {
            switch(stringType)
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
