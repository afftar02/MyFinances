using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Model
{
    [Serializable]
    public class Expenses
    {
        /// <summary>
        /// Категории расходов
        /// </summary>
        public enum Category
        {
            Transport,
            Products,
            Clothes,
            Accounts,
            Journeys,
            Entertainment,
            Technics,
            Health,
            Study,
            House,
            Sport,
            Gifts,
            Restaurant,
            Debts,
            Other
        }
        /// <summary>
        /// Общие расходы
        /// </summary>
        public double expenses { get; private set; }
        /// <summary>
        /// Расходы на каждую категорию
        /// </summary>
        public Dictionary<Category, double> expensesOfCategories { get; private set; } = new Dictionary<Category, double>();

        public Expenses()
        {
            expenses = 0;
            int i = 0;
            do
            {
                expensesOfCategories.Add((Category)i, 0);
                i++;
            } while (i < Enum.GetNames(typeof(Category)).Length);
        }

        public void AddExpensesOfCategory(Category category,double amount)
        {
            if (amount < 0)
            {
                throw new Exception();
            }
            expensesOfCategories[category] += amount;
            expenses += amount;
        }

        public void ChangeExpenseOfCategory(Category category,double amount)
        {
            if (amount < 0)
            {
                throw new Exception();
            }
            double previousAmount = expensesOfCategories[category];
            expensesOfCategories[category] = amount;
            expenses -= previousAmount;
            expenses += amount;
        }

        public bool IsOverCategoryBudget(double categoryLimit,Expenses.Category category)
        {
            if(expensesOfCategories[category] > categoryLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOrangeProgressBar(double categoryLimit, Expenses.Category category)
        {
            if (expensesOfCategories[category] == categoryLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsYellowProgressBar(double categoryLimit,Expenses.Category category)
        {
            if((expensesOfCategories[category]*100)/categoryLimit >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOverAllBudget(double limit)
        {
            if (expenses > limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOrangeAllBudget(double limit)
        {
            if (expenses == limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsYellowProgressBar(double limit)
        {
            if ((expenses * 100) / limit >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
