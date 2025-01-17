using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdojarasSQL
{
    internal class Januar
    {
        public int Id;
        public int Datum;
        public int Homerseklet;
        public int Csapadek;
        public int Parataltalom;

        public Januar(int id, int datum, int homerseklet, int csapadek, int parataltalom)
        {
            Id = id;
            Datum = datum;
            Homerseklet = homerseklet;
            Csapadek = csapadek;
            Parataltalom = parataltalom;
        }
    }
}