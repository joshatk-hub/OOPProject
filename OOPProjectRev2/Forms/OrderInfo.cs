using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProjectRev2
{
    public partial class OrderInfo : Form
    {
        public OrderInfo()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for placing an order! You may pick it up at the time selected.");
            this.Close();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
