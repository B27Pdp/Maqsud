using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework
{
    internal class Operations
    {
        public void Start()
        {
            Console.WriteLine("Pul ayirboshlash");
            Console.WriteLine("Qaysi kartadan pul yechmoqchisiz");
            Card card1 = new Card(1, "Maqsud Haydarov", 1000_000, CardType.Uzcard);
            Card card2 = new Card(2, "Feruz Hamroyev", 1200_000, CardType.Humo);
            Card card3 = new Card(3, "Nasullaev Azizbek", 100_000, CardType.Visa);
            Card card4 = new Card(4, "Abbos Beshimov", 200_000, CardType.UnionPay);
            Card card11 = new Card(1, "Maqsud Haydarov2", 1000_000, CardType.Uzcard);
            Card card22 = new Card(2, "Feruz Hamroyev2", 1200_000, CardType.Humo);
            Card card33 = new Card(3, "Nasullaev Azizbek2", 100_000, CardType.Visa);
            Card card44 = new Card(4, "Abbos Beshimov2", 200_000, CardType.UnionPay);
            Console.WriteLine("<<Pul o'tkazmalar jarayoni");
            Console.WriteLine(" Here you can exchange your money from card to card. ");
            Console.WriteLine("from => \n 1=> UzCard \n 2=> Humo \n 3=> Visa \n 4=> UnionPay");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("to => \n 1=> UzCard \n 2=> Humo \n 3=> Visa \n 4=> UnionPay");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the amount of Money");
            int number3 = int.Parse(Console.ReadLine());
            Console.Clear();
            try
            {
                switch ((number1, number2))
                {
                    case (1, 1):
                        if (number3 <= card1.Balance)
                        {
                            card1.Balance -= number3;
                            card11.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;

                    case (1, 2):
                        if (number3 <= card1.Balance)
                        {
                            card1.Balance -= number3;
                            card2.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;

                    case (2, 1):
                        if (number3 <= card2.Balance)
                        {
                            card2.Balance -= number3;
                            card1.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (2, 2):
                        if (number3 <= card2.Balance)
                        {
                            card2.Balance -= number3;
                            card22.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (3, 4):
                        if (number3 <= card3.Balance)
                        {
                            card3.Balance -= number3;
                            card4.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (3, 3):
                        if (number3 <= card3.Balance)
                        {
                            card3.Balance -= number3;
                            card33.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (4, 3):
                        if (number3 <= card4.Balance)
                        {
                            card4.Balance -= number3;
                            card3.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (4, 4):
                        if (number3 <= card4.Balance)
                        {
                            card4.Balance -= number3;
                            card44.Balance += number3;
                        }
                        else throw new NotEnoughMoney();
                        break;
                    case (1, 3):
                    case (1, 4):
                    case (2, 3):
                    case (2, 4):
                    case (3, 1):
                    case (4, 1):
                    case (3, 2):
                    case (4, 2):
                        throw new CardTypeNotMatch();

                }

                Console.WriteLine("Muvofaqqiyatli o'tkazildi ");
            }

            catch (NotEnoughMoney e)
            {
                Console.WriteLine(e.Message);

            }
            catch (CardTypeNotMatch e)
            {
                Console.WriteLine(e.Message);

            }
        }




    }
}

