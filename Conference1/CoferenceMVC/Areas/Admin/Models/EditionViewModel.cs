using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoferenceMVC.Areas.Admin.Models
{
    public class EditionViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "User name can't be less than 2 characters")]
        public string Name { get; set; }
        [Required]
        public string TagLine { get; set; }
        [Required]
        [Range(2010, 2019)]

        public int Year { get; set; }
        [Required]
        public bool Active { get; set; }

    }
}