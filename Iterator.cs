using System;
using System.Collections.Generic;
using System.Text;
using Rekord;

namespace Iterator_rekordu
{
    public class TIteratorRekord
    {
        private TRekord r;
        private static TIteratorRekord instancja;
        private TIteratorRekord()
        {
            r = TRekord.Adres;
        }
        public void NastępnyRekord()
        {
            r.Czas.NastępnaGodzina();
            r.Pobierz();
        }
        public void PoprzedniRekord()
        {
            r.Czas.PoprzedniaGodzina();
            r.Pobierz();
        }
        public void NastępnyMiesiąc()
        {
            r.Czas.NastępnyMiesiąc();
            r.Pobierz();
        }
        public void PoprzedniMiesiąc()
        {
            r.Czas.PoprzedniMiesiąc();
            r.Pobierz();
        }
        public void NastępnyRok()
        {
            r.Czas.NastępnyRok();
            r.Pobierz();
        }
        public void PoprzedniRok()
        {
            r.Czas.PoprzedniRok();
            r.Pobierz();
        }
        public void SkoczDo(int rok, int miesiąc, int dzień, int godzina)
        {
            r.Czas.Rok = rok;
            r.Czas.Miesiąc = miesiąc;
            r.Czas.Dzień = dzień;
            r.Czas.Godzina = godzina;
            r.Pobierz();
        }
        public TRekord Rekord
        {
            get
            {
                return r;
            }
        }
        public static TIteratorRekord Adres
        {
            get
            {
                if (instancja == null)
                    instancja = new TIteratorRekord();
                return instancja;
            }
        }
    }

}
