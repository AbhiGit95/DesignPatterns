using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Guitar
{
    public interface IGuitar
    {
        GuitarBrand getBrand();
        int getStrings();
        GuitarType getGuitarType();
    }

    public enum GuitarType
    {
        Acoustic,
        Electric,
        Semi_Acoustic
    }
}
