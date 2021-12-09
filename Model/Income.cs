using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Model
{
    [Serializable]
    public class Income
    {
        /// <summary>
        /// Доходы
        /// </summary>
        public List<(Card, double)> incomes { get; private set; } = new List<(Card, double)>();

        public double GetIncome(Card.CardType cardType, string cardNumber)
        {
            foreach (var item in incomes)
            {
                if(item.Item1.type == cardType && item.Item1.cardNumber == cardNumber)
                {
                    return item.Item2;
                }
            }
            return 0;
        }

        public void AddIncome(double amount, Card.CardType cardType, string cardNumber, Card card)
        {
            if (amount <= 0)
            {
                throw new Exception();
            }
            for (int i=0;i< incomes.Count;i++)
            {
                if(incomes[i].Item1.type == cardType && incomes[i].Item1.cardNumber == cardNumber)
                {
                    double previous = incomes[i].Item2;
                    incomes.RemoveAt(i);
                    incomes.Add((card, (previous + amount)));
                    return;
                }
            }
            incomes.Add((card, amount));
        }

        public void DecreaseIncome(double amount, Card.CardType cardType, string cardNumber)
        {
            if (amount <= 0)
            {
                throw new Exception();
            }
            for (int i = 0; i < incomes.Count; i++)
            {
                if (incomes[i].Item1.type == cardType && incomes[i].Item1.cardNumber == cardNumber)
                {
                    double previous = incomes[i].Item2;
                    Card card = incomes[i].Item1;
                    incomes.RemoveAt(i);
                    incomes.Add((card, (previous - amount)));
                    return;
                }
            }
            throw new Exception();
        }
    }
}
