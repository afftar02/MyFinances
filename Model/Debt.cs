using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach_3_Sem.Model
{
    [Serializable]
    public class Debt
    {
        public int id { get; private set; }
        /// <summary>
        /// Счетчик для id
        /// </summary>
        public static int idCounter { get; private set; } = 0;
        /// <summary>
        /// Размер долга
        /// </summary>
        public double amount { get; private set; }
        /// <summary>
        /// До какого месяца
        /// </summary>
        public int month { get; private set; }
        /// <summary>
        /// До какого года
        /// </summary>
        public int year { get; private set; }
        /// <summary>
        /// Имя кредитора
        /// </summary>
        public string nameOfCreditor { get; private set; }

        public Debt(double amount,int month,int year,string name)
        {
            if (!IsRightDate(month, year))
            {
                throw new Exception();
            }
            else if (amount <= 0)
            {
                throw new Exception();
            }
            else if (string.Empty.Equals(name))
            {
                throw new Exception();
            }
            else
            {
                this.amount = amount;
                this.month = month;
                this.year = year;
                nameOfCreditor = name;
                id = idCounter++;
            }
        }

        public bool ChangeDebtCreditorName(string newName)
        {
            if (string.Empty.Equals(newName))
            {
                return false;
            }
            nameOfCreditor = newName;
            return true;
        }

        public bool ChangeDebtAmount(double newAmount)
        {
            if(newAmount <= 0)
            {
                return false;
            }
            amount = newAmount;
            return true;
        }

        public bool ChangeDebtDate(int month,int year)
        {
            if (!IsRightDate(month, year))
            {
                return false;
            }
            this.month = month;
            this.year = year;
            return true;
        }

        public bool IsRightDate(int month,int year)
        {
            if (year < DateTime.Now.Year || (year.ToString().Length > 4))
            {
                return false;
            }
            else if (DateTime.Now.Year.Equals(year))
            {
                if (month < DateTime.Now.Month)
                {
                    return false;
                }
            }
            else if (!(month >= 1 && month <= 12))
            {
                return false;
            }
            return true;
        }

        public bool IsOverDebtDate()
        {
            if(year < DateTime.Now.Year || (year == DateTime.Now.Year && month < DateTime.Now.Month))
            {
                return true;
            }
            return false;
        }

        public bool IsYellowProgressBar()
        {
            if (year == DateTime.Now.Year && month == DateTime.Now.Month)
            {
                return true;
            }
            return false;
        }
    }
}
