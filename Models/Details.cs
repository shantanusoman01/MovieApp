using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }
        [Required]
        [MaxLength(30)]
        public string ?Actor { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public string ?Gender { get; set; }
        [MaxLength(10)]
        public string ?Role { get; set; }
        public Movie ?Movie { get; set; }
    }
}