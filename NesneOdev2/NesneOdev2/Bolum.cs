using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev2
{
    class Bolum : Fakulte
    {

        public int bolumId;
        public string ismi;
        List<Ogrenci> ogrenciList;

        public int BolumId { get => bolumId; set => bolumId = value; }
        public string Ismi { get => ismi; set => ismi = value; }
        public List<Ogrenci> OgrenciList { get => ogrenciList; set => ogrenciList = value; }

        List<OgretimElemani> lisansOgretmenList;
        internal List<OgretimElemani> LisansOgretmenList { get => lisansOgretmenList; set => lisansOgretmenList = value; }

        List<OgretimElemani> yuksekLisansOgretmenList;
        internal List<OgretimElemani> YuksekLisansOgretmenList { get => yuksekLisansOgretmenList; set => yuksekLisansOgretmenList = value; }

        List<OgretimElemani> doktoraOgretmenList;
        internal List<OgretimElemani> DoktoraOgretmenList { get => doktoraOgretmenList; set => doktoraOgretmenList = value; }


        public Bolum()
        {
        }

        public Bolum(int bolumId, string ismi)
        {
            this.bolumId = bolumId;
            this.ismi = ismi;
        }
        //öğretmen ekleme işlemi yaparken öğretimElemanı classında ogretmen bolumId kullanarak bolumıd ile kontrol sağladım.
        //eğer bolumId ler eşitse öğretmen eklemesi lisans, y.lisans ya da doktora öğretmen listesine eklenecektir.
        void OgretmenEkle(string ogretmenAdi, int ogretmenId, int bolumId)
        {
            try
            {
                foreach (OgretimElemani ogretmen in lisansOgretmenList)
                {
                    for (int i = 0; i < ogretmen.LisansOgretmenList.Count; i++)
                        if (ogretmen.LisansOgretmenList[i].ogretmenBolumId == bolumId)
                        {
                            OgretimElemani og = new OgretimElemani(ogretmenAdi, ogretmenId, bolumId);
                            ogretmen.LisansOgretmenList.Add(og);
                            return;
                        }
                }
                foreach (OgretimElemani ogretmen in yuksekLisansOgretmenList)
                {
                    for (int i = 0; i < ogretmen.YuksekLisansOgretmenList.Count; i++)
                        if (ogretmen.YuksekLisansOgretmenList[i].ogretmenBolumId == bolumId)
                        {
                            OgretimElemani og = new OgretimElemani(ogretmenAdi, ogretmenId, bolumId);
                            ogretmen.YuksekLisansOgretmenList.Add(og);
                            return;
                        }
                }
                foreach (OgretimElemani ogretmen in doktoraOgretmenList)
                {
                    for (int i = 0; i < ogretmen.DoktoraOgretmenList.Count; i++)
                        if (ogretmen.DoktoraOgretmenList[i].ogretmenBolumId == bolumId)
                        {
                            OgretimElemani og = new OgretimElemani(ogretmenAdi, ogretmenId, bolumId);
                            ogretmen.DoktoraOgretmenList.Add(og);
                            return;
                        }
                }
            }
            catch(Exception b)
            {
                Console.WriteLine("Ogretmen eklenemedi!" + b.Message);
            }
            }

        //öğretmen silme işlemi için eklemedeki gibi bolumIdlerini kontrol ettim.
        //Idler aynıysa silme işlemi yapılcaktır.
        void OgretmenSilme()
        {
            try
            {
                foreach (OgretimElemani ogretmen in lisansOgretmenList)
                {
                    if (ogretmen.ogretmenBolumId == bolumId)
                    {
                        for (int i = 0; i < ogretmen.LisansOgretmenList.Count; i++)
                        {
                            if (ogretmen.LisansOgretmenList[i].ogretmenBolumId == bolumId)
                            {
                                ogretmen.LisansOgretmenList.RemoveAt(i);
                                return;
                            }
                        }
                    }
                }
                foreach (OgretimElemani ogretmen in yuksekLisansOgretmenList)
                {
                    if (ogretmen.ogretmenBolumId == bolumId)
                    {
                        for (int i = 0; i < ogretmen.YuksekLisansOgretmenList.Count; i++)
                        {
                            if (ogretmen.YuksekLisansOgretmenList[i].ogretmenBolumId == bolumId)
                            {
                                ogretmen.YuksekLisansOgretmenList.RemoveAt(i);
                                return;
                            }
                        }
                    }
                }
                foreach (OgretimElemani ogretmen in doktoraOgretmenList)
                {
                    if (ogretmen.ogretmenBolumId == bolumId)
                    {
                        for (int i = 0; i < ogretmen.DoktoraOgretmenList.Count; i++)
                        {
                            if (ogretmen.DoktoraOgretmenList[i].ogretmenBolumId == bolumId)
                            {
                                ogretmen.DoktoraOgretmenList.RemoveAt(i);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception d)
            {
                Console.WriteLine("Öğretmen silinemedi!" + d.Message);
            }

        }

        List<Ders> lisansDersList;
        internal List<Ders> LisansDersList { get => lisansDersList; set => lisansDersList = value; }

        List<Ders> yuksekLisansDersList;
        internal List<Ders> YuksekLisansDersList { get => yuksekLisansDersList; set => yuksekLisansDersList = value; }

        List<Ders> doktoraDersList;
        internal List<Ders> DoktoraDersList { get => doktoraDersList; set => doktoraDersList = value; }

        //ders ekleme işlemleri bolumIdler ile yapılmıştır.
        void DersEkle(int dersId, string dersAdi, int bolumId)
        {
            try
            {
                foreach (Ders d in LisansDersList)
                {
                    for (int i = 0; i < d.lisansDersList.Count; i++)
                        if (d.lisansDersList[i].dersBolumId == bolumId)
                        {
                            Ders ders = new Ders(dersId, dersAdi, bolumId);
                            d.lisansDersList.Add(ders);
                            return;
                        }
                }
                foreach (Ders d in yuksekLisansDersList)
                {
                    for (int i = 0; i < d.yuksekLisansDersList.Count; i++)
                        if (d.yuksekLisansDersList[i].dersBolumId == bolumId)
                        {
                            Ders ders = new Ders(dersId, dersAdi, bolumId);
                            d.yuksekLisansDersList.Add(ders);
                            return;
                        }
                }
                foreach (Ders d in doktoraDersList)
                {
                    for (int i = 0; i < d.doktoraDersList.Count; i++)
                        if (d.doktoraDersList[i].dersBolumId == bolumId)
                        {
                            Ders ders = new Ders(dersId, dersAdi, bolumId);
                            d.doktoraDersList.Add(ders);
                            return;
                        }
                }
            }
            catch(Exception d)
            {
                Console.WriteLine("Ders eklenemedi!" + d.Message);
            }
        }
    }
}