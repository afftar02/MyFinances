using Kursach_3_Sem.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Controller
{
    public class ExpensesController
    {
        public int[] GetExpensesCategories()
        {
            return (int[])Enum.GetValues(typeof(Expenses.Category));
        }

        public string GetCategory(int index)
        {
            return Enum.GetNames(typeof(Expenses.Category))[index];
        }

        public object[] GetCategories()
        {
            return Enum.GetNames(typeof(Expenses.Category));
        }

        public double GetExpenseAmount(UserController userController,int categoryIndex)
        {
            Expenses.Category category = (Expenses.Category)categoryIndex;
            User user = userController.user;
            Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.expensesOfCategories.TryGetValue(category, out double value);
            return value;
        }

        public void ChangeExpenseOfCategory(UserController userController,string expenseValue,int categoryIndex)
        {
            User user = userController.user;
            double value = Convert.ToDouble(expenseValue);
            Expenses.Category category = (Expenses.Category)categoryIndex;
            Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.ChangeExpenseOfCategory(category, value);
        }

        public void AddExpense(UserController userController,int categoryIndex,double value)
        {
            User user = userController.user;
            Expenses.Category category = (Expenses.Category)categoryIndex;
            Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.AddExpensesOfCategory(category, value);
        }

        public double GetAllExpenses(UserController userController)
        {
            User user = userController.user;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.expenses;
        }

        public bool IsOverCategoryBudget(UserController userController,int indexCategory)
        {
            User user = userController.user;
            Expenses.Category category = (Expenses.Category)indexCategory;
            double categoryLimit = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limitsOfCategories[category];
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.IsOverCategoryBudget(categoryLimit, category);
        }

        public bool IsYellowProgressBar(UserController userController, int indexCategory)
        {
            User user = userController.user;
            Expenses.Category category = (Expenses.Category)indexCategory;
            double categoryLimit = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limitsOfCategories[category];
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.IsYellowProgressBar(categoryLimit, category);
        }

        public bool IsOrangeProgressBar(UserController userController, int indexCategory)
        {
            User user = userController.user;
            Expenses.Category category = (Expenses.Category)indexCategory;
            double categoryLimit = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limitsOfCategories[category];
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.IsOrangeProgressBar(categoryLimit, category);
        }

        public bool IsOverAllBudget(UserController userController)
        {
            User user = userController.user;
            double limit = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limit;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.IsOverAllBudget(limit);
        }

        public bool IsOrangeProgressBar(UserController userController)
        {
            User user = userController.user;
            double limit = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limit;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.IsOrangeAllBudget(limit);
        }

        public bool IsYellowProgressBar(UserController userController)
        {
            User user = userController.user;
            double limit = Data.users.Where(x => x.data.login.Equals(user.data.login)).First().budget.limit;
            return Data.users.Where(x => x.data.login.Equals(user.data.login)).First().expenses.IsYellowProgressBar(limit);
        }
    }
}
