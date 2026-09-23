namespace Problema7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalPagar = 0;
            double abono = 0;
            double resta = 0;

            if (checkBox1.Checked) { totalPagar += 150.00; }
            if (checkBox2.Checked) { totalPagar += 160.00; }
            if (checkBox3.Checked) { totalPagar += 140.00; }
            if (checkBox4.Checked) { totalPagar += 170.00; }

            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                abono = Convert.ToDouble(textBox5.Text);
            }
            ;
            resta = totalPagar - abono;

            textBox4.Text = totalPagar.ToString("N2");
            textBox6.Text = resta.ToString("N2");
            MessageBox.Show("Registro guardado exitosamente.", "Colegio Salesiano Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox1.Focus();
        }
    }
}
