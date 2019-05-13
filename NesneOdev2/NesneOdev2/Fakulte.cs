using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NesneOdev2
{
    class Fakulte
    {
        int fakulteId;
        public int FakulteId { get => fakulteId; }

        string fakulteAdi;
        public string FakulteAdi { get => fakulteAdi; }

        List<Bolum> lisansBolumList;
        internal List<Bolum> LisansBolumList { get => lisansBolumList; set => lisansBolumList = value; }

        List<Bolum> yuksekLisansBolumList;
        internal List<Bolum> YuksekLisansBolumList { get => yuksekLisansBolumList; set => yuksekLisansBolumList = value; }

        List<Bolum> doktoraBolumList;
        internal List<Bolum> DoktoraBolumList { get => doktoraBolumList; set => doktoraBolumList = value; }

        public Fakulte() { }

        public Fakulte(int fakulteId, string fakulteAdi)
        {
            this.fakulteId = fakulteId;
            this.fakulteAdi = fakulteAdi;
        }
         //lisans,yükseklisans ve doktora için tek tek bolumId kontrolü yapılıp öğrenciler ekleniyor. 
        void OgrenciEkle(int bolumId, int ogrenciId, string ogrenciAdi)
        {
            try
            {
                Ogrenci o;
                foreach (Bolum bolum in lisansBolumList)
                {
                    if (bolum.BolumId == bolumId)
                    {
                        o = new Doktora(ogrenciId, ogrenciAdi);
                        bolum.OgrenciList.Add(o);
                        return;
                    }
                }
                foreach (Bolum bolum in yuksekLisansBolumList)
                {
                    if (bolum.BolumId == bolumId)
                    {
                        o = new YuksekLisans(ogrenciId, ogrenciAdi);
                        bolum.OgrenciList.Add(o);
                        return;
                    }
                }
                foreach (Bolum bolum in doktoraBolumList)
                {
                    o = new Doktora(ogrenciId, ogrenciAdi);
                    if (bolum.BolumId == bolumId)
                    {
                        bolum.OgrenciList.Add(o);
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Öğrenci eklenemedi!" + e.Message);
            }
        }
        //öğrenci silme işlemleri yapılırken lisans,yükseklisans ve doktora bölüm listlerine bakılarak bolumIdleri aynıysa ööğrenci siliniyor.
        void OgrenciSil(int bolumId, int ogrenciId)
        {
            try
            {
                foreach (Bolum bolum in lisansBolumList)
                {
                    if (bolum.BolumId == bolumId)
                    {
                        for (int i = 0; i < bolum.OgrenciList.Count; i++)
                        {
                            if (bolum.OgrenciList[i].ogrenciId == ogrenciId)
                            {
                                bolum.OgrenciList.RemoveAt(i);
                                return;
                            }
                        }
                    }
                }
                foreach (Bolum bolum in yuksekLisansBolumList)
                {
                    if (bolum.BolumId == bolumId)
                    {
                        for (int i = 0; i < bolum.OgrenciList.Count; i++)
                        {
                            if (bolum.OgrenciList[i].ogrenciId == ogrenciId)
                            {
                                bolum.OgrenciList.RemoveAt(i);
                                return;
                            }
                        }
                    }
                }
                foreach (Bolum bolum in doktoraBolumList)
                {
                    if (bolum.BolumId == bolumId)
                    {
                        for (int i = 0; i < bolum.OgrenciList.Count; i++)
                        {
                            if (bolum.OgrenciList[i].ogrenciId == ogrenciId)
                            {
                                bolum.OgrenciList.RemoveAt(i);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Öğrenci silinemedi!" + e.Message);
            }

        }
        //bölüm ekleme işlemini yapmak için ayrı ayrı lisans y.lisans ve doktora bölüm listleri oluşturdum.
        //eğer listlerin içinde aynı isimle bir bölüm yoksa o bölümü ekleyebilirim.Aksi takdirde ekleme olmayacaktır.
        void BolumEkle(int bolumId,string bolumAdi)
        {
            try
            {
                foreach (Bolum bolum in lisansBolumList)
                {
                    for (int i = 0; i < bolum.lisansBolumList.Count; i++)
                    {

                        if (bolum.lisansBolumList[i].ismi != bolumAdi)
                        {
                            Bolum b = new Bolum(bolumId, bolumAdi);
                            bolum.lisansBolumList.Add(b);
                            return;
                        }

                    }

                }
                foreach (Bolum bolum in yuksekLisansBolumList)
                {
                    for (int i = 0; i < bolum.yuksekLisansBolumList.Count; i++)
                    {

                        if (bolum.yuksekLisansBolumList[i].ismi != bolumAdi)
                        {
                            Bolum b = new Bolum(bolumId, bolumAdi);
                            bolum.yuksekLisansBolumList.Add(b);
                            return;
                        }

                    }

                }
                foreach (Bolum bolum in doktoraBolumList)
                {
                    for (int i = 0; i < bolum.doktoraBolumList.Count; i++)
                    {

                        if (bolum.doktoraBolumList[i].ismi != bolumAdi)
                        {
                            Bolum b = new Bolum(bolumId, bolumAdi);
                            bolum.doktoraBolumList.Add(b);
                            return;
                        }

                    }

                }
            }
            catch(Exception a)
            {
                Console.WriteLine("Fakülteye bölüm eklenemedi!" + a.Message);
            }
        }
        
    }

}
