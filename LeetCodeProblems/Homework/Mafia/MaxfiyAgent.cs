using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Mafia
{
    internal class MaxfiyAgent
    {
        public event EventHandler<CallBackEventargs>Ordercall;
        public void Order()
        {
            Console.WriteLine("O'ldirish kerak bo'lgan idni kiriting");
            int id = int.Parse(Console.ReadLine());
            string orderMessage = Console.ReadLine() ?? "Empty";
            CallBackEventargs callBackEventargs = new()
            {
                Id = id,
                OrderMessage = orderMessage,
                SendDate = DateTime.Now,
            };
            Ordercall.Invoke(this, callBackEventargs);
        }
    }
}
