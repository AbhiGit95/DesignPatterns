using AbstractFactory.Guitar;

namespace AbstractFactory.ConcreteGuitar
{
    class Prestige : IGuitar
    {
        int _strings;
        GuitarType _guitarType;

        public Prestige(int numStrings, GuitarType type)
        {
            _guitarType = type;
            _strings = numStrings;
        }
        public GuitarBrand getBrand()
        {
            return GuitarBrand.Ibanez;
        }

        public GuitarModels getGuitarModel()
        {
            return GuitarModels.Prestige;
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
