namespace WinFormsApp1
{
    partial class Form1
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
            btnSubmit = new Button();
            btnExit = new Button();
            txtSubtotal = new Label();
            tbSubtotal = new TextBox();
            txtDiscountPercent = new Label();
            txtDiscountAmount = new Label();
            txtTotal = new Label();
            tbDiscountPercent = new TextBox();
            tbDiscountAmount = new TextBox();
            tbTotal = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(266, 338);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(178, 47);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 64, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(61, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(182, 47);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.AutoSize = true;
            txtSubtotal.Location = new Point(61, 109);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(51, 15);
            txtSubtotal.TabIndex = 3;
            txtSubtotal.Text = "Subtotal";
            // 
            // tbSubtotal
            // 
            tbSubtotal.Location = new Point(266, 106);
            tbSubtotal.Name = "tbSubtotal";
            tbSubtotal.Size = new Size(178, 23);
            tbSubtotal.TabIndex = 4;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.AutoSize = true;
            txtDiscountPercent.Location = new Point(61, 163);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.Size = new Size(67, 15);
            txtDiscountPercent.TabIndex = 5;
            txtDiscountPercent.Text = "Discount %";
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.AutoSize = true;
            txtDiscountAmount.Location = new Point(61, 214);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(63, 15);
            txtDiscountAmount.TabIndex = 6;
            txtDiscountAmount.Text = "Discount $";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(61, 272);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(32, 15);
            txtTotal.TabIndex = 7;
            txtTotal.Text = "Total";
            // 
            // tbDiscountPercent
            // 
            tbDiscountPercent.Enabled = false;
            tbDiscountPercent.Location = new Point(266, 160);
            tbDiscountPercent.Name = "tbDiscountPercent";
            tbDiscountPercent.Size = new Size(178, 23);
            tbDiscountPercent.TabIndex = 8;
            // 
            // tbDiscountAmount
            // 
            tbDiscountAmount.Enabled = false;
            tbDiscountAmount.Location = new Point(266, 211);
            tbDiscountAmount.Name = "tbDiscountAmount";
            tbDiscountAmount.Size = new Size(178, 23);
            tbDiscountAmount.TabIndex = 9;
            // 
            // tbTotal
            // 
            tbTotal.Enabled = false;
            tbTotal.Location = new Point(266, 269);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(178, 23);
            tbTotal.TabIndex = 10;
            // 
            // Form1
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(507, 450);
            Controls.Add(tbTotal);
            Controls.Add(tbDiscountAmount);
            Controls.Add(tbDiscountPercent);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(tbSubtotal);
            Controls.Add(txtSubtotal);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Invoice Total Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnExit;
        private Label txtSubtotal;
        private TextBox tbSubtotal;
        private Label txtDiscountPercent;
        private Label txtDiscountAmount;
        private Label txtTotal;
        private TextBox tbDiscountPercent;
        private TextBox tbDiscountAmount;
        private TextBox tbTotal;
    }
}
