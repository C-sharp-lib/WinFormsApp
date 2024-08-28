namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(tbSubtotal.Text);
            decimal discountPercent = 0m;
            if (rYesPremier.Checked)
            {
                if (subtotal > 50 || subtotal <= 100)
                {
                    discountPercent = .1m;
                }
                else if (subtotal > 100 && subtotal <= 150)
                {
                    discountPercent = .15m;
                }
                else if (subtotal > 150)
                {
                    discountPercent = .20m;
                }
            }
            decimal discountAmount = subtotal * discountPercent;
            decimal total = subtotal - discountAmount;
            if (cbGift.Checked)
            {
                total += 5;
            }
            tbDiscountPercent.Text = discountPercent.ToString("p2");
            tbDiscountAmount.Text = discountAmount.ToString("C");
            tbTotal.Text = total.ToString("C");
        }
    }
}
