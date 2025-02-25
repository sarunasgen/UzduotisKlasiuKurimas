using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzduotisKlasiuKurimas.Models
{
    public class Patalpa
    {
        public string Tipas { get; set; } //Butas, komercines patalpos
        public int DabartinisGyventojuSkaicius { get; set; }
        public double Plotas { get; set; }
    }
}
