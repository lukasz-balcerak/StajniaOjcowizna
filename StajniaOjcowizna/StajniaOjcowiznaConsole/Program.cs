using StajniaOjcowiznaCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            JSON.LessonsData = JSON.LoadJson<Lesson>("Lessons");

            //List<Option> options = new List<Option>
            //{
            //    new Option("Zapisz jazde", ConsoleView.AddLesson),
            //    new Option("Usuń jazde", ConsoleView.RemoveLesson)
            //};

            //ConsoleView.ConsoleMenu(options);
            //Console.ReadKey();
            ConsoleTable
                .From<Horse>(JSON.HorseData)
                .Configure(o => o.NumberAlignment = Alignment.Left)
                .Write(Format.MarkDown);
        }
    }
}

