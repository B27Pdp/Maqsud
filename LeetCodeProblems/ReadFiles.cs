using LeetCodeProblems.Lesson.IEnumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ReadFiles
    {
        public void ReadF(string filePath)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\acer\source\repos\LeetCodeProblems\LeetCodeProblems\Person\PersonData2.txt");

            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\acer\source\repos\LeetCodeProblems\LeetCodeProblems\Person\PersonData2.txt");

            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

          
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
