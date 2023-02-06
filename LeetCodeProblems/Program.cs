using LeetCodeProblems.Homework;
using LeetCodeProblems.Homework._30._01._2023;
using LeetCodeProblems.Homework.Delegation;
using LeetCodeProblems.Lesson;
using LeetCodeProblems.Lesson.Delegates;
using LeetCodeProblems.Lesson.Events;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class Program
{
    public delegate void ClickSendSmsToYer(object? sender, string SmsText);
    static void Main(string[] args)
    {
       /* Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        publisher.OnClickSendSms += subscriber.OnClickSendSms;
        publisher.SendSmsMesage();
        subscriber.ShowAllMessages();

        subscriber.OnClickSendSms1 += publisher.OnClickSendSms1;
        subscriber.SendSmsMesage();
        publisher.ShowAllMessages();
       */
        string message = Console.ReadLine();
        Console.WriteLine(Regex.IsMatch(message,"^[a-z1-9]{10}$"));




    } 
    
    
}