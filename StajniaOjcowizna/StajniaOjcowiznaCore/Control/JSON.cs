using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
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
            string CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(CurrentDirectory, @$"..\..\..\..\StajniaOjcowiznaCore\Data\{fileName}");
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
            System.IO.File.WriteAllText($@"..\..\..\..\StajniaOjcowiznaCore\Data\{fileName}", savingData);
        }
    }
}