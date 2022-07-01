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

            ////Instanziierung eines Objekts der vererbenden Klasse
            //Lebewesen lebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23));
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6));
            //Mensch mensch2 = new Mensch("Maria", "Meier", "Schnitzel", new DateTime(1997, 5, 6), mensch);
            ////Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            //Console.WriteLine(mensch2.Alter);
            //Console.WriteLine(mensch2.Name);

            ////Aufruf einer Property der abgeleiteten Klasse
            //Console.WriteLine(mensch2.Vorname);

            ////Ausgabe der (überschriebenen) ToString()-Methoden
            //Console.WriteLine(lebewesen);
            //Console.WriteLine(mensch);
            //Console.WriteLine(mensch2);

            ////Aufruf einer Property eines abhängigen Objekts
            //Console.WriteLine(mensch2.Mutter.Alter);

            #endregion

            #region Modul 09: Polymorphismus

            //Deklaration einer Bsp-Variablen
            Lebewesen lebewesen;
            //Instanziierung eines Objekts der abgeleiteten Klasse
            Mensch mensch = new Mensch("Anna", "Nass", "Lasagne", new DateTime(2003, 2, 12));
            //Mensch-Variable gewährt zugriff auf Mensch-Member und Lebewesen-Member
            Console.WriteLine(mensch.Vorname);

            //Zuweisung des abgeleiteten Objekts zu Variable der Mutterklasse
            lebewesen = mensch;

            //Lebewesen-Variable gewährt Zugriff auf Lebewesen-Member
            Console.WriteLine(lebewesen.Name);

            //überschriebene Methoden werden trotzdem von spezifischer Klasse ausgeführt
            Console.WriteLine(lebewesen.ToString());

            //Aufruf der unten stehenden Methode
            BenneLebewesenUm("Meier", mensch);

            //Da Lebewesen abstrakt ist, können keine allgemeinen Lebewesen-Objekte mehr instanziier werden
            //lebewesen = new Lebewesen();

            //Aufruf der abstrakten Methoden
            mensch.Essen();
            lebewesen.Essen();

            #endregion
        }

        #region Modul 09: Polymorphismus
        //Methode erwartet ein Lebewesen -> jedes Objekt der Lebewesenklasse und abgeleiteter Klassen ist erlaubt
        public static void BenneLebewesenUm(string neuerName, Lebewesen lebewesen)
        {
            //Zugriff auf Lebewesen-Member (ist bei jedem Lebewesen und damit auch jedem Mensch vorhanden)
            lebewesen.Name = neuerName;

            //Tests des Laufzeittyps
            if (lebewesen.GetType() == typeof(Mensch))
                Console.WriteLine($"Der Nachname wurde in {neuerName} geändert.");
            else
                Console.WriteLine($"Der Name wurde in {neuerName} geändert.");

            //Test, ob Laufzeittyp von bestimmtem Typ erbt (oder dieser ist)
            if (lebewesen is Mensch)
            {
                //Rückcast des abgeleiteten Objekts aus Mutterklassevariablen in abgeleitete Variable
                Mensch mensch = (Mensch)lebewesen;
                //Alternativer Cast
                mensch = lebewesen as Mensch;
                //Zugriff auf spezifischen Member der abgeleiteten Klasse
                Console.WriteLine($"{mensch.Vorname} ist Mensch");
            }
        }
        #endregion
    }
}