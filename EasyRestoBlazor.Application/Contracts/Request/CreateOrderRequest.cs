using System.ComponentModel.DataAnnotations;

namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class CreateOrderRequest
    {
        [Required]
        public string DiningTableId { get; set; }

        [Required]
        public string OrderStatusId { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalPrice { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal Tax { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal BillAmount { get; set; }

        [MaxLength(255)]
        public string? CustomerNote { get; set; }

        public ICollection<OrderDetailRequest> OrderDetails { get; set; } = new List<OrderDetailRequest>();
    }
}
