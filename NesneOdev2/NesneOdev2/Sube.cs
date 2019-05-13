using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NesneOdev2
{
    
    class Sube
    {
        int subeKodu;
        List<Ogrenci> ogrencilerSube= new List<Ogrenci>();

        public Sube(int subeKodu)
        {
            this.subeKodu = subeKodu;
        }

        internal List<Ogrenci> OgrencilerSube { get => ogrencilerSube; set => ogrencilerSube = value; }
    }
}
