using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Rasrochka
{
    internal class Start
    {
        public static async Task Run()
        {
            string passportId = "ABC12345";

            // Send the message to both companies asynchronously
            Operation operation = new Operation();
            var companyTask1 = operation.SenderIIB(passportId);
            var companyTask2 = operation.SenderSoliq(passportId);


            Console.WriteLine("Sending messages to both companies...");

            //// Wait for both tasks to complete
            //string company1Result = await company1Task;
            //string company2Result = await company2Task;

            await Task.Run(() => Console.WriteLine(companyTask1.Result));
            await Task.Run(() => Console.WriteLine(companyTask2.Result));

            // Print the results from both companies
            //Console.WriteLine($"Result from Company 1: {company1Result}");
            //Console.WriteLine($"Result from Company 2: {company2Result}");


            await operation.InFormationOfScoring();



            Console.ReadLine();
        }
    }
}
