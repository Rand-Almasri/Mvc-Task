using System.ComponentModel.DataAnnotations;

namespace MvcCategory.Models.Entity.Category
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }


        [StringLength(100)]
        public string Description { get; set; }
    }
}
