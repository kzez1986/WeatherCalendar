using System;
using System.Collections.Generic;
using System.Text;

namespace Czas
{
    public class TSingletonCzas
    {
        private int dzień;
        private int miesiąc;
        private int rok;
        private int godzina;
        private static TSingletonCzas instancja;
        //private TRekord tRekord;

        public void NastępnyDzień()
        {
            if (dzień == IleDni(miesiąc))
            {
                dzień = 1;
                NastępnyMiesiąc();
            }
            else
                dzień++;
        }
        public void PoprzedniDzień()
        {
            if (dzień == 1)
            {
                dzień = IleDni(miesiąc - 1);
                PoprzedniMiesiąc();
            }
            else
                dzień--;
        }
        public int Dzień
        {
            get
            {
                return dzień;
            }
            set
            {
                dzień = value;
            }
        }
        public int Miesiąc
        {
            get
            {
                return miesiąc;
            }
            set
            {
                miesiąc = value;
            }
        }
        public int Rok
        {
            get
            {
                return rok;
            }
            set
            {
                rok = value;
            }
        }
        public int Godzina
        {
            get
            {
                return godzina;
            }
            set
            {
                godzina = value;
            }
        }
        public void UstawDziś()
        {
            DateTime dziś = DateTime.Now;
            dzień = dziś.Day;
            godzina = dziś.Hour;
            miesiąc = dziś.Month;
            rok = dziś.Year;
        }
        public void NastępnyMiesiąc()
        {
            if (miesiąc == 12)
            {
                miesiąc = 1;
                NastępnyRok();
            }
            else
                miesiąc++;
        }
        public void PoprzedniMiesiąc()
        {
            if (miesiąc == 1)
            {
                miesiąc = 12;
                PoprzedniRok();
            }
            else
                miesiąc--;
        }
        public void NastępnyRok()
        {
            rok++;
        }
        public void PoprzedniRok()
        {
            rok--;
        }
        private TSingletonCzas()
        {
          
        }
        public static TSingletonCzas DajInstancję()
        {
            if(instancja == null)
                instancja = new TSingletonCzas();
            return instancja;
        }
        public void PoprzedniaGodzina()
        {
            if (godzina == 0)
            {
                godzina = 23;
                PoprzedniDzień();
            }
            else
                godzina--;
        }
        public void NastępnaGodzina()
        {
            if (godzina == 23)
            {
                godzina = 0;
                NastępnyDzień();
            }
            else
                godzina++;
        }
        public int IleDni(int m)
        {
            switch (m)
            {
                case 1: { return 31;}
                case 2: 
                    {
                        if (CzyPrzestępny(rok) == true)
                            return 29;
                        else
                            return 28;
                    }
                case 3: { return 31;}
                case 4: { return 30;}
                case 5: { return 31;}
                case 6: { return 30;}
                case 7: { return 31;}
                case 8: { return 31;}
                case 9: { return 30;}
                case 10: { return 31;}
                case 11: { return 30;}
                case 12: { return 31;}
                default: return -1;
            }
        }
        public bool CzyPrzestępny(int rok)
        {
            if (rok % 4 != 0)
                return false;
            else if (rok % 4 == 0 && rok % 400 != 0 && rok % 100 == 0)
                return false;
            else
                return true;
        }
    }

}
