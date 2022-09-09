using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_GG
{
     class Ese : Uksus 
    {
        private string nimi;
        private int punkt_arv;
        public Ese(string nimi, int punkt_arv)
        {
            this.nimi = nimi;
            this.punkt_arv = punkt_arv;
        }


        public string info()
        {
            return (nimi);
        }
        public int punktideArv()
        {
            return(punkt_arv);
        }
    }
}
