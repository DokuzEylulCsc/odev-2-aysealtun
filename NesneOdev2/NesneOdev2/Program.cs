using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace NesneOdev2
{
    class Program
    {
        /*static void Main(string[] args)
        {
         
        }
        static void Serialize(Ogrenci ogrenci)
        {
            Console.WriteLine("Serialize yapılıyor.");
            using (FileStream fs = new FileStream("ogrenci.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(fs, ogrenci);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }
            }
        }
        static Ogrenci Deserialize()
        {
            Console.WriteLine("Deserialize yapılıyor.");
            Ogrenci ogrenci;
            using (FileStream fs = new FileStream("ogrenci.dat", FileMode.Open))
            {

                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    ogrenci = (Ogrenci)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }

            }
            return ogrenci;
        }*/


    }
}

