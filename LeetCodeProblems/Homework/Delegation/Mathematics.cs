using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Delegation
{
    public delegate void Calculator(int a, int b);
    internal class Mathematics
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        public void Start()
        {
            Calculator calculator = Sum;
            calculator.Invoke(12, 3);
            calculator = Substract;
            calculator.Invoke(12, 3);
            calculator = Multiply;
            calculator.Invoke(12, 3);
            calculator = Divide;
            calculator.Invoke(12, 3);
        }
    }
}
