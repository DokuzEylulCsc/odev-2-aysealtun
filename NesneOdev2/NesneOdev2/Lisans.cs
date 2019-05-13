using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    class Lisans:Ogrenci
    {
       
        public Lisans( int ogrenciId, string ogrenciAdi) : base( ogrenciId, ogrenciAdi)
        {
            base.ogrenciId = ogrenciId;
            base.ogrenciAdi = ogrenciAdi;
        }

      
    }
}
