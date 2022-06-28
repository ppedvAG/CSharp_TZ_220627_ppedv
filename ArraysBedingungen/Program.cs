
namespace ArraysBedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] zahlen;
            //zahlen = new int[] { 2, 4, 56, -123, 456, 11111, 0 };

            //Console.WriteLine(zahlen[2]);
            //zahlen[2] = 1234;
            //Console.WriteLine(zahlen[2]);

            //string[] worte = new string[5];

            //Console.WriteLine(zahlen.Contains(-123));
            //Console.WriteLine(zahlen.Contains(555));

            //string beispiel = "Hallo";
            //Console.WriteLine(beispiel[2]);


            bool wahrheitswert = false;
            bool negierterWert = !wahrheitswert;
            bool undVerknüpfung = wahrheitswert && negierterWert;
            bool oderVerknüpfung = wahrheitswert || negierterWert;
            bool xorVerknüpfung = wahrheitswert ^ negierterWert;

            int a = 16;
            int b = 14;

            if(a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if(a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
                Console.WriteLine("A ist gleich B");

            Console.WriteLine("Ende");

            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            string name1 = "Hugo";
            string name2 = "Hugo";

            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1.Equals(name2));
        }
    }
}