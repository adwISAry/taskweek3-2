namespace taskweek3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFullName("Jonathan", "Will", " ");                
        }

        static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName[0] + ". " + lastName);
        }

        static void PrintFullName(string firstName, string lastName, string middleName)
        {
            Console.WriteLine(firstName[0] + ". " + lastName + ". " + middleName[0] + ".");
        }
    }
}
