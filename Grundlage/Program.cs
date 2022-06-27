
namespace Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int alter;
            alter = 33;

            string stadt = "Berlin";

            Console.WriteLine(alter);
            Console.WriteLine(stadt);

            int doppeltesAlter = alter * 2;
            Console.WriteLine(doppeltesAlter);

            Console.WriteLine(doppeltesAlter + alter);

            char Textzeichen = 'A';

            double gleitkommazahl = 78.123;
            Console.WriteLine(gleitkommazahl);

            bool wahrheitswert = false;


            string satz = "Ich bin " + alter + " Jahre alt und wohne in " + stadt + ".";
            Console.WriteLine(satz);
            Console.WriteLine("Ich bin " + alter + " Jahre alt und wohne in " + stadt + ".");

            satz = $"Ich bin {alter} Jahre alt und wohne in {stadt}.";
            Console.WriteLine(satz);
            Console.WriteLine($"Ich bin {alter} Jahre alt und wohne in {stadt}.");

            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", alter, stadt);

            int a = 45;
            int b = 57;

            Console.WriteLine($"{a} + {b} = {a + b}");

            string bsp = "Dies ist ein \nZeilenumbruch und dies ist ein \tTabulator";
            Console.WriteLine(bsp);

            string path = $"{{\"C:\\Programme\\Programm.exe\"}}";
            Console.WriteLine(path);

            string verbatim = @$"Dies ist ein 
Zeilenumbruch und dies ist ein  Tabulator\n""";
            Console.WriteLine(verbatim);

            Console.WriteLine("Bitte gib deinen Namen ein:");
            string name = Console.ReadLine();
            Console.WriteLine("Dein Name ist also " + name);

            Console.WriteLine("Bitte gib deine Lieblingszahl ein:");
            string zahlAlsString = Console.ReadLine();
            int zahl = int.Parse(zahlAlsString);
            Console.WriteLine("Das Doppelte deiner Zahl ist " + zahl*2);

            Console.ReadKey();

            int intZahl = 67;
            double doubleZahl = intZahl;

            doubleZahl = 123.45;
            intZahl = (int)doubleZahl;
            intZahl = Convert.ToInt32(doubleZahl);

            double zero = 0.0;
            double z = 2 / zero;
            Console.WriteLine(z);

            z++;
            z++;
        }
    }
}

