using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Models
{
    public class Election
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int c_id { get; set; }
        public string winner { get; set; }
        public string freeze_status { get; set; }
        public string publish_status { get; set; }
    }
}
