using System.ComponentModel.DataAnnotations;

namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class UpdateOrderOrderStatusRequest
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string StatusCode { get; set; }
    }
}
