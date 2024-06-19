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

        PaymentMethod paymentMethod;

        Order currentOrder;
        List<Bill> billParts;


        //perharps to many paramaters
        public Checkout(List<Bill> bills,int partNumber,Order Order)
        {
            billParts = bills;
            Bill part = billParts[partNumber];
            currentOrder = Order;


            InitializeComponent();
            CheckPaymentMethod(paymentMethod);

            labelOrderNr.Text = currentOrder.OrderId.ToString();
            labelPart.Text = (partNumber + 1).ToString();
            labelPartCost.Text = part.TotalAmount.ToString();
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
            if (billParts.Count -1  == partNumber)
            {

                // to much shit
                OrderService orderService = new OrderService();
                orderService.UpdateOrder(currentOrder);


                PaymentService paymentService = new PaymentService();
                paymentService.SaveBill(billParts);


                BillCompleted billCompleted = new BillCompleted();
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
