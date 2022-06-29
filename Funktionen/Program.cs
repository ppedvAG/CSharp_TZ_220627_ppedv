namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = Addiere(3, 5);
            Console.WriteLine(summe);

            double summe2 = Addiere(2.4, 3.6);

            summe = BildeSumme(2, 465, -12, 567, 6, 0, 12);

            summe = Subtrahiere(23, 5, 56);

            summe = AddiereUndSubtrahiere(13, 4, out int diff);

            Console.WriteLine(summe);
            Console.WriteLine(diff);


            string eingabe = Console.ReadLine();
            if(int.TryParse(eingabe, out int result))
            {
                Console.WriteLine(result * result);
            }
        }


        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static double Addiere(double a, double b)
        {
            return a + b;
        }

        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (int item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        static int Subtrahiere(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }
    }
}