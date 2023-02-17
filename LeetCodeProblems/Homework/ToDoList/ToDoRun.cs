using JsonAddAndUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.ToDoList
{
    internal class ToDoRun
    {
        public static void Run()
        {
            TODO todo = new TODO();
             Menyu:
            Console.WriteLine("Choose Your Options : \n 1 - Add \n 2 - Update \n 3 - Delete \n 4 - GetTasks \n 5 - GetById");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Task task = new Task();
                    Console.WriteLine("Add task");
                    Console.WriteLine("Enter user id");
                    task.userId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter id");
                    task.id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter title");
                    task.Title = Console.ReadLine();
                    Console.WriteLine("Enter task status");
                    task.Completed = true;
                    todo.AddTask(task);
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;
                case "2":
                    Task task1 = new Task();
                    Console.WriteLine("Enter id");
                    int id = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Enter new id");
                    //int id = int.Parse(Console.ReadLine());
                    todo.Update(id,true, task1);
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;
                case "3":
                    Console.WriteLine("Enter id");
                    int id1 = int.Parse(Console.ReadLine());
                    todo.Delete(id1);
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;
                case "4":
                    todo.GetTasks();
                    Console.ReadKey();
                    Console.Clear();
                    goto Menyu;
                    case"5":
                    Console.WriteLine("Enter id");
                    int newId = int.Parse(Console.ReadLine());
                    todo.GetById(newId);
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
