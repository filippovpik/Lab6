using System.Globalization;
using System.Text;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string input = Console.ReadLine();
            string[] words = input.Split(' '); //Split into words
            string max = string.Empty;

            //Use StringBuilder
            StringBuilder result= new StringBuilder();

            //Count lenght of words
            foreach (string word in words)
                if (word.Length > max.Length)
                    max = word;

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
