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
            buttonClear = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.SaddleBrown;
            dateTimePicker1.CalendarMonthBackground = Color.BlanchedAlmond;
            dateTimePicker1.Location = new Point(517, 114);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.MaxDate = new DateTime(2026, 10, 27, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 10, 19, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2026, 10, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(557, 97);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 2;
            label1.Text = "Scheduled for pickup on:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.BlanchedAlmond;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.ForeColor = Color.SaddleBrown;
            btnPlaceOrder.Location = new Point(517, 196);
            btnPlaceOrder.Margin = new Padding(2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(87, 45);
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
            listViewItems.Location = new Point(8, 7);
            listViewItems.Margin = new Padding(2);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(505, 284);
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
            buttonAdd.Location = new Point(517, 141);
            buttonAdd.Margin = new Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(87, 42);
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
            buttonRemove.Location = new Point(655, 141);
            buttonRemove.Margin = new Padding(2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(91, 42);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Remove Item";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(517, 69);
            labelTotal.Margin = new Padding(2, 0, 2, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(84, 15);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Order Total: $0";
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(517, 9);
            labelSubtotal.Margin = new Padding(2, 0, 2, 0);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(102, 15);
            labelSubtotal.TabIndex = 9;
            labelSubtotal.Text = "Order Subtotal: $0";
            // 
            // labelTaxAmt
            // 
            labelTaxAmt.AutoSize = true;
            labelTaxAmt.Location = new Point(517, 40);
            labelTaxAmt.Margin = new Padding(2, 0, 2, 0);
            labelTaxAmt.Name = "labelTaxAmt";
            labelTaxAmt.Size = new Size(75, 15);
            labelTaxAmt.TabIndex = 10;
            labelTaxAmt.Text = "Order Tax: $0";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.BlanchedAlmond;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = Color.SaddleBrown;
            buttonClear.Location = new Point(655, 196);
            buttonClear.Margin = new Padding(2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(87, 45);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear Order";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(763, 324);
            Controls.Add(buttonClear);
            Controls.Add(labelTaxAmt);
            Controls.Add(labelSubtotal);
            Controls.Add(labelTotal);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listViewItems);
            Controls.Add(btnPlaceOrder);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(2);
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
        private Button buttonClear;
    }
}