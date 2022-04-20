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
            while (true)
            {
                Console.WriteLine("1. Employee");
                Console.WriteLine("2. Engineer");
                Console.WriteLine("3. Worker");
                Console.WriteLine("4. Exit");
                Console.Write("Choose a role: ");
                int role = Convert.ToInt32(Console.ReadLine());
                switch (role)
                {
                    case 1:
                        Employee employee = new(
                            name: Console.ReadLine(), 
                            age: Convert.ToInt32(Console.ReadLine()), 
                            gender: Console.ReadLine(), 
                            task: Console.ReadLine()
                        );
                        OfficerList.Add(employee);
                        break;
                    case 2:
                        Engineer engineer = new(
                            name: Console.ReadLine(), 
                            age: Convert.ToInt32(Console.ReadLine()), 
                            gender: Console.ReadLine(),
                            trainingIndustry: Console.ReadLine()  
                        );
                        OfficerList.Add(engineer);
                        break;
                    case 3:
                        Worker worker = new(
                            name: Console.ReadLine(), 
                            age: Convert.ToInt32(Console.ReadLine()), 
                            gender: Console.ReadLine(),
                            level: Convert.ToInt32(Console.ReadLine())
                        );
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Role not available");
                        break;
                }
            }
        }

        public void DisplayList(List<Officer> OfficerList)
        {
            Console.WriteLine("{0, -5} {1, 5} {2, 7} {3, 10}",
            "Name", "Age", "Gender", "Task/Level/TrainingIndustry");
                        
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
    }
}