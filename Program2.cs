using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
    internal class Student
    {
        public string Surname;
        public string Name;
        public string LastName;
        public string Sex;
        public DateTime Birthday;
        public string Math;
        public string Physics;
        public string ComputerScience;
        public int Grant;

        public static List<Student> LoadFile()
        {
            List<Student> students = new List<Student>();
            string[] input = File.ReadAllLines("input.txt");

            for (int i = 0; i < input.Length; i++)
            {
                string[] parts = input[i].Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);
                Student st = new Student();
                st.Surname = parts[0];
                st.Name = parts[1];
                st.LastName = parts[2];
                st.Sex = parts[3];
                st.Birthday = DateTime.Parse(parts[4]);
                st.Math = parts[5];
                st.Physics = parts[6];
                st.ComputerScience = parts[7];
                st.Grant = int.Parse(parts[8]);
                students.Add(st);

            }
            return students;
        }
        public static int Mark(string mark)
        {
            if (mark == "-")
                return 2;

            return int.Parse(mark);
        }
        public static void Var20(List<Student> students)
        {
            int count = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (Mark(students[i].Math) == 5 && Mark(students[i].Physics) == 5 && Mark(students[i].ComputerScience) == 5)
                { 
                    count ++;
                    Console.WriteLine($"{students[i].Surname} {students[i].Name} {students[i].LastName}" +
                        $"\nОцінки: \nМатематика: {students[i].Math}\nФізика: {students[i].Physics}" +
                        $"\nІнформатика: {students[i].ComputerScience} \nСтипендія: {students[i].Grant} ");
                        Console.WriteLine();
                }
            }
            Console.WriteLine($"Кількість: {count}");

        }
    }
}
