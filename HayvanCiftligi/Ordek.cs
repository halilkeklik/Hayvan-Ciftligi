using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligi
{
    class Ordek : Hayvan
    {
        public override void Enerji()
        {
            if (enerji> 0)
            {
                enerji -= 3;
            }
            else
            {
                enerji = 0;
            }
        }

        public int eNerji
        {
            set
            {
                eNerji = enerji;
            }
            get
            {
                if (enerji < 3)
                {
                    return enerji = 0;
                }
                else
                    return enerji;
            }
        }

        public override void Urun()
        {
            if (enerji > 0)
            {
                urun++;
            }
        }

        public override void YemVer()
        {
            if (enerji > 0)
            {
                enerji = 100;
            }
        }

    }
}
