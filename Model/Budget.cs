using Model;
using System;
using System.Collections.Generic;

namespace Kursach_3_Sem.Model
{
    [Serializable]
    public class Budget
    {
        /// <summary>
        /// бюджет на расходы
        /// </summary>
        public double limit { get; private set; }
        /// <summary>
        /// бюджет на каждую категорию расходов
        /// </summary>
        public Dictionary<Expenses.Category, double> limitsOfCategories { get; private set; } = new Dictionary<Expenses.Category, double>();

        public Budget() 
        {
            for(int i = 0; i < (Enum.GetNames(typeof(Expenses.Category))).Length; i++)
            {
                limitsOfCategories.Add((Expenses.Category)i, 0);
            }
        }

        public bool SetLimit(double limit)
        {
            if (limit < 0)
            {
                return false;
            }
            else if(limit < GetCategoryLimitsSum())
            {
                return false;
            }
            this.limit = limit;
            return true;
        }

        private double GetCategoryLimitsSum()
        {
            double result = 0;
            foreach (var item in limitsOfCategories)
            {
                result += item.Value;
            }
            return result;
        }

        public bool IsOverLimit(double expenses)
        {
            if(expenses > limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetLimitOfCategory(Expenses.Category category, double limit)
        {
            double limitsSum = 0;
            limitsOfCategories.TryGetValue(category, out double previousValue);
            limitsOfCategories[category] = limit;
            foreach (var item in limitsOfCategories.Values)
            {
                limitsSum += item;
            }
            if (limitsSum > this.limit)
            {
                limitsOfCategories[category] = previousValue;
                return false;
            }
            else if (limit < 0)
            {
                limitsOfCategories[category] = previousValue;
                return false;
            }
            return true;
        }

        public bool IsOverCategoryLimit(Expenses.Category category,double expenses)
        {
            if(expenses > limitsOfCategories[category])
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
