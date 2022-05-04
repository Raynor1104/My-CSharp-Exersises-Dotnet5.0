using System;

namespace Exersise8
{
    public class Management
    {
        private List<Officer> OfficerList;

        public Management()
        {
            OfficerList = new List<Officer>();
        }

        public int OfficerAmount()
        {
            int count = 0;
            if  (OfficerList != null)
            {
                count = OfficerList.Count;
            }
            return count;
        }

        public void AddNewStaff()
        {
            Console.Write("Enter name: ");
            string? nameEnter = Console.ReadLine();

            Console.Write("Enter age: ");
            int ageEnter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter gender: ");
            string? genderEnter = Console.ReadLine();

            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Engineer");
            Console.WriteLine("3. Worker");
            Console.Write("Choose a role: ");
            int role = Convert.ToInt32(Console.ReadLine());
            switch (role)
            {
                case 1:
                    Console.Write("Enter task: ");
                    string? taskEnter = Console.ReadLine();
                    Employee employee = new(
                        name: nameEnter, 
                        age: ageEnter, 
                        gender: genderEnter, 
                        task: taskEnter
                    );
                    OfficerList.Add(employee);
                    break;
                case 2:
                    Console.Write("Enter training industry: ");
                    string? trainingIndustryEnter = Console.ReadLine();
                    Engineer engineer = new(
                        name: nameEnter, 
                        age: ageEnter, 
                        gender: genderEnter, 
                        trainingIndustry: trainingIndustryEnter
                    );
                    OfficerList.Add(engineer);
                    break;
                case 3:
                    Console.Write("Enter level: ");
                    int levelEnter = Convert.ToInt32(Console.ReadLine());
                    Worker worker = new(
                        name: nameEnter, 
                        age: ageEnter, 
                        gender: genderEnter, 
                        level: levelEnter
                    );
                    OfficerList.Add(worker);
                    break;
            }
        }

        public void SearchByName(string? name)
        {
            Officer? searchResult = null;
            if (OfficerList != null && OfficerList.Count > 0)
            {
                foreach (Officer officer in OfficerList)
                {
                    if (name == officer.Name)
                    {
                        searchResult = officer;
                    }
                }
            }
        }

        public void DisplayList(List<Officer> OfficerList)
        {
            // Console.WriteLine("{0, -5} {1, 5} {2, 7} {3, 15}",
            // "Name", "Age", "Gender", "Task/Level/TrainingIndustry");
                        
            if (OfficerList != null && OfficerList.Count > 0)
            {
                foreach (Officer officer in OfficerList)
                {
                     officer.EnterStaff();
                }
            }
        }

        public List<Officer> GetOfficerList()
        {
            return OfficerList;
        }

        public void ExitProgram()
        {
            Environment.Exit(0);
        }  
    }
}
