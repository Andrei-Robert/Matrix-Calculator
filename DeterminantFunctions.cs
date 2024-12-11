namespace MetodaGauss
{
    public class DeterminantFunctions
    {
        public static double CalculateDeterminant(double[,] matrix, RichTextBox _output)
        {
            int n = matrix.GetLength(0);
            double det = 1;

            // Creează o copie a matricei pentru a evita modificarea matricei originale
            double[,] augmented = (double[,])matrix.Clone();

            for (int i = 0; i < n; i++)
            {
                // Caută elementul pivot
                double diagElement = augmented[i, i];
                if (Math.Abs(diagElement) < 1e-10)
                {
                    // Caută numerele nenule de pe aceeași coloană
                    for (int k = i + 1; k < n; k++)
                    {
                        if (Math.Abs(augmented[k, i]) > Math.Abs(diagElement))
                        {
                            // Schimbă rândurile între ele
                            SwapRows(augmented, i, k);
                            diagElement = augmented[i, i];
                            det *= -1; // Schimbând rândurile între ele se schimbă semnul determinantului
                            _output.Text += Functions.PrintMatrix($"R{i + 1} si {k + 1} schimbate", augmented, n, n);
                            break;
                        }
                    }

                    if (Math.Abs(diagElement) < 1e-10)
                    {
                        return 0; // Matricea este singulară
                    }
                }

                // Elimină elementele din coloanele de sub pivot

                for (int k = i + 1; k < n; k++)
                {
                    double factor = augmented[k, i] / diagElement;
                    for (int j = i; j < n; j++)
                    {
                        augmented[k, j] -= factor * augmented[i, j];
                    }
                    _output.Text += Functions.PrintMatrix($"R{k + 1} - R{i + 1} * -({Functions.ToFraction(factor)})", augmented, n, n);
                }


            }

            // Calculează determinantul prin înmulțirea numerelor de pe diagonală
            _output.Text += "Determinatul este: ";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    _output.Text += "(" + Functions.ToFraction(augmented[i, i]) + ") * ";
                }
                det *= augmented[i, i];
            }
            _output.Text += " = " + det;
            return det;
        }

        public static void SwapRows(double[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);
            for (int i = 0; i < cols; i++)
            {
                double temp = matrix[row1, i];
                matrix[row1, i] = matrix[row2, i];
                matrix[row2, i] = temp;
            }
        }
    }
}