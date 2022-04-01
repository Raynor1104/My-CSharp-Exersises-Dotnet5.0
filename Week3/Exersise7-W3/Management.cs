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

            employee.EnterEmployee();

            employee.GetAge();
            employee.GetFullName();
            employee.GetSalary();

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
                while(true)
                {
                    Console.WriteLine("\n1. First name");
                    Console.WriteLine("2. Last name");
                    Console.WriteLine("3. Sex");
                    Console.WriteLine("4. Date of birth");
                    Console.WriteLine("5. birth level");
                    Console.WriteLine("6. basic salary");
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
                                employee.FirstName = edit_firstName;
                            }
                            break;
                        case 2:
                            Console.Write("Enter Last name to edit: ");
                            string? edit_lastName = Console.ReadLine();
                            if (edit_lastName != null && edit_lastName.Length > 0)
                            {
                                employee.LastName = edit_lastName;
                            }
                            break;
                        case 3:
                            Console.Write("Enter Sex to edit: ");
                            string? edit_sex = Console.ReadLine();
                            if (edit_sex != null && edit_sex.Length > 0)
                            {
                                employee.Sex = edit_sex;
                            }
                            break;
                        case 4:
                            Console.Write("Enter date of birth in the format of YYYY-MM-DD to edit: ");
                            string? edit_dateOfBirth = Console.ReadLine();
                            if (edit_dateOfBirth != null)
                            {
                                employee.DateOfBirth = Convert.ToDateTime(edit_dateOfBirth);
                            }
                            break;
                        case 5:
                            Console.Write("Enter level to edit: ");
                            string? edit_levelStr = Console.ReadLine();
                            if (edit_levelStr != null && edit_levelStr.Length > 0)
                            {
                                employee.Level = Convert.ToInt32(edit_levelStr);
                            }
                            break;
                        case 6:
                            Console.Write("Enter basic salary to edit: ");
                            string? edit_basicSalaryStr = Console.ReadLine();
                            if (edit_basicSalaryStr != null && edit_basicSalaryStr.Length > 0)
                            {
                                employee.BasicSalary = Convert.ToInt32(edit_basicSalaryStr);
                            }
                            break;
                        case 0:
                            Console.WriteLine("Edit complete.");
                            return;
                        default:
                            Console.WriteLine("Option not available");
                            break;
                    }
                    employee.GetAge();
                    employee.GetFullName();
                    employee.GetSalary();
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

        public void SoftByFullName()
        {
            EmployeeList.Sort(delegate (Employee employee1, Employee employee2) {
                if (employee1.FullName == null && employee2.FullName == null) return 0;
                else if (employee1.FullName == null) return -1;
                else if (employee2.FullName == null) return 1;
                else return employee1.FullName.CompareTo(employee2.FullName);
            });
        }

        public List<Employee> OlderThan30()
        {
            List<Employee> result = new List<Employee>();
            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                foreach (Employee employee in EmployeeList)
                {
                    if (employee.Age >= 30)
                    {
                        result.Add(employee);
                    }
                }
            }
            return result;
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
        
        public void ShowEmployeeList(List<Employee> EmployeeList)
        {
            Console.WriteLine("{0, -5} {1, 10} {2, 10} {3, 5} {4, 7} {5, 12} {6, 12} {7, 9}",
            "ID", "FirstName", "LastName", "Sex", "DOB", "Level", "Basicsalary", "Salary");

            if (EmployeeList != null && EmployeeList.Count > 0)
            {
                foreach (Employee employee in EmployeeList)
                {
                    employee.WriteInformation();
                }
            }
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeList;
        }
    }
}
