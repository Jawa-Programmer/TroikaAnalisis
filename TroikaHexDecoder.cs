using System;

namespace troika_data
{
    class Program
    {
        static DateTime date0 = new DateTime(2016, 1, 1, 0, 0, 0);
        static void Main(string[] args)
        {
            string data = "E9673BCAD61620000A8C200002C437B0";
            Console.Title = "Модуль декодирования данных с Тройки";
            Console.WriteLine("Пример использования. Введены данные \n{0}\nВыведена расшифровка:\nПоследнее время прохода: {1}. Баланс: {2}руб.", data, date0.AddMinutes(int.Parse(data.Substring(4, 6), System.Globalization.NumberStyles.HexNumber) / 2).AddDays(-1), int.Parse(data.Substring(17, 4), System.Globalization.NumberStyles.HexNumber) / 400);
            Console.WriteLine();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Введите данные с карты Тройка (8й сектор, 2й блок):");
                data = Console.ReadLine();
                if (data == "0") break;
                int mnts = int.Parse(data.Substring(4, 6), System.Globalization.NumberStyles.HexNumber) / 2;
                int mny = int.Parse(data.Substring(17, 4), System.Globalization.NumberStyles.HexNumber) / 400;
                DateTime date1 = date0.AddMinutes(mnts).AddDays(-1);
                Console.WriteLine("Последнее время прохода: {0}. Баланс: {1}руб.", date1, mny);
            }
            Console.WriteLine("ПРограмма завершена, нажмите любую клавишу, что бы выйти...");
            Console.ReadKey();
        }
    }
}
