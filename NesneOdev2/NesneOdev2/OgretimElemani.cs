using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    class OgretimElemani
    {
        List<OgretimElemani> ogretmenList;
        public string ogretmenAdi;
        public int ogretmenId;
        public int ogretmenBolumId;
        public OgretimElemani(string ogretmenAdi,int ogretmenId, int ogretmenBolumId)
        {
            this.ogretmenAdi = ogretmenAdi;
            this.ogretmenId = ogretmenId;
            this.ogretmenBolumId = ogretmenBolumId;
        }

        public string OgrElemaniAdi { get => ogretmenAdi; set => ogretmenAdi = value; }
        public int OgretmenId { get => ogretmenId; set => ogretmenId = value; }
        public int OgretmenBolumId { get => ogretmenBolumId; set => ogretmenBolumId = value; }
        List<OgretimElemani> lisansOgretmenList;
        internal List<OgretimElemani> LisansOgretmenList { get => lisansOgretmenList; set => lisansOgretmenList = value; }

        List<OgretimElemani> yuksekLisansOgretmenList;
        internal List<OgretimElemani> YuksekLisansOgretmenList { get => yuksekLisansOgretmenList; set => yuksekLisansOgretmenList = value; }

        List<OgretimElemani> doktoraOgretmenList;
        internal List<OgretimElemani> DoktoraOgretmenList { get => doktoraOgretmenList; set => doktoraOgretmenList = value; }

    }
}
