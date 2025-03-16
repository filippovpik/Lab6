using System.Text;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            input = input.Replace(" ", ""); //Remove spaces
            input = input.ToLower(); //Lower case           

            for (int i = input.Length-1; i >= 0; i--)
            {
                reverse = reverse.Insert(reverse.Length, char.ToString(input[i]));
            }         

            if (input == reverse)
                Console.WriteLine("Предложение является палиндромом");
            else
                Console.WriteLine("Предложение не является палиндромом");

            Console.ReadLine();
        }
    }
}
