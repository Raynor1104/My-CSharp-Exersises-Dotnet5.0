﻿using System;
using System.Collections.Generic;

namespace Exersise7_W3
{
    class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();

            while (true)
            {
                Console.WriteLine("\n1. Enter employee");
                Console.WriteLine("2. Get employee by ID");
                Console.WriteLine("3. Edit employee");
                Console.WriteLine("4. Remove employee");
                Console.WriteLine("5. Get employee by full name");
                Console.WriteLine("6. Sort employee by salary");
                Console.WriteLine("7. Show employee list");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("\nEnter employee");
                        management.EnterEmployee();
                        Console.WriteLine("\nNew employee added.");
                        break;
                    case 2:
                        if (management.EmployeeAmount() > 0)
                        {
                            Console.WriteLine("\nGet employee by ID");
                            Console.Write("Enter an id: ");
                            int search_ID = Convert.ToInt32(Console.ReadLine());
                            List<Employee> searchResult = management.GetByID(search_ID);
                            management.ShowEmployeeList(searchResult);
                        }
                        else
                        {
                            Console.WriteLine("\n The list is empty.");
                        }
                        break;
                    case 3:
                        if (management.EmployeeAmount() > 0)
                        {
                            int id;
                            Console.WriteLine("\nEdit employee");
                            Console.Write("Enter employee you want to edit by id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            management.EditEmployee(id);
                        }
                        else 
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        break;
                    case 4:
                        if (management.EmployeeAmount() > 0)
                        {
                            int id;
                            Console.WriteLine("\nRemove employee");
                            Console.Write("Enter an ID to remove: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (management.RemoveById(id))
                            {
                                Console.WriteLine($"Employee {id} has been removed");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        break;
                    case 5:
                        if (management.EmployeeAmount() > 0)
                        {
                            string? fullName;
                            Console.WriteLine("\nGet employee by full name");
                            Console.Write("Enter a name: ");
                            fullName = Console.ReadLine();
                            List<Employee> searchresult = management.GetByFullName(fullName);
                            management.ShowEmployeeList(searchresult);
                        }
                        else
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        break;
                    case 6:
                        if (management.EmployeeAmount() > 0)
                        {
                            Console.WriteLine("\nSort employee by salary");
                            management.SoftBySalary();
                            management.ShowEmployeeList(management.GetEmployeeList());
                        }
                        else
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        break;
                    case 7:
                        if (management.EmployeeAmount() > 0)
                        {
                            Console.WriteLine("\nShow employee list");
                            management.ShowEmployeeList(management.GetEmployeeList());
                        }
                        else
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Good bye!");
                        return;
                    default:
                        Console.WriteLine("Option not available");
                        break;
                }
            }
        }
    }
}
