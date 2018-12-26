using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Salesman : Form
    {
        Matr matr;
        Algoritm alg;
        int count;
        public Salesman()
        {
            InitializeComponent();
            this.count = 0;
            but_wayOK.Enabled = but_alg.Enabled = pan_select.Enabled = false;
        }

        private void but_countOK_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(num_count.Value);
            if (count<2)
                MessageBox.Show("Ошибка ввода. Введите число больше 1");
            else
            {
                pan_select.Enabled = true;
                matr = new Matr(count);
                matr.MatrixToGrid(GrVw, count);
            }
        }


        private void but_selectOK_Click(object sender, EventArgs e)
        {
            but_wayOK.Enabled = but_alg.Enabled = true;
            if (radBut_hand.Checked)
            {
                matr.GridToMatrix(GrVw);
                matr.MatrixToGrid(GrVw, count);
                alg = new Algoritm(count, matr.GetMatr());
                return;
            }
            if (radBut_rand.Checked)
            {
                matr.RandomToMatrix();
                matr.MatrixToGrid(GrVw, count);
                alg = new Algoritm(count, matr.GetMatr());
                return;
            }
        }

        private void radBut_hand_CheckedChanged(object sender, EventArgs e)
        {
            but_wayOK.Enabled = but_alg.Enabled = false;
            matr.Select(GrVw);
        }

        private void radRand_hand_CheckedChanged(object sender, EventArgs e)
        {
            but_wayOK.Enabled = but_alg.Enabled = false;
        }

        private void but_wayOK_Click(object sender, EventArgs e)
        {
             alg.Leks();
             MessageBox.Show("Кратчайший путь по маршруту " + alg.getAllWay() + " равен " + alg.getWay().ToString());
        }

        private void but_alg_Click(object sender, EventArgs e)
        {
            string timeLeks = alg.Leks();
            string timeRand = alg.Rand();
            MessageBox.Show("Скорость работы лексикографического алгоритма - " + timeLeks + "\nСкорость работы случайного алгоритма - " + timeRand);
        }

        private void num_count_ValueChanged(object sender, EventArgs e)
        {
            GrVw.DataSource = null;
            but_wayOK.Enabled = but_alg.Enabled = pan_select.Enabled = false;
        }
    }

}
