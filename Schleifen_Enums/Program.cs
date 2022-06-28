namespace Schleifen_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 15;

            while (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
                a++;

                if (a == 5)
                    break;
            }

            a = -45;

            do
            {
                Console.WriteLine(a);
                a++;

                continue;

            } while (a > 0);


            for (int index = 1; index <= 100; index*=2)
            {
                Console.WriteLine($"Dies ist Durchlauf Nr. {index}.");
                index++;
            }

            int[] zahlen = { 2, 4, 12, 456, 32, -456, 0 };
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }

            Console.WriteLine("\n\n\n\n\n");

            Wochentag heute = Wochentag.Dienstag;
            heute = (Wochentag)6;
            Console.WriteLine($"Heute ist also ein {heute}");

            Console.WriteLine("Welcher Wochentag ist dein Lieblingstag?");
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            heute = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Dein Lieblingstag ist also der {heute}.");

            //heute = (Wochentag)Enum.Parse(typeof(Wochentag), "Freitag");
            Console.WriteLine($"Dein Lieblingstag ist also der {heute}.");


            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if(consoleKeyInfo.Key == ConsoleKey.G)
                Console.WriteLine("Du hast das G gedrückt");


            switch (heute)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochenstart");
                    break;
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Normaler Arbeitstag");
                    break;
                case Wochentag.Freitag:
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                default:
                    Console.WriteLine("Da ist wohl ein Fehler passiert...");
                    break;
            }

            int zahl2 = -45;
            switch (zahl2)
            {
                case 5:
                    Console.WriteLine("zahl ist 5");
                    break;
                case int z when z < 0:
                    Console.WriteLine("Zahl ist kleiner 0");
                    break;
                default:
                    break;
            }

        }

        enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}
    }
}