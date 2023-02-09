using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework.Leetcode
{
    internal class LeetCodeProblem
    {
            public char FindTheDifference(string s, string t)
            {
                List<char> list = new List<char>(t);
                for (int i = 0; i < s.Length; i++)
                    list.Remove(s[i]);
                return list[0];
            }

            
    }
    
}
