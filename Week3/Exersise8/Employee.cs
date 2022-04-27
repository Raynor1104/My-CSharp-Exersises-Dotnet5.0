using System;

namespace Exersise8
{
    class Employee : Officer
    {
        public string? Task { get; set; }

        public Employee(string? name, int age, string? gender, string? task) : base(name, age, gender)
        {
            Task = task;
        }

        public override void EnterStaff()
        {
            Console.WriteLine("{0, -5} {1, 5} {2, 10} {3, 11} ", 
            Name, Age, Gender, $"Task: {Task}");
        }
    }
}