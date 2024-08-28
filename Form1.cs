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
            var discountPercent = 0m;
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
            var discountAmount = subtotal * discountPercent;
            var total = subtotal - discountAmount;
            tbDiscountPercent.Text = discountPercent.ToString("P2");
            tbDiscountAmount.Text = discountAmount.ToString("C");
            tbTotal.Text = total.ToString("C");
        }
    }
}
