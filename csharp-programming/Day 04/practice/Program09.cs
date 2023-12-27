namespace csharp_programming
{
    internal class Program09
    {
        public class Matrix
        {
            int[,] matrix;
            private int rows;
            private int cols;

            public Matrix(int rows, int cols)
            {
                this.matrix = new int[rows,cols];
                this.rows = rows;
                this.cols = cols;
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        this.matrix[i, j] = i + j;
                    }
                }
            }

            public static Matrix operator+(Matrix a, Matrix b)
            {
                if (a.rows != b.rows || a.cols != b.cols)
                    throw new Exception("Matrcix is not valid");
                Matrix m = new Matrix(a.rows, a.cols);
                for(int i = 0; i < a.rows; i++)
                {
                    for(int j =0; j < a.cols; j++)
                    {
                        m.matrix[i,j] = a.matrix[i,j] + b.matrix[i,j];
                    }
                }

                return m;
            }
            
            public static Matrix operator*(Matrix a, Matrix b)
            {
                int r1 = a.rows;
                int c1 = a.cols;
                int r2 = b.rows;
                int c2 = b.cols;

                if(c1 != r2)
                {
                    throw new Exception("Can not multiple matrixes");
                }

                Matrix m = new Matrix(r1, c2);
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        m.matrix[i, j] = 0;
                        for (int k = 0; k < r2; k++)
                            m.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                    }
                }


                return m;

            }

            public static void Main()
            {
                Matrix m1 = new Matrix(2, 2);
                Matrix m2 = new Matrix(2, 2);

                Matrix m3 = m1 + m2;
                m3 = m1 * m2;
            }

        }
    }
}
