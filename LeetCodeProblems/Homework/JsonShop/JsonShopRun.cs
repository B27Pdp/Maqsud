using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.JsonShop
{
    internal class JsonShopRun
    {
        public void RunShop()
        {
           Request request = new Request();
            request.created = DateTime.Now;
            request.method = "POST";
            JsonShopCrud jsonShopCrud = new JsonShopCrud();
            jsonShopCrud.AddRequest(request);
            
        }
    }
}
