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
            Employee? employee = FindById(id);
            if (employee != null)
            {
                Console.Write("Enter First name to edit: ");
                string? edit_firstName = Console.ReadLine();
                if (edit_firstName != null && edit_firstName.Length > 0)
                {
                    employee.FirstName = edit_firstName;
                }

                Console.Write("Enter Last name to edit: ");
                string? edit_lastName = Console.ReadLine();
                if (edit_lastName != null && edit_lastName.Length > 0)
                {
                    employee.LastName = edit_lastName;
                }

                Console.Write("Enter Sex to edit: ");
                string? edit_sex = Console.ReadLine();
                if (edit_sex != null && edit_sex.Length > 0)
                {
                    employee.Sex = edit_sex;
                }

                Console.Write("Enter birth day to edit: ");
                string? edit_birthDay = Console.ReadLine();
                if (edit_birthDay != null && edit_birthDay.Length > 0)
                {
                    employee.BirthDay = Convert.ToInt32(edit_birthDay);
                }

                Console.Write("Enter birth month to edit: ");
                string? edit_birthMonth = Console.ReadLine();
                if (edit_birthMonth != null && edit_birthMonth.Length > 0)
                {
                    employee.BirthMonth = Convert.ToInt32(edit_birthMonth);
                }

                Console.Write("Enter birth year to edit: ");
                string? edit_birthYear = Console.ReadLine();
                if (edit_birthYear != null && edit_birthYear.Length > 0)
                {
                    employee.BirthYear = Convert.ToInt32(edit_birthYear);
                }

                Console.Write("Enter level to edit: ");
                string? edit_level = Console.ReadLine();
                if (edit_level != null && edit_level.Length > 0)
                {
                    employee.Level = Convert.ToInt32(edit_level);
                }

                Console.Write("Enter basic salary to edit: ");
                string? edit_basicSalary = Console.ReadLine();
                if (edit_basicSalary != null && edit_basicSalary.Length > 0)
                {
                    employee.BasicSalary = Convert.ToInt32(edit_basicSalary);
                }

                GetDOB(employee);
                GetFullName(employee);
                GetSalary(employee);
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
