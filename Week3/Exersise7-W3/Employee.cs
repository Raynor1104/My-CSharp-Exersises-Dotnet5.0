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
    }
}
