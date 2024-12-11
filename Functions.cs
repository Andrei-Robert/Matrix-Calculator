using System.Text;

namespace MetodaGauss
{
    public class Functions
    {
        public static double[,] ReadMatrix(string[] _lines, int _rows, int _cols)
        {
            double[,] matrix = new double[_rows, _cols];

            if (_rows != _cols)
            {
                throw new FormatException("Matricea nu este patratica");
            }
            for (int i = 0; i < _rows; i++)
            {
                string[] elements = _lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (elements.Length != _cols)
                {
                    throw new FormatException($"Randul {i + 1} nu are numarul corect de coloane.");
                }
                for (int j = 0; j < _cols; j++)
                {
                    if (!double.TryParse(elements[j], out matrix[i, j]))
                    {
                        throw new FormatException($"Unitatea introdusa este incorecta pe randul {i + 1} si coloana {j + 1}.");
                    }
                    matrix[i, j] = double.Parse(elements[j]);
                }
            }
            return matrix;
        }
        public static string PrintMatrix(string _matrixText, double[,] _matrix, int _rows, int _cols, bool inversa = false)
        {
            double[] x = new double[_cols];

            int numRows = _matrix.GetLength(0);
            int numCols = _matrix.GetLength(1);

            int[] columnWidths = new int[numCols];

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_matrixText);
            for (int i = 0; i < _rows; i++)
            {
                sb.Append("[" + "\t");

                for (int j = 0; j < _cols; j++)
                {
                    if (inversa == true && j != 0 && (j % (_cols / 2) == 0))
                    {
                        sb.Append("|\t");
                    }
                    sb.Append(ToFraction(_matrix[i, j]) + "\t");
                }
                sb.Append("]");
                sb.AppendLine();
            }
            sb.AppendLine("--------------------------------------------------------------------------------------------------");
            return sb.ToString();
        }

        public static string ToFraction(double value)
        {
            if (Math.Abs(value % 1) < 1e-10) // Verifică dacă numărul este întreg
            {
                return ((int)value).ToString();
            }

            // Numerele care nu sunt întregi devin fracții
            int sign = Math.Sign(value);
            value = Math.Abs(value);
            double tolerance = 1.0E-6;
            double h1 = 1;
            double h2 = 0;
            double k1 = 0;
            double k2 = 1;
            double b = value;
            do
            {
                double a = Math.Floor(b);
                double aux = h1;
                h1 = a * h1 + h2;
                h2 = aux;
                aux = k1;
                k1 = a * k1 + k2;
                k2 = aux;
                b = 1 / (b - a);
            } while (Math.Abs(value - h1 / k1) > value * tolerance);

            return $"{sign * h1}/{k1}";
        }
    }
}