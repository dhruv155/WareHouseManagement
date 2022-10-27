using InboundService.Application.Persistence;
using InboundService.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InboundService.Persistence.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly InboundDbContext _dbContext;
        public OrderRepository(InboundDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
            
        public async Task<Order> CreateUpdateOrder(Order order)
        {
            // throw new NotImplementedException();
            await _dbContext.AddRangeAsync(order);
            return order;
        }

        public async Task<bool> DeleteOrder(int orderId)
        {
            //throw new NotImplementedException();
            try
            {

                Order order = await _dbContext.Orders.FirstOrDefaultAsync(u => u.Id == orderId);
                if (order == null)
                {
                    return false;
                }
                _dbContext.Orders.Remove(order);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

       /* public Task GetAllAsync()
        {
            throw new NotImplementedException();
            
        }*/

        public async Task<Order> GetOrderById(int orderId)
        {
            // throw new NotImplementedException();
            Order order = await _dbContext.Orders.Where(x => x.Id == orderId).FirstOrDefaultAsync();
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            //throw new NotImplementedException();
            var orderList = await _dbContext.Orders.ToListAsync();
            return orderList;
        }
    }
}
