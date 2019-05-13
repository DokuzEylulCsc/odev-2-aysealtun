using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    class YuksekLisans : Ogrenci
    {
        
        public YuksekLisans( int ogrenciId, string ogrenciAdi) : base(ogrenciId, ogrenciAdi)
        {
            base.ogrenciId = ogrenciId;
            base.ogrenciAdi = ogrenciAdi;
            
        }
    }
}
