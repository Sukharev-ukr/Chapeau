using DAL;
using Model;
using System.Data.SqlClient;

namespace Service
{
    public class OrderService
    {
        OrderDao orderDao;

        public OrderService()
        {
            orderDao = new OrderDao();
        }

        public List<Order> GetOrders(bool drink, Status status)
        {
            List<Order> orders = orderDao.GetOrders(drink, status);

            if (!drink)
            {
                orders = CategorizeItems(orders);
            }

            return orders;
        }

        private static void SplitFoodOrders(Order order, Dictionary<Category, List<OrderItem>> categorizedItems)
        {
            foreach (OrderItem item in order.Items)
            {
                Category category = item.MenuItem.Category;
                if (!categorizedItems.ContainsKey(category))
                {
                    categorizedItems[category] = new List<OrderItem>();
                }
                categorizedItems[category].Add(item);
            }
        }

        public List<Order> CategorizeItems(List<Order> orders)
        {
            List<Order> categorizedOrders = new List<Order>();

            foreach (Order order in orders)
            {
                var categorizedItems = new Dictionary<Category, List<OrderItem>>();
                SplitFoodOrders(order, categorizedItems);
                categorizedOrders.AddRange(CreateOrdersFromCategories(order, categorizedItems));
            }

            return categorizedOrders;
        }

        private List<Order> CreateOrdersFromCategories(Order originalOrder, Dictionary<Category, List<OrderItem>> categorizedItems)
        {
            List<Order> splitOrders = new List<Order>();

            foreach (var category in categorizedItems.Keys)
            {
                Order newOrder = new Order(originalOrder)
                {
                    Items = categorizedItems[category]
                };
                splitOrders.Add(newOrder);
            }

            return splitOrders;
        }
    }
}