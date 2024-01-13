using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Management_System.BL;

namespace Bank_Management_System.DL
{
    class EmployeeDL
    {
        internal static List<Employee> allEmployees = new List<Employee>();

        public static bool addEmployeeInList(Employee e)
        {
            bool flag = true;

            foreach (Employee emp in allEmployees)
            {
                if (e.Username == emp.Username && e.Password == emp.Password)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                allEmployees.Add(e);
            }

            return flag;
        }

        public static void fireEmployee(Employee e)
        {
            
             allEmployees.Remove(e);
        }

        public static List<Employee> getEmployeeList()
        {
            return allEmployees;
        }

        public static bool employeeExist(string username)
        {
            foreach (Employee e in allEmployees)
            {
                if (e.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public static Employee getEmployee(string username, string password)
        {
            foreach (Employee e in allEmployees)
            {
                if (e.Username == username && e.Password == password)
                {
                    return e;
                }
            }

            return null;
        }

        public static Employee getEmployee(string username)
        {
            foreach (Employee e in allEmployees)
            {
                if (e.Username == username)
                {
                    return e;
                }
            }

            return null;
        }

        public static Employee getEmployee(string username, string password, bool flag)
        {
            if (allEmployees[0].Username == username && allEmployees[0].Password == password)
            {
                return allEmployees[0];
            }

            return null;
        }

        public static void loadEmployees()
        {
            string path = "Employees.txt";
            string username;
            string password;
            string name;
            int age;
            float salary;
            int workingHours;

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
                    age = int.Parse(line[3]);
                    salary = float.Parse(line[4]);
                    workingHours = int.Parse(line[5]);

                    Employee e = new Employee(username, password, name, age, salary, workingHours);
                    
                    addEmployeeInList(e);
                }
            }

            file.Close();
        }

        public static void storeEmployee()
        {
            string path = "Employees.txt";
            StreamWriter file = new StreamWriter(path, false);

            foreach (Employee e in allEmployees)
            {
                file.WriteLine(e.Username + "," + e.Password + "," + e.Name + "," + e.Age + "," + e.Salary + "," + e.WorkingHours);
            }

            file.Flush();
            file.Close();
        }

        public static void swap(int c1, int c2)
        {
            Employee temp = allEmployees[c1];
            allEmployees[c1] = allEmployees[c2];
            allEmployees[c2] = temp;
        }

        public static void bubbleSort()
        {
            for (int x = 0; x < allEmployees.Count - 1; x++)
            {
                bool isSwapped = false;
                for (int y = 0; y < allEmployees.Count - x - 1; y++)
                {
                    if (allEmployees[y].WorkingHours > allEmployees[y + 1].WorkingHours)
                    {
                        swap(y, y + 1);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
        }

        public static void selectionSort()
        {
            for (int x = 0; x < allEmployees.Count - 1; x++)
            {
                int minIndex = findMinimum(x, allEmployees.Count);
                swap(x, minIndex);
            }
        }

        public static int findMinimum(int start, int end)
        {
            Employee min = allEmployees[start];
            int minIndex = start;
            for (int x = start; x < end; x++)
            {
                if (min.WorkingHours > allEmployees[x].WorkingHours)
                {
                    min = allEmployees[x];
                    minIndex = x;
                }
            }
            return minIndex;
        }

        public static void insertionSort()
        {
            for (int x = 1; x < allEmployees.Count; x++)
            {
                Employee key = allEmployees[x];
                int y = x - 1;
                while (y >= 0 && allEmployees[y].WorkingHours > key.WorkingHours)
                {
                    allEmployees[y + 1] = allEmployees[y];
                    y--;
                }
                allEmployees[y + 1] = key;
            }
        }

        public static void mergeSort(int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(start, mid);
                mergeSort(mid + 1, end);
                merge(start, mid, end);
            }
        }

        public static void merge(int start, int mid, int end)
        {
            int i = start;
            int j = mid + 1;
            Queue<Employee> tempArr = new Queue<Employee>();
            while (i <= mid && j <= end)
            {
                if (allEmployees[i].WorkingHours < allEmployees[j].WorkingHours)
                {
                    tempArr.Enqueue(allEmployees[i]);
                    i++;
                }
                else
                {
                    tempArr.Enqueue(allEmployees[j]);
                    j++;
                }
            }
            while (i <= mid)
            {
                tempArr.Enqueue(allEmployees[i]);
                i++;
            }
            while (j <= end)
            {
                tempArr.Enqueue(allEmployees[j]);
                j++;
            }
            for (int x = start; x <= end; x++)
            {
                allEmployees[x] = tempArr.Dequeue();
            }
        }

        public static void quickSort(int start, int end)
        {
            if (start >= end)
                return;

            int p = partition(start, end);
            quickSort(start, p - 1);
            quickSort(p + 1, end);
        }

        public static int partition(int start, int end)
        {

            int pivot = allEmployees[start].WorkingHours;

            int count = 0;
            int x = 0;
            for (x = start + 1; x <= end; x++)
            {
                if (allEmployees[x].WorkingHours <= pivot)
                    count++;
            }
            int pivotIndex = start + count;
            swap(pivotIndex, start);
            int i = start, j = end;

            while (i < pivotIndex && j > pivotIndex)
            {
                while (allEmployees[i].WorkingHours <= pivot)
                {
                    i++;
                }
                while (allEmployees[j].WorkingHours > pivot)
                {
                    j--;
                }
                if (i < pivotIndex && j > pivotIndex)
                {
                    swap(i++, j--);
                }
            }

            return pivotIndex;
        }


        public static void heapSort()
        {
            for (int x = (allEmployees.Count / 2) - 1; x >= 0; x--)
            {
                heapify(allEmployees.Count ,x);
            }
            for (int x = allEmployees.Count - 1; x > 0; x--)
            {
                swap(0,x);
                heapify(x,0);
            }
        }

        public static void heapify( int size, int index)
        {
            int maxIndex;
            while (true)
            {
                int lIdx = leftChildIndex(index);
                int rIdx = rightChildIndex(index);
                if (rIdx >= size)
                {
                    if (lIdx >= size)
                        return;
                    else
                        maxIndex = lIdx;
                }
                else
                {
                    if (allEmployees[lIdx].WorkingHours >= allEmployees[rIdx].WorkingHours)
                        maxIndex = lIdx;
                    else
                        maxIndex = rIdx;
                }
                if (allEmployees[index].WorkingHours < allEmployees[maxIndex].WorkingHours)
                {
                    swap(index, maxIndex);
                    index = maxIndex;
                }
                else
                    return;
            }
        }

        public static int parentIndex(int i)
        {
            return (i - 1) / 2;
        }
        public static int leftChildIndex(int i)
        {
            return (2 * i) + 1;
        }
        public static int rightChildIndex(int i)
        {
            return (2 * i) + 2;
        }

        public static void countingSort()
        {
            int max = maxElement();
            List<int> count = new List<int>( new int[max + 1]);
            List<Employee> output = new List<Employee>( new Employee[allEmployees.Count]);

            for (int i = 0; i < count.Count; i++)
            {
                count[i] = 0;
            }
            for (int x = 0; x < allEmployees.Count; x++)
            {
                count[allEmployees[x].WorkingHours]++;
            }
            for (int x = 1; x < count.Count; x++)
            {
                count[x] = count[x - 1] + count[x];
            }
            for (int x = allEmployees.Count - 1; x >= 0; x--)
            {
                int index = count[allEmployees[x].WorkingHours] - 1;
                count[allEmployees[x].WorkingHours]--;
                output[index] = allEmployees[x];
            }
            for (int x = 0; x < output.Count; x++)
            {
                allEmployees[x] = output[x];
            }
        }

        public static int maxElement()
        {
            Employee temp = allEmployees[0];
            int idx = 0;

            for (int i = 0; i < allEmployees.Count; i++)
            {
                if (allEmployees[i].WorkingHours > temp.WorkingHours)
                {
                    temp = allEmployees[i];
                    idx = i;
                }
            }

            return allEmployees[idx].WorkingHours;
        }

        public static void radixSort()
        {
            int max = maxElement();
            int place = 1;
            while ((max / place) > 0)
            {
                countingSort(place);
                place = place * 10;
            }
        }

        public static void countingSort(int place)
        {
            List<int> count = new List<int>(new int[10]);
            List<Employee> output = new List<Employee>( new Employee[allEmployees.Count]);

            for (int x = 0; x < allEmployees.Count; x++)
            {
                count[(allEmployees[x].WorkingHours / place) % 10]++;
            }
            for (int x = 1; x < count.Count; x++)
            {
                count[x] = count[x - 1] + count[x];
            }
            for (int x = allEmployees.Count - 1; x >= 0; x--)
            {
                int index = count[(allEmployees[x].WorkingHours / place) % 10] - 1;
                count[(allEmployees[x].WorkingHours / place) % 10]--;
                output[index] = allEmployees[x];
            }
            for (int x = 0; x < output.Count; x++)
            {
                allEmployees[x] = output[x];
            }
        }

        public static void bucketSort()
        {

            int minValue = allEmployees[0].WorkingHours;
            int maxValue = allEmployees[0].WorkingHours;

            for (int i = 1; i < allEmployees.Count; i++)
            {
                if (allEmployees[i].WorkingHours > maxValue)
                    maxValue = allEmployees[i].WorkingHours;
                if (allEmployees[i].WorkingHours < minValue)
                    minValue = allEmployees[i].WorkingHours;
            }

            List<Employee>[] bucket = new List<Employee>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<Employee>();
            }

            for (int i = 0; i < allEmployees.Count; i++)
            {
                bucket[allEmployees[i].WorkingHours - minValue].Add(allEmployees[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        allEmployees[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }
    }
}
