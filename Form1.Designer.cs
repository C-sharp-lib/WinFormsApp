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
            txtPremierCustomer = new Label();
            rYesPremier = new RadioButton();
            rNoPremier = new RadioButton();
            panel1 = new Panel();
            cbGift = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(266, 480);
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
            btnExit.Location = new Point(61, 480);
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
            // txtPremierCustomer
            // 
            txtPremierCustomer.AutoSize = true;
            txtPremierCustomer.Location = new Point(31, 24);
            txtPremierCustomer.Name = "txtPremierCustomer";
            txtPremierCustomer.Size = new Size(103, 15);
            txtPremierCustomer.TabIndex = 11;
            txtPremierCustomer.Text = "Premier Customer";
            // 
            // rYesPremier
            // 
            rYesPremier.AutoSize = true;
            rYesPremier.Location = new Point(40, 42);
            rYesPremier.Name = "rYesPremier";
            rYesPremier.Size = new Size(42, 19);
            rYesPremier.TabIndex = 12;
            rYesPremier.Text = "Yes";
            rYesPremier.UseVisualStyleBackColor = true;
            // 
            // rNoPremier
            // 
            rNoPremier.AutoSize = true;
            rNoPremier.Location = new Point(40, 67);
            rNoPremier.Name = "rNoPremier";
            rNoPremier.Size = new Size(41, 19);
            rNoPremier.TabIndex = 13;
            rNoPremier.Text = "No";
            rNoPremier.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rNoPremier);
            panel1.Controls.Add(rYesPremier);
            panel1.Controls.Add(txtPremierCustomer);
            panel1.Location = new Point(61, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 100);
            panel1.TabIndex = 14;
            // 
            // cbGift
            // 
            cbGift.AutoSize = true;
            cbGift.Location = new Point(290, 359);
            cbGift.Name = "cbGift";
            cbGift.Size = new Size(122, 19);
            cbGift.TabIndex = 15;
            cbGift.Text = "Is this order a gift?";
            cbGift.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(507, 539);
            Controls.Add(cbGift);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label txtPremierCustomer;
        private RadioButton rYesPremier;
        private RadioButton rNoPremier;
        private Panel panel1;
        private CheckBox cbGift;
    }
}
