using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexityProjectSLN
{
    public class Parametr
    {
        private int maxArr;
        private int maxElem;
        private int count;
        private List<int> array;
        public int MaxArr
        {
            get { return maxArr; }
            set 
            { maxArr = value;}
        }
        public int MaxElem
        {
            get { return maxElem; }
            set 
            { 
                if (value <= maxArr)
                {
                    maxElem = value;
                }
                else
                {
                    Console.WriteLine("Необходимо соблюдать условие задачи о том, что вес элемента не должен превышать максимальную вместимость контейнера. \n" +
                        "Элемент приравнен к максимальному весу контейнера");
                    maxElem = maxArr;
                }
            }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public List<int> Array
        {
            get { return array; }
            set { array = value; }
        }
        public void SetParametrs()
        {
            Random random = new Random();
            Console.Write("Введите максимальный вес контейнера:");
            MaxArr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество элементов массива:");
            Count = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            Console.WriteLine($"Как задать максимальный вес элемента?\n" +
                $"1.С клаиватуры.\n" +
                $"2. Приравнять максимальному размеру контейнера.\n" +
                $"3. Автоматически в перделах от [1..max], где max- максимальный вес контейнера.");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Введите максимальный вес элемента");
                    MaxElem = Convert.ToInt32(Console.ReadLine());
                    break;
                case "2":
                    MaxElem = MaxArr;
                    break;
                case "3":
                    MaxElem = random.Next(1, MaxArr);
                    break;
                default:
                    Console.WriteLine("Неизвестная команда! Параметры прежние");
                    break;
            }
            for (int i = 0; i < Count; i++)
            {
                list.Add(random.Next(1, MaxElem));
            }
            Array = list;
            Show();
        }
        public void Show()
        {
            Console.WriteLine($"Используемые параметры для работы:\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Максимальный вес контейнера: ");
            Console.ResetColor();
            Console.WriteLine($"{MaxArr}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Вес элемента: ");
            Console.ResetColor();
            Console.WriteLine($"{MaxElem}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Массив: ");
            Console.ResetColor();
            Console.WriteLine($"{Function.ShowList(Array)}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Размер массива: ");
            Console.ResetColor();
            Console.WriteLine($"{Count}");
        }
    }
}
