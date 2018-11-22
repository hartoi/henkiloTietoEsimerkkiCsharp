using System;
using System.Collections.Generic;

namespace tekstinLukuJakirjoitus
{
    class Henkilo
    {
        public string nimi;
        public string ika;
        public string harrastukset;
        public void tulostaTyyppi()
        {
            Console.WriteLine("Nimi:" + nimi + " ikä:" + ika + " harrastukset:" + harrastukset);
        }
        public Henkilo(string n = "", string i = "", string h = "")
        {
            nimi = n;
            ika = i;
            harrastukset = h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // TEHTÄVÄ 1: luo kolme henkilöä harrastuksineen luokasta henkilo
            Henkilo matti = new Henkilo("Matti", "34", "sienestys");
            Henkilo teppo = new Henkilo("Teppo", "24", "metsästys");
            Henkilo janina = new Henkilo("Janina", "20", "ompeleminen,BB");// jotain googlatkaa miten 
                                                                           // muuta henkilot taulukkomuuttuja listaksi
            List<Henkilo> henkilot = new List<Henkilo>();// tässä uusi lista ja siihen matti,teppo,janina
            henkilot.Add(matti);
            henkilot.Add(teppo);
            henkilot.Add(janina);
            // TEHTÄVÄ 2
            // luo kolmelle henkilölle taulukkomuuttuja, johon asetat ne

            //{ matti, teppo, janina }; // jotain
            // TEHTÄVÄ 3
            // Muuta seuraava loopiksi
            for (int i = 0; i < henkilot.Count; i++)
            {
                henkilot[i].tulostaTyyppi();
            }
            // TEHTÄVÄ 4
            // Lisää for-looppi switch/casen 1.kohtaan

            // TEHTÄVÄ 5
            // Kirjoita tiedot tiedostoon "C:\Users\raikas\Desktop\henkilodata.txt"
            // Googlaa c# write to file, katso eka esimerkki
            string rivi = henkilot[1].nimi + ";" + henkilot[1].ika +
                ";" + henkilot[1].harrastukset;
            Console.WriteLine(rivi); // ei tulosteta consoleen, vaan tiedostoon
            while (true)
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
                        Console.WriteLine("1.Valittu");
                        break;
                    case 2:
                        Console.WriteLine("2.Valittu");
                        break;
                    case 3:
                        Console.WriteLine("3.Valittu");
                        break;
                    case 4:
                        Console.WriteLine("4.Valittu");

                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Tarkista valinta");
                        break;
                } // switch
            } // while            
        } // main
    }
}