﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPONLV3
{
    public class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;

        private MatrixGenerator()
        {
            this.generator = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] CreateMatrix(int rows, int columns)
        {
            double[][] matrix = new double[rows][];
            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new double[columns];
            }
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }
            return matrix;
        }
    }
}
