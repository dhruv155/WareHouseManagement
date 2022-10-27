using AutoMapper;
using InboundService.Application.DTOs;
using InboundService.Application.Features.OrderAllocation.Requests;
using InboundService.Application.Persistence;
using InboundService.Domain;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InboundService.Application.Features.OrderAllocation.Handlers.Queries
{
    public class GetOrderListRequestHandler : IRequestHandler<GetOrdersListRequest, List<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public GetOrderListRequestHandler(IOrderRepository orderRepository, IMapper mapper )
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;
        }
        public async Task<List<OrderDto>> Handle(GetOrdersListRequest request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();

            IEnumerable<Order> orders = await _orderRepository.GetOrders();
            return _mapper.Map<List<OrderDto>>(orders);


            
        }
    }
}
