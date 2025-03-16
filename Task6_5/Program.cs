using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number =
            {
                "+7(123)456-78-90",
                "7(123)456-78-90",
                "+a(123)456-78-90",
                "+7123)456-78-90",
                "+7(123)45678-90",
                "+7(123)456-78-9a",
                "!7(123)456-78-90",
            };

            Regex regex = new Regex(@"^\+[0-9]+\([0-9]+[0-9]+[0-9]+\)[0-9]+[0-9]+-[0-9]+[0-9]+-[0-9]+[0-9]$");

            foreach (string str in number)
                if (regex.IsMatch(str))
                    Console.WriteLine("\"{0}\" - ok", str);
                else
                    Console.WriteLine("\"{0}\" - не ok", str);

            Console.ReadKey();
        }
    }
}
