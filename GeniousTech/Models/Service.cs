using System.ComponentModel.DataAnnotations;

namespace GeniousTech.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string IconClass { get; set; }  // e.g., "fa-solid fa-code"
    }
}
