using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Lebewesen
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                if(value.Length > 0)
                    name = value; 
            }
        }

        public string Lieblingsnahrung { get; set; }

        public DateTime Geburtsdatum { get; private set; }

        public int Alter
        {
            get { return (DateTime.Now - Geburtsdatum).Days / 365; }
        }

        public Lebewesen GebäreKind(string kindname)
        {
            return new Lebewesen(kindname, "Muttermilch", DateTime.Now);
        }

        public Lebewesen(string name, string lieblingsnahrung, DateTime geburtsdatum)
        {
            this.Name = name;
            this.Lieblingsnahrung = lieblingsnahrung;
            this.Geburtsdatum = geburtsdatum;
        }

        public Lebewesen()
        {

        }

    }
}
