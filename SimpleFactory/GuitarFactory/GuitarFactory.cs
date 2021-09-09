using SimpleFactory.ConcreteGuitar;
using SimpleFactory.Guitar;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.GuitarFactory
{
    public class GuitarFactory
    {

        //Centralizes Object Creation
        public static IGuitar CreateGuitar(GuitarBrand brand, int numStrings, GuitarType type)
        {
            switch(brand)
            {
                case GuitarBrand.Ibanez:
                    return new Ibanez(numStrings, type);
                case GuitarBrand.Jackson:
                    return new Jackson(numStrings, type);
                default:
                    throw new Exception("Invalid Brand Selected");
            }
        }
    }
}
