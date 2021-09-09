using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IGuitarInfo
    {
        public IGuitarInfo ShallowCopy();
        public IGuitarInfo DeepCopy();

        void Print(string Message);
    }
}
