using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SODataAccessLibrary.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public Instructor Instructor { get; set; }
        public List<Horse> Horses { get; set; } = new List<Horse>();
        public List<Student> Students { get; set; } = new List<Student>();

    }
}
