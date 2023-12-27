namespace csharp_programming
{
    internal class Program02
    {
        public class Matrix
        {
            int[,] matrix;
            public Matrix(int rows , int columns)
            {
                matrix = new int[rows, columns];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = i +  j;
                    }
                }
            }

            public int this[int i, int j] {
                get { return matrix[i, j]; }
            }

            public int[,] Transpose(){
                int[,] transpose_matrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix.GetLength(1); j++)
                    {
                        transpose_matrix[j, i] = this[i, j];
                    }
                }

                return transpose_matrix;
            }

        }
        public static void Main()
        {
            Matrix m = new Matrix(2, 3);
            int[,] result = m.Transpose();
        }
    }
}
