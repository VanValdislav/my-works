namespace MatrixCal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RandMatrix = new System.Windows.Forms.Button();
            this.Opred = new System.Windows.Forms.Button();
            this.RevMatrix = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.vichet = new System.Windows.Forms.Button();
            this.Summ = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.multiplicationNamber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Transpor = new System.Windows.Forms.Button();
            this.SosdatMatrix = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RandMatrix1 = new System.Windows.Forms.Button();
            this.SosdatMatrix1 = new System.Windows.Forms.Button();
            this.Opred1 = new System.Windows.Forms.Button();
            this.RevMatrix1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.multiplicationNamber1 = new System.Windows.Forms.Button();
            this.Transpor1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RandMatrix
            // 
            this.RandMatrix.Location = new System.Drawing.Point(180, 62);
            this.RandMatrix.Name = "RandMatrix";
            this.RandMatrix.Size = new System.Drawing.Size(121, 23);
            this.RandMatrix.TabIndex = 57;
            this.RandMatrix.Text = "Случайные числа";
            this.RandMatrix.UseVisualStyleBackColor = true;
            this.RandMatrix.Click += new System.EventHandler(this.RandMatrix_Click);
            // 
            // Opred
            // 
            this.Opred.Location = new System.Drawing.Point(182, 340);
            this.Opred.Name = "Opred";
            this.Opred.Size = new System.Drawing.Size(121, 23);
            this.Opred.TabIndex = 55;
            this.Opred.Text = "Определитель";
            this.Opred.UseVisualStyleBackColor = true;
            this.Opred.Click += new System.EventHandler(this.Opred_Click);
            // 
            // RevMatrix
            // 
            this.RevMatrix.Location = new System.Drawing.Point(14, 369);
            this.RevMatrix.Name = "RevMatrix";
            this.RevMatrix.Size = new System.Drawing.Size(121, 23);
            this.RevMatrix.TabIndex = 53;
            this.RevMatrix.Text = "Обратная матрица";
            this.RevMatrix.UseVisualStyleBackColor = true;
            this.RevMatrix.Click += new System.EventHandler(this.RevMatrix_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(339, 228);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 52;
            this.multiplication.Text = "Умножение";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // vichet
            // 
            this.vichet.Location = new System.Drawing.Point(339, 199);
            this.vichet.Name = "vichet";
            this.vichet.Size = new System.Drawing.Size(75, 23);
            this.vichet.TabIndex = 51;
            this.vichet.Text = "Вычитание";
            this.vichet.UseVisualStyleBackColor = true;
            this.vichet.Click += new System.EventHandler(this.vichet_Click);
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(339, 170);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(75, 23);
            this.Summ.TabIndex = 50;
            this.Summ.Text = "Сложение";
            this.Summ.UseVisualStyleBackColor = true;
            this.Summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 398);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 20);
            this.textBox3.TabIndex = 47;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // multiplicationNamber
            // 
            this.multiplicationNamber.Location = new System.Drawing.Point(182, 369);
            this.multiplicationNamber.Name = "multiplicationNamber";
            this.multiplicationNamber.Size = new System.Drawing.Size(121, 23);
            this.multiplicationNamber.TabIndex = 46;
            this.multiplicationNamber.Text = "Умножить на число ";
            this.multiplicationNamber.UseVisualStyleBackColor = true;
            this.multiplicationNamber.Click += new System.EventHandler(this.multiplicationNamber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Введите размерность матрицы 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(235, 448);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(289, 246);
            this.dataGridView3.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Transpor
            // 
            this.Transpor.Location = new System.Drawing.Point(14, 340);
            this.Transpor.Name = "Transpor";
            this.Transpor.Size = new System.Drawing.Size(121, 23);
            this.Transpor.TabIndex = 38;
            this.Transpor.Text = "Транспонировать матрицу";
            this.Transpor.UseVisualStyleBackColor = true;
            this.Transpor.Click += new System.EventHandler(this.Transpor_Click);
            // 
            // SosdatMatrix
            // 
            this.SosdatMatrix.Location = new System.Drawing.Point(12, 62);
            this.SosdatMatrix.Name = "SosdatMatrix";
            this.SosdatMatrix.Size = new System.Drawing.Size(121, 23);
            this.SosdatMatrix.TabIndex = 37;
            this.SosdatMatrix.Text = "Создать матрицу";
            this.SosdatMatrix.UseVisualStyleBackColor = true;
            this.SosdatMatrix.Click += new System.EventHandler(this.SosdatMatrix_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(449, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(289, 246);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_Changed);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(289, 246);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Результат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(446, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Введите размерность матрицы 2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(505, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(30, 20);
            this.textBox4.TabIndex = 60;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(449, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(31, 20);
            this.textBox5.TabIndex = 59;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // RandMatrix1
            // 
            this.RandMatrix1.Location = new System.Drawing.Point(617, 62);
            this.RandMatrix1.Name = "RandMatrix1";
            this.RandMatrix1.Size = new System.Drawing.Size(121, 23);
            this.RandMatrix1.TabIndex = 64;
            this.RandMatrix1.Text = "Случайные числа";
            this.RandMatrix1.UseVisualStyleBackColor = true;
            this.RandMatrix1.Click += new System.EventHandler(this.RandMatrix1_Click);
            // 
            // SosdatMatrix1
            // 
            this.SosdatMatrix1.Location = new System.Drawing.Point(449, 62);
            this.SosdatMatrix1.Name = "SosdatMatrix1";
            this.SosdatMatrix1.Size = new System.Drawing.Size(121, 23);
            this.SosdatMatrix1.TabIndex = 63;
            this.SosdatMatrix1.Text = "Создать матрицу";
            this.SosdatMatrix1.UseVisualStyleBackColor = true;
            this.SosdatMatrix1.Click += new System.EventHandler(this.SosdatMatrix1_Click);
            // 
            // Opred1
            // 
            this.Opred1.Location = new System.Drawing.Point(619, 340);
            this.Opred1.Name = "Opred1";
            this.Opred1.Size = new System.Drawing.Size(121, 23);
            this.Opred1.TabIndex = 69;
            this.Opred1.Text = "Определитель";
            this.Opred1.UseVisualStyleBackColor = true;
            this.Opred1.Click += new System.EventHandler(this.Opred1_Click);
            // 
            // RevMatrix1
            // 
            this.RevMatrix1.Location = new System.Drawing.Point(451, 369);
            this.RevMatrix1.Name = "RevMatrix1";
            this.RevMatrix1.Size = new System.Drawing.Size(121, 23);
            this.RevMatrix1.TabIndex = 68;
            this.RevMatrix1.Text = "Обратная матрица";
            this.RevMatrix1.UseVisualStyleBackColor = true;
            this.RevMatrix1.Click += new System.EventHandler(this.RevMatrix1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(651, 398);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 20);
            this.textBox6.TabIndex = 67;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // multiplicationNamber1
            // 
            this.multiplicationNamber1.Location = new System.Drawing.Point(619, 369);
            this.multiplicationNamber1.Name = "multiplicationNamber1";
            this.multiplicationNamber1.Size = new System.Drawing.Size(121, 23);
            this.multiplicationNamber1.TabIndex = 66;
            this.multiplicationNamber1.Text = "Умножить на число ";
            this.multiplicationNamber1.UseVisualStyleBackColor = true;
            this.multiplicationNamber1.Click += new System.EventHandler(this.multiplicationNamber1_Click);
            // 
            // Transpor1
            // 
            this.Transpor1.Location = new System.Drawing.Point(451, 340);
            this.Transpor1.Name = "Transpor1";
            this.Transpor1.Size = new System.Drawing.Size(121, 23);
            this.Transpor1.TabIndex = 65;
            this.Transpor1.Text = "Транспонировать матрицу";
            this.Transpor1.UseVisualStyleBackColor = true;
            this.Transpor1.Click += new System.EventHandler(this.Transpor1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(825, 700);
            this.Controls.Add(this.Opred1);
            this.Controls.Add(this.RevMatrix1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.multiplicationNamber1);
            this.Controls.Add(this.Transpor1);
            this.Controls.Add(this.RandMatrix1);
            this.Controls.Add(this.SosdatMatrix1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandMatrix);
            this.Controls.Add(this.Opred);
            this.Controls.Add(this.RevMatrix);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.vichet);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.multiplicationNamber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Transpor);
            this.Controls.Add(this.SosdatMatrix);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "MatrixCalk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RandMatrix;
        private System.Windows.Forms.Button Opred;
        private System.Windows.Forms.Button RevMatrix;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button vichet;
        private System.Windows.Forms.Button Summ;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button multiplicationNamber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Transpor;
        private System.Windows.Forms.Button SosdatMatrix;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button RandMatrix1;
        private System.Windows.Forms.Button SosdatMatrix1;
        private System.Windows.Forms.Button Opred1;
        private System.Windows.Forms.Button RevMatrix1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button multiplicationNamber1;
        private System.Windows.Forms.Button Transpor1;
    }
}

