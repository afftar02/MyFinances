using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class BudgetController
    {
        public bool SetNewAllBudget(UserController userController,double value)
        {
            User user = userController.user;
            if(Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.SetLimit(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object[] GetAllCategories()
        {
            return Enum.GetNames(typeof(Expenses.Category));
        }

        public bool SetNewCategoryBudget(UserController userController, double value,int index)
        {
            User user = userController.user;
            if (Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.SetLimitOfCategory((Expenses.Category)index, value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetAllBudget(UserController userController)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limit;
        }

        public (string,double) GetCategoryBudget(UserController userController,int index)
        {
            Expenses.Category category = (Expenses.Category)index;
            string strCategory = Enum.GetName(typeof(Expenses.Category), index);

            User user = userController.user;
            double categoryBudget = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limitsOfCategories[category];

            return (strCategory, categoryBudget);
        }
    }
}
