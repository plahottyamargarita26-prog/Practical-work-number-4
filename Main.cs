using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTime = (int hour, int min, int sec);

namespace лаба_4
{
    internal class ProgramMain
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Натисніть 1,якщо хочете виконати перше завдання\nНатисніть 2,якщо хочете виконати друге завдання");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Години: ");
                        int hour = int.Parse(Console.ReadLine());
                        Console.Write("Хвилини: ");
                        int min = int.Parse(Console.ReadLine());
                        Console.Write("Секунди: ");
                        int sec = int.Parse(Console.ReadLine());
                        MyTime t = (hour, min, sec);
                        Console.WriteLine("Введений час:");
                        Console.WriteLine(Program.MyTimeToString(t));
                        Console.WriteLine("Нормалізація:");
                        Console.WriteLine(Program.MyTimeToString(Program.Normalize(t)));
                        Console.WriteLine("+1 секунда:");
                        Console.WriteLine(Program.MyTimeToString(Program.AddOneSecond(t)));
                        Console.WriteLine("+1 хвилина:");
                        Console.WriteLine(Program.MyTimeToString(Program.AddOneMinute(t)));
                        Console.WriteLine("+1 година:");
                        Console.WriteLine(Program.MyTimeToString(Program.AddOneHour(t)));
                        Console.WriteLine("+500 секунд:");
                        Console.WriteLine(Program.MyTimeToString(Program.AddSeconds(t, 500)));
                        Console.WriteLine("Секунд від початку доби:");
                        Console.WriteLine(Program.ToSecSinceMidnight(t));
                        Console.WriteLine("Яка зараз пара:");
                        Console.WriteLine(Program.WhatLesson(t));
                        break;
                    case 2:
                        List<Student> students = Student.LoadFile();
                        Student.Var20(students);
                        break;
                }
                Console.WriteLine("Натисніть будь-яку клавішу для повернення в меню");
                Console.ReadKey();
                Console.Clear();
            }

        
        }
    }
}
