using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class WalletController
    {
        public double getUserBalance(string userName)
        {
            foreach (var user in Data.users)
            {
                if (user.data.login == userName)
                {
                    return user.wallet.createUserBalance(user.wallet.cards);
                }
            }
            return 0;
        }

        public object[] GetCardNumbers(UserController userController,int cardTypeIndex)
        {
            Card.CardType cardType = (Card.CardType)cardTypeIndex;
            User user = userController.user;
            List<object> result = new List<object>();
            foreach (var item in Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.cardNumbersInCardTypes)
            {
                if(item.Item1 == cardType)
                {
                    result.Add(item.Item2);
                }
            }
            return result.ToArray();
        }

        public void AddCard(UserController userController, int cardTypeIndex,string cardNumber,string pinCode)
        {
            if(IsCardExists(cardTypeIndex, cardNumber, pinCode))
            {
                User user = userController.user;
                Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.AddCard(GetCard(cardTypeIndex, cardNumber, pinCode));
            }
            else
            {
                throw new Exception();
            }
        }

        public bool IsCardExists(int cardTypeIndex, string cardNumber, string pinCode)
        {
            foreach (var card in Data.cards)
            {
                if(card.type.Equals((Card.CardType)cardTypeIndex) && card.cardNumber.Equals(cardNumber) && card.pinCode.Equals(pinCode))
                {
                    return true;
                }
            }
            return false;
        }

        public Card GetCard(int cardTypeIndex, string cardNumber, string pinCode)
        {
            foreach (var card in Data.cards)
            {
                if (card.type.Equals((Card.CardType)cardTypeIndex) && card.cardNumber.Equals(cardNumber) && card.pinCode.Equals(pinCode))
                {
                    return card;
                }
            }
            return null;
        }

        public void DeleteCard(UserController userController, int cardTypeIndex, string cardNumber)
        {
            User user = userController.user;
            Card.CardType cardType = (Card.CardType)cardTypeIndex;
            Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.DeleteCard(cardNumber, cardType);
        }

        public object[] GetCardTypes()
        {
            return Enum.GetNames(typeof(Card.CardType));
        }

        public double GetCardBalance(UserController userController,int cardTypeIndex,string cardNumber)
        {
            User user = userController.user;
            Card.CardType cardType = (Card.CardType)cardTypeIndex;
            return Data.users.First(u => u.data.login.Equals(user.data.login)).wallet.cards.First(c => (c.cardNumber.Equals(cardNumber) && c.type.Equals(cardType))).amount;
        }
    }
}
