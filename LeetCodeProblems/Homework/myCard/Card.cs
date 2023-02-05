using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Homework
{
    internal class Card
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public double Balance { get; set; }
        public CardType CardType { get; set; }

        public Card(int id, string owner, double balance, CardType cardType)
        {
            Id = id;
            Owner = owner;
            Balance = balance;
            CardType = cardType;
        }

    }
    enum CardType
    {
        Uzcard,
        Humo,
        Visa,
        UnionPay
    }
    class CardTypeNotMatch : SystemException
    {
        public override string Message { get; } = "Kartalar mos emas ";

    }
    class NotEnoughMoney : SystemException
    {
        public override string Message { get; } = "Pul yetarli emas ";

    }

}