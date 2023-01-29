using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework
{
    class Mylist
    {
        List<int> list { get; set; } = new();
            public void AddValue() 
            {

                Console.WriteLine("Enter the numbers!");
                string? a = Console.ReadLine();
                bool temp = true;
                bool isnumber = false;
                while (temp)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (char.IsNumber(a[i]))
                        {
                            isnumber= true;
                        }
                        else isnumber= false;
                    }
                    if(isnumber)
                    {
                        int num = Convert.ToInt32(a);
                        list.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("Do you enter all numbers?");
                        int yesno = Convert.ToInt32(Console.ReadLine);
                        if(yesno == 1)
                        {

                        }
                    }


                }


            }
        //List<T> list = new List<T>();
        //public void Add(T item)
        //{
        //    list.Add(item);
        //}
        //public T this[int i]
        //{
        //    get { return list[i]; }
        //    set { list[i] = value; }
        //}

        //public void Clear() { list.Clear(); }
        //public bool Contains(T item)
        //{
        //    if (list.Contains(item))
        //    {
        //        Console.WriteLine($"{item} qiymat {list.IndexOf(item)} indexda mavjud!");
        //        return true;
        //    }
        //    return false;
        //}

        //public int IndexOf(T item)
        //{
        //    Console.WriteLine();
        //    return list.IndexOf(item);
        //}
        //public bool Remove(T item)
        //{
        //    Console.WriteLine(item + "Qiymat o`chirildi");
        //    return list.Remove(item);
        //}
        //public void ConsoleLog()
        //{
        //    foreach (T item in list)
        //    {
        //        Console.WriteLine("Barcha Elemntlar:");
        //        Console.Write(item + " ");
        //    }
        //}
    }
}
