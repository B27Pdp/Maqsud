using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Events
{
    public delegate void ClickSendSmsToOy(object? sender, string SmsText);
    internal class Publisher
    {
        public event ClickSendSmsToOy? OnClickSendSms;
        public void SendSmsMesage()
        {
            Console.WriteLine("Xabarni kiriting");
            string SmsText = Console.ReadLine() ?? "No Text";
            OnClickSendSms?.Invoke(this, SmsText);
        }
        List<(object, string)> GetAllMessages = new();

        public void ShowAllMessages()
        {
            foreach (var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickSendSms1(object sender, string SmsText)
        {
            GetAllMessages.Add((sender, SmsText));
        }
    }
}
