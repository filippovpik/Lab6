namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц");
            string month = Console.ReadLine();

            Console.WriteLine("Введите год");
            string year = Console.ReadLine();

            Console.WriteLine("Введите общую сумму продаж");
            double totalSum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество проданных товаров");
            int quantity = Convert.ToInt32(Console.ReadLine());
            double mid = totalSum / quantity;
            string midS = Convert.ToString(mid);
            midS = String.Format("{0:F2}", mid);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Отчёт о продажах за {0} {1}", month, year);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Общая сумма продаж: {0:F2} р.", totalSum);
            Console.WriteLine("");
            Console.WriteLine("Количество проданных товаров: {0:0,0} шт.", quantity);
            Console.WriteLine("");
            Console.WriteLine("Средняя стоимость товара: {0} р.", midS);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            Console.ReadKey();

        }
    }
}
