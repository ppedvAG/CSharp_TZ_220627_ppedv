namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            //Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            Lebewesen neuesLebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23));
            Lebewesen neuesLebewesen2 = new Lebewesen("Hannes Schmidt", "Lasagne", new DateTime(1972, 12, 2));

            //Lesezugriff auf Property per Getter
            Console.WriteLine(neuesLebewesen.Name);

            //Schreibzugriff auf Property per Setter
            neuesLebewesen.Name = "Rex";
            Console.WriteLine(neuesLebewesen.Name);

            Console.WriteLine(neuesLebewesen.Geburtsdatum);
            Console.WriteLine(neuesLebewesen.Alter);

            //Aufruf einer klasseneigenen Funktion
            Lebewesen kind = neuesLebewesen.GebäreKind("Fridolin");
            #endregion


            #region Modul 07: Statische Member und GC
            //for (int i = 0; i < 100000; i++)
            //{
            //    neuesLebewesen = new Lebewesen("Tier_" + i, "", new DateTime());
            //}

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine(Lebewesen.ZeigeAnzahlAllerLebewesen());

            Console.ReadKey();
            #endregion
        }
    }
}