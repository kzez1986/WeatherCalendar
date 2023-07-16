using System;
using System.Collections.Generic;
using System.Text;

namespace Zjawisko
{
    public interface IFabryka
    {
        TZjawisko TwórzZjawisko();
    }
    public class TFabrykaZjawiska : IFabryka
    {
        private static TFabrykaZjawiska instancja;
        public TZjawisko TwórzZjawisko()
        {
            return new TZjawisko();
        }
        public static TFabrykaZjawiska Adres
        {
            get
            {
                if (instancja == null)
                    instancja = new TFabrykaZjawiska();
                return instancja;
            }
        }
    }
    public class TZjawisko
    {
        private int temperatura;
        private int szybkość_wiatru;
        private String kierunek_wiatru;
        private int ciśnienie;
        private String warunki;
        public int Temperatura
        {
            get
            {
                return temperatura;
            }
            set
            {
                temperatura = value;
            }
        }
        public int Szybkość_wiatru
        {
            get
            {
                return szybkość_wiatru;
            }
            set
            {
                szybkość_wiatru = value;
            }
        }
        public String Kierunek_wiatru
        {
            get
            {
                return kierunek_wiatru;
            }
            set
            {
                kierunek_wiatru = value;
            }
        }
        public int Ciśnienie
        {
            get
            {
                return ciśnienie;
            }
            set
            {
                ciśnienie = value;
            }
        }
        public String Warunki
        {
            get
            {
                return warunki;
            }
            set
            {
                warunki = value;
            }
        }
    }
}
