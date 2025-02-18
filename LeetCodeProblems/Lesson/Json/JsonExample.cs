﻿using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace JsonAddAndUpdate
{
    class TODo
    {
        private string jsonFile = @"C:\Users\acer\source\repos\LeetCodeProblems\LeetCodeProblems\Lesson\Json\tsconfig1.json";
        private void AddCompany()
        {

            Console.WriteLine("Enter Company ID : ");
            string companyId = Console.ReadLine();
            JObject json1 =JObject.Parse(File.ReadAllText(jsonFile));
            if (json1["experiences"].FirstOrDefault(x => (string)x["companyid"] == companyId) == null )
            {
                Console.WriteLine("\nEnter Company Name : ");
                var companyName = Console.ReadLine();

                var newCompanyMember = "{ 'companyid': " + companyId + ", 'companyname': '" + companyName + "'}";
                try
                {
                    var json = File.ReadAllText(jsonFile);
                    var jsonObj = JObject.Parse(json);
                    var experienceArrary = jsonObj.GetValue("experiences") as JArray;
                    var newCompany = JObject.Parse(newCompanyMember);
                    experienceArrary.Add(newCompany);

                    jsonObj["experiences"] = experienceArrary;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, newJsonResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Add Error : " + ex.Message.ToString());
                }
            }
            else
                Console.WriteLine("Already used");
          
        }

        private void UpdateCompany()
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["experiences"];
                Console.Write("Enter Company ID to Update Company : ");
                var companyId = Convert.ToInt32(Console.ReadLine());

                if (companyId > 0)
                {
                    Console.Write("Enter new company name : ");
                    var companyName = Convert.ToString(Console.ReadLine());

                    foreach (var company in experiencesArrary.Where(obj => obj["companyid"].Value<int>() == companyId))
                    {
                        company["companyname"] = !string.IsNullOrEmpty(companyName) ? companyName : "";
                    }

                    jObject["experiences"] = experiencesArrary;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Company ID, Try Again!");
                    UpdateCompany();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }

        private void DeleteCompany()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["experiences"];
                Console.Write("Enter Company ID to Delete Company : ");
                var companyId = Convert.ToInt32(Console.ReadLine());

                if (companyId > 0)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["companyid"].Value<int>() == companyId);

                    experiencesArrary.Remove(companyToDeleted);

                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
                else
                {
                    Console.Write("Invalid Company ID, Try Again!");
                    UpdateCompany();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetUserDetails()
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    Console.WriteLine("ID :" + jObject["id"].ToString());
                    Console.WriteLine("Name :" + jObject["name"].ToString());

                    var address = jObject["address"];
                    Console.WriteLine("Street :" + address["street"].ToString());
                    Console.WriteLine("City :" + address["city"].ToString());
                    Console.WriteLine("Zipcode :" + address["zipcode"]);
                    JArray experiencesArrary = (JArray)jObject["experiences"];
                    if (experiencesArrary != null)
                    {
                        foreach (var item in experiencesArrary)
                        {
                            Console.WriteLine("company Id :" + item["companyid"]);
                            Console.WriteLine("company Name :" + item["companyname"].ToString());
                        }

                    }
                    Console.WriteLine("Phone Number :" + jObject["phoneNumber"].ToString());
                    Console.WriteLine("Role :" + jObject["role"].ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void Run()
        {
            TODo objProgram = new JsonAddAndUpdate.TODo();
            Menyu:
            Console.WriteLine("Choose Your Options : \n 1 - Add \n 2 - Update \n 3 - Delete \n 4 - Select \n");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    objProgram.AddCompany();
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;
                case "2":
                    objProgram.UpdateCompany();
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;
                case "3":
                    objProgram.DeleteCompany();
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Menyu;
                case "4":
                    objProgram.GetUserDetails();
                    Console.ReadKey();
                    Console.Clear();
                    goto Menyu;
                default:
                    break;
            }
            Console.ReadLine();

        }
    }
}