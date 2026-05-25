using System;
using MyTime = (int hour, int min, int sec);
using MyTime2 = (int hour2, int min2, int sec2);
namespace лаба_4
{
       
    internal class Program
    {
        public static string MyTimeToString(MyTime t)
        {
            return $"{t.hour}:{t.min:D2}:{t.sec:D2}";
        }
        public static MyTime Normalize(MyTime t)
        {
            int totalSeconds = ToSecSinceMidnight(t);
            return FromSecSinceMidnight(totalSeconds);
        }
        public static int ToSecSinceMidnight(MyTime t)
        {
            return t.hour * 3600 + t.min * 60 + t.sec;
        }
        public static MyTime FromSecSinceMidnight(int t)
        {
            int secPerDay = 60 * 60 * 24;
            t %= secPerDay;
            if (t < 0)
            {
                t += secPerDay;
            }
            int hour = t / 3600;
            int min = (t / 60) % 60;
            int sec = t % 60;
            return (hour, min, sec);
        }
        public static MyTime AddOneSecond(MyTime t)
        {
            return AddSeconds(t, 1);
        }
        public static MyTime AddOneMinute(MyTime t)
        {
            return AddSeconds(t, 60);
        }
        public static MyTime AddOneHour(MyTime t)
        {
            return AddSeconds(t, 3600);
        }
        public static MyTime AddSeconds(MyTime t, int s)
        {
            int totalSeconds = ToSecSinceMidnight(t);
            totalSeconds += s;
            return FromSecSinceMidnight(totalSeconds);
        }
        public static int Difference(MyTime t1, MyTime t2)
        {
            return ToSecSinceMidnight(t1) - ToSecSinceMidnight(t2);
        }
        public static string WhatLesson(MyTime t)
        {
            int sec = ToSecSinceMidnight(t);
            int p1Start = 8 * 3600;
            int p1End = 9 * 3600 + 20 * 60;
            int p2Start = 9 * 3600 + 40 * 60;
            int p2End = 11 * 3600;
            int p3Start = 11 * 3600 + 20 * 60;
            int p3End = 12 * 3600 + 40 * 60;
            int p4Start =  13 * 3600;
            int p4End = 14 * 3600 + 20 * 60;
            int p5Start = 14 * 3600 + 40 * 60;
            int p5End = 16 * 3600;
            int p6Start = 16 * 3600 + 10 * 60; 
            int p6End = 17 * 3600 + 30 * 60;
            if (sec < p1Start)
                return "пари ще не почалися";
            if (sec >= p1Start && sec <= p1End)
                return "1-а пара";
            if (sec > p1End && sec < p2Start)
                return "перерва між 1-ю та 2-ю парами";
            if (sec >= p2Start && sec <= p2End)
                return "2-а пара";
            if (sec > p2End && sec < p3Start)
                return "перерва між 2-ю та 3-ю парами";
            if (sec >= p3Start && sec <= p3End)
                return "3-я пара";
            if (sec > p3End && sec < p4Start)
                return "перерва між 3-ю та 4-ю парами";
            if (sec >= p4Start && sec <= p4End)
                return "4-а пара";
            if (sec > p4End && sec < p5Start)
                return "перерва між 4-ю та 5-ю парами";
            if (sec >= p5Start && sec <= p5End)
                return "5-а пара";
            if (sec > p5End && sec < p6Start)
                return "перерва між 5-ю та 6-ю парами";
            if (sec >= p6Start && sec <= p6End)
                return "6-а пара";
            return "пари вже скінчилися";
        }

        
    }
}
