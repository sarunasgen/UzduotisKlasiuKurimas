using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzduotisKlasiuKurimas.Models
{
    public class Pastatas
    {
        public string Adresas { get; set; }
        public Patalpa[] Patalpos { get; set; }

        public int SkaiciuotiKomercinesPatalpas()
        {
            int kiekis = 0;
            foreach (Patalpa p in Patalpos)
            {
                if (p.Tipas == "Komercines Patalpos")
                    kiekis++;
            }
            return kiekis;
        }

        public int SkaiciuotiGyvenamasiasPatalpas()
        {
            int kiekis = 0;
            foreach (Patalpa p in Patalpos)
            {
                if (p.Tipas == "Gyvenamosios Patalpos")
                    kiekis++;
            }
            return kiekis;
        }
        public double GautiPastatoGyvenamujuPatalpuPlota()
        {
            double plotas = 0;
            foreach (Patalpa p in Patalpos)
            {
                if (p.Tipas == "Gyvenamosios Patalpos")
                    plotas = plotas + p.Plotas;
            }

            return plotas;
        }

        public double GautiPastatoKomerciniuPatalpuPlota()
        {
            double plotas = 0;
            foreach (Patalpa p in Patalpos)
            {
                if (p.Tipas == "Komercines Patalpos")
                    plotas = plotas + p.Plotas;
            }

            return plotas;
        }
    }
}
