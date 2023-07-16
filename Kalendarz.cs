using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rekord;

namespace Kalendarz_Pogody
{
    public partial class Kalendarz : Form
    {
        public Kalendarz()
        {
            InitializeComponent();
        }

        private void Kalendarz_Load(object sender, EventArgs e)
        {

        }

        public TextBox TemperaturaUstaw
        {
            get
            {
                return teTemperatura;
            }
        }

        public TextBox Nagłówek
        {
            get
            {
                return teLublin;
            }
        }

        public TextBox Wiatr
        {
            get
            {
                return teWiatr;
            }
        }

        public TextBox Ciśnienie
        {
            get
            {
                return teCiśnienie;
            }
        }

        public TextBox Warunki
        {
            get
            {
                return teWarunki;
            }
        }

        private void Kalendarz_Shown(object sender, EventArgs e)
        {
            TDyrektor dyr = new TDyrektor();
            IBudowniczy builder = new TBudowniczyRekordu();
            TRekord r;
            dyr.Konstruuj(builder);
            r = builder.PobierzWynik();
            r.Czas.UstawDziś();
            r.Pobierz();
            r.AdresKal = this;
            r.WyświetlRekord();
            r.Zapisz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teTemperatura.Text = "bleble";
        }

        private void teTemperatura_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public Label Max
        {
            get
            {
                return laMiesiącMax;
            }
        }
        public Label Min
        {
            get
            {
                return laMiesiącMin;
            }
        }
        public Label Średnia
        {
            get
            {
                return laMieśŚrednia;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TDyrektor dyr = new TDyrektor();
            IBudowniczy builder = new TBudowniczyRekordu();
            TRekord r;
            dyr.Konstruuj(builder);
            r = builder.PobierzWynik();
            r.Czas.UstawDziś();
            r.Pobierz();
            r.AdresKal = this;
            r.WyświetlRekord();
            r.Zapisz();
        }

        private void buOdśwież_Click(object sender, EventArgs e)
        {
            TDyrektor dyr = new TDyrektor();
            IBudowniczy builder = new TBudowniczyRekordu();
            TRekord r;
            dyr.Konstruuj(builder);
            r = builder.PobierzWynik();
            r.Czas.UstawDziś();
            r.Pobierz();
            r.AdresKal = this;
            r.WyświetlRekord();
            r.Zapisz();
        }
    }
}
