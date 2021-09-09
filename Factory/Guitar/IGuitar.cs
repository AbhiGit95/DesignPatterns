using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Guitar
{
    public interface IGuitar
    {
        GuitarBrand getBrand();
        int getStrings();
        GuitarType getGuitarType();

        GuitarModels getGuitarModel();
    }

    public enum GuitarType
    {
        Acoustic,
        Electric,
        Semi_Acoustic
    }
}
