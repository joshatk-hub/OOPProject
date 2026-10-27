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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnEditOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Goldenrod;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.SaddleBrown;
            dateTimePicker1.CalendarMonthBackground = Color.BlanchedAlmond;
            dateTimePicker1.Location = new Point(424, 48);
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
            label1.Location = new Point(472, 12);
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
            btnPlaceOrder.Location = new Point(631, 103);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(119, 63);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.BackColor = Color.BlanchedAlmond;
            btnEditOrder.FlatStyle = FlatStyle.Flat;
            btnEditOrder.ForeColor = Color.SaddleBrown;
            btnEditOrder.Location = new Point(424, 103);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(112, 63);
            btnEditOrder.TabIndex = 4;
            btnEditOrder.Text = "Edit Order";
            btnEditOrder.UseVisualStyleBackColor = false;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(772, 450);
            Controls.Add(btnEditOrder);
            Controls.Add(btnPlaceOrder);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "OrderInfo";
            Text = "OrderInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnPlaceOrder;
        private Button btnEditOrder;
    }
}