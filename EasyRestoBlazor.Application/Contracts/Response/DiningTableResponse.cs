﻿namespace EasyRestoBlazor.Application.Contracts.Response
{
    public class DiningTableResponse
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}
