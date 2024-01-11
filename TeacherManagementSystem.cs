using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordSystem
{
    public class TeacherManagementSystem
    {
        private List<Teacher> teachers;

        public TeacherManagementSystem()
        {
            teachers = FileHandler.LoadDataFromFile();
        }

        public void AddTeacher(int id, string name, string classSection)
        {
            Teacher newTeacher = new Teacher { ID = id, Name = name, ClassSection = classSection };
            teachers.Add(newTeacher);
            FileHandler.SaveDataToFile(teachers);
            Console.WriteLine("Teacher added successfully.");
        }

        public void DisplayAllTeachers()
        {
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.ID}, Name: {teacher.Name}, " +
                    $"Class and Section: {teacher.ClassSection}");
            }
        }

        public void UpdateTeacher(int id, string newName, string newClassSection)
        {
            Teacher existingTeacher = teachers.Find(t => t.ID == id);

            if (existingTeacher != null)
            {
                existingTeacher.Name = newName;
                existingTeacher.ClassSection = newClassSection;
                FileHandler.SaveDataToFile(teachers);
                Console.WriteLine("Teacher information updated successfully.");
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }
    }
}
