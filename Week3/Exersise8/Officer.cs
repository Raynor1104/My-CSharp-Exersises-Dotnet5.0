using System;

namespace Exersise8
{
    public class Officer
    {
        string? gender;

        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender 
        { 
            get { return gender; } 
            set
            {
                if (value == "male" || value == "female") gender = value;
                else gender = "other";
            } 
        }

        public Officer()
        {

        }
        public Officer(string? name, int age, string? gender) : this()
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void EnterStaff()
        {
            Console.WriteLine("{0, -5} {1, 5} {2, 10}", 
            Name, Age, Gender);
        }
    }
}