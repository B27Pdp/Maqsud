using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LeetCodeProblems.Lesson.Delegates;

class Regexamples
{
    public static void Start()
    {
        /*string pattern = @"gr[ae]y\s\S+?[\s\p{P}]";
        string input = "The gray wolf jumped over the grey wall.";
        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
        Console.WriteLine($"'{match.Value}'");
        // icida harf bor yoki yoqligi
        string str1 = "x";
        Console.WriteLine(Regex.IsMatch(str1, "[q-z]"));
        Console.WriteLine(Regex.IsMatch(str1, "."));
        //class Regex Repesents an immutable regular expression.    
        Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
        string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
        //Input strings for Match valid mobile number.    
        foreach (string s in str)
        {
            Console.WriteLine("{0} {1} a valid mobile number.", s,
                r.IsMatch(s) ? "is" : "is not");
            ///The IsMatch method is used to validate a string or     
            ///to ensure that a string conforms to a particular pattern.   
        }
        Console.WriteLine(Regex.IsMatch("a=aa", @"\D{}"));
        */
        
       
    }
    public void BeginWithS()
    {
        List<string> names = new List<string>();
        names.Add("Maqsud");
        names.Add("Sardor");
        names.Add("Aziz");
        names.Add("Sarvar");
        Regex regex = new Regex("[S]");
        foreach (var item in names)
        {
            if (regex.IsMatch(item))
            {
                Console.WriteLine(item);
            }
        }
    }
    public void OnlyNumbers()
    {
        Regex re = new Regex(@"\d+");
        Match m = re.Match("test 101");
    

        if (m.Success)
        {
            Console.WriteLine(string.Format("RegEx found " + m.Value + " at position " + m.Index.ToString()));
        }
        else
        {
            Console.WriteLine("You didn't enter a string containing a number!");
        }

    }
}