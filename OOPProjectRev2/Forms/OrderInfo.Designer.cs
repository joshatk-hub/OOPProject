namespace OOPProjectRev2
{
    partial class OrderInfo
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnPlaceOrder = new Button();
            listViewItems = new ListView();
            columnName = new ColumnHeader();
            columnHeaderQty = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            columnHeaderTax = new ColumnHeader();
            columnHeaderTotal = new ColumnHeader();
            buttonAdd = new Button();
            buttonRemove = new Button();
            labelTotal = new Label();
            labelSubtotal = new Label();
            labelTaxAmt = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.SaddleBrown;
            dateTimePicker1.CalendarMonthBackground = Color.BlanchedAlmond;
            dateTimePicker1.Location = new Point(626, 168);
            dateTimePicker1.MaxDate = new DateTime(2026, 10, 27, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 10, 19, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(326, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2026, 10, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 140);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 2;
            label1.Text = "Scheduled for pickup on:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.BlanchedAlmond;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.ForeColor = Color.SaddleBrown;
            btnPlaceOrder.Location = new Point(731, 281);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(119, 63);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { columnName, columnHeaderQty, columnHeaderPrice, columnHeaderTax, columnHeaderTotal });
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(12, 12);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(608, 470);
            listViewItems.TabIndex = 5;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 180;
            // 
            // columnHeaderQty
            // 
            columnHeaderQty.Text = "Quantity";
            columnHeaderQty.Width = 80;
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Subtotal";
            columnHeaderPrice.Width = 80;
            // 
            // columnHeaderTax
            // 
            columnHeaderTax.Text = "Tax";
            columnHeaderTax.Width = 80;
            // 
            // columnHeaderTotal
            // 
            columnHeaderTotal.Text = "Total";
            columnHeaderTotal.Width = 80;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.BlanchedAlmond;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.SaddleBrown;
            buttonAdd.Location = new Point(626, 205);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 70);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add Item";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.BlanchedAlmond;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.ForeColor = Color.SaddleBrown;
            buttonRemove.Location = new Point(822, 205);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(130, 70);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Remove Item";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(626, 83);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(129, 25);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Order Total: $0";
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(626, 12);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(159, 25);
            labelSubtotal.TabIndex = 9;
            labelSubtotal.Text = "Order Subtotal: $0";
            // 
            // labelTaxAmt
            // 
            labelTaxAmt.AutoSize = true;
            labelTaxAmt.Location = new Point(626, 46);
            labelTaxAmt.Name = "labelTaxAmt";
            labelTaxAmt.Size = new Size(116, 25);
            labelTaxAmt.TabIndex = 10;
            labelTaxAmt.Text = "Order Tax: $0";
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(964, 450);
            Controls.Add(labelTaxAmt);
            Controls.Add(labelSubtotal);
            Controls.Add(labelTotal);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listViewItems);
            Controls.Add(btnPlaceOrder);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "OrderInfo";
            Text = "OrderInfo";
            Load += OrderInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnPlaceOrder;
        private ListView listViewItems;
        private ColumnHeader columnName;
        private ColumnHeader columnHeaderPrice;
        private ColumnHeader columnHeaderQty;
        private Button buttonAdd;
        private Button buttonRemove;
        private ColumnHeader columnHeaderTax;
        private ColumnHeader columnHeaderTotal;
        private Label labelTotal;
        private Label labelSubtotal;
        private Label labelTaxAmt;
    }
}