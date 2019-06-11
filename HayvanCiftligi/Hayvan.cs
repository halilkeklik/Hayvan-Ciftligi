using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligi
{
    abstract class Hayvan
    {
        public int urun = 0;
        protected int enerji = 100;
        public bool yasam = true;
        public abstract void YemVer();
        public abstract void Enerji();
        public abstract void Urun();
        

    }
}
