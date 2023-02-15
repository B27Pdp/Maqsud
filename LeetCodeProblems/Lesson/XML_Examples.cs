using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LeetCodeProblems.Lesson
{
    internal class XML_Examples
    {
        static readonly string XMLFile1 = @"..\..\..\Lesson\XML\XMLFile1.xml";
        static readonly string XMLFile2 = @"..\..\..\XML\XMLFile2.xml";

        public static void Run()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLFile1);
            XmlElement xRoot = xDoc.DocumentElement;
            if(xRoot != null )
            {
                foreach(XmlElement xnode in xRoot )
                {
                    XmlNode? atr = xnode.Attributes.GetNamedItem("name");
                    Console.WriteLine(atr?.Value);

                    foreach(XmlNode childnode in xnode.ChildNodes)
                    {
                        if(childnode.Name == "company") 
                        {
                            Console.WriteLine($"Company: {childnode.InnerText}");
                        }
                        if(childnode.Name == "age")
                        {
                            Console.WriteLine($"Age:{childnode.InnerText}");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
        public static void Add(Person1 person)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLFile2);
            XmlNode? ROOT = doc.SelectSingleNode("/ROOT");
            XmlNode Person = doc.CreateElement("Person");
            XmlNode id = doc.CreateElement("id");
            XmlNode name = doc.CreateElement("name");
            id.InnerText = person.id.ToString();
            name.InnerText = person.Name.ToString();
            XmlNode age = doc.CreateElement("age");

            Person.AppendChild(id);
            Person.AppendChild(name);
            Person.AppendChild(age);
            ROOT?.AppendChild(Person);
            doc.Save(XMLFile2);

            
        }

        public static void XML_Serialize()
        {
            Person1 person = new Person1("Maqsud", 19,1);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person1));
            using(StreamWriter sw = new StreamWriter(XMLFile1))
            {
                xmlSerializer.Serialize(sw, person);
                Console.WriteLine("Object has been serialized");
            }
        }
        public static void XML_Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person1));

            // десериализуем объект
            using (FileStream fs = new FileStream("XMLFile2.xml", FileMode.OpenOrCreate))
            {
                Person1? person = xmlSerializer.Deserialize(fs) as Person1;
                Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");
            }
        }
    }
    public class Person1
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;
        public int id { get; set; }

        public Person1(string name, int age, int id)
        {
            Name = name;
            Age = age;
            this.id = id;
        }
    }
}
