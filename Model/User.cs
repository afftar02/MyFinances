using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Model;

namespace Kursach_3_Sem.Model
{
    [KnownType(typeof(Budget))]
    [KnownType(typeof(Card))]
    [KnownType(typeof(Debt))]
    [KnownType(typeof(Expenses))]
    [KnownType(typeof(Income))]
    [KnownType(typeof(Wallet))]
    [KnownType(typeof(UserData))]
    [Serializable]
    public class User
    {
        /// <summary>
        /// Бюджет
        /// </summary>
        public Budget budget { get; private set; }
        /// <summary>
        /// Долги
        /// </summary>
        public List<Debt> debts { get; private set; }
        /// <summary>
        /// Расходы
        /// </summary>
        public Expenses expenses { get; private set; }
        /// <summary>
        /// Доходы
        /// </summary>
        public Income income { get; private set; }
        /// <summary>
        /// Кошелек с картами
        /// </summary>
        public Wallet wallet { get; private set; }
        /// <summary>
        /// логин и пароль user
        /// </summary>
        public UserData data { get; private set; }

        public User(string login,string password)
        {
            budget = new Budget();
            debts = new List<Debt>();
            expenses = new Expenses();
            income = new Income();
            wallet = new Wallet();
            data = new UserData(login, password);
        }
    }
}
