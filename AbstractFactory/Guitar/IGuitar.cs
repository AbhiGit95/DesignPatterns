
namespace AbstractFactory.Guitar
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
