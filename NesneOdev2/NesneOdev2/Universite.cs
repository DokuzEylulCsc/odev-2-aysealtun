using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NesneOdev2
{
    class Universite
    {
        private string universiteAdi;
        public string UniversiteAdi { get => universiteAdi; }

        public Universite() { }
        public Universite(string adi)
        {
            this.universiteAdi = adi;
        }

        public List<Fakulte> fakulteList;
        
        public List<Fakulte> FakulteList { get => fakulteList; set => fakulteList = value; }

        public void FakulteEkle(int fakulteId, string fakulteAdi)
        {
            try
            {   
                Fakulte f = new Fakulte(fakulteId, fakulteAdi);
                fakulteList.Add(f);
            }
            catch (Exception e)
            {
                Console.WriteLine("Eklenemedi" + e);
            }
        }

    }
}
