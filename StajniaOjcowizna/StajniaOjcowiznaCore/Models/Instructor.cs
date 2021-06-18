using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StajniaOjcowiznaCore.Control;

namespace StajniaOjcowiznaCore.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Instructor(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Id = JSON.InstructorData.Count + 1;
        }
    }
}
