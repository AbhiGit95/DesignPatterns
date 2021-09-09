using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static SingletonClass _singleton;
        private static readonly object _lockResource = new object(); 
        private SingletonClass()
        {
            Console.WriteLine("Class Instantiated");
        }

        public static SingletonClass GetInstance()
        {
            lock(_lockResource)
            {
                if (_singleton == null)
                    _singleton = new SingletonClass();

                return _singleton;
            }
        }
    }
}
