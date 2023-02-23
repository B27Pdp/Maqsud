using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Asynxron
{
    internal class MyAsync
    {
        //public static void Run()
        //{
        //    Console.WriteLine("Main Method Started......");
        //    SomeMethod();
        //    SomeMethod1();
        //    Console.WriteLine("Main Method End");
        //    Console.ReadKey();
        //}
        //public static async Task SomeMethod()
        //{
        //    Console.WriteLine("Some Method Started......");
        //    //Thread.Sleep(TimeSpan.FromSeconds(10));
        //    await Task.Delay(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("Some Method End");
        //}
        //public static  async void SomeMethod1()
        //{
        //    Console.WriteLine("Some Method1 Started......");
        //    Thread.Sleep(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("Some Method1 End");
        //}
        //    public static void Run()
        //    {
        //        Method1();
        //        Method2();
        //        Console.ReadKey();
        //    }

        //    public static async Task Method1()
        //    {
        //        await Task.Run(() =>
        //        {
        //            for (int i = 0; i < 10; i++)
        //            {
        //                Console.WriteLine(" Method 1");
        //                // Do something
        //                Task.Delay(1000).Wait();
        //            }
        //        });
        //    }


        //    public static void Method2()
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine(" Method 2");
        //            // Do something
        //            Task.Delay(1000).Wait();
        //        }
        //    }
        //}

        //public static void Run()
        //{
        //    Console.WriteLine("Main Method Started......");
        //    SomeMethod();
        //    Console.WriteLine("Main Method End");
        //    Console.ReadKey();
        //}
        //public async static void SomeMethod()
        //{

        //    Console.WriteLine("Some Method Started......");
        //    await Wait();
        //    Console.WriteLine("Some Method End");
        //}
        //private static async Task Wait()
        //{
        //    await Task.Delay(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n10 Seconds wait Completed\n");

        //}

        public static void Run()
        {
            Console.WriteLine("Main Method Started......");
            SomeMethod();
            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            Wait();
            Console.WriteLine("Some Method End");
        }
        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
    }
}
