using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.ToDoList
{
    internal class AutoResetEvent1
    {
        TODO todo1 = new TODO();
        AutoResetEvent resetEvent = new AutoResetEvent(true);

        public void AddWithThreads()
        {
            Task task = new Task();
            Console.WriteLine("Enter title:");
            task.Title = Console.ReadLine();
            Console.WriteLine("Finish?");
            task.Completed = Convert.ToBoolean(Console.ReadLine());
            object mylock = new();
            Thread thread = new(myThread);
            thread.Start();

            void myThread()
            {


                //lock (mylock)
                //{
                //    todo1.AddTask(task);
                //}
                //bool acquiredLock = false;
                //try
                //{
                //    Monitor.Enter(mylock, ref acquiredLock);
                //    todo1.AddTask(task);
                //}
                //finally
                //{
                //    if (acquiredLock)
                //    {
                //        Monitor.Exit(mylock);
                //    }
                //}


                resetEvent.WaitOne();
                todo1.AddTask(task);
                resetEvent.Set();
            }
        }
        public void EditWithThreads()
        {
            Task task = new Task();
            Console.WriteLine("Enter title:");
            task.Title = Console.ReadLine();
            Console.WriteLine("Finish?");
            task.Completed = Convert.ToBoolean(Console.ReadLine());
            object mylock = new();
            Thread thread = new(myThread);
            thread.Start();

            void myThread()
            {
                //lock (mylock)
                //{
                //    todo1.AddTask(task);
                //}
                //bool acquiredLock = false;
                //try
                //{
                //    Monitor.Enter(mylock, ref acquiredLock);
                //    todo1.AddTask(task);
                //}
                //finally
                //{
                //    if (acquiredLock)
                //    {
                //        Monitor.Exit(mylock);
                //    }
                //}
                resetEvent.WaitOne();
                todo1.AddTask(task);
                resetEvent.Set();
            }
        }
        public void DeleteWithThreads()
        {
            Task task = new Task();
            Console.WriteLine("Enter id:");
            task.id = int.Parse(Console.ReadLine());
            object mylock = new();
            Thread thread = new(myThread);
            thread.Start();

            void myThread() 
                {

                //lock (mylock)
                //{
                //    todo1.AddTask(task);
                //}

                //bool acquiredLock = false;
                //try
                //{
                //    Monitor.Enter(mylock, ref acquiredLock);
                //    todo1.AddTask(task);
                //}
                //finally
                //{
                //    if (acquiredLock)
                //    {
                //        Monitor.Exit(mylock);
                //    }
                //}

                resetEvent.WaitOne();
                todo1.AddTask(task);
                resetEvent.Set();
            }
        }


    }
}
