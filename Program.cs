using RPPONLV3;
using System.Diagnostics;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            MatrixGenerator gen = MatrixGenerator.GetInstance();
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            double[][] matrix = gen.CreateMatrix(a, b);

            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Console.WriteLine(matrix[i][j]);

                }
                
            }
           

           
        }
       
    }
}

