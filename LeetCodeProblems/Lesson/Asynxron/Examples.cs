using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Asynxron
{
    internal class Examples
    {
        public void Run()
        {
            Console.WriteLine("Run start");
            MyExample();
            Console.WriteLine("Run end");
            
        }
        public async Task<string> MyExample()
        {
            Task<string> task = new(() =>
            {
                //Task.Delay(1000);
                Console.WriteLine("MyExample");
                return "aaa";
            });
            task.Start();
            Console.WriteLine("Ishga tuwdi");
            return await task;
        }

        public async Task<string> MyExample2()
        {
            Task<string> task2 = new(() =>
            {
                Console.WriteLine("My example 2");
                return "bbb";
            });
            task2.Start();
            Console.WriteLine();
            return await task2;

        }
    }
}

