using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Models
{
    public class Voter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String location { get; set; }
        public String date_of_birth { get; set; }
        public String password { get; set; }
        public String voted { get; set; }

    }
}
