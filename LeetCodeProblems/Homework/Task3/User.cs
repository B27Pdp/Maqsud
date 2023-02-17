using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Task3
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }

    class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string ziocode { get; set; }
        public Geo geo { get; set; }
    }

    class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
}
