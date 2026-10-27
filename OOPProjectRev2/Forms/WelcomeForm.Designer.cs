namespace OOPProjectRev2
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlaceOrder = new Button();
            btnAdminPortal = new Button();
            SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.BlanchedAlmond;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.ForeColor = Color.SaddleBrown;
            btnPlaceOrder.Location = new Point(84, 58);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(150, 150);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place an Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnAdminPortal
            // 
            btnAdminPortal.BackColor = Color.BlanchedAlmond;
            btnAdminPortal.FlatStyle = FlatStyle.Flat;
            btnAdminPortal.ForeColor = Color.SaddleBrown;
            btnAdminPortal.Location = new Point(341, 58);
            btnAdminPortal.Name = "btnAdminPortal";
            btnAdminPortal.Size = new Size(150, 150);
            btnAdminPortal.TabIndex = 1;
            btnAdminPortal.Text = "Administrator Portal";
            btnAdminPortal.UseVisualStyleBackColor = false;
            btnAdminPortal.Click += btnAdminPortal_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(579, 267);
            Controls.Add(btnAdminPortal);
            Controls.Add(btnPlaceOrder);
            Name = "WelcomeForm";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlaceOrder;
        private Button btnAdminPortal;
    }
}
