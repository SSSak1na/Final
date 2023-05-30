using FinalProject.Models.Base.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Profession: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string? Image { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
    }
   
