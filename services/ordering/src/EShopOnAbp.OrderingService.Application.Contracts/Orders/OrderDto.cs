using System;
using System.Collections.Generic;
using EShopOnAbp.OrderingService.Buyers;
using Volo.Abp.Application.Dtos;

namespace EShopOnAbp.OrderingService.Orders;

public class OrderDto : EntityDto<Guid>
{
    public DateTime OrderDate { get; set; }
    public int OrderStatusId { get; set; }
    public string OrderStatus { get; set; }
    public BuyerDto Buyer { get; set; }
    public OrderAddressDto Address { get; set; } = new();
    public List<OrderItemDto> Products { get; set; } = new();
}