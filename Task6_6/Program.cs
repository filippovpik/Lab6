using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            int counterNum;
            int counterSym;
            int counterUp;
            int counterLow;
            string pass = string.Empty;

            do
            {
                k = 0;
                counterNum = 0;
                counterSym = 0;
                counterUp = 0;
                counterLow = 0;

                Console.WriteLine("Введите пароль. Пароль должен состоять минимум из 14 символов и иметь в составе минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.");
                pass = Console.ReadLine(); //input password                

                foreach (char c in pass) //symbol
                {
                    if ("!#;%:?*".Contains(c))
                        counterSym=1;
                }
                if (counterSym == 1)
                    k = k + 1;

                if (pass.Length >= 14) //Length
                    k = k + 1;

                foreach (char c in pass) //number
                {
                    if ("0123456789".Contains(c))
                        counterNum = 1;
                }
                if (counterNum == 1)
                    k = k + 1;

                for (int i = 0; i < pass.Length; i++) //upper case
                {
                    if (Char.IsUpper(pass[i]))
                        counterUp = 1;
                }
                if (counterUp == 1)
                    k = k + 1;

                for (int i = 0; i < pass.Length; i++) //lower case
                {
                    if (Char.IsLower(pass[i]))
                        counterLow = 1;
                }
                if (counterLow == 1)
                    k = k + 1;
            }
            while (k < 5);


            Console.WriteLine(pass);
            Console.WriteLine("Пароль принят");

            Console.ReadKey();
        }
    }
}
