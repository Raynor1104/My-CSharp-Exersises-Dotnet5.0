using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise8
{
    class Engineer : Officer
    {
        public string? TrainingIndustry { get; set; }

        public Engineer(string? name, int age, string? gender, string? trainingIndustry) : base(name, age, gender)
        {
            TrainingIndustry = trainingIndustry;
        }

        public override void EnterStaff()
        {
            Console.WriteLine("{0, -5} {1, 5} {2, 10} {3, 11} ", 
            Name, Age, Gender, $"TrainingIndustry: {TrainingIndustry}");
        }
    }
}