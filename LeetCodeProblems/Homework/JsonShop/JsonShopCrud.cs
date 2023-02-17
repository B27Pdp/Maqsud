using JsonAddAndUpdate;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Text.Json;

namespace LeetCodeProblems.Homework.JsonShop
{
    internal class JsonShopCrud
    {
        string myFilepath = "C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Homework\\JsonShop\\shop.json";
        
        public void AddRequest(Request request)
        {
            if (request == null)
            {
                Console.WriteLine("null");
            }
            else
            {
               Shop shop = new Shop();
                shop.requests.Add(request);
                string newtext = JsonConvert.SerializeObject(shop, Formatting.Indented);
                File.WriteAllText(myFilepath, newtext );




                
            }
        }
        
    }
}
