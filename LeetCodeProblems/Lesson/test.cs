using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson
{
    interface Animal
    {
        static Animal() { }
        public void AA()
        {
            Console.WriteLine("Animal");
        }
       
    }
     internal class Dog : Animal 
     {
        public void AA()
        {
            Console.WriteLine("Dog");
        }

     }
}

