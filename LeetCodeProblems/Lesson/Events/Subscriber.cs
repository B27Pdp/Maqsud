using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCodeProblems.Lesson.Events
{
    internal class Subscriber
    {
        public delegate void ClickSendSmsToYer(object? sender, string SmsText);
        List<(object, string)> GetAllMessages = new();

        public void ShowAllMessages()
        {
            foreach (var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickSendSms(object sender, string SmsText)
        {
            GetAllMessages.Add((sender, SmsText));
        }
        public event ClickSendSmsToYer? OnClickSendSms1;
        public void SendSmsMesage()
        {
            Console.WriteLine("Xabarni kiriting");
            string SmsText = Console.ReadLine() ?? "No Text";
            OnClickSendSms1?.Invoke(this, SmsText);
        }
    }
}
