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
            _datastore.LoadRegularMenuItems();
        }
        public void GetMenuItems()
        {
            foreach (var item in _datastore.LoadRegularMenuItems())
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Category);
                listViewItem.SubItems.Add(item.Price.ToString("C"));
                listViewItems.Items.Add(listViewItem);
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

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.ToString() == "All")
            {
                listViewItems.Items.Clear();
                GetMenuItems();
            }
            else
            {
                for (int i = 0; i < comboBoxCategory.Items.Count; i++)
                {
                    if (comboBoxCategory.SelectedItem.ToString() == _datastore.LoadRegularMenuItems()[i].Category)
                    {
                        listViewItems.Items.Clear();
                        for (int j = 0; j < _datastore.LoadRegularMenuItems().Count; j++)
                        {
                            if (_datastore.LoadRegularMenuItems()[j].Category == comboBoxCategory.SelectedItem.ToString())
                            {
                                ListViewItem listViewItem = new ListViewItem(_datastore.LoadRegularMenuItems()[j].Name);
                                listViewItem.SubItems.Add(_datastore.LoadRegularMenuItems()[j].Category);
                                listViewItem.SubItems.Add(_datastore.LoadRegularMenuItems()[j].Price.ToString("C"));
                                listViewItems.Items.Add(listViewItem);
                            }
                        }
                    }
                }
            }
        }
    }
}
