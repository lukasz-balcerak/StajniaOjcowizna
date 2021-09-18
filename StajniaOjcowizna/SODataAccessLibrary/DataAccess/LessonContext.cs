using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SODataAccessLibrary.Models;

namespace SODataAccessLibrary.DataAccess
{
    public class LessonContext : DbContext
    {
        public LessonContext(DbContextOptions options) : base(options){}
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
