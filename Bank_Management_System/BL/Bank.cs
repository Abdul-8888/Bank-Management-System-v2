using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System.BL
{
    class Bank : iBank
    {
        public double[] cashOut;
        public double[] cashIn;
        public string[] date;

        public Bank()
        {
            cashOut = new double[7];
            cashIn = new double[7];
            date = new string[7];
        }

        public void addBankData(double cashOut, double cashIn, string date, int count)
        {
            for (int i = count; i < 7; i++)
            {
                this.cashOut[i] = cashOut;
                this.cashIn[i] = cashIn;
                this.date[i] = date;
            }
        }

        public void compareDate()
        {
            string now = (DateTime.Today).ToString();
            string[] today = now.Split(' ');

            if (date[0] != today[0])
            {
                changesForToday(today[0]);
            }
        }

        public void changesForToday(string today)
        {
            for (int i = 5; i >= 0; i--)
            {
                this.cashOut[i + 1] = cashOut[i];
                this.cashIn[i + 1] = this.cashIn[i];
                this.date[i + 1] = this.date[i];
            }

            cashOut[0] = 0;
            cashIn[0] = 0;
            date[0] = today;
        }

        public double calculateProfitLoss()
        {
            double amount = 0;
            bool flag = isProfit();

            if (!flag)
            {
                amount = (cashOut[0] - cashIn[0]);
            }

            else if (flag)
            {
                amount = (cashIn[0] - cashOut[0]);
            }

            return amount;
        }

        public bool isProfit()
        {
            if (cashIn[0] > cashOut[0])
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    interface iBank
    {
        void compareDate();
        void addBankData(double cashOut, double cashIn, string date, int count);
        double calculateProfitLoss();
        bool isProfit();
        void changesForToday(string today);
    }
}
