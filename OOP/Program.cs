namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            ////Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            //Lebewesen neuesLebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23));
            //Lebewesen neuesLebewesen2 = new Lebewesen("Hannes Schmidt", "Lasagne", new DateTime(1972, 12, 2));

            ////Lesezugriff auf Property per Getter
            //Console.WriteLine(neuesLebewesen.Name);

            ////Schreibzugriff auf Property per Setter
            //neuesLebewesen.Name = "Rex";
            //Console.WriteLine(neuesLebewesen.Name);

            //Console.WriteLine(neuesLebewesen.Geburtsdatum);
            //Console.WriteLine(neuesLebewesen.Alter);

            ////Aufruf einer klasseneigenen Funktion
            //Lebewesen kind = neuesLebewesen.GebäreKind("Fridolin");
            #endregion

            #region Modul 07: Statische Member und GC

            ////Aufruf eines statischen Members der Person-Klasse
            //Console.WriteLine(Lebewesen.ZeigeAnzahlLebewesen());

            ////Nullsetzung der Variablen (um das Personenobjekt freizugeben und die GC demonstrieren zu können)
            //neuesLebewesen = null;

            ////Aufruf der GC und Programmpause, bis alle Destruktoren beendet wurden
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            #endregion

            #region Modul 08: Vererbung

            //Instanziierung eines Objekts der vererbenden Klasse
            Lebewesen lebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23));
            //Instanziierung eines Objekts der abgeleiteten Klasse
            Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6));
            Mensch mensch2 = new Mensch("Maria", "Meier", "Schnitzel", new DateTime(1997, 5, 6), mensch);
            //Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            Console.WriteLine(mensch2.Alter);
            Console.WriteLine(mensch2.Name);

            //Aufruf einer Property der abgeleiteten Klasse
            Console.WriteLine(mensch2.Vorname);

            //Ausgabe der (überschriebenen) ToString()-Methoden
            Console.WriteLine(lebewesen);
            Console.WriteLine(mensch);
            Console.WriteLine(mensch2);

            //Aufruf einer Property eines abhängigen Objekts
            Console.WriteLine(mensch2.Mutter.Alter);

            #endregion
        }
    }
}