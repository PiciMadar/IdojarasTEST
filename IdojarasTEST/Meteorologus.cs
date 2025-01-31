using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdojarasTEST
{
    internal class Meteorologus
    {
        public int Id { get; private set; }
        public string Nev { get; private set; }
        public int SzulEv { get; private set; }

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

        public override bool Equals(object? obj)
        {
            return obj is Meteorologus meteorologus &&
                   Id == meteorologus.Id &&
                   Nev == meteorologus.Nev &&
                   SzulEv == meteorologus.SzulEv;
        }
    }
}
