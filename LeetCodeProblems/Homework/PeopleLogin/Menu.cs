using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.PeopleLogin
{
    internal class Regestration
    {
        public static LearningFiles learnignFiles = new();
        public static void Menyu()
        {
            learnignFiles.AddToListAllItems();

            Console.Clear();

            Console.WriteLine("----------------------");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Show Users");
            Console.WriteLine("0. Exit");
            Console.WriteLine("----------------------");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatda kiriting");
                Menyu();
            }
            switch (a)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("<==== Add User ====>");
                        Console.WriteLine("Id kiriting: ");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.Clear();
                            Console.WriteLine("To'g'ri formatda kiriting");
                            Menyu();
                        }

                        //Guid id = Guid.NewGuid();

                        Console.WriteLine("Ism kiriting: ");
                        Console.Write(">> ");
                        string name = Console.ReadLine()!;
                        Console.WriteLine("Address kiriting: ");
                        Console.Write(">> ");
                        string address = Console.ReadLine()!;
                        learnignFiles.CreateFile(id, name, address);
                        Console.Clear();
                        //Console.WriteLine("User qo'shildi");
                        Menyu();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("<==== Delete User  ====>");
                        Console.WriteLine("1. Find by ID");
                        Console.WriteLine("2. Find by NAME");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.Clear();
                            Console.WriteLine("To'g'ri formatda kiriting");
                            Menyu();
                        }
                        switch (id)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Id ni kiriting");
                                    int deletedID;
                                    Console.Write(">> ");
                                    while (!int.TryParse(Console.ReadLine(), out deletedID))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("To'g'ri formatda kiriting");
                                    }
                                    learnignFiles.DeleteUserById(deletedID);
                                    Console.Clear();
                                    Menyu();
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Name ni kiriting");
                                    Console.Write(">> ");
                                    string DeletedName = Console.ReadLine()!;
                                    learnignFiles.DeleteUserByName(DeletedName);
                                    Console.Clear();
                                    Menyu();
                                }
                                break;
                            default:
                                Console.Clear();
                                Menyu();
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("<==== Update User  ====>");
                        Console.WriteLine("1. Find by ID");
                        Console.WriteLine("2. Find by NAME");
                        Console.Write(">> ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.Clear();
                            Console.WriteLine("To'g'ri formatda kiriting");
                            Menyu();
                        }
                        switch (id)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Id ni kiriting");
                                    int updateId;
                                    Console.Write(">> ");
                                    while (!int.TryParse(Console.ReadLine(), out updateId))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("To'g'ri formatda kiriting");
                                    }
                                    learnignFiles.UpdateUserById(updateId);
                                    Console.Clear();
                                    Menyu();
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Name ni kiriting");
                                    Console.Write(">> ");
                                    string updateName = Console.ReadLine()!;
                                    learnignFiles.UpdateUserByName(updateName);
                                    Console.Clear();
                                    Menyu();
                                }
                                break;
                            default:
                                Console.Clear();
                                Menyu();
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("<==== Show Users  ====>");
                        learnignFiles.ShowInfo();
                        Console.ReadKey();
                        Console.Clear();
                        Menyu();
                    }
                    break;
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("\n<===== Thanks for Attention =====>");
                    }
                    break;
                default:
                    Console.Clear();
                    Menyu();
                    break;
            }
        }
    }
}
