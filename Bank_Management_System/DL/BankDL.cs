using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Management_System.BL;

namespace Bank_Management_System.DL
{
    class BankDL
    {
        static Bank bank;

        internal static Bank Bank { get => bank; set => bank = value; }

        public static void loadBank()
        {
            bank = new Bank();

            string path = "Bank.txt";
            double cash_in = 0;
            double cash_out = 0;
            string date = "";
            int count = 0;

            StreamReader file = new StreamReader(path);
            string record;

            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] line = record.Split(',');
                    cash_in = double.Parse(line[0]);
                    cash_out = double.Parse(line[1]);
                    date = line[2];

                    Bank.addBankData(cash_in, cash_out, date, count);
                    count++;
                }
            }


            file.Close();
        }

        public static void storeBank()
        {
            string path = "Bank.txt";
            StreamWriter file = new StreamWriter(path,false);

            for(int i = 0; i < 7; i++)
            {
                file.WriteLine(bank.cashIn[0] + "," + bank.cashOut[0] + "," + bank.date[0]);
            }

            file.Flush();
            file.Close();
        }
    }
}
