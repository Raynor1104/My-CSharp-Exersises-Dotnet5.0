using System;

namespace Exersise8
{
    class Worker : Officer
    {
        int level;

        public int Level
        {
            get { return level;}
            set 
            {
                if (value >= 1 && value <= 10) level = value;
                else level = 0;
            }
        }
        public Worker(string? name, int age, string? gender, int level) : base(name, age, gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }

        public override void EnterStaff()
        {
            Console.WriteLine("{0, -5} {1, 5} {2, 10} {3, 11} ", 
            Name, Age, Gender, Level);
        }
    }
}