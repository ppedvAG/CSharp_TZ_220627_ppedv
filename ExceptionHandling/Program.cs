namespace ExceptionHandling
{
    class MeineException : Exception
    {
        public MeineException(string fehlermeldung) : base(fehlermeldung)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string eingabe = Console.ReadLine();

                int zahl = int.Parse(eingabe);

                if (zahl == 0)
                    throw new MeineException("Du darft keine 0 eingeben");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Du darfst nur Zahlen eingeben. " + ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Deine Zahl ist zu groß / zu klein");
                return;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt");
            }

            Console.WriteLine("Und weiter gehts...");
        }
    }
}