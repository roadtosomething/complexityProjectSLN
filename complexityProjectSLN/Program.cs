using complexityProjectSLN;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.WebSockets;

class BaseClass
{
    public static void Menu(Parametr par)
    {
        List<List<int>> result = new List<List<int>>();
        //int kolElem = Function.Factorial(par.Count);
        bool processing = true;
        while (processing)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Выберите алгоритм для подсчета минимального количества контейнеров:");
            Console.WriteLine($"1.Точный алгоритм\n" +
                $"2.FF функция (первый подходящий)\n" +
                $"3.FF+S функция (первый подходящий с сортировкой)\n" +
                $"4.Нагрузочное тестирование. \n" +
                $"5.Задать новые параметры.\n" +
                $"6.Закончить программу");
            switch (Console.ReadLine())
            {
                case "1":
                    sw.Start();
                    List<string> listStrings = Function.ShowAllCombinations(par.Array);
                    List<List<int>> listOfPerrupts = Function.GetIntList(listStrings);
                    int minimumValue = int.MaxValue;
                    List<List<int>> listForPrint = new List<List<int>>();
                    for (int i=0;i<listOfPerrupts.Count;i++)//(List<int> list in listOfPerrupts)
                    {
                        List<List<int>> list1 = new List<List<int>>(Function.iterFFD(listOfPerrupts[i], par.MaxArr, result));
                        int value = list1.Count;
                        //Console.WriteLine($"{Math.Round(((double)i/kolElem),4)*100}%");
                        if (value <= minimumValue)
                        {
                            minimumValue = value;
                            listForPrint = list1;
                        }
                        result.Clear();
                    }
                    sw.Stop();
                    
                    result.Clear();
                    Console.WriteLine($"Затраченное время: {(sw.ElapsedMilliseconds/1000)/60} мин {(sw.ElapsedMilliseconds/1000)%60} с {(sw.ElapsedMilliseconds%1000)} мс {sw.ElapsedTicks} тиков\n" +
                        $"Минимальное количество используемых контейнеров по точному алгоритму: {minimumValue}\n" +
                        $"Получившийся набор предметов: {Function.ShowList(listForPrint)}");
                    break;
                case "2":
                    sw.Start();
                    List<List<int>> list2 = new List<List<int>>(Function.FFD(par.Array, par.MaxArr, result));
                    int value1 = list2.Count;
                    sw.Stop();
                    result.Clear();
                    Console.WriteLine($"Затраченное время: {(sw.ElapsedMilliseconds / 1000) / 60} мин {(sw.ElapsedMilliseconds / 1000) % 60} с {(sw.ElapsedMilliseconds % 1000)} мс {sw.ElapsedTicks} тиков\n" +
                        $"Минимальное количество используемых контейнеров по алгоритму FFI: {value1}\n" +
                        $"Получившийся набор предметов: {Function.ShowList(list2)}");
                    break;
                case "3":
                    sw.Start();
                    List<List<int>> list3 = new List<List<int>>(Function.FFS(par.Array, par.MaxArr, result));
                    int value2 = list3.Count;
                    sw.Stop();
                    result.Clear();
                    Console.WriteLine($"Затраченное время: {(sw.ElapsedMilliseconds / 1000) / 60} мин {(sw.ElapsedMilliseconds / 1000) % 60} с {(sw.ElapsedMilliseconds % 1000)} мс {sw.ElapsedTicks} тиков\n" +
                        $"Минимальное количество используемых контейнеров по алгоритму FF+S: {value2}\n" +
                        $"Получившийся набор предметов: {Function.ShowList(list3)}");
                    break;
                case "4":
                    Test.BenchMarkTest();
                    break;
                case "5":
                    par.SetParametrs();
                    break;
                case "6":
                    Console.WriteLine("Процесс работы остановлен");
                    processing = false;
                    break;
                case "7":
                    sw.Start();
                    int time=1;
                    sw.Stop();
                    Console.WriteLine($"Время выполнения 1 элементарной операции в тиках: {sw.ElapsedTicks}");
                    break;
            }
                
        }
    }
    static void Main(string[] args)
    {
        Parametr par = new Parametr();
        par.SetParametrs();
        Menu(par);
    }
}
