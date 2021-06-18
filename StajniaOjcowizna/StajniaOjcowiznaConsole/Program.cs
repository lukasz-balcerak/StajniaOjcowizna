using StajniaOjcowiznaCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
using StajniaOjcowiznaCore.Control;
using StajniaOjcowiznaCore.Models;
using Newtonsoft.Json;

namespace StajniaOjcowiznaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            JSON.HorseData = JSON.LoadJson<Horse>("Horses.json");
            JSON.InstructorData = JSON.LoadJson<Instructor>("Instructors.json");

        }
    }
}
