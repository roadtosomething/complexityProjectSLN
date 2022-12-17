using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace complexityProjectSLN
{
    public class Function
    {
        public static int Factorial(int n)
        {
            int fix = 1;
            for (int i =1; i <= n; i++)
            {
                fix*= i;
            }
            return fix;
        }
        public static string ShowList (List<List<int>> target)
        {
            string res = "";
            res+="[";
            foreach (List<int> list in target)
            {
                res+="[";
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != list.Count - 1)
                    {
                        res+=list[i].ToString()+",";
                    }
                    else
                    {
                        res+=list[i].ToString();
                    }
                }
                res+="]";
            }
            res+="]";
            return res;
        }
        public static string ShowList(List<int> target)
        {
            string res = "";
            res += "[";
            for (int i = 0; i < target.Count; i++)
            {
                if (i != target.Count - 1)
                {
                    res += target[i].ToString() + ",";
                }
                else
                {
                    res += target[i].ToString();
                }
            }
            res += "]";
            return res;
        }
        public static List<List<int>> FFD(List<int> arr, int max, List<List<int>> containers)
        {
            if (arr.Count == 0)
            {
                return containers;
            }
            List<int> brr = new List<int>(arr);
            if (containers.Count == 0)
            {
                containers.Add(new List<int> { arr[0] });
            }
            else
            {
                for (int j = 0; j < containers.Count; j++)
                {
                    if (containers[j].Sum () + arr[0] <= max)
                    {
                        containers[j].Add(arr[0]);
                        break;
                    }
                    else
                    {
                        if (j == containers.Count - 1)
                        {
                            containers.Add(new List<int> { arr[0] });
                            break;
                        }
                    }
                }
            }
            brr.RemoveAt(0);
            return FFD(brr, max, containers);
        }
        public static List<List<int>> iterFFD(List<int> arr, int max, List<List<int>> containers)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                List<int> brr = new List<int>(arr.TakeLast(arr.Count-i));
                if (brr.Count == 0)
                {
                    return containers;
                }
                if (containers.Count == 0)
                {
                    containers.Add(new List<int> { brr[0] });
                }
                else
                {
                    for (int j = 0; j < containers.Count; j++)
                    {
                        if (containers[j].Sum() + brr[0] <= max)
                        {
                            containers[j].Add(brr[0]);
                            break;
                        }
                        else
                        {
                            if (j == containers.Count - 1)
                            {
                                containers.Add(new List<int> { brr[0] });
                                break;
                            }
                        }
                    }
                }
            }
            return containers;
        }
        public static List<List<int>> iterFFS(List<int> arr, int max, List<List<int>> containers)
        { 
            List<int> brr = arr;
            brr.Sort();
            brr.Reverse();
            return iterFFD(brr, max, containers);
        }
        public static List<List<int>> FFS (List<int> arr, int max, List<List<int>> containers)
        {
            List<int> brr = arr;
            brr.Sort();
            brr.Reverse();
            return FFD (brr, max, containers);
        }
        public static List<string> ShowAllCombinations<T>(IList<T> arr, List<string> list = null, string current = "")
        {
            if (list == null) list = new List<string>();
            if (arr.Count == 0) //если все элементы использованы, выводим на консоль получившуюся строку и возвращаемся
            {
                list.Add(current);
                return list;
            }
            for (int i = 0; i < arr.Count; i++) //в цикле для каждого элемента прибавляем его к итоговой строке, создаем новый список из оставшихся элементов, и вызываем эту же функцию рекурсивно с новыми параметрами.
            {
                List<T> lst = new List<T>(arr);
                lst.RemoveAt(i);
                ShowAllCombinations(lst, list, current + arr[i].ToString()+",");
            }
            return list;
        }
        public static List<List<int>> GetIntList(List<string> target)
        {
            List<List<int>> baseList = new List<List<int>>();
            foreach (string str in target)
            {
                List<int> intlst = new List<int>();
                List<string> strlist = new List<string>(str.Split(','));
                strlist.RemoveAt(strlist.Count - 1);
                for (int i = 0; i < strlist.Count; i++)
                {
                    intlst.Add(Convert.ToInt32(strlist[i]));
                }
                baseList.Add(intlst);
            }
            return baseList;
        }
    }
}
