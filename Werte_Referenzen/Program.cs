namespace Werte_Referenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonC classP = new PersonC(30, "Anna");
            PersonS structP = new PersonS(30, "Hannes");

            Console.WriteLine($"{classP.Name}: {classP.Alter}");
            Console.WriteLine($"{structP.Name}: {structP.Alter}");

            Altern(classP);
            Console.WriteLine($"{classP.Name}: {classP.Alter}");

            Altern(structP);
            Console.WriteLine($"{structP.Name}: {structP.Alter}");

            Altern(ref structP);
            Console.WriteLine($"{structP.Name}: {structP.Alter}");
        }

        public static void Altern(PersonC person)
        {
            person.Alter++;
        }
        public static void Altern(PersonS person)
        {
            person.Alter++;
        }
        public static void Altern(ref PersonS person)
        {
            person.Alter++;
        }
    }

    class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }
        public PersonC(int a, string n)
        {
            Alter = a;
            Name = n;
        }
    }

    struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }
        public PersonS(int a, string n)
        {
            Alter = a;
            Name = n;
        }
    }
}