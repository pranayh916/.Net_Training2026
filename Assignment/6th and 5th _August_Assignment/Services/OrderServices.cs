using _6th_and_5th_August_Assignment.Data;
using _6th_and_5th_August_Assignment.Models;
using _6th_and_5th_August_Assignment.Repository;

namespace _6th_and_5th_August_Assignment.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;

        public OrderService(AppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAllOrders()
        {
            try
            {
                return _context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching orders.", ex);
            }
        }

        public Order? GetOrderById(int id)
        {
            try
            {
                return _context.Orders.FirstOrDefault(o => o.OrderId == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching order.", ex);
            }
        }

        public void AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding order.", ex);
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                _context.Orders.Update(order);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating order.", ex);
            }
        }

        public void DeleteOrder(int id)
        {
            try
            {
                var order = _context.Orders.FirstOrDefault(o => o.OrderId == id);

                if (order != null)
                {
                    _context.Orders.Remove(order);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while deleting order.", ex);
            }
        }
    }
}