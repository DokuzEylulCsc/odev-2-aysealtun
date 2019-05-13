using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    abstract class Ogrenci
    {
      
        public string ogrenciAdi;
        public int ogrenciId;

        public string OgrenciAdi { get => ogrenciAdi; }
        public int OgrenciId { get => ogrenciId; }
        public Ogrenci (int ogrenciId, string ogrenciAdi)
        {
            this.ogrenciId = ogrenciId;
            this.ogrenciAdi = ogrenciAdi;
        }

        
    }
}
