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

            Mensch mensch = new Mensch("Anna", "Nass", "Spagetti", new DateTime(2001, 6, 4));
            Mensch mensch2 = new Mensch("Rainer", "Zufall", "Pommes", new DateTime(2020, 6, 4), mensch);

            Console.WriteLine(mensch.Alter);

            Console.WriteLine(mensch.Vorname);

            Console.WriteLine(mensch.ToString());

            Lebewesen lebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2020, 1, 23));
            Console.WriteLine(lebewesen.ToString());

            Console.WriteLine(lebewesen);

            Console.WriteLine(mensch2.Mutter.Alter);
        }
    }
}