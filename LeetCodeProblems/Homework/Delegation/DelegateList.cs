using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Delegation
{
    public delegate (int min, int max) MinAndMax(List<int> list);
    internal class DelegateList
    {
        (int min, int max) FindMinMax(List<int> list)
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var item in list)
            {
                if(item < min)
                {
                    min = item;
                }
                if(item > max)
                {
                    max = item;
                }
            }
            return (min, max);
        }
        public void Start()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            MinAndMax minAndMax = FindMinMax;
            Console.WriteLine(minAndMax.Invoke(list));

        }
    }
}
