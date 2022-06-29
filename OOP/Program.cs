namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lebewesen neuesLebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2017, 4, 12));
            Lebewesen neuesLebewesen2 = new Lebewesen("Hannes Schmidt", "Lasagne", new DateTime(2001, 12, 4));

            Console.WriteLine(neuesLebewesen.Name);

            neuesLebewesen.Name = "Rex";
            Console.WriteLine(neuesLebewesen.Name);

            Console.WriteLine(neuesLebewesen2.Geburtsdatum);
            Console.WriteLine(neuesLebewesen2.Alter);

            Lebewesen kind = neuesLebewesen.GebäreKind("Fridolin");
        }
    }
}