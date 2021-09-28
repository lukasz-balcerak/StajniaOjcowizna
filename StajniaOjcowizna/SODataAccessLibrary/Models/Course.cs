using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SODataAccessLibrary.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public Instructor Instructor { get; set; }

        [Required]
        public DateTime DateStart { get; set; }
        [Required]
        public DateTime DateEnd { get; set; }

        [MaxLength(400)]
        public string Note { get; set; }

    }
}
