using InboundService.Application.DTOs;
using InboundService.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InboundService.Application.Persistence
{
   public interface IOrderRepository: IGenereicRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderById(int orderId);
        Task<Order> CreateUpdateOrder(Order order);
        Task<bool> DeleteOrder(int orderId);
        //Task GetAllAsync();
    }
}
