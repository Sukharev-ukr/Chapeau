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
<<<<<<< Updated upstream
            orders = orderDAL.GetOrders(drink, status);
            CategorizeItems();
=======
            List<Order> orders = orderDAL.GetOrders(drink, status);
>>>>>>> Stashed changes

            return orders;
        }

<<<<<<< Updated upstream
        private void CategorizeItems()
=======
        public void CategorizeItems(List<Order> orders)
>>>>>>> Stashed changes
        {
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.Items)
                {
                    switch (item.MenuItem.Category)
                    {
                        case Category.Starters:
                            starters.Add(item);
                            break;
                        case Category.Mains:
                            mains.Add(item);
                            break;
                        case Category.Deserts:
                            deserts.Add(item);
                            break;
                        case Category.Drinks:
                            starters.Add(item);
                            break;
                    }
                }
            }
        }
    }
}