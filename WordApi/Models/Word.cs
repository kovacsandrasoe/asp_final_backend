using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordApi.Models
{
    public class Word
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string HomeWord { get; set; }

        [Required]
        [StringLength(30)]
        public string ForeignWord { get; set; }
    }
}
