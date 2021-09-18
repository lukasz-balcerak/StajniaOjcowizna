using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SODataAccessLibrary.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "varchar(64)")]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "varchar(64)")]
        public String LastName { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
