using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODataAccessLibrary.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "varchar(64)")]
        public String  FirstName { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "varchar(64)")]
        public String LastName { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public String Email { get; set; }

        [Required]
        [MaxLength(20)]
        public String Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public String Password { get; set; }

    }
}
