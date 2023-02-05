using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Delegates
{
    public  delegate bool Mydelegate(string message, int phonenumber, MyPointer myPointer);
    public delegate string MyPointer();
    internal class Delegates
    {
        public static void DoSomething(Mydelegate pointer) 
        {
            pointer = SendMessage;
            pointer.Invoke("Men keldim", 937040019, Start);
        }
        public static bool SendMessage(string message, int phonenumber, MyPointer myPointer)
        {
            myPointer = Start;
            Console.WriteLine("{0} is sended to {1} at {2}", message, phonenumber, myPointer());
            return true;
        }
        public static string Start()
        {
            return DateTime.Now.ToString();
        }
        public delegate int Mynum(int a);
        public static void AnonymusDelegate()
        {
            Mynum mynum = delegate (int a)
            {
                return a;
            };
                 
        }
      
    }
    class A
    {
        public delegate string Text(string text);
        public static string Mytext(string text)
        {
            return text;
        }
    }
     
}

