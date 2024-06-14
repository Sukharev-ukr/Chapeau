using DAL;
using Model;

namespace Service
{
    public class OrderService
    {
        OrderDAL orderDAL;
        MenuDAL menuDAL; 

        public List<Order> orders;
        public List<OrderItem> starters;
        public List<OrderItem> mains;
        public List<OrderItem> deserts;
        public List<OrderItem> drinks;
        public List<MenuItem> allMenuItems; 

        public OrderService()
        {
            orderDAL = new OrderDAL();
            menuDAL = new MenuDAL(); 
            orders = new List<Order>();
            starters = new List<OrderItem>();
            mains = new List<OrderItem>();
            deserts = new List<OrderItem>();
            drinks = new List<OrderItem>();
            allMenuItems = menuDAL.GetMenuItems();
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

        public List<MenuItem> GetAllMenuItems()
        {
            return allMenuItems;
        }

        public List<MenuItem> GetMenuItemsByCard(string card)
        {
            return allMenuItems.Where(item => item.Card == card).ToList();
        }

        public void UpdateTipById(decimal input ,int id)
        {
            OrderDAL orderDAL = new OrderDAL();
            orderDAL.UpdateTipById(input ,id);
        }
        public void UpdateTotalById(decimal input, int id)
        {
            OrderDAL orderDAL = new OrderDAL();
            orderDAL.UpdateTotalById(input, id);
        }
    }
}