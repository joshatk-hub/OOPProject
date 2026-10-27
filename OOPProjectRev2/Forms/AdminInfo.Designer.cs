namespace OOPProjectRev2.Forms
{
    partial class AdminInfo
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Goldenrod;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(122, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 1;
            label1.Text = "Orders in Queue:";
            // 
            // button1
            // 
            button1.BackColor = Color.BlanchedAlmond;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(456, 134);
            button1.Name = "button1";
            button1.Size = new Size(138, 65);
            button1.TabIndex = 2;
            button1.Text = "Inventory Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.BlanchedAlmond;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(456, 219);
            button2.Name = "button2";
            button2.Size = new Size(138, 57);
            button2.TabIndex = 3;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlanchedAlmond;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.SaddleBrown;
            button3.Location = new Point(456, 51);
            button3.Name = "button3";
            button3.Size = new Size(138, 62);
            button3.TabIndex = 4;
            button3.Text = "Active Orders";
            button3.UseVisualStyleBackColor = false;
            // 
            // AdminInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(646, 334);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AdminInfo";
            Text = "Admin Info";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}