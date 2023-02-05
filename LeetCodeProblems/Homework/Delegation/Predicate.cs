using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Delegation
{
    public delegate void Print(int value);
    internal class Predicate
    {
        public static void StartUp()
        {
            Predicate<string> predicate = word =>
            {
                foreach (var chr in word)
                {
                    if (!char.IsUpper(chr))
                    {
                        return false;
                    }
                }
                return true;
            };
            bool result = predicate("MAQSUD");
            Console.WriteLine(result);

            ////

            Predicate<string> CheckIfApple = modelname =>
            {
                if (modelname == "I Phone X") return true;
                else
                    return false;
            };
            bool resultt = CheckIfApple("I Phone X");
            if (resultt)
                Console.WriteLine("It's an IPhone");


            Action<int> printActionDel = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel(10);

        }

        //Anonymous method
        Print print = delegate (int val)
        {
            Console.WriteLine("Inside Anonymous method. Value: {0}", val);

        };
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

        //Lamda delegate
        class Class1
        {
            public delegate int Del(int Value);

            static void A(string[] args)
            {
                Del obj = (Value) =>
                {
                    int x = Value * 2;
                    return x;
                };
                Console.WriteLine(obj(5));
            }
            public void WithList()
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var result = numbers.Where(number => number > 3 && number < 8);
                Console.WriteLine(String.Join(" ", result));
                Console.WriteLine();
            }
            public void WithDict()
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                var result = dict.Where(dict => dict.Key == 1 && dict.Value == "Maqsud");
                Console.WriteLine(result);
            }

            public void WITHStack()
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                stack.Push(6);
                var result = stack.FirstOrDefault(stackelement => stackelement == 1);
                Console.WriteLine(result);
            }




        }
    }
}
