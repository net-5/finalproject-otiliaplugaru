using Conference1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoferenceMVC.Areas.Admin.Models
{
    public class SponsorTypesViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Sponsor Type name can't be less than 2 characters")]
        [MaxLength(25, ErrorMessage = "Sponsor Type name can't have more than 25 characters")]
        public string Name { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public string Edition { get; set; }

        public virtual ICollection<Sponsors> Sponsors { get; set; }

        internal void InjectFrom(SponsorTypes sponsorTypes)
        {
            throw new NotImplementedException();
        }
    }
}
