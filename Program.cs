﻿using System;

namespace UusiTekstinLukuJaKirjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1.Tulosta tiedot");
            Console.WriteLine("2.Lisää tieto");
            Console.WriteLine("3.Lue tiedostosta");
            Console.WriteLine("4.Kirjoita tiedostoon");
            Console.WriteLine("5.Lopeta");
            int valinta = int.Parse(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    Console.WriteLine("Valitsit toiminnon 1");
                    break;
            }
        }
    }
}