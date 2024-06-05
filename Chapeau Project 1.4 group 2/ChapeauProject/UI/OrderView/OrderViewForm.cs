using DAL;
using Model;
using Service;
using System.Windows.Forms;

namespace UI.OrderView
{
    public partial class OrderViewForm : Form
    {
        OrderService orderService;
        public OrderViewForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            // LoadMenuItems("Lunch");
            LoadAllMenuItems();
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            // LoadMenuItems("Diner");
            LoadAllMenuItems();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //LoadMenuItems("Drinks");
            LoadAllMenuItems();
        }

        //private void LoadMenuItems(string card)
        //{
        //    List<MenuItem> menuItems = orderService.GetMenuItemsByCard(card);

        //    int verticalPosition = 5;

        //    foreach (MenuItem item in menuItems)
        //    {
        //        UCOrderView ucOrderView = new UCOrderView();
        //        ucOrderView.Item = item;
        //        ucOrderView.Location = new Point(5, verticalPosition);
        //        verticalPosition += ucOrderView.Height + 5;
        //        ucOrderView.Visible = true;

        //        pnlOrderView.Controls.Add(ucOrderView);
        //    }
        //}


        private void LoadAllMenuItems()
        {
            List<MenuItem> menuItems = orderService.GetAllMenuItems(); // Retrieve all menu items

            int verticalPosition = 5;

            foreach (MenuItem item in menuItems)
            {
                UCOrderView ucOrderView = new UCOrderView();
                ucOrderView.Item = item;
                ucOrderView.Location = new Point(5, verticalPosition);
                verticalPosition += ucOrderView.Height + 5;
                ucOrderView.Visible = true;

                pnlOrderView.Controls.Add(ucOrderView);
            }
        }

        private void OrderView_Load(object sender, EventArgs e)
        {

        }
    }
}
