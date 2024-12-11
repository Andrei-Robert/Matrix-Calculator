namespace MetodaGauss
{
    public class InverseFunctions
    {
        public static double[,] InverseMatrix(double[,] matrix, RichTextBox _output)
        {
            int n = matrix.GetLength(0);
            double[,] augmented = new double[n, 2 * n];

            // Se creează matricea extinsă [A | I]
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmented[i, j] = matrix[i, j];
                }
                augmented[i, n + i] = 1;
            }

            _output.Text += Functions.PrintMatrix("Adaugam I la matricea introdusa:", augmented, n, 2 * n, true);

            // Se aplică metoda Gauss de eliminare
            for (int i = 0; i < n; i++)
            {
                // Toate elementele de pe diagonală devin 1
                double diagElement = augmented[i, i];
                if (Math.Abs(diagElement) < 1e-10)
                {
                    return null; // Matrice singulară
                }
                for (int j = 0; j < 2 * n; j++)
                {
                    augmented[i, j] /= diagElement;
                }

                _output.Text += Functions.PrintMatrix($"R{i + 1} / {Functions.ToFraction(diagElement)} (pivot):", augmented, n, 2 * n, true);

                // Toate celelalte elemente devin 0
                for (int k = 0; k < n; k++)
                {
                    if (k == i)
                        continue;
                    double factor = augmented[k, i];
                    for (int j = 0; j < 2 * n; j++)
                    {
                        augmented[k, j] -= factor * augmented[i, j];
                    }
                    _output.Text += Functions.PrintMatrix($"R{k + 1} - R{i + 1} * {Functions.ToFraction(factor)}:", augmented, n, 2 * n, true);
                }
            }

            // Se extrage inversa matricei
            double[,] inverse = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverse[i, j] = augmented[i, n + j];
                }
            }

            return inverse;
        }
    }
}