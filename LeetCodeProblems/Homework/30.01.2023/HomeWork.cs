using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework._30._01._2023
{
    internal class HomeWork:IEnumerable
    {
        List<string> list = new List<string>();

        IEnumerator IEnumerable.GetEnumerator()
        {

            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
        public void Add(string name)
        {
            list.Add(name);
            
        }
        public void changeSecond(string surname)
        {
             list[1] = surname;

        }
        public void ConvertToArray()
        {
            string[] arr = list.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        
        }
        public void DeleteMyInfo()
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == "Maqsud") 
                { 
                    list.RemoveAt(i);
                }
                if (list[i] == "Haydarov")
                {
                    list.RemoveAt(i);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
