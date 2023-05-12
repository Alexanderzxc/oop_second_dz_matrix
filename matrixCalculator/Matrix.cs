using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixCalculator
{
    internal class Matrix
    {
        private int[,] matrix;
        private int size;
        Random rand = new Random();

        public Matrix(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }

        public void Random()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(100);
                }
            }
        }

        public int[,] FillMatrix(int i, int j, int number)
        {
            matrix[i, j] = number;
            return matrix;
        }
        public int GetValue(int row, int column)
        {
            int number = matrix[row, column];
            return matrix[row, column];
        }

        public void FillMatrixGrid(DataGridView dataGridView)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix = FillMatrix(i, j, Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value));
                }
            }
        }

        public void Visualize(DataGridView dataGridView)
        {
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        public Matrix Sum(Matrix other)
        {
            Matrix res = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    res.matrix[i, j] = this.matrix[i, j] + other.matrix[i, j];
                }
            }
            return res;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix newTemp = a.Sum(b);
            return newTemp;
        }

        public Matrix Multiply(Matrix other)
        {
            int count = 0;
            Matrix res = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        count += this.matrix[i, k] * other.matrix[k, j];
                    }
                    res.matrix[i, j] = count;
                    count = 0;
                }
            }
            return res;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix newTemp = a.Multiply(b);
            return newTemp;
        }

        public Matrix Transposition()
        {
            Matrix res = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    res.matrix[i, j] = this.matrix[j, i];
                }
            }
            return res;
        }

        public static Matrix operator !(Matrix a)
        {
            Matrix newTemp = a.Transposition();
            return newTemp;
        }
    }
}
