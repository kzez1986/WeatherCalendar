using System;
using System.Collections.Generic;
using System.Text;
using Iterator_rekordu;

namespace Obliczenia
{
    public class TObliczenia //wartości statystyczne miesiąca
    {
        private TIteratorRekord i;
        public TObliczenia()
        {
            i = TIteratorRekord.Adres;
        }
        public int Min(int rok, int miesiąc) //liczenie minimalnej temperatury dla danego miesiąca
        {
            int minimum = 200;
            //zachowanie aktualnych ustawień
            int dzień_temp = i.Rekord.Dzień;
            int miesiąc_temp = i.Rekord.Miesiąc;
            int rok_temp = i.Rekord.Rok;
            int godzina_temp = i.Rekord.Godzina;
            //ustawianie wartości dla obliczeń
            i.SkoczDo(rok, miesiąc, 1, 0);
            //główna pętla
            while (i.Rekord.Temperatura == -99 && miesiąc == i.Rekord.Miesiąc) //nie wolno przypisać wartości pustej
            {
                i.NastępnyRekord();
            }
            while (miesiąc == i.Rekord.Miesiąc)
            {
                if (i.Rekord.Temperatura < minimum && i.Rekord.Temperatura != -99) //wartość pusta
                    minimum = i.Rekord.Temperatura;
                i.NastępnyRekord();
            }
            //przywracanie poprzednich ustawień
            i.SkoczDo(rok_temp, miesiąc_temp, dzień_temp, godzina_temp);
            return minimum; //minimum = 200 - oznacza że nie znaleziono żadnych rekordów
        }
        public int Max(int rok, int miesiąc) //maksymalna temperatura dla danego miesiąca
        {
            int maksimum = -99;
            //zachowanie aktualnych ustawień
            int dzień_temp = i.Rekord.Dzień;
            int miesiąc_temp = i.Rekord.Miesiąc;
            int rok_temp = i.Rekord.Rok;
            int godzina_temp = i.Rekord.Godzina;
            //ustawianie wartości dla obliczeń
            i.SkoczDo(rok, miesiąc, 1, 0);
            //główna pętla
            while (i.Rekord.Temperatura == -99 && miesiąc == i.Rekord.Miesiąc) //nie wolno przypisać wartości pustej
            {
                i.NastępnyRekord();
            }
            maksimum = i.Rekord.Temperatura;
            while (miesiąc == i.Rekord.Miesiąc)
            {
                if (i.Rekord.Temperatura > maksimum) //wartość pusta nie ma znaczenia, i tak -200 będzie zawsze mniejsze
                    maksimum = i.Rekord.Temperatura;
                i.NastępnyRekord();
            }
            //przywracanie poprzednich ustawień
            i.SkoczDo(rok_temp, miesiąc_temp, dzień_temp, godzina_temp);
            return maksimum; //wartość -200 oznacza, że nie znaleziono żadnych reokordów
        }
        public double Średnia(int rok, int miesiąc)
        {
            long suma = 0;
            int ile_obliczeń = 0;
            //zachowanie aktualnych ustawień
            int dzień_temp = i.Rekord.Dzień;
            int miesiąc_temp = i.Rekord.Miesiąc;
            int rok_temp = i.Rekord.Rok;
            int godzina_temp = i.Rekord.Godzina;
            //ustawianie wartości dla obliczeń
            i.SkoczDo(rok, miesiąc, 1, 0);
            while (miesiąc == i.Rekord.Miesiąc)
            {
                if (i.Rekord.Temperatura != -99)
                {
                    suma += i.Rekord.Temperatura;
                    ile_obliczeń++;
                }
                i.NastępnyRekord();
            }
            //przywracanie poprzednich ustawień
            i.SkoczDo(rok_temp, miesiąc_temp, dzień_temp, godzina_temp);
            return 1.0 * suma / ile_obliczeń;
        }
    }
}
