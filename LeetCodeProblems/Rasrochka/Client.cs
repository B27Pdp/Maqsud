using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Rasrochka
{
    internal class Client
    {
        public string PassportId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsDebt { get; set; }
        public bool IsImprison { get; set; }
        public bool IsMarried { get; set; }
        public double Salary { get; set;}

      

    }
}
