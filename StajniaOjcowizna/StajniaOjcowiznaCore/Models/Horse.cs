using System;
using StajniaOjcowiznaCore.Control;

namespace StajniaOjcowiznaCore
{
    public class Horse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Horse(string name)
        {
            Name = name;
            Id = JSON.HorseData.Count + 1;
        }
    }
}
