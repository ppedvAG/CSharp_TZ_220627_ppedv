using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Mensch : Lebewesen
    {
        public string Vorname { get; set; }

        public Mensch Mutter { get; set; }

        public Mensch(string vorname, string nachname, string lieblingsnahrung, DateTime geburtsdatum, Mensch mutter = null) : base(nachname, lieblingsnahrung, geburtsdatum)
        {
            this.Vorname = vorname;
            Mutter = mutter;
        }

        public override string ToString()
        {
            return $"{this.Vorname} " + base.ToString();
        }
    }
}
