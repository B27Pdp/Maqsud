using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LeetCodeProblems.Homework.JsonHomeWorks
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class MySerializer
    {
        public static void Run()
        {
        string XMLFile = "C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Homework\\JsonHomeWorks\\XMLFile1.xml";
            Person person = new Person();
            person.Name = "Maqsud";
            person.Id = "aaa1111";
            person.Age = 19;

            //string a1 = JsonConvert.SerializeObject(person, Formatting.Indented);
            //string path = "C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Homework\\JsonHomeWorks\\Myfile.json";
            //File.WriteAllText(path, a1);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (StreamWriter sw = new StreamWriter(XMLFile))
            {
                xmlSerializer.Serialize(sw, person);
                Console.WriteLine("Object has been serialized");
            }
            

        }
    }
    
}
