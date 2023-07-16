using System;
using System.Collections.Generic;
using System.Text;
using Czas;
using Zjawisko;
using Operacje_plikowe;
using Kalendarz_Pogody;
using System.Windows.Forms;
using Obliczenia;

namespace Rekord
{
    public interface IBudowniczy
    {
        void ZbudujCzas();
        void ZbudujZjawisko();
        TRekord PobierzWynik();
    }
    public class TBudowniczyRekordu : IBudowniczy
    {
        private TRekord r;
        private TSingletonCzas c;
        private TFabrykaZjawiska z;
        private Kalendarz k;
        public TBudowniczyRekordu()
        {
            z = TFabrykaZjawiska.Adres;
            r = TRekord.Adres;
            c = TSingletonCzas.DajInstancję();

        }
        public void ZbudujCzas()
        {
            r.DodajCzęść(c);   
        }
        public void ZbudujZjawisko()
        {
            r.DodajCzęść(z);
        }
        public TRekord PobierzWynik()
        {
            return r;
        }
    }
    public class TDyrektor
    {
        public void Konstruuj(IBudowniczy build)
        {
            build.ZbudujCzas();
            build.ZbudujZjawisko();
        }
    }
    public class TRekord
    {
        private TSingletonCzas czas;
        private TZjawisko zjawisko;
        private static TRekord instancja;
        private Kalendarz kal;
        public void DodajCzęść(TSingletonCzas c)
        {
            czas = TSingletonCzas.DajInstancję();
        }
        public void DodajCzęść(TFabrykaZjawiska fabryka)
        {
            zjawisko = fabryka.TwórzZjawisko();
        }
        public void WyświetlRekord() //musi być komunikacja z formą
        {
            kal.TemperaturaUstaw.Text = Temperatura.ToString();
            kal.Nagłówek.Text = "Lublin " + Dzień.ToString() + "." + Miesiąc.ToString() + "." + Rok.ToString() + " Dane z godziny " + Godzina.ToString() + ".";
            kal.Wiatr.Text = Szybkość_wiatru.ToString() + "km/h " + Kierunek_wiatru;
            kal.Ciśnienie.Text = Ciśnienie.ToString() + " hPA";
            kal.Warunki.Text = Warunki;
            TObliczenia obl = new TObliczenia();
            if (obl.Max(czas.Rok, czas.Miesiąc) == -99)
                kal.Max.Text = "Maksimum miesięczne: Brak danych";
            else
                kal.Max.Text = "Maksimum miesięczne: " + obl.Max(czas.Rok,czas.Miesiąc).ToString();
            if (obl.Min(czas.Rok, czas.Miesiąc) == 200)
                kal.Min.Text = "Minimum miesięczne: Brak danych";
            else
                kal.Min.Text = "Minimum miesięczne: " + obl.Min(czas.Rok, czas.Miesiąc).ToString();
            if (obl.Średnia(czas.Rok, czas.Miesiąc).ToString() == "nie jest liczbą")
            {
                kal.Średnia.Text = "Średnia miesięczna: Brak danych";
            }
            else
                kal.Średnia.Text = "Średnia miesięczna: " + obl.Średnia(czas.Rok, czas.Miesiąc).ToString();
        }
        public void Pobierz()
        {
            TSieć p = new TSieć();
            p.PobierzDane(p.NazwaPliku);
        }
        public void Zapisz()
        {
            TZapiszDane z = new TZapiszDane();
            z.ZapiszDane(z.NazwaPliku);
        }
        public int Rok
        {
            get
            {
                return czas.Rok;
            }
            set
            {
                czas.Rok = value;
            }
        }
        public int Miesiąc
        {
            get
            {
                return czas.Miesiąc;
            }
            set
            {
                czas.Miesiąc = value;
            }
        }
        public int Dzień
        {
            get
            {
                return czas.Dzień;
            }
            set
            {
                czas.Dzień = value;
            }
        }
        public int Godzina
        {
            get
            {
                return czas.Godzina;
            }
            set
            {
                czas.Godzina = value;
            }
        }
        public int Temperatura
        {
            get
            {
                return zjawisko.Temperatura;
            }
            set
            {
                zjawisko.Temperatura = value;
            }
        }
        public int Szybkość_wiatru
        {
            get
            {
                return zjawisko.Szybkość_wiatru;
            }
            set
            {
                zjawisko.Szybkość_wiatru = value;
            }
        }
        public String Kierunek_wiatru
        {
            get
            {
                return zjawisko.Kierunek_wiatru;
            }
            set
            {
                zjawisko.Kierunek_wiatru = value;
            }
        }
        public int Ciśnienie
        {
            get
            {
                return zjawisko.Ciśnienie;
            }
            set
            {
                zjawisko.Ciśnienie = value;
            }
        }
        public String Warunki
        {
            get
            {
                return zjawisko.Warunki;
            }
            set
            {
                zjawisko.Warunki = value;
            }
        }
        public TSingletonCzas Czas
        {
            get
            {
                return czas;
            }
        }
        public static TRekord Adres
        {
            get
            {
                if (instancja == null)
                    instancja = new TRekord();
                return instancja;
            }
        }
        public Kalendarz AdresKal
        {
            set
            {
                kal = value;
            }
        }
        
    }

}
