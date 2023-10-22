using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {

        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,200,ErrorMessage ="The value must be between 1 up to 200")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
