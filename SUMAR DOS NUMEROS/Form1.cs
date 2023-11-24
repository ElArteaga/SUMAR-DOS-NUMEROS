namespace SUMAR_DOS_NUMEROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtN1.Text = "";
            TxtN2.Text = "";
            TxtR.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1 = double.Parse(TxtN1.Text);
            N2 = double.Parse(TxtN2.Text);
            R = N1 + N2;
            TxtR.Text = R.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       }
    }

