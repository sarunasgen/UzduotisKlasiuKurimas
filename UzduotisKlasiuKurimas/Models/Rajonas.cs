using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzduotisKlasiuKurimas.Models
{
    public class Rajonas
    {
        public string Pavadinimas { get; set; }
        public string Miestas { get; set; }
        public Pastatas[] Pastatai { get; set; }

        public Rajonas(string pavadinimas, string miestas, Pastatas[] pastatai)
        {
            Pavadinimas = pavadinimas;
            Miestas = miestas;
            Pastatai = pastatai;
        }

        public int SkaiciuotiKomercinesPatalpas()
        {
            int kiekis = 0;

            foreach(Pastatas p in Pastatai)
            {
                kiekis += p.SkaiciuotiKomercinesPatalpas();
            }

            return kiekis;
        }

        

        public double GautiBendraGyvenamujuPatalpuPlota()
        {  //PRASIDEDA
            
            double bendrasPlotas = 0;

            for(int i = 0; i < Pastatai.Length; i++)
            {
                bendrasPlotas += Pastatai[i].GautiPastatoGyvenamujuPatalpuPlota();
            }

            return bendrasPlotas;

        } // BAIGIASI

        public double GautiBendraKomerciniuPatalpuPlota()
        {  //PRASIDEDA

            double bendrasPlotas = 0;

            for (int i = 0; i < Pastatai.Length; i++)
            {
                bendrasPlotas += Pastatai[i].GautiPastatoKomerciniuPatalpuPlota();
            }

            return bendrasPlotas;

        } // BAIGIASI

        public int SkaiciuotiGyvenamasiasPatalpas()
        {
            int kiekis = 0;

            foreach (Pastatas p in Pastatai)
            {
                kiekis += p.SkaiciuotiGyvenamasiasPatalpas();
            }

            return kiekis;
        }
        public void RodytiRajonoInformacija()
        {
            Console.WriteLine("Gyvenamosios Patalpos: " + SkaiciuotiGyvenamasiasPatalpas());
            Console.WriteLine("Komercines Patalpos: " + SkaiciuotiKomercinesPatalpas());
            Console.WriteLine("Bendras gyvenamuju patalpu plotas: " + GautiBendraGyvenamujuPatalpuPlota());
            Console.WriteLine("Bendras komerciniu patalpu plotas: " + GautiBendraKomerciniuPatalpuPlota());
        }
    }
}
