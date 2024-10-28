using System.ComponentModel.DataAnnotations;

namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class UpdateFoodCategoryRequest
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
