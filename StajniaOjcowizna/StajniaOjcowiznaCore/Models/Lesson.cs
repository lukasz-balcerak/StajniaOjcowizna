using System;
using System.Collections.Generic;

namespace StajniaOjcowiznaCore.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Type { get; set; }
        public int FreePlaces { get; set; }
        public int TookedPlaces = 0;
        public List<Horse> RidingHorses = new List<Horse>();
        public List<string> Students = new List<string>();

        public Lesson(DateTime lessonDate, string type, int freePlaces, TimeSpan lessonDuration)
        {
            Date = lessonDate.ToString("MM/dd/yyyy");
            TimeStart = lessonDate.ToString("HH:mm");
            TimeEnd = (lessonDate + lessonDuration).ToString("HH:mm");
            Type = type;
            FreePlaces = freePlaces;

        }
    }
}
