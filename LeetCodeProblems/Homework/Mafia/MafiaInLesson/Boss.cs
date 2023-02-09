using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Mafia.MafiaInLesson
{
    internal class Boss
    {
        public event EventHandler<EventHandler>? Order;
        public EventHandler? NextOrder;
        Others others = new();
        public void Orders()
        {
            Assasin assasin = new Assasin();
            Order += assasin.Task;
            NextOrder += others.Method1;
            NextOrder += others.Method2;
            Order.Invoke(this, NextOrder);


        }



    }
}
