using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Lesson.Events
{
    internal class Subscriber2
    {
        public event ClickSendSmsToOy? OnClickSendSms;
        public void SendSmsMesage()
        {
            Console.WriteLine("Xabarni kiriting");
            string SmsText = Console.ReadLine() ?? "No Text";
            OnClickSendSms?.Invoke(this, SmsText);
        }
        List<(object, string)> GetAllMessages = new();

        public void ShowAllMessages2()
        {
            foreach (var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickSendSms2(object sender, string SmsText)
        {
            GetAllMessages.Add((sender, SmsText));
        }
    }
}
