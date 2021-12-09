using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class DataController
    {
        public void Save()
        {
            Data.Serialize();
        }

        public void Read()
        {
            Data.Deserialize();
        }

        public static void CreateCards()
        {
            /*Card card1 = new Card(amount: 0, cardNumber: "1111 2222 3333 4444", pinCode: "1111", type: Card.CardType.MasterCard);
            Card card2 = new Card(amount: 50, cardNumber: "4000 3000 2000 1000", pinCode: "9999", type: Card.CardType.Visa);
            Card card3 = new Card(amount: 180, cardNumber: "1010 2020 3030 4040", pinCode: "1234", type: Card.CardType.MasterCard);
            Card card4 = new Card(amount: 11, cardNumber: "5555 6666 7777 8888", pinCode: "9876", type: Card.CardType.Visa);
            Card card5 = new Card(amount: 38, cardNumber: "5005 6006 7007 8008", pinCode: "0000", type: Card.CardType.Visa);
            Data.cards.Add(card1);
            Data.cards.Add(card2);
            Data.cards.Add(card3);
            Data.cards.Add(card4);
            Data.cards.Add(card5);*/
        }
    }
}
