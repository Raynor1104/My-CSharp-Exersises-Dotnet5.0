using System;
using System.Collections.Generic;

namespace Exersise7_W3
{
    class Management
    {
        private List<Employee> EmployeeList;

        public Management()
        {
            EmployeeList = new List<Employee>();
        }

        private int GenerateID()
        {
            int max = 1;
            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                max = EmployeeList[0].Id;
                foreach (Employee employee in EmployeeList)
                {
                    if (max < employee.Id)
                    {
                        max = employee.Id;
                    }
                }
                max++;
            }
            return max;
        }

        public int EmployeeAmount()
        {
            int count = 0;
            if (EmployeeList != null)
            {
                count = EmployeeList.Count;
            }
            return count;
        }

        public void EnterEmployee()
        {
            Employee employee = new Employee();

            employee.Id = GenerateID();

            Console.Write("Enter first name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            employee.LastName = Console.ReadLine();

            Console.Write("Enter gender: ");
            employee.Sex = Console.ReadLine();

            Console.Write("Birth day: ");
            employee.BirthDay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Birth Month: ");
            employee.BirthMonth = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Birth year: ");
            employee.BirthYear = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Level: ");
            employee.Level = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Basic salary: ");
            employee.BasicSalary = Convert.ToInt32(Console.ReadLine());

            GetDOB(employee);
            GetFullName(employee);
            GetSalary(employee);

            EmployeeList.Add(employee);
        }

        public List<Employee> GetByID(int searchID)
        {
            List<Employee> searchResult = new List<Employee>();
            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                foreach (Employee employee in EmployeeList)
                {
                    if (employee.Id == searchID)
                    {
                        searchResult.Add(employee);
                    }
                }
            }
            return searchResult;
        }
        
        public void EditEmployee(int id)
        {
            Employee? emp = FindById(id);

            if (emp != null)
            {
                while(true)
                {
                    Console.WriteLine("\n1. First name");
                    Console.WriteLine("2. Last name");
                    Console.WriteLine("3. Sex");
                    Console.WriteLine("4. birth day");
                    Console.WriteLine("5. birth month");
                    Console.WriteLine("6. birth year");
                    Console.WriteLine("7. birth level");
                    Console.WriteLine("8. basic salary");
                    Console.WriteLine("0. Exit");
                    Console.Write("Choose an option to edit: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            Console.Write("Enter First name to edit: ");
                            string? edit_firstName = Console.ReadLine();
                            if (edit_firstName != null && edit_firstName.Length > 0)
                            {
                                emp.FirstName = edit_firstName;
                            }
                            break;
                        case 2:
                            Console.Write("Enter Last name to edit: ");
                            string? edit_lastName = Console.ReadLine();
                            if (edit_lastName != null && edit_lastName.Length > 0)
                            {
                                emp.LastName = edit_lastName;
                            }
                            break;
                        case 3:
                            Console.Write("Enter Sex to edit: ");
                            string? edit_sex = Console.ReadLine();
                            if (edit_sex != null && edit_sex.Length > 0)
                            {
                                emp.Sex = edit_sex;
                            }
                            break;
                        case 4:
                            Console.Write("Enter birth day to edit: ");
                            string? edit_birthDayStr = Console.ReadLine();
                            if (edit_birthDayStr != null && edit_birthDayStr.Length > 0)
                            {
                                emp.BirthDay = Convert.ToInt32(edit_birthDayStr);
                            }
                            break;
                        case 5:
                            Console.Write("Enter birth month to edit: ");
                            string? edit_birthmonthStr = Console.ReadLine();
                            if (edit_birthmonthStr != null && edit_birthmonthStr.Length > 0)
                            {
                                emp.BirthMonth = Convert.ToInt32(edit_birthmonthStr);
                            }
                            break;
                        case 6:
                            Console.Write("Enter birth year to edit: ");
                            string? edit_birthYearStr = Console.ReadLine();
                            if (edit_birthYearStr != null && edit_birthYearStr.Length > 0)
                            {
                                emp.BirthYear = Convert.ToInt32(edit_birthYearStr);
                            }
                            break;
                        case 7:
                            Console.Write("Enter level to edit: ");
                            string? edit_levelStr = Console.ReadLine();
                            if (edit_levelStr != null && edit_levelStr.Length > 0)
                            {
                                emp.Level = Convert.ToInt32(edit_levelStr);
                            }
                            break;
                        case 8:
                            Console.Write("Enter basic salary to edit: ");
                            string? edit_basicSalaryStr = Console.ReadLine();
                            if (edit_basicSalaryStr != null && edit_basicSalaryStr.Length > 0)
                            {
                                emp.BasicSalary = Convert.ToInt32(edit_basicSalaryStr);
                            }
                            break;
                        case 0:
                            Console.WriteLine("Edit complete.");
                            return;
                        default:
                            Console.WriteLine("Option not available");
                            break;
                    }
                    GetDOB(emp);
                }
            }
        }

        public bool RemoveById(int id)
        {
            bool isDeleted = false;
            Employee? employee = FindById(id);
            if (employee != null)
            {
                isDeleted = EmployeeList.Remove(employee);
            }
            return isDeleted;
        }

        public List<Employee> GetByFullName(string? fullName)
        {
            List<Employee> searchResult = new List<Employee>();
            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                foreach (Employee employee in EmployeeList)
                {
                    if (employee.FullName == fullName)
                    {
                        searchResult.Add(employee);
                    }
                }
            }
            return searchResult;
        }

        public void SoftBySalary()
        {
            EmployeeList.Sort(delegate (Employee employee1, Employee employee2) {
                return employee1.Salary.CompareTo(employee2.Salary);
            });
        }

        public Employee? FindById(int id)
        {
            Employee? searchResult = null;
            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                foreach (Employee employee in EmployeeList)
                {
                    if (employee.Id == id)
                    {
                        searchResult = employee;
                    }
                }
            }
            return searchResult;
        }

        private void GetDOB(Employee employee)
        {
            employee.DOB = $"{employee.BirthDay}/{employee.BirthMonth}/{employee.BirthYear}";
        }

        private void GetFullName(Employee employee)
        {
            employee.FullName = $"{employee.FirstName} {employee.LastName}";
        }

        private void GetSalary(Employee employee)
        {
            employee.Salary = employee.Level * employee.BasicSalary;
        }

        public void ShowEmployeeList(List<Employee> EmployeeList)
        {
            Console.WriteLine("{0, -5} {1, 10} {2, 10} {3, 5} {4, 7} {5, 12} {6, 12} {7, 9}",
            "ID", "FirstName", "LastName", "Sex", "DOB", "Level", "Basicsalary", "Salary");

            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                foreach (Employee employee in EmployeeList)
                {
                    Console.WriteLine("{0, -5} {1, 5} {2, 10} {3, 11} {4, 11} {5, 4} {6, 9} {7, 15}", 
                    employee.Id, employee.FirstName, employee.LastName, employee.Sex, employee.DOB, employee.Level, employee.BasicSalary, employee.Salary);
                }
            }
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeList;
        }
    }
}
