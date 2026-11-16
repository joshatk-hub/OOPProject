namespace OOPProjectRev2
{
    partial class CustomerOrdering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            listViewItems = new ListView();
            columnName = new ColumnHeader();
            columnHeaderCategory = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            comboBoxCategory = new ComboBox();
            menuItemBindingSource1 = new BindingSource(components);
            menuItemBindingSource = new BindingSource(components);
            label1 = new Label();
            buttonAddCart = new Button();
            tabControl1 = new TabControl();
            tabPageBrowse = new TabPage();
            tabPageSaved = new TabPage();
            listViewSavedOrders = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderQty = new ColumnHeader();
            columnHeaderPrice2 = new ColumnHeader();
            buttonDelSaved = new Button();
            buttonSaveOrder = new Button();
            buttonApply = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPageBrowse.SuspendLayout();
            tabPageSaved.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(625, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.home;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "Return to Welcome";
            toolStripButton1.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.user;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(28, 28);
            toolStripButton2.Text = "Account";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.grocery_store;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(28, 28);
            toolStripButton3.Text = "Go to Cart";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { columnName, columnHeaderCategory, columnHeaderPrice });
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(0, 0);
            listViewItems.Margin = new Padding(2);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(361, 284);
            listViewItems.TabIndex = 1;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 180;
            // 
            // columnHeaderCategory
            // 
            columnHeaderCategory.Text = "Category";
            columnHeaderCategory.Width = 100;
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Price";
            columnHeaderPrice.Width = 80;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "All", "Breads", "Cookies", "Muffins", "Pastries", "Cakes", "Pies", "Extras" });
            comboBoxCategory.Location = new Point(462, 47);
            comboBoxCategory.Margin = new Padding(2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(129, 23);
            comboBoxCategory.TabIndex = 2;
            comboBoxCategory.Text = "All";
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // menuItemBindingSource1
            // 
            menuItemBindingSource1.DataSource = typeof(Models.MenuItem);
            // 
            // menuItemBindingSource
            // 
            menuItemBindingSource.DataSource = typeof(Models.MenuItem);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Category:";
            // 
            // buttonAddCart
            // 
            buttonAddCart.BackColor = Color.BlanchedAlmond;
            buttonAddCart.Location = new Point(464, 88);
            buttonAddCart.Margin = new Padding(2);
            buttonAddCart.Name = "buttonAddCart";
            buttonAddCart.Size = new Size(127, 66);
            buttonAddCart.TabIndex = 4;
            buttonAddCart.Text = "Add Item to Cart";
            buttonAddCart.UseVisualStyleBackColor = false;
            buttonAddCart.Click += buttonAddCart_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBrowse);
            tabControl1.Controls.Add(tabPageSaved);
            tabControl1.Location = new Point(12, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(370, 312);
            tabControl1.TabIndex = 5;
            // 
            // tabPageBrowse
            // 
            tabPageBrowse.Controls.Add(listViewItems);
            tabPageBrowse.Location = new Point(4, 24);
            tabPageBrowse.Name = "tabPageBrowse";
            tabPageBrowse.Padding = new Padding(3);
            tabPageBrowse.Size = new Size(362, 284);
            tabPageBrowse.TabIndex = 0;
            tabPageBrowse.Text = "Browse Menu";
            tabPageBrowse.UseVisualStyleBackColor = true;
            // 
            // tabPageSaved
            // 
            tabPageSaved.Controls.Add(listViewSavedOrders);
            tabPageSaved.Location = new Point(4, 24);
            tabPageSaved.Name = "tabPageSaved";
            tabPageSaved.Padding = new Padding(3);
            tabPageSaved.Size = new Size(362, 284);
            tabPageSaved.TabIndex = 1;
            tabPageSaved.Text = "Saved Orders";
            tabPageSaved.UseVisualStyleBackColor = true;
            // 
            // listViewSavedOrders
            // 
            listViewSavedOrders.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderDate, columnHeaderQty, columnHeaderPrice2 });
            listViewSavedOrders.GridLines = true;
            listViewSavedOrders.Location = new Point(0, 0);
            listViewSavedOrders.Name = "listViewSavedOrders";
            listViewSavedOrders.Size = new Size(362, 284);
            listViewSavedOrders.TabIndex = 0;
            listViewSavedOrders.UseCompatibleStateImageBehavior = false;
            listViewSavedOrders.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Order Name";
            columnHeaderName.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date Saved";
            columnHeaderDate.Width = 100;
            // 
            // columnHeaderQty
            // 
            columnHeaderQty.Text = "Qty. Items";
            columnHeaderQty.Width = 70;
            // 
            // columnHeaderPrice2
            // 
            columnHeaderPrice2.Text = "Price";
            columnHeaderPrice2.Width = 90;
            // 
            // buttonDelSaved
            // 
            buttonDelSaved.BackColor = Color.BlanchedAlmond;
            buttonDelSaved.Location = new Point(464, 229);
            buttonDelSaved.Margin = new Padding(2);
            buttonDelSaved.Name = "buttonDelSaved";
            buttonDelSaved.Size = new Size(127, 63);
            buttonDelSaved.TabIndex = 7;
            buttonDelSaved.Text = "Delete Saved Order";
            buttonDelSaved.UseVisualStyleBackColor = false;
            buttonDelSaved.Click += buttonDelSaved_Click;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.BackColor = Color.BlanchedAlmond;
            buttonSaveOrder.Location = new Point(464, 159);
            buttonSaveOrder.Margin = new Padding(2);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(127, 66);
            buttonSaveOrder.TabIndex = 8;
            buttonSaveOrder.Text = "Save Order";
            buttonSaveOrder.UseVisualStyleBackColor = false;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // buttonApply
            // 
            buttonApply.BackColor = Color.BlanchedAlmond;
            buttonApply.Location = new Point(462, 300);
            buttonApply.Margin = new Padding(2);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(127, 59);
            buttonApply.TabIndex = 9;
            buttonApply.Text = "Apply Order to Cart";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // CustomerOrdering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(625, 435);
            Controls.Add(buttonApply);
            Controls.Add(buttonSaveOrder);
            Controls.Add(buttonDelSaved);
            Controls.Add(tabControl1);
            Controls.Add(buttonAddCart);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(toolStrip1);
            ForeColor = Color.SaddleBrown;
            Margin = new Padding(2);
            Name = "CustomerOrdering";
            Text = "Order";
            Load += CustomerOrdering_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageBrowse.ResumeLayout(false);
            tabPageSaved.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ListView listViewItems;
        private ColumnHeader columnName;
        private ColumnHeader columnHeaderCategory;
        private ColumnHeader columnHeaderPrice;
        private ComboBox comboBoxCategory;
        private BindingSource menuItemBindingSource;
        private Label label1;
        private BindingSource menuItemBindingSource1;
        private Button buttonAddCart;
        private TabControl tabControl1;
        private TabPage tabPageBrowse;
        private TabPage tabPageSaved;
        private ListView listViewSavedOrders;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderQty;
        private ColumnHeader columnHeaderPrice2;
        private Button buttonDelSaved;
        private Button buttonSaveOrder;
        private Button buttonApply;
    }
}