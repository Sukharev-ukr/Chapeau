using DAL;
using Model;
using Service;
using System.Windows.Forms;
using UI.PaymentSystem;


namespace UI.OrderView
{
    public partial class OrderViewForm : Form
    {
        OrderService orderService;
        Dictionary<string, UCOrderView> ucOrderViews = new Dictionary<string, UCOrderView>();

        public OrderViewForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Lunch");
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Diner");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Drinks");
        }

        private void LoadMenuItems(string card)
        {
            pnlOrderView.Controls.Clear();


            List<MenuItem> menuItems = orderService.GetMenuItemsByCard(card);

            int verticalPosition = 5;

            foreach (MenuItem item in menuItems)
            {
                UCOrderView ucOrderView;
                if (!ucOrderViews.TryGetValue(item.Name, out ucOrderView))
                {
                    ucOrderView = new UCOrderView();
                    ucOrderView.Item = item;
                    ucOrderViews[item.Name] = ucOrderView;
                }

                ucOrderView.Location = new Point(5, verticalPosition);
                verticalPosition += ucOrderView.Height + 5;
                ucOrderView.Visible = true;

                pnlOrderView.Controls.Add(ucOrderView);
            }
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            LoadMenuItems("Lunch");
        }

        private void btnOrderViewSummary_Click(object sender, EventArgs e)
        {
            OrderSummaryForm newForm = new OrderSummaryForm();

            Program.WindowSwitcher(this, newForm);
        }
    }
}
