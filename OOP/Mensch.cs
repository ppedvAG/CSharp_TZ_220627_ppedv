using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Mensch erbt mittels des :-Zeichens von der Lebewesen-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    class Mensch : Lebewesen
    {
        //Zusätzliche Mensch-eigene Eigenschaften
        public string Vorname { get; set; }
        public Mensch Mutter { get; set; }

        //Mensch-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Personklasse aufruft. Dieser erstellt dann ein Lebewesen, gibt diese
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public Mensch(string vorname, string nachname, string lieblingsnahrung, DateTime geburtsdatum, Mensch mutter = null) : base(nachname, lieblingsnahrung, geburtsdatum)
        {
            this.Vorname = vorname;
            this.Mutter = mutter;
        }

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        //Mittels BASE kann ein Rückbezug zur nächst-höheren Klasse hergestellt werden.
        //Mit SEALED kann eine Überschreibung durch Kindklassen verindert werden.
        public sealed override string ToString()
        {
            string ausgabe = $"Der Mensch {this.Vorname} " + base.ToString();
            if (this.Mutter != null)
                ausgabe = ausgabe + $" Die Mutter ist {this.Mutter.Vorname} {this.Mutter.Name}.";
            return ausgabe;
        }
    }
}
