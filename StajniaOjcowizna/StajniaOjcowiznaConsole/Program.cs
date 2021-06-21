using StajniaOjcowiznaCore;
using System;
using StajniaOjcowiznaCore.Control;
using StajniaOjcowiznaCore.Models;
using ConsoleTables;

namespace StajniaOjcowiznaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            JSON.HorseData = JSON.LoadJson<Horse>("Horses");
            JSON.InstructorData = JSON.LoadJson<Instructor>("Instructors");
            //JSON.LessonsData = JSON.LoadJson<Lesson>("Lessons");
            DateTime date = new DateTime(2021, 06, 21, 18, 30, 00);
            TimeSpan time = new TimeSpan(1, 30, 00);
            Lesson lesson = new Lesson(date, "Indywidualna", 1, time);
            JSON.LessonsData.Add(lesson);
            JSON.SaveJson<Lesson>(JSON.LessonsData,"Lessons");
    
            
            ConsoleTable
                .From<Lesson>(JSON.LessonsData)
                .Configure(o => o.NumberAlignment = Alignment.Left)
                .Write(Format.MarkDown);
        }
    }
}
