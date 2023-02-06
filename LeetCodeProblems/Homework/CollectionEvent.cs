using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework
{
    class NumberFound
    {

        public delegate void MyDelegate(List<int> sums);
        public event MyDelegate? myNumberEvent;


        public void Run()
        {

            List<int> list = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                list.Add((new Random()).Next(70));
            }
            myNumberEvent?.Invoke(list);


        }

        public void myNewList(List<int> list)
        {
            list.FindAll(x => x % 2 == 0).ForEach(x => Console.WriteLine(x));
        }
    }
}
