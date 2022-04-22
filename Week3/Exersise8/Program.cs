using System;

namespace Exersise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Management management = new();
            while (true)
            {
                Console.WriteLine("1. Add new staff");
                Console.WriteLine("2. Search by name");
                Console.WriteLine("3. Display officer list");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add new staff");
                        management.AddNewStaff();
                        Console.WriteLine("Staff added.");
                        break;
                    case 2:
                        if (management.OfficerAmount() > 0)
                        {
                            Console.WriteLine("Search by name");
                            Console.Write("Enter name: ");
                            string? searchName = Console.ReadLine();
                            management.SearchByName(searchName);
                            management.DisplayList(management.GetOfficerList());
                        }
                        else
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        break;
                    case 3:
                        if (management.OfficerAmount() > 0)
                        {
                            Console.WriteLine("Display officer list");
                            management.DisplayList(management.GetOfficerList());
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
