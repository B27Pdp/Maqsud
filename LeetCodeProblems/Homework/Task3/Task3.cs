using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Task3
{
    internal class Task3
    {
        public static string path = @"C:\Users\acer\source\repos\LeetCodeProblems\LeetCodeProblems\Homework\Task3\users.json";
        public static string jsonToString = File.ReadAllText(path);
        public static List<User>? users = JsonConvert.DeserializeObject<List<User>>(jsonToString);

        public static void SearchUsers(string userName)
        {
            var user = users?.FirstOrDefault(info => (info.username == userName) || (info.email == userName));
            if (user != null)
            {
                string comp = JsonConvert.SerializeObject(user.company, Formatting.Indented);
                string geo = JsonConvert.SerializeObject(user.address.geo, Formatting.Indented);
                Console.WriteLine(comp);
                Console.WriteLine(geo);
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
        }
    }
}

