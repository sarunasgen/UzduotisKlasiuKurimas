using System;
using UzduotisKlasiuKurimas.Models;

namespace UzduotisKlasiuKurimas
{
    public class Program
    {
        public static void Main()
        {
            Patalpa p1 = new Patalpa
            {
                Plotas = 64.55,
                DabartinisGyventojuSkaicius = 3,
                Tipas = "Gyvenamosios Patalpos"
            };
            Patalpa p2 = new Patalpa
            {
                Plotas = 94.55,
                DabartinisGyventojuSkaicius = 4,
                Tipas = "Gyvenamosios Patalpos"
            };
            Patalpa p3 = new Patalpa
            {
                Plotas = 30.55,
                DabartinisGyventojuSkaicius = 0,
                Tipas = "Komercines Patalpos"
            };

            Pastatas pastatas1 = new Pastatas
            {
                Adresas = "Pauksciu g. 74",
                Patalpos = new Patalpa[] { p1, p2, p3 },
            };


            Patalpa pp1 = new Patalpa
            {
                Plotas = 44.55,
                DabartinisGyventojuSkaicius = 1,
                Tipas = "Gyvenamosios Patalpos"
            };
            Patalpa pp2 = new Patalpa
            {
                Plotas = 28,
                DabartinisGyventojuSkaicius = 2,
                Tipas = "Gyvenamosios Patalpos"
            };
            Patalpa pp3 = new Patalpa
            {
                Plotas = 50.55,
                DabartinisGyventojuSkaicius = 0,
                Tipas = "Komercines Patalpos"
            };
            Patalpa pp4 = new Patalpa
            {
                Plotas = 50.55,
                DabartinisGyventojuSkaicius = 5,
                Tipas = "Gyvenamosios Patalpos"
            };

            Pastatas pastatas2 = new Pastatas
            {
                Adresas = "Pauksciu g. 21",
                Patalpos = new Patalpa[] { pp1, pp2, pp3, pp4 },
            };

            Rajonas naujasRajonas = new Rajonas("Naujininkai", "Vilnius", new Pastatas[] { pastatas1, pastatas2 });
            naujasRajonas.RodytiRajonoInformacija();
            

        }
    }
}