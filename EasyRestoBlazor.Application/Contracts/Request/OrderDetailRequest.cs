using EasyRestoBlazor.Application.Contracts.Response;
using System.ComponentModel.DataAnnotations;

namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class OrderDetailRequest
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string FoodItemId { get; set; }

        public virtual FoodItemResponse FoodItem { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 100)]
        public int Qty { get; set; }
    }
}
