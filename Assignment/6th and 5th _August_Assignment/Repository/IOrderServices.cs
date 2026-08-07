using _6th_and_5th_August_Assignment.Models;

namespace _6th_and_5th_August_Assignment.Repository
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order? GetOrderById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}