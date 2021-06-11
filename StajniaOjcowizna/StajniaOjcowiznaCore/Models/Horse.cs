using System;

namespace StajniaOjcowiznaCore
{
    public class Horse
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Horse(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
