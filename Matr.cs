using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace lab1
{
    class Matr
    {
        private int size;

        private int[,] matrix; // обрабатываемая матрица

        public Matr(int n)
        {
            this.size = n;
            this.matrix = new int[n, n];
        }

        public int[,] GetMatr()
        {
            return matrix;
        }

        /*если выбрано заполнение вручную, то оставляем заполнение для пользователя
          выше главной диагонали*/

        public void Select(DataGridView GrVw)
        {
            GrVw.ReadOnly = false;
            for (int i = 0; i < size; i++)
                for (int j = 0; j <= i; j++)
                    GrVw[j, i].ReadOnly = true;
        }

        //заполнение матрицы из DataGridView
        public void GridToMatrix(DataGridView GrVw)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    txtCell = GrVw.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    //string s = GrVw[j, i].Value.ToString();
                    if (s == "")
                        matrix[j, i] = matrix[i, j] = 0;
                    else
                        try
                        {
                            matrix[j, i] = matrix[i, j] = Int32.Parse(s);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Неверный формат");
                        }
                }
            }
        }

        //заполнение матрицы рандомно
        public void RandomToMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (i == j)
                        matrix[j, i] = 0;
                    else
                        matrix[j, i] = matrix[i, j] = rand.Next(100);
                }
            }
        }

        //вывод матрицы в DataGridView
        public void MatrixToGrid(DataGridView GrVw, int count)
        {
            //установка размеров
            DataTable matr = new DataTable("Расстояние между городами");
            DataColumn[] cols = new DataColumn[count];

            for (int i = 0; i < count; i++)
            {
                cols[i] = new DataColumn((i + 1).ToString());
                matr.Columns.Add(cols[i]);
            }

            for (int i = 0; i < count; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            GrVw.DataSource = matr;
            for (int i = 0; i < count; i++)
            {
                GrVw.Columns[i].Width = 50;
                GrVw.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            // занесение значений
            DataGridViewCell Cell;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cell = GrVw.Rows[i].Cells[j];
                    Cell.Value = matrix[i, j];
                }
            }

            GrVw.AllowUserToAddRows = false;
            GrVw.ReadOnly = true;
        }
    }
}
