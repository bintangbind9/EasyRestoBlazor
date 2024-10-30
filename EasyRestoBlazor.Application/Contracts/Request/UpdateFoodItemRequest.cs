using System.ComponentModel.DataAnnotations;

namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class UpdateFoodItemRequest
    {
        [Required(ErrorMessage = "Category is required.")]
        public string FoodCategoryId { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string FoodItemStatusId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
