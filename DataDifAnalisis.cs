using System;
using System.Collections.Generic;

namespace dif_analis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные карт в формате n строк по 16 символов (количество строк должно совпадать).\nСначала введите первую карту, затем пустую строку, затем вторую карту. ");
           
            List<string> rd1 = new List<string>();
            string tmp;
            while("" != (tmp = Console.ReadLine()))
            {
                rd1.Add(tmp);
            }
           string[] rd2 = new string[rd1.Count];
            for (int i = 0; i < rd2.Length; i++)
            {
                rd2[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < rd1.Count; i++)
            {
                for (int j = 0; j < rd1[i].Length; j++)
                {
                    if (rd1[i][j] != rd2[i][j])
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(j, i);
                    Console.Write(rd1[i][j]);
                    Console.SetCursorPosition(j + 35, i);
                    Console.Write(rd2[i][j]);

                    if (rd1[i][j] != rd2[i][j])
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
