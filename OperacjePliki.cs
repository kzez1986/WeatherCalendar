using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using Rekord;

namespace Operacje_plikowe
{
    public class TOperacjePliki
    {
        protected TRekord r;
        protected String nazwa_pliku;
        public TOperacjePliki()
        {
            r = TRekord.Adres;
        }
        public String NazwaPliku
        {
            get
            {
                String mies, dz, godz;
                if (r.Miesiąc < 10)
                    mies = "0" + r.Miesiąc.ToString();
                else
                    mies = r.Miesiąc.ToString();
                if (r.Dzień < 10)
                    dz = "0" + r.Dzień.ToString();
                else
                    dz = r.Dzień.ToString();
                if (r.Godzina < 10)
                    godz = "0" + r.Godzina.ToString();
                else
                    godz = r.Godzina.ToString();
                nazwa_pliku = string.Format("Lublin_{0}{1}{2}{3}", r.Rok.ToString(), mies, dz, godz); 
                return nazwa_pliku;
            }
        }

    }
    public abstract class TŁańcuchPobierzDane : TOperacjePliki
    {
        public abstract void PobierzDane(String nazwa_pliku);
    }
    public class TSieć : TŁańcuchPobierzDane
    {
        public override void PobierzDane(string nazwa_pliku)
        {
            DateTime temp;
            temp = DateTime.Now;
            if (temp.Hour == r.Godzina && temp.Year == r.Rok && temp.Month == r.Miesiąc && temp.Day == r.Dzień) //pobieranie z sievi nie ma sensu dla innego czasu i bieżący
            {
                WebClient client = new WebClient();
                try
                {
                    client.DownloadFile("http://rss.wunderground.com/auto/rss_full/global/stations/12495.xml", "dane.xml");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problem z podłączeniem do serwera. Sprawdź połączenie z Internetem lub poczekaj jakiś czas aż serwer będxzie znowu dostępny. Dopóki problem nie zostanie rozwiązany, dostępne będą wyłącznie dane lokalne.");
                    TPlikIn p = new TPlikIn();
                    p.PobierzDane(nazwa_pliku);
                    return;
                }
                StreamReader sr = File.OpenText("dane.xml");
                string input = null;
                for (int i = 0; i < 19; i++)
                    input = sr.ReadLine();
                sr.Close();
                int poz = input.IndexOf('&') + 2;
                input = input.Substring(poz);
                poz = input.IndexOf('/') + 2;
                input = input.Substring(poz);
                poz = input.IndexOf('&');
                int temperatura = int.Parse(input.Substring(0, poz));
                poz = input.IndexOf('/') + 2;
                input = input.Substring(poz);
                poz = input.IndexOf('h');
                int ciśnienie = int.Parse(input.Substring(0, poz));
                poz = input.IndexOf(':') + 2;
                input = input.Substring(poz);
                poz = input.IndexOf('|') - 1;
                String warunki = input.Substring(0, poz);
                poz = input.IndexOf(':') + 2;
                input = input.Substring(poz);
                poz = input.IndexOf(' ');
                String kierunek = input.Substring(0, poz);
                poz = input.IndexOf('/') + 2;
                input = input.Substring(poz);
                poz = input.IndexOf('k');
                int szybkość = int.Parse(input.Substring(0, poz));
                r.Temperatura = temperatura;
                r.Szybkość_wiatru = szybkość;
                r.Kierunek_wiatru = kierunek;
                r.Ciśnienie = ciśnienie;
                r.Warunki = warunki;
            }
            else
            {
                TPlikIn p = new TPlikIn();
                p.PobierzDane(nazwa_pliku);
            }
        }
    }
    public class TPlikIn : TŁańcuchPobierzDane
    {
        public override void PobierzDane(string nazwa_pliku)
        {
            if (File.Exists(nazwa_pliku)) //struktura pliku 1 linia = 1 dana (1 plik - 5 linii)
                //opis linii: godzina, temperatura, szybkość wiatru, kierunek wiatru, ciśnieniw, warunki
            {
                StreamReader sr = File.OpenText(NazwaPliku);
                //godziny 0 - 24
                //numer linii startowej: godzina * 6 + 1
                r.Temperatura = int.Parse(sr.ReadLine());
                r.Szybkość_wiatru = int.Parse(sr.ReadLine());
                r.Kierunek_wiatru = sr.ReadLine();
                r.Ciśnienie = int.Parse(sr.ReadLine());
                r.Warunki = sr.ReadLine();
                sr.Close();
            }
            else
            {
                TBrakDanych brak = new TBrakDanych();
                brak.PobierzDane(nazwa_pliku);
            }
        }  
    }
    public class TBrakDanych : TŁańcuchPobierzDane
    {
        public override void PobierzDane(string nazwa_pliku)
        {
            FileInfo plik = new FileInfo(nazwa_pliku);
            //wypełnianie pliku wartościami oznaczającymi, że nic tu nie ma
            StreamWriter sw = plik.CreateText();
            sw.WriteLine("-99"); //temperatura
            sw.WriteLine("-1"); //prędkość wiatru
            sw.WriteLine("NULL"); //kierunek wiatru
            sw.WriteLine("-999"); //ciśnienie
            sw.WriteLine("NULL"); //warunki
            sw.Close();
            r.Temperatura = -99;
            r.Szybkość_wiatru = -1;
            r.Kierunek_wiatru = "NULL";
            r.Ciśnienie = -999;
            r.Warunki = "NULL";
        }
    }
    public class TZapiszDane : TOperacjePliki
    {
        public void ZapiszDane(string nazwa_pliku)
        {
            if (!File.Exists(nazwa_pliku))
            {
                FileInfo plik = new FileInfo(nazwa_pliku);
                FileStream fs = plik.Create();
            }
            FileInfo plik2 = new FileInfo(nazwa_pliku);
            StreamWriter sw = plik2.CreateText();
            sw.WriteLine(r.Temperatura.ToString());
            sw.WriteLine(r.Szybkość_wiatru.ToString());
            sw.WriteLine(r.Kierunek_wiatru);
            sw.WriteLine(r.Ciśnienie.ToString());
            sw.WriteLine(r.Warunki);
            sw.Close();
        }
    }
}
