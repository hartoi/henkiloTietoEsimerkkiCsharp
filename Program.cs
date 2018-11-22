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
        public string tulostaTiedostoonFormaatti()
        {
            return nimi + ";" + ika + ";" + harrastukset+"\r\n";
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
            /*
            Henkilo matti = new Henkilo("Matti", "34", "sienestys");
            Henkilo teppo = new Henkilo("Teppo", "24", "metsästys");
            Henkilo janina = new Henkilo("Janina", "20", "ompeleminen,BB");// jotain googlatkaa miten 
              */                                                             // muuta henkilot taulukkomuuttuja listaksi
            List<Henkilo> henkilot = new List<Henkilo>();// tässä uusi lista ja siihen matti,teppo,janina
            /*
            henkilot.Add(matti);
            henkilot.Add(teppo);
            henkilot.Add(janina);
    */        
    // TEHTÄVÄ 2
            // luo kolmelle henkilölle taulukkomuuttuja, johon asetat ne

            //{ matti, teppo, janina }; // jotain
            // TEHTÄVÄ 3
            // Muuta seuraava loopiksi

            // TEHTÄVÄ 4
            // Lisää for-looppi switch/casen 1.kohtaan

            // TEHTÄVÄ 5
            // Kirjoita tiedot tiedostoon "C:\Users\raikas\Desktop\henkilodata.txt"
            // Googlaa c# write to file, katso eka esimerkki
           
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
                        for (int i = 0; i < henkilot.Count; i++)
                        {
                            henkilot[i].tulostaTyyppi();
                        }
                        break;
                    case 2:
                        // Otetaan tiedot ja lisätään henkilö listaan
                        Console.WriteLine("Anna nimi");             // kysy nimi
                        string nimi = Console.ReadLine();           // talleta nimi (matti.nimi <= käyttäjän syöte)
                        Console.WriteLine("Anna ikä");              // Kysy ikä
                        string ikä = Console.ReadLine();            // talleta ikä
                        Console.WriteLine("Anna harrastukset");     // kysy harrastukset
                        string harrastukset = Console.ReadLine();   // talleta harrastukset
                        // Luo uusi henkilö
                        Henkilo lisättävä = new Henkilo(nimi,ikä,harrastukset);
                        // Lisää äsken luotu henkilö listaan henkilöt
                        henkilot.Add(lisättävä);
                        break;
                    case 3:
                        Console.WriteLine("3.Valittu");
                        foreach (string line in System.IO.File.ReadLines(
                            @"C:\Users\raikas\Desktop\henkilödata.txt"))
                        {
                            string rivi_nimi = line.Split(';')[0];
                            string rivi_ikä = line.Split(';')[1];
                            string rivi_harrastukset = line.Split(';')[2];
                            Henkilo rivi_lisättävä = new Henkilo(rivi_nimi,
                                rivi_ikä,rivi_harrastukset);
                            // Lisää äsken luotu henkilö listaan henkilöt
                            henkilot.Add(rivi_lisättävä);
                            // luokaa näistä tiedoista uusi henkilö
                        }

                        // lue rivi tiedostosta henkilödata.txt
                        // erottele tiedot split-komennolla
                        // luo näistä tiedoista uusi henkilö
                        // lisää henkilö listaan henkilöt
                        // toista sama muille tiedoston riveille
                        break;
                    case 4:
                        string teksti = "";
                        foreach( Henkilo data in henkilot)
                        {
                            teksti = teksti + data.tulostaTiedostoonFormaatti();
                        }
                        System.IO.File.WriteAllText(
                            @"C:\Users\raikas\Desktop\henkilödata.txt", teksti);
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