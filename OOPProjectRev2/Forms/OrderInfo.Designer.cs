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
            dateTimePicker = new DateTimePicker();
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
            labelPickup = new Label();
            textBoxNotes = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = Color.SaddleBrown;
            dateTimePicker.CalendarMonthBackground = Color.BlanchedAlmond;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(517, 133);
            dateTimePicker.Margin = new Padding(2);
            dateTimePicker.MaxDate = new DateTime(2027, 5, 1, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(2024, 4, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(229, 23);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.Value = new DateTime(2026, 11, 10, 20, 40, 13, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(557, 116);
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
            btnPlaceOrder.Location = new Point(426, 295);
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
            buttonAdd.Location = new Point(11, 295);
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
            buttonRemove.Location = new Point(102, 295);
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
            labelTotal.ForeColor = Color.SaddleBrown;
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
            labelSubtotal.ForeColor = Color.SaddleBrown;
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
            labelTaxAmt.ForeColor = Color.SaddleBrown;
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
            buttonClear.Location = new Point(197, 295);
            buttonClear.Margin = new Padding(2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(91, 45);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear Order";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelPickup
            // 
            labelPickup.AutoSize = true;
            labelPickup.ForeColor = Color.SaddleBrown;
            labelPickup.Location = new Point(518, 93);
            labelPickup.Name = "labelPickup";
            labelPickup.Size = new Size(116, 15);
            labelPickup.TabIndex = 12;
            labelPickup.Text = "Earliest Pickup Time:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(517, 186);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(229, 105);
            textBoxNotes.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(610, 168);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 14;
            label2.Text = "Notes:";
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(756, 403);
            Controls.Add(label2);
            Controls.Add(textBoxNotes);
            Controls.Add(labelPickup);
            Controls.Add(buttonClear);
            Controls.Add(labelTaxAmt);
            Controls.Add(labelSubtotal);
            Controls.Add(labelTotal);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listViewItems);
            Controls.Add(btnPlaceOrder);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Margin = new Padding(2);
            Name = "OrderInfo";
            Text = "OrderInfo";
            Load += OrderInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker;
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
        private Label labelPickup;
        private TextBox textBoxNotes;
        private Label label2;
    }
}