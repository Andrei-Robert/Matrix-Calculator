namespace MetodaGauss
{
    public partial class Inversa : Form
    {
        public Inversa()
        {
            InitializeComponent();
        }

        private void buttonInversa_Click(object sender, EventArgs e)
        {
            string[] lines = input.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            double[,] matrix;

            output.Text = "";
            try
            {
                matrix = Functions.ReadMatrix(lines, rows, cols);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Matrix Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            output.Text += Functions.PrintMatrix("Matricea introdusa:", matrix, rows, cols);

            double[,] inverse = InverseFunctions.InverseMatrix(matrix, output);

            if (inverse != null)
            {
                output.Text += Functions.PrintMatrix("Inversa matrici:", inverse, rows, cols);
            }
            else
            {
                MessageBox.Show("Matrix is singular and cannot be inverted.", "Result", MessageBoxButtons.OK);
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            MainForm inversa_form = new MainForm();
            this.Hide();
            inversa_form.Show();
        }
    }
}