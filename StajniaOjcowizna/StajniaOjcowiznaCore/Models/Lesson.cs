using System;
using System.Collections.Generic;
using StajniaOjcowiznaCore.Control;

namespace StajniaOjcowiznaCore.Models
{
    public class GroupLesson : Lesson
    {
        

        public GroupLesson(DateTime date)
        {
            DateStart = date;
            DateEnd = date.AddHours(1).AddMinutes(30);
            FreePlaces = 4;
            Id = JSON.LessonsData.Count + 1;
        }
    }

    public class IndividualLesson : Lesson
    {
        public IndividualLesson(DateTime date)
        {
            DateStart = date;
            DateEnd = date.AddHours(1).AddMinutes(30);
            FreePlaces = 1;
            Id = JSON.LessonsData.Count + 1;
        }
    }

    public class LungeLesson : Lesson
    {
        public LungeLesson(DateTime date)
        {
            DateStart = date;
            DateEnd = date.AddHours(1);
            FreePlaces = 1;
            Id = JSON.LessonsData.Count + 1;
        }
    }

    public class ATour : Lesson
    {
        public ATour(DateTime date)
        {
            DateStart = date;
            DateEnd = date.AddMinutes(30);
            FreePlaces = 1;
            Id = JSON.LessonsData.Count + 1;
        }
    }

    public class Lesson
    {
        public int Id;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd;
        public int FreePlaces;
        public int TookedPlaces;
        public List<Horse> RidingHorses = new List<Horse>();
        public List<string> Students = new List<string>();
        public Dictionary<Horse, string> HorseForStudent = new();
    }
}
