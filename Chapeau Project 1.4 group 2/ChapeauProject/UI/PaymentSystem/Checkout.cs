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

        CurrentOrder currentOrder;
        BillParts billParts;

        public Checkout(PaymentMethod method)
        {
            billParts = BillParts.Getinstance();

            currentOrder = CurrentOrder.Getinstance();
            partNumber = billParts.currentPart.BillId;
            Bill part = billParts.ListOFParts[partNumber];

            paymentMethod = method;

            InitializeComponent();
            CheckPaymentMethod(paymentMethod);

            labelOrderNr.Text = currentOrder.orderId.ToString();
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
            if (billParts.ListOFParts.Count-1 == partNumber)
            {
                OrderService orderService = new OrderService();
                orderService.UpdateTipById(currentOrder.Tip, currentOrder.orderId);
                orderService.UpdateTotalById( currentOrder.OrderTotal, currentOrder.orderId);

                PaymentService paymentService = new PaymentService();
                paymentService.UploadBill(billParts.ListOFParts);
                

                BillCompleted billCompleted = new BillCompleted();
                Program.WindowSwitcher(this, billCompleted);
            }
            else
            {
                billParts.IncrementParts();
                PaymentForm form = new PaymentForm();
                Program.WindowSwitcher(this, form);
            }
        }

    }
}
