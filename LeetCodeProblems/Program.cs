using JsonAddAndUpdate;

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

         string message = Console.ReadLine();
         Console.WriteLine(Regex.IsMatch(message,"^[a-z1-9]{10}$"));
        */
        //Regexamples regexamples = new Regexamples();
        //Regexamples.Start();
        //regexamples.OnlyNumbers();
        //MaxfiyAgent maxfiyAgent = new();
        //Josus josus = new Josus();
        //maxfiyAgent.Ordercall += josus.GetCall;
        //maxfiyAgent.Order();
        //Boss boss = new Boss();
        //Assasin assasin = new Assasin();


        //WorkingWithFiles workingWithFiles = new WorkingWithFiles();
        //WorkingWithFiles.Start();
        //WorkingWithFiles.AllLines();
        //WorkingWithFiles.CopyFile();
        //WorkingWithFiles.CombineMultipleFilesIntoSingleFile();
        //ReadFiles readFiles = new ReadFiles();
        //readFiles.ReadF("C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Person\\PersonData1.txt");
        //LearningFiles learningFiles = new LearningFiles();
        //Regestration regestration = new Regestration();
        //regestration.Menyu();
        //XML_Examples xML_Examples = new XML_Examples();
        //XML_Examples.Run();
        //Person1 person = new Person1("Feruz", 19, 1);
        //XML_Examples.Add(person);
        MyJsonExample myJsonExample = new MyJsonExample();
        MyJsonExample.Run();












    }


}