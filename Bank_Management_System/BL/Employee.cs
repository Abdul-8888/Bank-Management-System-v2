using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Management_System.DL;

namespace Bank_Management_System.BL
{
    public class Employee : Credential, iEmployee
    {
        private int workingHours;
        private string name;
        private int age;
        private float salary;

        public int WorkingHours { get => workingHours; set => workingHours = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public float Salary { get => salary; set => salary = value; }

        public Employee(string username, string password, string name, int age, float salary, int workingHours) : base(username, password)
        {
            Name = name;
            Age = age;
            Salary = salary;
            WorkingHours = workingHours;
        }

        public Employee(string username, string password, string name, int age, float salary) : base(username, password)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public float calculateBonus()
        {
            float bonus = 8 - WorkingHours;

            if (bonus > 0 && BankDL.Bank.isProfit())
            {
                bonus *= 100;
            }

            else
            {
                bonus = 0;
            }

            return bonus;
        }

        public double calculateSalary()
        {
            return (Salary + calculateBonus());
        }
    }

    interface iEmployee
    {
        float calculateBonus();
        double calculateSalary();
    }
}
