using System.ComponentModel.DataAnnotations;

namespace GeniousTech.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Display(Name = "Completed On")]
        [DataType(DataType.Date)]
        public DateTime CompletedOn { get; set; }
    }
}
