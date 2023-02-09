using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons.Homework.Delegation
{
    internal class Mystr
    {
        public void Print()
        {
            try
            {
                Console.WriteLine("Matnni kiriting");
                string str = Console.ReadLine();
                throw new ArgumentNullException("Kiritilgan matn bo'sh bo'lmasligi kerak");

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
