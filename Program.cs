using RPPONLV3;
using System.Diagnostics;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            MatrixGenerator gen = MatrixGenerator.GetInstance();
            double[][] matrix = gen.CreateMatrix(5, 5);            
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix.Length; i++)
                {
                    Console.WriteLine(matrix[i][j]);
                }
            }


        }
    }
}
