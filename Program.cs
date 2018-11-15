using System;
using System.Collections.Generic;

namespace UusiTekstinLukuJaKirjoitus
{
    class Henkilo
    {
        // olion ominaisuudet (properties)
        public string nimi;
        public string ikä;
        public string harrastus;
        // lisää tähän string-muuttujat, johon laitetaan harrastukset
        public void esitteleItsesti() {
            Console.WriteLine("Nimi:" + nimi + " ikä:" + ikä + " harrastukset:" + harrastus);
        }
        // olion funktiot (eli metodit)
        public Henkilo(string animi, string aikä, string aharrastus) // Muodostin (constructor) funktio
        {
            nimi = animi;
            ikä = aikä;
            harrastus = aharrastus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            // Tämän koodin pitäis toimia kun luokka on valmis
            // Lisää mattille yksi harrastus tässä
            Henkilo matti = new Henkilo("Matti", "13", "Ponit");
            Henkilo marleena = new Henkilo("Marleena", "30", "Ompelu");
            Henkilo sirpa = new Henkilo("Sirpa", "54", "Toimintaelokuvat");
            /*
            Console.WriteLine(matti.nimi + " " + matti.ikä + " " + matti.harrastus);

            Console.WriteLine(marleena.nimi + " " + marleena.ikä + " " + marleena.harrastus);

            // Googlaa c# class methods examples
            marleena.esitteleItsesti();
            sirpa.esitteleItsesti();
            */
            // TEHTÄVÄ
            // Etsi miten C#:lla luetaan tietoa tiedostosta
            // Lue data.txt ohjelman muistiin ja tulosta se konsoliin
            // Google-apu: C# read textfile 
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\raikas\Desktop\data.txt");
          
            for ( int i = 0; i < 4; i++)
            {
                Console.WriteLine( lines[i] );
            }
            /*
            //                         0                           1
            string[] lines2 = { "Moro Joulupukki,", "Tässä on pieni kirje sinulle",
                //   2          3
                "Terveisin", "Matti" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(lines2[i]);
            }
            /*
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            */
            Console.WriteLine("Rivejä on "+lines.Length);
            // Tehtävä tulsota lines muuttuja sekä for:illa että foreach:lla
        }
    }
}
