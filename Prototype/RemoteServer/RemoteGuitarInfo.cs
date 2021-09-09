
namespace Prototype.RemoteServer
{

    public class GuitarInfo
    {
        public string GuitarModel { get; set; }
        public int NumberOfStrings { get; set; }
        public string Brand { get; set; }
    }

    public class RemoteGuitarInfo
    {
        public GuitarInfo GetGuitarDetails()
        {
            GuitarInfo _guitarInfo = new GuitarInfo();
            _guitarInfo.Brand = "Gibson";
            _guitarInfo.GuitarModel = "LesPaul";
            _guitarInfo.NumberOfStrings = 6;

            return _guitarInfo;
        }
    }
}
