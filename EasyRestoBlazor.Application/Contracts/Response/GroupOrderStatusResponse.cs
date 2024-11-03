namespace EasyRestoBlazor.Application.Contracts.Response
{
    public class GroupOrderStatusResponse
    {
        public DateTime Date { get; set; }
        public Guid OrderStatusId { get; set; }
        public OrderStatusResponse OrderStatus { get; set; }
        public int Count { get; set; }
    }
}
