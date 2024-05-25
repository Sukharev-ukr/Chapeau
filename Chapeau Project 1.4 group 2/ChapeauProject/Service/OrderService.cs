using DAL;
using Model;

namespace Service
{
    public class OrderService
    {
        OrderDAL orderDAL;

        public List<Order> orders;
        public List<OrderItem> starters;
        public List<OrderItem> mains;
        public List<OrderItem> deserts;
        public List<OrderItem> drinks;

        public OrderService()
        {
            orderDAL = new OrderDAL();
            orders = new List<Order>();
            starters = new List<OrderItem>();
            mains = new List<OrderItem>();
            deserts = new List<OrderItem>();
            drinks = new List<OrderItem>();
        }

        public List<Order> GetOrders(bool drink, Status status)
        {
            orders = orderDAL.GetOrders(drink, status);
            CategorizeItems();

            return orders;
        }

        private void CategorizeItems()
        {
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.Items)
                {
                    switch (item.MenuItem.Category)
                    {
                        case "Starters - Entrees":
                            starters.Add(item);
                            break;
                        case "Mains - Le plat principal":
                            starters.Add(item);
                            break;
                        case "Deserts - Les Desserts":
                            starters.Add(item);
                            break;
                        case "Drinks":
                            starters.Add(item);
                            break;
                    }
                }
            }
        }
    }
}