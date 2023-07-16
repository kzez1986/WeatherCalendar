using System;
using System.Collections.Generic;
using System.Text;
using Iterator_rekordu;
using System.Drawing;

namespace Wykres
{
    abstract public class TPolecenieRysujWykres
    {
        protected TIteratorRekord r;
        public abstract void Wykonaj();
        public void RysujSzkielet()
        {
        }
    }
}
