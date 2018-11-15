using System;

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

            Console.WriteLine(matti.nimi + " " + matti.ikä + " " + matti.harrastus);

            Console.WriteLine(marleena.nimi + " " + marleena.ikä + " " + marleena.harrastus);

            // Googlaa c# class methods examples
            marleena.esitteleItsesti();
            sirpa.esitteleItsesti();
        }
    }
}
