﻿namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class DeleteItemsRequest
    {
        public List<Guid> Ids { get; set; } = new List<Guid>();
    }
}
