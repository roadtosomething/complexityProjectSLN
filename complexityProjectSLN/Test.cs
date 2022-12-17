using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexityProjectSLN
{
    public class Test
    {
        public static List<int> CreateAutoTestList(int n)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                //list.Add(1);
                list.Add(random.Next(1, 10));
            }
            return list;
        }
        public static void BenchMarkTest()
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Введите шаг для нагрузочного тестирования");
            int k = 1;
            int w = Convert.ToInt32(Console.ReadLine());
            List<List<int>> list = new List<List<int>>();
            Console.WriteLine($"Выберите алгоритм для теста (вес контейнера для теста 10):\n" +
                $"Рекурсивные алгоритмы\n" +
                $"1.FFD\n" +
                $"2.FFS\n" +
                $"Итерационные алгоритмы\n" +
                $"3.FFD \n" +
                $"4.FFS \n");
            switch (Console.ReadLine())
            {
                case "1":
                    bool ok = true;
                    while (ok)
                    {
                        try 
                        {
                            sw.Start();
                            Function.FFD(CreateAutoTestList(k), 10, list);
                            sw.Stop();
                            /*Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Done");
                            Console.ResetColor();*/
                            //Console.WriteLine($" | Время выполнения: {sw.ElapsedMilliseconds} мс Тиков: {sw.ElapsedTicks}");
                            Console.WriteLine($"{sw.ElapsedTicks}");
                            list.Clear();
                            k += w;
                        }
                        catch (Exception) 
                        {
                            Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Not Done");
                            Console.ResetColor();
                            ok = false;
                        }
                        if (k >= 6000)
                        {
                            Console.WriteLine($"Нагрузочное тестирование закончено, при дальнейшей проверке стек переполнен.");
                            ok = false;
                        }
                    }
                    break;
                case "2":
                    bool ok2 = true;
                    while (ok2)
                    {
                        try
                        {
                            sw.Start();
                            Function.FFS(CreateAutoTestList(k), 10, list);
                            sw.Stop();
                            Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Done");
                            Console.ResetColor();
                            Console.WriteLine($" | Время выполнения: {sw.ElapsedMilliseconds} мс Тиков: {sw.ElapsedTicks}");
                            list.Clear();
                            k += w;
                        }
                        catch (Exception)
                        {
                            Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Not Done");
                            Console.ResetColor();
                            ok2 = false;
                        }
                        if (k >= 6002)
                        {
                            Console.WriteLine($"Нагрузочное тестирование закончено, при дальнейшей проверке стек переполнен.");
                            ok2 = false;
                        }
                    }
                    break;
                case "3":
                    bool ok3 = true;
                    while (ok3)
                    {
                        try
                        {
                            sw.Start();
                            Function.iterFFD(CreateAutoTestList(k), 10, list);
                            sw.Stop();
                            /*Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Done");
                            Console.ResetColor();*/
                            //Console.WriteLine($" | Время выполнения: {sw.ElapsedMilliseconds} мс Тиков: {sw.ElapsedTicks}");
                            Console.WriteLine($"{sw.ElapsedTicks}");
                            list.Clear();
                            k += w;
                        }
                        catch (Exception)
                        {
                            Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Not Done");
                            Console.ResetColor();
                            ok3 = false;
                        }
                    }
                    break;
                case "4":
                    bool ok4 = true;
                    while (ok4)
                    {
                        try
                        {
                            sw.Start();
                            Function.iterFFD(CreateAutoTestList(k), 10, list);
                            sw.Stop();
                            Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Done");
                            Console.ResetColor();
                            Console.WriteLine($" | Время выполнения: {sw.ElapsedMilliseconds} мс Тиков: {sw.ElapsedTicks}");
                            list.Clear();
                            k += w;
                        }
                        catch (Exception)
                        {
                            Console.Write($"Количество входных:{k} | ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Not Done");
                            Console.ResetColor();
                            ok4 = false;
                        }
                    }
                    break;
            }
        }
    }
}
