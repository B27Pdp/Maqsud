using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework._30._01._2023
{
    internal class CompleteList
    {
        List<int> list = new List<int>();
        Random random = new Random();
        public void Complete()
        {
            for(int i = 0; i < 50; i++)
            {
                list.Add(random.Next(1, 100));
                Console.WriteLine(list[i]);
            }
        }
    }
}
