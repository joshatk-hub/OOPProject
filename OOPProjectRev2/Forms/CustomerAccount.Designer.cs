namespace OOPProjectRev2
{
    partial class CustomerAccount
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
            textBoxNumber = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSignIn = new Button();
            linkLabel1 = new LinkLabel();
            listViewOrders = new ListView();
            columnHeaderConfirmation = new ColumnHeader();
            columnHeaderPickup = new ColumnHeader();
            columnHeaderStatus = new ColumnHeader();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.BackColor = Color.BlanchedAlmond;
            textBoxNumber.ForeColor = Color.SaddleBrown;
            textBoxNumber.Location = new Point(117, 35);
            textBoxNumber.Margin = new Padding(2);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(178, 23);
            textBoxNumber.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.BlanchedAlmond;
            textBoxEmail.ForeColor = Color.SaddleBrown;
            textBoxEmail.Location = new Point(117, 59);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(178, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.BlanchedAlmond;
            textBoxPassword.ForeColor = Color.SaddleBrown;
            textBoxPassword.Location = new Point(117, 83);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(178, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Phone Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.BlanchedAlmond;
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.Location = new Point(156, 113);
            buttonSignIn.Margin = new Padding(2);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(78, 27);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.IndianRed;
            linkLabel1.Location = new Point(135, 142);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "or, continue as guest";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listViewOrders
            // 
            listViewOrders.BackColor = SystemColors.Window;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeaderConfirmation, columnHeaderPickup, columnHeaderStatus });
            listViewOrders.ForeColor = SystemColors.ActiveCaptionText;
            listViewOrders.Location = new Point(330, 35);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(296, 200);
            listViewOrders.TabIndex = 8;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // columnHeaderConfirmation
            // 
            columnHeaderConfirmation.Text = "Confirmation Number";
            columnHeaderConfirmation.Width = 120;
            // 
            // columnHeaderPickup
            // 
            columnHeaderPickup.Text = "Pickup Time";
            columnHeaderPickup.Width = 100;
            // 
            // columnHeaderStatus
            // 
            columnHeaderStatus.Text = "Status";
            // 
            // CustomerAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(638, 317);
            Controls.Add(listViewOrders);
            Controls.Add(linkLabel1);
            Controls.Add(buttonSignIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNumber);
            ForeColor = Color.SaddleBrown;
            Margin = new Padding(2);
            Name = "CustomerAccount";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSignIn;
        private LinkLabel linkLabel1;
        private ListView listViewOrders;
        private ColumnHeader columnHeaderConfirmation;
        private ColumnHeader columnHeaderPickup;
        private ColumnHeader columnHeaderStatus;
    }
}