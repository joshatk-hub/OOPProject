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
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(893, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.home;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
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
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "Account";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.grocery_store;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "Go to Cart";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { columnName, columnHeaderCategory, columnHeaderPrice });
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(12, 36);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(388, 470);
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
            comboBoxCategory.Location = new Point(508, 36);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(182, 33);
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
            label1.Location = new Point(414, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 3;
            label1.Text = "Category:";
            // 
            // CustomerOrdering
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(893, 518);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(listViewItems);
            Controls.Add(toolStrip1);
            ForeColor = Color.SaddleBrown;
            Name = "CustomerOrdering";
            Text = "Order";
            Load += CustomerOrdering_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuItemBindingSource).EndInit();
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
    }
}