using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1

{
    internal class kupac : IComparable
    {
        public string prezime { get; set; }
        public string ime { get; set; }
        public int oib { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }



        public int CompareTo(object obj)
        {
            int rez = prezime.CompareTo(((kupac)obj).prezime);

            if (rez == 0) { rez = oib.CompareTo(((kupac)obj).oib); }
            return rez;
        }

        public override string ToString() => prezime + " " + ime + ", " + oib + ", " + adresa + ", " + email;
    }

}

