using InboundService.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace InboundService.Application.Features.OrderAllocation.Requests
{
  public  class GetOrderDetailRequest: IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
