using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajniaOjcowiznaCore.Models
{
    public class Instructor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }

    public class Instructors
    {
        public List<Instructor> InstructorsList { get; set; }
    }
}
