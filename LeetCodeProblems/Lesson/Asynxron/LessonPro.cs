using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Asynxron
{
    internal class LessonPro
    {
        public void Run()
        {
            Console.WriteLine("Run start");
            ////AsyncTask();
            ////await MyTask();
            ////if (!res.IsCompleted)
            ////{
            ////    res.Start();
            ////}
            //Console.WriteLine(StringTask().Result);
            //Console.Read();
            Task<int> resSoliq = SenderSoliq("55455");
            Task<string> res = SenderIIB("5555");

            //Console.WriteLine("Run stop");
            //// Task.WaitAll(resSoliq, res);        

            //Task.Run(() =>
            //{
            //    Console.WriteLine("hello");
            //});

            SoliqTest(resSoliq);
            Console.WriteLine("Main Thread");
            Console.ReadKey();
        }

        Task SoliqTest(Task<int> resSoliq)
        {
            //Console.WriteLine(resSoliq.Result);
            Task mytask = new Task(() =>
            {
                // Task.Delay(TimeSpan.FromSeconds(9));
                Console.WriteLine("hi");
            });
            mytask.Start();
            //Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("Salom");
            return mytask;
        }

        async Task<string> SenderIIB(string PassportID)
        {
            Task<string> yuborish = new(() =>
            {
                Task.Delay(4000).Wait();
                return $"Tom {PassportID}";
            });
            yuborish.Start();
            Console.WriteLine("yuborildi . . .");

            return await yuborish;
        }
        async Task<int> SenderSoliq(string PassportID)
        {
            Task<int> yuborish = new(() =>
            {
                Task.Delay(4000).Wait();
                return 550000;
            });
            yuborish.Start();
            Console.WriteLine("Yuborildi ...");

            return await yuborish;


        }
    }
}
