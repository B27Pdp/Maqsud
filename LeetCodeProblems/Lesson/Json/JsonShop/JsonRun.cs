using LeetCodeProblems.Homework.JsonShop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCodeProblems.Lesson.Json.JsonShop
{
    internal class JsonRun
    {
        string _path = "C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Lesson\\Json\\JsonShop\\shop.json";
        public Shop? GetAll()
        {
            if (File.Exists(_path))
            {
                //JObject jobj = JObject.Parse(File.ReadAllText(_path));
                return JsonConvert.DeserializeObject<Shop>(File.ReadAllText(_path));
            }
            return null;
        }
    }
}
