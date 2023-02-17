using JsonAddAndUpdate;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.ToDoList
{
    internal class TODO
    {
        private string jsonFile = @"C:\Users\acer\source\repos\LeetCodeProblems\LeetCodeProblems\Homework\ToDoList\todos.json";
        string text;
        public TODO()
        {
            if(File.Exists(jsonFile))
            {
                text = File.ReadAllText(jsonFile);
            }
        }
        public void AddTask(Task task)
        {
            List<Task> tasks = new();
            if(File.Exists(jsonFile))
            {
                tasks = JsonConvert.DeserializeObject<List<Task>>(text) ?? new();
                JArray datas = JArray.Parse(text);
                JToken? FoundAccount = datas.FirstOrDefault(x => (int)x["id"] == task.id);
                if( FoundAccount == null )
                {
                    tasks.Add(task);
                    text = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                    File.WriteAllText(jsonFile, text);
                }
                else
                {
                    Console.WriteLine("Bu id mavjud");
                }
            }
            
        }
        public bool Delete(int id)
        {
            JArray datas = JArray.Parse(text);
            JToken? FoundAccount = datas.FirstOrDefault(x => (int)x["id"] == id);
            if(FoundAccount != null )
            {
                datas.Remove(FoundAccount);
                File.WriteAllText(jsonFile, datas.ToString());
                Console.WriteLine("Task was deleted");
                return true;
            }
            return false;
        }
        public List<Task> GetTasks()
        {
            return JsonConvert.DeserializeObject<List<Task>>(text) ?? new();
        }
        public Task? GetById(int id)
        {
            JArray datas = JArray.Parse(text);
            JToken? tokentask = datas.FirstOrDefault(x => (int)x["id"] == id);
            return tokentask == null ? null : JsonConvert.DeserializeObject<Task>(tokentask.ToString());
        }
        public bool Update(int id,bool completed, Task task)
        {
            JArray datas = JArray.Parse(text);
            JToken? FoundAccount = datas.FirstOrDefault(x => (int)x["id"] == id);
            if( FoundAccount != null )
            {
                completed= true;
                task.Completed = completed;
                //datas.Remove(FoundAccount);
                //FoundAccount = JToken.Parse(JsonConvert.SerializeObject(task, Formatting.Indented));
                //datas.Add(FoundAccount);
                File.WriteAllText(jsonFile,datas.ToString());
                return true;
            }
            return false;


        }
    }
}

