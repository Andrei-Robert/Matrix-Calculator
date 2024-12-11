namespace MetodaGauss
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inversa inversa_form = new Inversa();
            this.Hide();
            inversa_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Determinant determinant_form = new Determinant();
            this.Hide();
            determinant_form.Show();
        }
    }
}