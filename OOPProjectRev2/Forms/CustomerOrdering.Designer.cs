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
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnMinus = new Button();
            labelAmtSourdough = new Label();
            btnMinus2 = new Button();
            btnAdd2 = new Button();
            labelAmtBaguette = new Label();
            amt1 = new Label();
            amt2 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(628, 33);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 58);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Sourdough Loaf:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Baguette:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.BlanchedAlmond;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(274, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(33, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.BlanchedAlmond;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(182, 54);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(32, 34);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // labelAmtSourdough
            // 
            labelAmtSourdough.AutoSize = true;
            labelAmtSourdough.Location = new Point(241, 58);
            labelAmtSourdough.Name = "labelAmtSourdough";
            labelAmtSourdough.Size = new Size(0, 25);
            labelAmtSourdough.TabIndex = 5;
            // 
            // btnMinus2
            // 
            btnMinus2.BackColor = Color.BlanchedAlmond;
            btnMinus2.FlatStyle = FlatStyle.Flat;
            btnMinus2.Location = new Point(182, 99);
            btnMinus2.Name = "btnMinus2";
            btnMinus2.Size = new Size(32, 34);
            btnMinus2.TabIndex = 7;
            btnMinus2.Text = "-";
            btnMinus2.UseVisualStyleBackColor = false;
            // 
            // btnAdd2
            // 
            btnAdd2.BackColor = Color.BlanchedAlmond;
            btnAdd2.FlatStyle = FlatStyle.Flat;
            btnAdd2.Location = new Point(274, 98);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(33, 35);
            btnAdd2.TabIndex = 6;
            btnAdd2.Text = "+";
            btnAdd2.UseVisualStyleBackColor = false;
            // 
            // labelAmtBaguette
            // 
            labelAmtBaguette.AutoSize = true;
            labelAmtBaguette.Location = new Point(241, 103);
            labelAmtBaguette.Name = "labelAmtBaguette";
            labelAmtBaguette.Size = new Size(0, 25);
            labelAmtBaguette.TabIndex = 8;
            // 
            // amt1
            // 
            amt1.AutoSize = true;
            amt1.Location = new Point(232, 59);
            amt1.Name = "amt1";
            amt1.Size = new Size(22, 25);
            amt1.TabIndex = 9;
            amt1.Text = "0";
            // 
            // amt2
            // 
            amt2.AutoSize = true;
            amt2.Location = new Point(232, 104);
            amt2.Name = "amt2";
            amt2.Size = new Size(22, 25);
            amt2.TabIndex = 10;
            amt2.Text = "0";
            // 
            // CustomerOrdering
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(628, 359);
            Controls.Add(amt2);
            Controls.Add(amt1);
            Controls.Add(labelAmtBaguette);
            Controls.Add(btnMinus2);
            Controls.Add(btnAdd2);
            Controls.Add(labelAmtSourdough);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            ForeColor = Color.SaddleBrown;
            Name = "CustomerOrdering";
            Text = "Order";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnMinus;
        private Label labelAmtSourdough;
        private Button btnMinus2;
        private Button btnAdd2;
        private Label labelAmtBaguette;
        private Label amt1;
        private Label amt2;
    }
}