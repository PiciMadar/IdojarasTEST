using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdojarasTEST
{
    internal class Meteorologus
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int SzulEv { get; set; }

        public Meteorologus(int id, string nev, int szulEv)
        {
            Id = id;
            Nev = nev;
            SzulEv = szulEv;
        }

        public override string ToString()
        {
            return $"A(z) {Id} ID-jű, {Nev} névre hallgató meteorológus születési éve: {SzulEv}";
        }
    }
}
