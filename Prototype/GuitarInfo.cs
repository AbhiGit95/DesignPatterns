using Prototype.RemoteServer;
using System;
using System.Threading;

namespace Prototype
{
    public class GuitarDetails : IGuitarInfo
    {
        GuitarInfo _guitarInfo;
        public GuitarDetails(string msg)
        {
            Console.WriteLine("Fetching Guitar Information");
            Thread.Sleep(3000);
            RemoteGuitarInfo remoteGuitarInfo = new RemoteGuitarInfo();
            _guitarInfo = remoteGuitarInfo.GetGuitarDetails();
            Print(msg);
        }
        public IGuitarInfo DeepCopy()
        {
            GuitarInfo guitarInfo = new GuitarInfo()
            {
                Brand = _guitarInfo.Brand,
                GuitarModel = _guitarInfo.GuitarModel,
                NumberOfStrings = _guitarInfo.NumberOfStrings
            };

            return (IGuitarInfo)guitarInfo;
        }

        public void Print(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--------------{0}-----------------", Message);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n----------------------Guitar Information-------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Guitar Brand : {_guitarInfo.Brand}");
            Console.WriteLine($"Number of Strings : {_guitarInfo.NumberOfStrings}");
            Console.WriteLine($"Guitar Model : {_guitarInfo.GuitarModel}");
        }

        public IGuitarInfo ShallowCopy()
        {
            return (IGuitarInfo)this.MemberwiseClone();
        }
    }
}
