using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Models
{
    public class Candidate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String name { get; set; }
        public String symbol { get; set; }
        public int vote_count { get; set; }
        public int e_id { get; set; }
        public String e_name { get; set; }


    }
}
