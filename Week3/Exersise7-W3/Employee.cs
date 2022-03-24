using System;
using System.Collections.Generic;
namespace Exersise7_W3
{
    class Employee
    {
        private int employeeId;
        public int Id 
        { 
            get
            {
                return employeeId;
            } 
            set
            {
                employeeId = value;
            }
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        private string? sex;
        public string? Sex 
        { 
            get{ return sex; } 
            set 
            {
                if (value == "male" || value == "female")
                {
                    sex = value;
                }
                else 
                {
                    sex = "unidentified";
                }
            } 
        }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public int BirthYear { get; set; }
        public string? DOB { get; set; }
        public int Level { get; set; }
        public int BasicSalary { get; set; }
        public int Salary { get; set; }
        public string? FullName { get; set; }

        public Employee()
        {
        
        }
        
        public Employee(int id) 
            : this()
        {
            this.Id = id;
        }

        public Employee(int id, string? firstName, string? lastName, string? sex, int birthDay, int birthMonth, int birthYear, int level, int basicSalary) 
            : this(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
            this.BirthDay = birthDay;
            this.BirthMonth = birthMonth;
            this.BirthYear = birthYear;
            this.Level = level;
            this.BasicSalary = basicSalary;
        }

        public void EnterEmployee()
        {
            Console.Write("Enter first name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            LastName = Console.ReadLine();

            Console.Write("Enter gender: ");
            Sex = Console.ReadLine();

            Console.Write("Birth day: ");
            BirthDay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Birth Month: ");
            BirthMonth = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Birth year: ");
            BirthYear = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Level: ");
            Level = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Basic salary: ");
            BasicSalary = Convert.ToInt32(Console.ReadLine());
        }

        public void WriteInformation()
        {   
            Console.WriteLine("{0, -5} {1, 5} {2, 10} {3, 11} {4, 11} {5, 4} {6, 9} {7, 15}", 
            Id, FirstName, LastName, Sex, DOB, Level, BasicSalary, Salary);
        }
    }
}
