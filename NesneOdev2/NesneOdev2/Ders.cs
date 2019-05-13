using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NesneOdev2
{
    class Ders : Bolum
    {
        private Ders ders;
        internal List<Ders> ogrencilerDers = new List<Ders>();
        int dersId;
        public int DersId { get => dersId; set => dersId = value; }
        string dersAdi;
        public string DersAdi { get => dersAdi; set => dersAdi = value; }

        public int dersBolumId;
        public int DersBolumId { get => dersBolumId; set => dersBolumId = value; }

        public Ders(int dersId, string dersAdi, int bolumId)
        { }



    }
}
}
