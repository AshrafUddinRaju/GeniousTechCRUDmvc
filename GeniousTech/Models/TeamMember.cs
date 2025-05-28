using System.ComponentModel.DataAnnotations;

namespace GeniousTech.Models
{
    public class TeamMember
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Display(Name = "Photo URL")]
        public string PhotoUrl { get; set; }

        [Display(Name = "LinkedIn URL")]
        [Url]
        public string LinkedInUrl { get; set; }
    }
}
