using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework
{
    internal class ConsolePrint
    {
        private void Print()
        {
            bool temp = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1 Add element");
                Console.WriteLine("2 Remove element");
                Console.WriteLine("3 Print element");
                Console.WriteLine("4 Remove the dublicate elements and print");
                Console.WriteLine("5 Change the elements");
                Console.WriteLine("6 Exit");
                Console.Write("Please choose the fuctions! ");
                Console.WriteLine();
                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1: AddValue(); break;
                    case 2: RemoveElement(); break;
                    case 3: PrintValue(); break;
                    case 4: RemoveDublicateElement(); break;
                    case 5: ChangeElement(); break;
                    case 6: temp = false; break;
                }

            }
            while (temp);


        }
        public ConsolePrint()
        {
            this.Print();
        } 
        List<int> list  = new List<int>();
        public void AddValue()
        {

            Console.WriteLine("Enter the numbers!");

            bool temp = true;
            bool isnumber = false;
            while (temp)
            {
                string a = Console.ReadLine();

                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsNumber(a[i]))
                    {
                        isnumber = true;
                    }
                    else isnumber = false;
                }
                if (isnumber)
                {
                    int num = Convert.ToInt32(a);
                    list.Add(num);
                }
                else
                {
                    Console.WriteLine(" Do you enter all numbers yes = 1  no = 2 ");
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        Print();
                        temp = false; break;
                    }
                    else if (result == 2)
                    {
                        a = Console.ReadLine();
                    }
                    else
                    {
                        while (result != 1 || result != 2)
                        {
                            Console.WriteLine(" Do you enter all numbers? yes = 1, no = 2 ");
                            result = Convert.ToInt32(Console.ReadLine());
                            if (result == 1)
                            {
                                Print();
                                temp = false; break;
                            }
                            else if (result == 2)
                            {
                                AddValue();
                                a = Console.ReadLine();
                            }
                        }
                    }
                }
            }
        }

        public void PrintValue()
        {
            Console.WriteLine();
            Console.WriteLine("Print value");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
        public void RemoveElement()
        {

            PrintValue();
            Console.WriteLine(" Enter number which you want delete! ");
            int k = Convert.ToInt32(Console.ReadLine());
            list.Remove(k);
            Console.WriteLine("Item is removed");
            PrintValue();
        }
        public void RemoveDublicateElement()
        {
            Console.WriteLine("Old element");
            PrintValue();
            list = list.Distinct().ToList();
            Console.WriteLine("Remove dublicate element");
            PrintValue();
        }
        public void ChangeElement()
        {
            PrintValue();
            Console.WriteLine("Please choose the element! ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number to change!");
            int m = Convert.ToInt32(Console.ReadLine());
            bool temp = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                {
                    list[i] = m;
                    temp = true;
                }
            }
            if (!temp)
            {
                Console.WriteLine(" Wrong number ");
            }
            Console.WriteLine(" new list ");
            PrintValue();
        }
    }
}
