using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordSystem
{

    public class FileHandler
    {
        private const string FilePath = "D:/mphasis/Teachers.txt";

        public static List<Teacher> LoadDataFromFile()
        {
            List<Teacher> teachers = new List<Teacher>();

            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (int.TryParse(parts[0], out int id))
                    {
                        string name = parts[1];
                        string classSection = parts[2];
                        teachers.Add(new Teacher { ID = id, Name = name, ClassSection = classSection });
                    }
                    else
                    {
                        Console.WriteLine($"Skipping invalid line: {line}");
                    }
                }
            }


            return teachers;
        }

        public static void SaveDataToFile(List<Teacher> teachers)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Teacher teacher in teachers)
                {
                    writer.WriteLine($"{teacher.ID},{teacher.Name},{teacher.ClassSection}");
                }
            }
        }
    }
}
