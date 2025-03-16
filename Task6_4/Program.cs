using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Город");
            string city = Console.ReadLine();

            //Use StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("Имя:"+name+ ", Возраст:" + age+ ", Город:" + city);

            string result=sb.ToString();   
            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
