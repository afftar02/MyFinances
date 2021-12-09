using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class IncomeController
    {
        public double GetIncome(UserController userController, int cardTypeIndex, string cardNumber)
        {
            User user = userController.user;
            Card.CardType cardType = (Card.CardType)cardTypeIndex;
            return Data.users.First(u => u.data.login.Equals(user.data.login)).income.GetIncome(cardType, cardNumber);
        }

        public void AddIncome(UserController userController, double amount, int cardTypeIndex,string cardNumber)
        {
            User user = userController.user;
            Card.CardType cardType = (Card.CardType)cardTypeIndex;
            Card card = Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.FindCard(cardNumber, cardType);
            Data.users.First(u => u.data.login.Equals(user.data.login)).income.AddIncome(amount, cardType, cardNumber,card);
            Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.cards.First(c => (c.cardNumber.Equals(cardNumber) && c.type.Equals(cardType))).AddMoney(amount);
            Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.balance += amount;
        }

        public void DecreaseIncome(UserController userController, double amount, int cardTypeIndex, string cardNumber)
        {
            User user = userController.user;
            Card.CardType cardType = (Card.CardType)cardTypeIndex;
            Data.users.First(u => u.data.login.Equals(user.data.login)).income.DecreaseIncome(amount, cardType, cardNumber);
            Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.cards.First(c => (c.cardNumber.Equals(cardNumber) && c.type.Equals(cardType))).DecreaseMoney(amount);
            Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.balance -= amount;
        }
    }
}
