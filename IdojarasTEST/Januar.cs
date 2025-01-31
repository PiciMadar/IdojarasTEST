using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdojarasSQL
{
    internal class Januar
    {
        public int Id { get; private set; } /*<------- Ha a getterrel kap értéket, public lesz, de alapból privátra rakja a setter. Ezzel nem kell foglalkoznom a privát adattal, de mégse fog zavarni, ha nem kap adatot*/
        public int Datum { get; private set; }
        public int Homerseklet { get; private set; }
        public int Csapadek { get; private set; }
        public int Parataltalom { get; private set; }




        public Januar(int id, int datum, int homerseklet, int csapadek, int parataltalom)
        {
            Id = id;
            Datum = datum;
            Homerseklet = homerseklet;
            Csapadek = csapadek;
            Parataltalom = parataltalom;
        }

        public override string ToString() 
        {
            return $"--------------------------\nID = {Id}\nDátum = {Datum}\nHőmérséklet = {Homerseklet}\nCsapadék = {Csapadek}\nPáratartalom = {Parataltalom}\n--------------------------";
        }

        public override bool Equals(object? obj)
        {
            return obj is Januar januar &&
                   Id == januar.Id &&
                   Datum == januar.Datum &&
                   Homerseklet == januar.Homerseklet &&
                   Csapadek == januar.Csapadek &&
                   Parataltalom == januar.Parataltalom;
        }
    }
}