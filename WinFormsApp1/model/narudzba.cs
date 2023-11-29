using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class narudzba
    {
        public int broj_narudzbe { get; set; }
        public DateTime datum_narudzbe { get; set; }
        public string dostavljac { get; set; }
        public int tezina_paketa { get; set; }
        public int kolicina_paketa { get; set; }



        public int CompareTo(object obj)
        {
            int rez = dostavljac.CompareTo(((narudzba)obj).dostavljac);

            if (rez == 0) { rez = broj_narudzbe.CompareTo(((narudzba)obj).broj_narudzbe); }
            return rez;
        }

        public override string ToString() => broj_narudzbe + " " + datum_narudzbe + ", " + dostavljac + ", " + tezina_paketa + ", " + kolicina_paketa;
    }
}


