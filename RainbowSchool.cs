using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpBasicsSimpliLearnProject
{
    class RainbowSchool
    {
        public static void GetStudentDetails()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\RainbowSchoolStudentData.txt";
            if (File.Exists(path))
            {
                string[] contents = File.ReadAllLines(path);
                foreach (string content in contents)
                {
                    string[] details = content.Split(",");
                    Console.WriteLine($"Name:{details[0]}, Age:{details[1]}, Dept:{details[2]}");
                }
            }
        }
    }
}
