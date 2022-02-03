using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.OrderNo = Convert.ToInt32(OrderNo.Text);
            o.OrderDesc = OrderDesc.Text;
            o.OrderDate = DateTime.Now.Date;
            o.OrderQuantity = Convert.ToInt32(OrderQuantity.Text);
            o.OrderCreationDate = DateTime.Now.Date;
            o.CreatedBy = CreatedBy.Text;
            Service1Client service = new Service1Client();
            if(service.InsertOrder(o)==1)
            {
                MessageBox.Show("Order Created Successfully");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
