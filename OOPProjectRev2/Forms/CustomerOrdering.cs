using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProjectRev2.Models;
using OOPProjectRev2.Services;

namespace OOPProjectRev2
{
    public partial class CustomerOrdering : Form
    {
        private readonly DataStore _datastore;
        public CustomerOrdering()
        {
            InitializeComponent();
            _datastore = new DataStore();
            _datastore.LoadMenuItems();
        }
        public void GetMenuItems()
        {
            List<MenuItem> menuItems = _datastore.LoadMenuItems();
            listViewItems.Items.Clear();
            foreach (var item in menuItems)
            {
                if (item.InSeason && DateTime.Now.Date >= item.SeasonStart.Date && DateTime.Now.Date <= item.SeasonEnd.Date)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Name);
                    listViewItem.SubItems.Add(item.Category);
                    listViewItem.SubItems.Add(item.Price.ToString("C"));
                    listViewItem.Tag = item;
                    listViewItems.Items.Add(listViewItem);
                }
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CustomerAccount customerAccount = new CustomerAccount();
            customerAccount.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OrderInfo orderInfo = new OrderInfo();
            orderInfo.Show();
        }

        private void CustomerOrdering_Load(object sender, EventArgs e)
        {
            GetMenuItems();
        }
    }
}
