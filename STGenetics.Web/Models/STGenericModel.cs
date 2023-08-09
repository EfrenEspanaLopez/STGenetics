using System.ComponentModel.DataAnnotations;

namespace STGenetics.Web.Models
{
    public class STGenericModel
    {
        public int AnimalId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public double Price { get; set; }
        public bool Status { get; set; }
        public bool Selected { get; set; }
    }
}
