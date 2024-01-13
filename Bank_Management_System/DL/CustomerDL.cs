using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Management_System.BL;

namespace Bank_Management_System.DL
{
    class CustomerDL
    {
        internal static List<Customer> allCustomers = new List<Customer>();

        public static bool addCustomerInList(Customer c)
        {
            bool flag = true;

            foreach (Customer cus in allCustomers)
            {
                if (c.Username == cus.Username && c.Password == cus.Password)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                allCustomers.Add(c);
            }

            return flag;
        }

        public static bool customerExist(string username, string password)
        {
            foreach (Customer c in allCustomers)
            {
                if (c.Username == username && c.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public static void deleteCustomer(string username)
        {
            foreach (Customer cus in allCustomers)
            {
                if (cus.Username == username)
                {
                    allCustomers.Remove(cus);
                    break;
                }
            }
        }

        public static bool customerExist(string username)
        {
            foreach (Customer c in allCustomers)
            {
                if (c.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public static Customer getCustomer(string username, string password)
        {
            foreach (Customer c in allCustomers)
            {
                if (c.Username == username && c.Password == password)
                {
                    return c;
                }
            }

            return null;
        }

        public static Customer getCustomer(string username)
        {
            foreach (Customer c in allCustomers)
            {
                if (c.Username == username)
                {
                    return c;
                }
            }

            return null;
        }

        public static List<Customer> getCustomerList()
        {
            return allCustomers;
        }

        public static Customer getHighest()
        {
            double highest = allCustomers[0].AccountBalance;
            Customer Highest = allCustomers[0];

            for(int i = 0; i < allCustomers.Count; i++)
            {
                if(allCustomers[i].AccountBalance > highest)
                {
                    highest = allCustomers[i].AccountBalance;
                    Highest = allCustomers[i];
                }
            }
            Highest.Highest = true;
            return Highest;
        }

        public static void loadCustomers()
        {
            string path = "Customers.txt";
            string username;
            string password;
            string name;
            double accountBalance;

            StreamReader file = new StreamReader(path);
            string record;

            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] line = record.Split(',');
                    username = line[0];
                    password = line[1];
                    name = line[2];
                    accountBalance = double.Parse(line[3]);

                    Customer c = new Customer(username, password, name, accountBalance);

                    addCustomerInList(c);
                }
            }

            file.Close();
        }

        public static void storeCustomer()
        {
            string path = "Customers.txt";
            StreamWriter file = new StreamWriter(path, false);

            foreach (Customer c in allCustomers)
            {
                file.WriteLine(c.Username + "," + c.Password + "," + c.Name + "," + c.AccountBalance);
            }

            file.Flush();
            file.Close();
        }

        public static void swap( int c1, int c2 )
        {
            Customer temp = allCustomers[c1];
            allCustomers[c1] = allCustomers[c2];
            allCustomers[c2] = temp;
        }

        public static void bubbleSort()
        {
            for (int x = 0; x < allCustomers.Count - 1; x++)
            {
                bool isSwapped = false;
                for (int y = 0; y < allCustomers.Count - x - 1; y++)
                {
                    if (allCustomers[y].AccountBalance > allCustomers[y + 1].AccountBalance)
                    {
                        swap(y, y+1);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
        }
    }
}
