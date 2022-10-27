using AutoMapper;
using InboundService.Application.DTOs;
using InboundService.Application.Features.OrderAllocation.Requests;
using InboundService.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace InboundService.Application.Features.OrderAllocation.Handlers.Queries
{
    public class GetOrderDetailRequestHandler : IRequestHandler<GetOrderDetailRequest, OrderDto>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        
        
         public GetOrderDetailRequestHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;

        }

        public async Task<OrderDto> Handle(GetOrderDetailRequest request, CancellationToken cancellationToken)
        {
            //check
            var order = await _orderRepository.GetOrderById(request.Id);
            return _mapper.Map<OrderDto>(order);

        }
    }
}
