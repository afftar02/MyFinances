using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Model
{
    [Serializable]
    public class Wallet
    {
        /// <summary>
        /// Сопоставление типов карт с их номерами
        /// </summary>
        public List<(Card.CardType, string)> cardNumbersInCardTypes { get; private set; } = new List<(Card.CardType, string)>();
        public List<Card> cards { get; private set; } = new List<Card>();

        public double balance { get; set; } = 0;

        public double createUserBalance(List<Card> cards)
        {
            balance = 0;
            foreach (var card in cards)
            {
                balance += card.amount;
            }
            return balance;
        }

        public void AddCard(Card card)
        {
            if (card != null)
            {
                cards.Add(card);
                balance += card.amount;
                cardNumbersInCardTypes.Add((card.type, card.cardNumber));
            }
            else
            {
                throw new Exception();
            }
        }

        public void DeleteCard(string cardNumber,Card.CardType cardType)
        {
            try
            {
                if (cards.Find(x => (x.cardNumber.Equals(cardNumber) && x.type.Equals(cardType))) != null)
                {
                    balance -= cards.Find(x => (x.cardNumber.Equals(cardNumber) && x.type.Equals(cardType))).amount;
                    cards.Remove(cards.Find(x => (x.cardNumber.Equals(cardNumber) && x.type.Equals(cardType))));
                    cardNumbersInCardTypes.Remove((cardType, cardNumber));
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public Card FindCard(string cardNumber, Card.CardType cardType)
        {
            try
            {
                foreach (var card in cards)
                {
                    if(card.cardNumber == cardNumber && card.type == cardType)
                    {
                        return card;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            return null;
        }
    }
}
