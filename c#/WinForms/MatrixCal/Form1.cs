using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MatrixCal
{
    public partial class Form1 : Form
    {
        int err = 0; // catch
        public Form1()
        {
            InitializeComponent();
        }
        // ---------------------------------------------------------------------------------------
        // Matrica 1
        private void SosdatMatrix_Click(object sender, EventArgs e)
        {
            // создать матрицу 1
            int k = int.Parse(textBox1.Text);
            int k_2 = int.Parse(textBox2.Text);
            if (k < 0 || k > 20 || k_2 < 0 || k_2 > 20)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                MessageBox.Show("Слишком большая матрица .Максимальный размер матрицы 20");
            }
            else
            {
                try
                {
                    int n, nn;
                    n = int.Parse(textBox1.Text);
                    nn = int.Parse(textBox2.Text);

                    // исключение пустого textBox'a и отрицательного значения
                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || (n < 0) || (nn < 0))
                    {
                        err = err / 0;
                    }

                    dataGridView1.RowCount = n;
                    dataGridView1.ColumnCount = nn;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < nn; j++)
                        {
                            dataGridView1.Columns[j].Width = 60;
                            dataGridView1.Rows[i].Cells[j].Value = 0;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите корректный размер матрицы 1");
                }
            }
        }

        private void RandMatrix_Click(object sender, EventArgs e)
        {
            // случ числа 1
            try
            {
                Random rand = new Random();
                double value;

                // проверка на пустоту матрицы, некуда генерировать числа
                if((dataGridView1.RowCount == 0)|| (dataGridView1.ColumnCount == 0)){
                    err = err / 0;
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        //value = rand.Next(-100, 100) + rand.Next(0,10) / 10.0;
                        value = rand.Next(-10, 10);
                        dataGridView1[j, i].Value = value;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Создайте матрицу 1");
            }
        }

        private void Transpor_Click(object sender, EventArgs e)
        {
            // транспонировать
            try
            {
                // исключение полной пустой шняги в матрице
                int null_ = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            null_++;
                        }
                    }
                    if (null_ == (int)dataGridView1.RowCount * (int)dataGridView1.ColumnCount)
                        err = err / 0;
                }

                dataGridView3.RowCount = dataGridView1.ColumnCount;
                dataGridView3.ColumnCount = dataGridView1.RowCount;

                for (int i = 0; i < dataGridView3.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView3.RowCount; j++)
                    {
                        dataGridView3.Columns[i].Width = 60;
                        dataGridView3[i, j].Value = dataGridView1[j, i].Value;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите матрицу 1");
            }
        }

        private void Opred_Click(object sender, EventArgs e)
        {
            // det 1
            try
            {
                // проверка на пустоту матрицы и неравность
                if ((dataGridView1.RowCount == 0) || (dataGridView1.ColumnCount == 0) || (dataGridView1.RowCount != dataGridView1.ColumnCount))
                {
                    err = err / 0;
                }
                double det = 1;
                int n = dataGridView1.RowCount;
                double[,] matrix = new double[n,n];
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        matrix[i,j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                }

                //dataGridView3.RowCount = n;
                //dataGridView3.ColumnCount = n;

                if (dataGridView1.ColumnCount == 1)
                {
                    det = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value);
                }
                else if (dataGridView1.ColumnCount == 2)
                {
                    det = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value) - (Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value));
                }
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (matrix[i, i] == 0) continue;
                            double koef = matrix[j, i] / matrix[i, i];
                            for (int k = i; k < n; k++)
                            {
                                matrix[j, k] -= matrix[i, k] * koef;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            //dataGridView3.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                        det *= matrix[i, i];
                    }
                }

                MessageBox.Show("Определитель: " + det);
            }
            catch (Exception)
            {
                MessageBox.Show("Определитель не существует");
            }
        }

        private void RevMatrix_Click(object sender, EventArgs e)
        {
            // обратная матрица
            try
            {
                if ((dataGridView1.RowCount == 0) || (dataGridView1.ColumnCount == 0) || (dataGridView1.RowCount != dataGridView1.ColumnCount))
                {
                    err = err / 0;
                }
                double det = 1;
                int n = dataGridView1.RowCount;
                double[,] matrix = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                }

                //dataGridView3.RowCount = n;
                //dataGridView3.ColumnCount = n;

                if (dataGridView1.ColumnCount == 1)
                {
                    det = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value);
                }
                else if (dataGridView1.ColumnCount == 2)
                {
                    det = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value) - (Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value) * Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value));
                }
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (matrix[i, i] == 0) continue;
                            double koef = matrix[j, i] / matrix[i, i];
                            for (int k = i; k < n; k++)
                            {
                                matrix[j, k] -= matrix[i, k] * koef;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            //dataGridView3.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                        det *= matrix[i, i];
                    }
                }

                //MessageBox.Show(det.ToString());
                // 



                if (Math.Abs(det) < double.Epsilon)
                {
                    err = err / 0;
                }
                int h = dataGridView1.RowCount;

                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;

                // метод Гауса Жардана

                double[,] hhh = new double[h,h];

                for(int i = 0; i < h; i ++)
                {
                    for(int j = 0; j < h; j++)
                    {
                        hhh[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                double[,] ggg = new double[h, h];
                for (int i = 0; i < h;)
                {
                    for (int j = 0; j < h;)
                    {
                        if (i == j)
                        { ggg[i, j] = 1; }
                        else
                        { ggg[i, j] = 0; }
                        j++;
                    }
                    i++;
                }
                double arg;
                int i1;

                for (int j = 0; j < h;)
                {
                    for (int i = 0; i < h;)
                    {
                        if (i == j)
                        { 
                            goto k; 
                        }
                        arg = hhh[i, j] / hhh[j, j];
                        for (i1 = 0; i1 < h;)
                        {

                            hhh[i, i1] = hhh[i, i1] - hhh[j, i1] * arg;
                            ggg[i, i1] = ggg[i, i1] - ggg[j, i1] * arg;
                            i1++;
                        }
                    k:
                        i++;
                    }
                    j++;
                }

                for (int j = 0; j < h;)
                {
                    for (int i = 0; i < h;)
                    {
                        double arg_2;
                        if (i == j)
                        {
                            arg_2 = hhh[i, j];
                            for (i1 = 0; i1 < h;)
                            {
                                hhh[i, i1] = hhh[i, i1] / arg_2;
                                ggg[i, i1] = ggg[i, i1] / arg_2;
                                i1++;
                            }


                        }
                        i++;
                    }
                    j++;
                }

                for(int i=0; i<h; i++)
                {
                    for(int j=0; j<h; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = ggg[i, j];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя перевести в обратную матрицу");
            }
        }

        private void multiplicationNamber_Click(object sender, EventArgs e)
        {
            // *a
            try
            {
                double a;
                double.TryParse(textBox3.Text, out a);
                
                // исключение пустого множителя
                if (string.IsNullOrEmpty(textBox3.Text) || (!(double.TryParse(textBox3.Text, out double xd))))
                {
                    err = err / 0;
                }

                // исключение полной пустой шняги в матрице
                int null_ = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    { 
                        if (dataGridView1.Rows[i].Cells[j].Value == null) {
                            null_++;
                        }
                    }
                    if (null_ == (int)dataGridView1.RowCount * (int)dataGridView1.ColumnCount) 
                        err = err / 0;
                }

                dataGridView3.RowCount = dataGridView1.Rows.Count;
                dataGridView3.ColumnCount = dataGridView1.Columns.Count;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        dataGridView3.Columns[j].Width = 60;
                        dataGridView3[j, i].Value = a * Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте матрицу 1 или число на которое умножаете");
            }
        }

        private void dataGridView1_Changed(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) continue;
                    double val;
                    if (!double.TryParse(cell.Value.ToString(), out val))
                    {
                        MessageBox.Show("Значение матрицы №1 в ячейке (" + cell.ColumnIndex + ", " + cell.RowIndex + ") должно быть числом типа double!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cell.Value = null;
                    }
                    ((DataGridViewTextBoxColumn)dataGridView1.Columns[cell.ColumnIndex]).MaxInputLength = 6;
                }
            }
        }


        // ---------------------------------------------------------------------------------------
        // Matrica 2
        private void SosdatMatrix1_Click(object sender, EventArgs e)
        {
            // создать матрицу 2
            int k = int.Parse(textBox5.Text);
            int k_2 = int.Parse(textBox4.Text);
            if (k < 0 || k > 20 || k_2 < 0 || k_2 > 20)
            {
                textBox5.Text = string.Empty;
                textBox4.Text = string.Empty;
                MessageBox.Show("Слишком большая матрица .Максимальный размер матрицы 20");
            }
            else
            {
                try
                {
                    int n, nn;
                    n = int.Parse(textBox5.Text);
                    nn = int.Parse(textBox4.Text);

                    // исключение пустого textBox'a и отрицательного значения
                    if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox4.Text) || (n < 0) || (nn < 0))
                    {
                        err = err / 0;
                    }

                    dataGridView2.RowCount = n;
                    dataGridView2.ColumnCount = nn;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < nn; j++)
                        {
                            dataGridView2.Columns[j].Width = 60;
                            dataGridView2.Rows[i].Cells[j].Value = 0;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите корректный размер матрицы 2");
                }
            }
        }

        private void RandMatrix1_Click(object sender, EventArgs e)
        {
            /// случ числа 2
            try
            {
                Random rand = new Random();
                double value;

                // проверка на пустоту матрицы, некуда генерировать числа
                if ((dataGridView2.RowCount == 0) || (dataGridView2.ColumnCount == 0))
                {
                    err = err / 0;
                }

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        //value = rand.Next(-100, 100) + rand.Next(0,10) / 10.0;
                        value = rand.Next(-10, 10);
                        dataGridView2[j, i].Value = value;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Создайте матрицу 2");
            }
        }
        private void Transpor1_Click(object sender, EventArgs e)
        {
            // транспонировать
            try
            {
                // исключение полной пустой шняги в матрице
                int null_ = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value == null)
                        {
                            null_++;
                        }
                    }
                    if (null_ == (int)dataGridView2.RowCount * (int)dataGridView2.ColumnCount)
                        err = err / 0;
                }

                dataGridView3.RowCount = dataGridView2.ColumnCount;
                dataGridView3.ColumnCount = dataGridView2.RowCount;

                for (int i = 0; i < dataGridView3.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView3.RowCount; j++)
                    {
                        dataGridView3.Columns[i].Width = 60;
                        dataGridView3[i, j].Value = dataGridView2[j, i].Value;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите матрицу 2");
            }
        }

        private void Opred1_Click(object sender, EventArgs e)
        {
            // det 1
            try
            {
                // проверка на пустоту матрицы и неравность
                if ((dataGridView2.RowCount == 0) || (dataGridView2.ColumnCount == 0) || (dataGridView2.RowCount != dataGridView2.ColumnCount))
                {
                    err = err / 0;
                }
                double det = 1;
                int n = dataGridView2.RowCount;
                double[,] matrix = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value.ToString());
                    }
                }

                //dataGridView3.RowCount = n;
                //dataGridView3.ColumnCount = n;

                if (dataGridView2.ColumnCount == 1)
                {
                    det = Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value);
                }
                else if (dataGridView2.ColumnCount == 2)
                {
                    det = Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value) + Convert.ToDouble(dataGridView2.Rows[1].Cells[1].Value) - Convert.ToDouble(dataGridView2.Rows[1].Cells[0].Value) - Convert.ToDouble(dataGridView2.Rows[0].Cells[1].Value);
                }
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (matrix[i, i] == 0) continue;
                            double koef = matrix[j, i] / matrix[i, i];
                            for (int k = i; k < n; k++)
                            {
                                matrix[j, k] -= matrix[i, k] * koef;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            //dataGridView3.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                        det *= matrix[i, i];
                    }
                }
                MessageBox.Show("Определитель: " + det);
            }
            catch (Exception)
            {
                MessageBox.Show("Определитель не существует");
            }
        }

        private void RevMatrix1_Click(object sender, EventArgs e)
        {
            // обратная матрица
            try
            {
                if ((dataGridView2.RowCount == 0) || (dataGridView2.ColumnCount == 0) || (dataGridView2.RowCount != dataGridView2.ColumnCount))
                {
                    err = err / 0;
                }
                double det = 1;
                int n = dataGridView2.RowCount;
                double[,] matrix = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value.ToString());
                    }
                }

                //dataGridView3.RowCount = n;
                //dataGridView3.ColumnCount = n;

                if (dataGridView2.ColumnCount == 1)
                {
                    det = Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value);
                }
                else if (dataGridView2.ColumnCount == 2)
                {
                    det = Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value) + Convert.ToDouble(dataGridView2.Rows[1].Cells[1].Value) - Convert.ToDouble(dataGridView2.Rows[1].Cells[0].Value) - Convert.ToDouble(dataGridView2.Rows[0].Cells[1].Value);
                }
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (matrix[i, i] == 0) continue;
                            double koef = matrix[j, i] / matrix[i, i];
                            for (int k = i; k < n; k++)
                            {
                                matrix[j, k] -= matrix[i, k] * koef;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            //dataGridView3.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                        det *= matrix[i, i];
                    }
                }

                //MessageBox.Show(det.ToString());

                if (Math.Abs(det) < double.Epsilon)
                {
                    err = err / 0;
                }
                int h = dataGridView2.RowCount;

                dataGridView3.RowCount = dataGridView2.RowCount;
                dataGridView3.ColumnCount = dataGridView2.ColumnCount;

                // метод Гауса Жардана

                double[,] hhh = new double[h, h];

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        hhh[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }

                double[,] ggg = new double[h, h];
                for (int i = 0; i < h;)
                {
                    for (int j = 0; j < h;)
                    {
                        if (i == j)
                        { ggg[i, j] = 1; }
                        else
                        { ggg[i, j] = 0; }
                        j++;
                    }
                    i++;
                }
                double arg;
                int i1;

                for (int j = 0; j < h;)
                {
                    for (int i = 0; i < h;)
                    {
                        if (i == j)
                        {
                            goto k;
                        }
                        arg = hhh[i, j] / hhh[j, j];
                        for (i1 = 0; i1 < h;)
                        {

                            hhh[i, i1] = hhh[i, i1] - hhh[j, i1] * arg;
                            ggg[i, i1] = ggg[i, i1] - ggg[j, i1] * arg;
                            i1++;
                        }
                    k:
                        i++;
                    }
                    j++;
                }

                for (int j = 0; j < h;)
                {
                    for (int i = 0; i < h;)
                    {
                        double arg_2;
                        if (i == j)
                        {
                            arg_2 = hhh[i, j];
                            for (i1 = 0; i1 < h;)
                            {
                                hhh[i, i1] = hhh[i, i1] / arg_2;
                                ggg[i, i1] = ggg[i, i1] / arg_2;
                                i1++;
                            }


                        }
                        i++;
                    }
                    j++;
                }

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = ggg[i, j];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя перевести в обратную матрицу");
            }
        }

        private void multiplicationNamber1_Click(object sender, EventArgs e)
        {
            // *a
            try
            {
                double a;
                double.TryParse(textBox6.Text, out a);

                // исключение пустого множителя
                if (string.IsNullOrEmpty(textBox6.Text) || (!(double.TryParse(textBox6.Text, out double xd))))
                {
                    err = err / 0;
                }

                // исключение полной пустой шняги в матрице
                int null_ = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value == null)
                        {
                            null_++;
                        }
                    }
                    if (null_ == (int)dataGridView2.RowCount * (int)dataGridView2.ColumnCount)
                        err = err / 0;
                }

                dataGridView3.RowCount = dataGridView2.Rows.Count;
                dataGridView3.ColumnCount = dataGridView2.Columns.Count;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        dataGridView3.Columns[j].Width = 60;
                        dataGridView3[j, i].Value = a * Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте матрицу 1 или число на которое умножаете");
            }
        }

        private void dataGridView2_Changed(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) cell.Value = 0;
                    double val;
                    if (!double.TryParse(cell.Value.ToString(), out val))
                    {
                        MessageBox.Show("Значение матрицы №2 в ячейке (" + cell.ColumnIndex + ", " + cell.RowIndex + ") должно быть числом типа double!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cell.Value = null;
                    }
                    ((DataGridViewTextBoxColumn)dataGridView2.Columns[cell.ColumnIndex]).MaxInputLength = 6;
                }
            }
        }


        // ---------------------------------------------------------------------------------------
        // + - *
        private void Summ_Click(object sender, EventArgs e)
        {
            // +
            try
            {
                // проверка на пустые матрицы
                if ((dataGridView1.RowCount == 0)||( dataGridView1.ColumnCount == 0)||( dataGridView2.RowCount == 0)||( dataGridView2.ColumnCount == 0))
                {
                    err = err / 0;
                }

                // проверка на соотношение строк и столбцов
                if((dataGridView1.RowCount != dataGridView2.RowCount) || (dataGridView1.ColumnCount != dataGridView2.ColumnCount))
                {
                    err = err / 0;
                }

                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    {
                        dataGridView3.Columns[j].Width = 60;
                        dataGridView3[i,j].Value = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value) + Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные матрицы 1 и/или 2 (количество строк и столбцов должно совпадать)");
            }
                
        }

        private void vichet_Click(object sender, EventArgs e)
        {
            // -
            try
            {
                // проверка на пустые матрицы
                if ((dataGridView1.RowCount == 0) || (dataGridView1.ColumnCount == 0) || (dataGridView2.RowCount == 0) || (dataGridView2.ColumnCount == 0))
                {
                    err = err / 0;
                }

                // проверка на соотношение строк и столбцов
                if ((dataGridView1.RowCount != dataGridView2.RowCount) || (dataGridView1.ColumnCount != dataGridView2.ColumnCount))
                {
                    err = err / 0;
                }

                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    {
                        dataGridView3.Columns[j].Width = 60;
                        dataGridView3[i, j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) - Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные матрицы 1 и/или 2 (количество строк и столбцов должно совпадать)");
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            // *
            try
            {
                // проверка на пустые матрицы
                if ((dataGridView1.RowCount == 0) || (dataGridView1.ColumnCount == 0) || (dataGridView2.RowCount == 0) || (dataGridView2.ColumnCount == 0))
                {
                    err = err / 0;
                }

                // проверка на соотношение строк и столбцов
                if (dataGridView1.ColumnCount != dataGridView2.RowCount)
                {
                    err = err / 0;
                }

                int n = dataGridView1.RowCount; 
                int m = dataGridView1.ColumnCount;
                int p = dataGridView2.ColumnCount; 

                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView2.ColumnCount;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = 0;
                        for (int k=0; k<m; k++)
                        {
                            dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView3.Rows[i].Cells[j].Value.ToString()) + Convert.ToDouble(dataGridView1.Rows[i].Cells[k].Value.ToString()) * Convert.ToDouble(dataGridView2.Rows[k].Cells[j].Value.ToString());

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные матрицы 1 и/или 2 (количество строк 1 матрицы и столбцов 2 матрицы должно совпадать)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 10;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 2;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 2;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 2;
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 2;
        }
    }
}
