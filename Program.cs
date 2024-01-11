using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordSystem
{

    class Program
    {
        static void Main()
        {
            TeacherManagementSystem system = new TeacherManagementSystem();

            while (true)
            {
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Display All Teachers");
                Console.WriteLine("3. Update Teacher Information");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Teacher ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Teacher Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Class and Section: ");
                            string classSection = Console.ReadLine();
                            system.AddTeacher(id, name, classSection);
                            break;
                        case 2:
                            system.DisplayAllTeachers();
                            break;
                        case 3:
                            Console.Write("Enter Teacher ID to update: ");
                            int updateId = int.Parse(Console.ReadLine());
                            Console.Write("Enter New Teacher Name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter New Class and Section: ");
                            string newClassSection = Console.ReadLine();
                            system.UpdateTeacher(updateId, newName, newClassSection);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
        }
    }

}

