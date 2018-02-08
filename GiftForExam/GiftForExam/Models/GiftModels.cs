using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForExam.Models
{
    public class GiftModels
    {
        [Required]
        public int Number { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public bool Boy { get; set; }

        [Required]
        public bool Girl { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
