using Newtonsoft.Json;

namespace LeetCodeProblems.Rasrochka
{
    public class Operation
    {
        int scoreOfSoliq = 0;
        int scoreOfIIB = 0;
        public async Task<string> SenderIIB(string PassportID)
        {
            string filePath = "C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Rasrochka\\infos.json";
            string json = File.ReadAllText(filePath);
            Client[] people = JsonConvert.DeserializeObject<Client[]>(json);


            Task<string> yuborish = new(() =>
            {
                 Task.Delay(4000).Wait();
                foreach (Client person in people)
                {
                    if (person.PassportId == PassportID)
                    {
                        if (!(person.IsImprison && person.IsMarried && person.Salary >= 6000_000))
                        {
                            scoreOfIIB = 50;
                        }
                        else if (!(person.IsImprison && person.Salary >= 4000_000))
                        {
                            scoreOfIIB = 45;
                        }
                        else if (person.IsMarried && person.Salary >= 3000_000)
                        {
                            scoreOfIIB = 40;
                        }
                        else
                        {
                            scoreOfIIB = 30;
                        }
                        return $"Information from IIV\n Person Name:{person.FirstName}\n Person LastName:{person.LastName}\n Person IsImprison:{person.IsImprison}\n Person IsMarried:{person.IsMarried}\n Person Salary:{person.Salary}\n Person Score:{scoreOfIIB}";


                    }
                }
                return "Bunday id dagi odam mavjud emas";
            });
            yuborish.Start();
            Console.WriteLine("Sending...");
            return await yuborish;

        }
        public async Task<string> SenderSoliq(string PassportID)
        {
            string filePath = "C:\\Users\\acer\\source\\repos\\LeetCodeProblems\\LeetCodeProblems\\Rasrochka\\infos.json";
            string json = File.ReadAllText(filePath);
            Client[] people = JsonConvert.DeserializeObject<Client[]>(json);
            
            Task<string> yuborish = new(() =>
            {
                Task.Delay(7000).Wait();
                foreach (Client person in people)
                {
                    if (person.PassportId == PassportID)
                    {

                        if (!person.IsDebt)
                        {
                            scoreOfSoliq = 50;
                        }
                        else
                        {
                            scoreOfSoliq = 20;
                        }
                        return $"\nInformation from DSQ\n Person Name:{person.FirstName}\n Person LastName:{person.LastName}\n Person DebtStatus{person.IsDebt}\n Person Score {scoreOfSoliq}";

                    }
                }
                return "Bunday id dagi odam mavjud emas";
            });
            yuborish.Start();
            Console.WriteLine("Sending...");
            return await yuborish;

        }
        public async Task InFormationOfScoring()
        {
            Console.WriteLine("\nScoring...");
            await Task.Delay(3000);

            int sumOfScore = scoreOfIIB + scoreOfSoliq;
            if (sumOfScore >= 90)
            {
                Console.WriteLine("35_000_000 so'mgacha pul berilishi mumkin");
            }
            else if (sumOfScore >= 75 && sumOfScore < 90)
            {
                Console.WriteLine("20_000_000 so'mgacha pul berilishi mumkin");
            }
            else if (sumOfScore >= 65 && sumOfScore < 75)
            {
                Console.WriteLine("8_000_000 so'mdan 14_000_000 so'mgacha pul berilishi mumkin");
            }
            else
            {
                Console.WriteLine("Berilmaydi");
            }


        }
    }
}
