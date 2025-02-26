/*
 * 1.Studentų Pažymiai
Sukurkite klasę Student, kuri turi šiuos laukus:
Name (studento vardas),
Grades (masyvas su studento pažymiais, pvz., [8, 9, 7, 10]).
Parašykite metodą GetAverageGrade(), kuris apskaičiuoja ir grąžina studento pažymių vidurkį.
Parašykite metodą GetStatus(), kuris pagal vidurkį grąžina:
"Puiku", jei vidurkis >= 9,
"Gerai", jei vidurkis >= 7,
"Patenkinama", jei vidurkis >= 5,
"Nepatenkinama", jei vidurkis < 5.
Sukurkite bent 3 studentus ir išveskite jų vardus, vidurkius bei statusą.
 */

using System;
using Uzduotis1.Models;

namespace Uzduotis1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Kiek studentu noresite prideti? ");
            int sCount = int.Parse(Console.ReadLine());
            Student[] students = new Student[sCount];
            for(int i = 0; i < sCount; i++)
            {
                Console.WriteLine("Studento Vardas: ");
                string sName = Console.ReadLine();

                Console.WriteLine("Kiek pazymiu ivesite: ");
                int gCount = int.Parse(Console.ReadLine());
                int[] sGrades = new int[gCount];
                for(int j = 0; j < gCount; j++)
                {
                    Console.WriteLine($"Iveskite {j + 1} studento {sName} pazymi: ");
                    sGrades[j] = int.Parse(Console.ReadLine());
                }

                students[i] = new Student { Name = sName, Grades = sGrades };
            }

            foreach(Student s in students)
            {
                Console.WriteLine($"Studento {s.Name} statusas: "+s.GetStatus());
            }
        }
    }
}