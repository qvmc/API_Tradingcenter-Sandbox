using System.Threading.Tasks;
using API_Tradingcenter.Database;
using API_Tradingcenter.Models;

namespace API_Tradingcenter.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DatabaseContext context;
        public OrderRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<Order> SaveOrder(Order order){
            await this.context.Orders.AddAsync(order);
            await this.context.SaveChangesAsync();
            return order;
        }
    }
}