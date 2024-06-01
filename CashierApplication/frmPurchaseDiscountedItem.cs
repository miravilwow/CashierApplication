using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        private DiscountedItem discountedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = ItemtextBox1.Text;
            double price = double.Parse(PricestextBox3.Text);
            int quantity = Convert.ToInt32(QuantitytextBox4.Text);
            double discount = double.Parse(DiscounttextBox2.Text);

            discountedItem = new DiscountedItem(name, price, quantity, discount);
            double totalPrice = discountedItem.getTotalPrice();
            TotalAmountlabel6.Text = totalPrice.ToString();
        }

        private void Submitbutton2_Click(object sender, EventArgs e)
        {
            double AmountPayment = double.Parse(PaymenttextBox5.Text);
            discountedItem.setPayment(AmountPayment);
            double change = discountedItem.getChange();
            Changelabel8.Text = change.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
