using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class DebtController
    {
        public List<Debt> GetDebts(UserController userController)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts;
        }

        public string GetCreditorName(UserController userController,Debt debt)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.id.Equals(debt.id)).First().nameOfCreditor;
        }

        public double GetDebtAmount(UserController userController,Debt debt)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.id.Equals(debt.id)).First().amount;
        }

        public double GetDebtAmount(UserController userController, string creditorName)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.nameOfCreditor.Equals(creditorName)).First().amount;
        }

        public string GetDebtDate(UserController userController,Debt debt)
        {
            User user = userController.user;
            Debt currentDebt = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.id.Equals(debt.id)).First();
            return (Convert.ToString(currentDebt.month) + "." + Convert.ToString(currentDebt.year));
        }

        public int GetDebtMonth(UserController userController, string creditorName)
        {
            User user = userController.user;
            Debt currentDebt = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.nameOfCreditor.Equals(creditorName)).First();
            return currentDebt.month;
        }

        public int GetDebtYear(UserController userController, string creditorName)
        {
            User user = userController.user;
            Debt currentDebt = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.nameOfCreditor.Equals(creditorName)).First();
            return currentDebt.year;
        }

        public void AddDebt(UserController userController,double amount,string creditorName,int month,int year)
        {
            User user = userController.user;
            Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Add(new Debt(amount, month, year, creditorName));
        }

        public bool RemoveDebt(UserController userController,string creditorName)
        {
            User user = userController.user;
            int id = FindDebt(user, creditorName);
            try
            {
                Debt debtToDelete = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Where(d => d.id.Equals(id)).First();
                Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.Remove(debtToDelete);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private int FindDebt(User user,string creditorName)
        {
            foreach (var item in Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts)
            {
                if(creditorName == item.nameOfCreditor)
                {
                    return item.id;
                }
            }
            return -1;
        }

        public bool ChangeDebt(UserController userController, double amount, string creditorName, int month, int year)
        {
            User user = userController.user;
            int index = Data.users.First(x => x.data.login.Equals(user.data.login)).debts.FindIndex(d => d.nameOfCreditor.Equals(creditorName));
            if(
            Data.users.First(x => x.data.login.Equals(user.data.login)).debts[index].ChangeDebtAmount(amount) &
            Data.users.First(x => x.data.login.Equals(user.data.login)).debts[index].ChangeDebtDate(month, year) &
            Data.users.First(x => x.data.login.Equals(user.data.login)).debts[index].ChangeDebtCreditorName(creditorName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCreditorNameExists(UserController userController,string creditorName)
        {
            User user = userController.user;
            foreach (var debt in Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts)
            {
                if(creditorName == debt.nameOfCreditor)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsOverDebrDate(UserController userController, string creditorName)
        { 
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.First(d => d.nameOfCreditor.Equals(creditorName)).IsOverDebtDate();
        }

        public bool IsYellowProgressBar(UserController userController, string creditorName)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().debts.First(d => d.nameOfCreditor.Equals(creditorName)).IsYellowProgressBar();
        }
    }
}
