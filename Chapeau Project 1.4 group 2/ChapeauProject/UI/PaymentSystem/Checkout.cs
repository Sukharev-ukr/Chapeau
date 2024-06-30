using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Service.PaymentService;

namespace UI.PaymentSystem
{
    public partial class Checkout : Form
    {
        int partNumber;

        Order currentOrder;
        List<Bill> billParts;
        PaymentService paymentService = new PaymentService();
        OrderService orderService = new OrderService();


        //perharps to many paramaters
        public Checkout(List<Bill> bills,int partNumber,Order Order)
        {
            billParts = bills;
            currentOrder = Order;
            this.partNumber = partNumber;

            InitializeComponent();
            CheckPaymentMethod(billParts[partNumber].PaymentMethod);

            labelOrderNr.Text = currentOrder.OrderId.ToString();
            labelPart.Text = (partNumber).ToString();
            labelPartCost.Text = billParts[partNumber].TotalAmount.ToString("F");
        }

        void CheckPaymentMethod(PaymentMethod method)
        {
            switch (method)
            {
                case PaymentMethod.Cash:
                    buttonConfirm.Enabled = true;
                    buttonConfirm.Visible = true;
                    break;
                default:
                    pictureBoxNFC.Enabled = true;
                    pictureBoxNFC.Visible = true;
                    break;
            }
        }

        // checks if there are any parts of the bill left to pay
        private void PaymentConfirm(object sender, EventArgs e)
        {
            billParts[partNumber].Paid = true;
            if (billParts.Count -1   == partNumber)
            {

                orderService.UpdateOrder(currentOrder);
                paymentService.SaveBill(billParts);


                BillCompleted billCompleted = new BillCompleted(currentOrder);
                Program.WindowSwitcher(this, billCompleted);
            }
            else
            {
                PaymentForm form = new PaymentForm(billParts,currentOrder);
                Program.WindowSwitcher(this, form);
            }
        }

    }
}
