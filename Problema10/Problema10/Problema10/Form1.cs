namespace Problema10
{
    public partial class Form1 : Form
    {
        private const decimal PRECIO_BOX      = 150.00m;
        private const decimal PRECIO_PAVILION = 100.00m;
        private const decimal PRECIO_LAWN     =  75.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int boxQty = 0, pavilionQty = 0, lawnQty = 0;

            if (chkBox.Checked)
            {
                if (!int.TryParse(txtBox.Text, out boxQty) || boxQty < 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida para Box.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (chkPavilion.Checked)
            {
                if (!int.TryParse(txtPavilion.Text, out pavilionQty) || pavilionQty < 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida para Pavilion.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (chkLawn.Checked)
            {
                if (!int.TryParse(txtLawn.Text, out lawnQty) || lawnQty < 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida para Lawn.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int totalTickets = boxQty + pavilionQty + lawnQty;
            decimal totalDue = (boxQty * PRECIO_BOX)
                             + (pavilionQty * PRECIO_PAVILION)
                             + (lawnQty * PRECIO_LAWN);

            if (chk10Discount.Checked)
                totalDue *= 0.90m;   // aplica 10% de descuento

            txtTotalTickets.Text = totalTickets.ToString();
            txtTotalDue.Text     = totalDue.ToString("C2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            txtBox.Enabled = chkBox.Checked;
            if (!chkBox.Checked) txtBox.Text = "";
        }

        private void chkPavilion_CheckedChanged(object sender, EventArgs e)
        {
            txtPavilion.Enabled = chkPavilion.Checked;
            if (!chkPavilion.Checked) txtPavilion.Text = "";
        }

        private void chkLawn_CheckedChanged(object sender, EventArgs e)
        {
            txtLawn.Enabled = chkLawn.Checked;
            if (!chkLawn.Checked) txtLawn.Text = "";
        }
    }
}
