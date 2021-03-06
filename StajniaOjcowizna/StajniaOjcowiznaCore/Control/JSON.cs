using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using StajniaOjcowiznaCore.Models;


namespace StajniaOjcowiznaCore.Control
{
    public class JSON
    {
        public static List<Instructor> InstructorData = new List<Instructor>();
        public static List<Horse> HorseData = new List<Horse>();
        public static List<Lesson> LessonsData = new List<Lesson>();
        public static List<T> LoadJson<T>(string fileName)
        {
            List<T> Data = new List<T>();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(currentDirectory, @$"..\..\..\..\StajniaOjcowiznaCore\Data\{fileName}.json");
            using (StreamReader reader = new StreamReader(path))
            {
                path = reader.ReadToEnd();
                Data = (JsonConvert.DeserializeObject<List<T>>(path));
            }

            return Data;
        }

        public static void SaveJson<T>(List<T> dataToSave, string fileName)
        {
            string savingData = JsonConvert.SerializeObject(dataToSave.ToArray());
            System.IO.File.WriteAllText($@"..\..\..\..\StajniaOjcowiznaCore\Data\{fileName}.json", savingData);
        }
    }
}