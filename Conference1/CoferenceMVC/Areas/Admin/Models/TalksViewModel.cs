﻿using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoferenceMVC.Areas.Admin.Models
{
    public class TalksViewModel
    {
        public int Id { get; set; }
        [Required]
        public int SpeakerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Edition { get; set; }

        public virtual Speakers Speaker { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }

    }
}
