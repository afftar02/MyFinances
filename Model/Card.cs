using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Model
{
    [Serializable]
    public class Card
    {
        public enum CardType
        {
            Visa,
            MasterCard
        }
        /// <summary>
        /// Количество денег на карте
        /// </summary>
        public double amount { get; private set; } = 0;
        /// <summary>
        /// Номер карты
        /// </summary>
        public string cardNumber { get; private set; }
        public string pinCode { get; private set; }
        public CardType type { get; private set; }

        public Card(double amount,string cardNumber,string pinCode,CardType type)
        {
            this.amount = amount;
            this.cardNumber = cardNumber;
            this.pinCode = pinCode;
            this.type = type;
        }

        public Card(Card card) 
        {
            cardNumber = card.cardNumber;
            pinCode = card.pinCode;
            type = card.type;
        }

        public void AddMoney(double amount)
        {
            if (amount > 0)
            {
                this.amount += amount;
            }
            else
            {
                throw new Exception();
            }
        }

        public void DecreaseMoney(double amount)
        {
            if (this.amount >= amount && amount > 0)
            {
                this.amount -= amount;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
