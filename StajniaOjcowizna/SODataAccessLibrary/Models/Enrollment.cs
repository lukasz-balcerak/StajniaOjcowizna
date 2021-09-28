using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SODataAccessLibrary.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CurseId { get; set; }
        public int StudentId { get; set; }
        public int HorseId { get; set; }
    }
}
