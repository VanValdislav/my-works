namespace TxtRedactor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.X = new System.Windows.Forms.Button();
            this.Вперед = new System.Windows.Forms.Button();
            this.Назад = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Заменить = new System.Windows.Forms.Button();
            this.ЗаменитьВсе = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(591, 36);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // X
            // 
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Location = new System.Drawing.Point(718, 1);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(26, 23);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Вперед
            // 
            this.Вперед.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Вперед.Location = new System.Drawing.Point(609, 5);
            this.Вперед.Name = "Вперед";
            this.Вперед.Size = new System.Drawing.Size(83, 24);
            this.Вперед.TabIndex = 3;
            this.Вперед.Text = "Вперед";
            this.Вперед.UseVisualStyleBackColor = true;
            this.Вперед.Click += new System.EventHandler(this.Вперед_Click);
            // 
            // Назад
            // 
            this.Назад.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Назад.Location = new System.Drawing.Point(609, 35);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(83, 23);
            this.Назад.TabIndex = 4;
            this.Назад.Text = "Назад";
            this.Назад.UseVisualStyleBackColor = true;
            this.Назад.Click += new System.EventHandler(this.Назад_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(12, 77);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(591, 36);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // Заменить
            // 
            this.Заменить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Заменить.Location = new System.Drawing.Point(609, 65);
            this.Заменить.Name = "Заменить";
            this.Заменить.Size = new System.Drawing.Size(83, 23);
            this.Заменить.TabIndex = 6;
            this.Заменить.Text = "Заменить";
            this.Заменить.UseVisualStyleBackColor = true;
            this.Заменить.Click += new System.EventHandler(this.Заменить_Click);
            // 
            // ЗаменитьВсе
            // 
            this.ЗаменитьВсе.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ЗаменитьВсе.Location = new System.Drawing.Point(609, 94);
            this.ЗаменитьВсе.Name = "ЗаменитьВсе";
            this.ЗаменитьВсе.Size = new System.Drawing.Size(83, 47);
            this.ЗаменитьВсе.TabIndex = 7;
            this.ЗаменитьВсе.Text = "Заменить все";
            this.ЗаменитьВсе.UseVisualStyleBackColor = true;
            this.ЗаменитьВсе.Click += new System.EventHandler(this.ЗаменитьВсе_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(745, 145);
            this.Controls.Add(this.ЗаменитьВсе);
            this.Controls.Add(this.Заменить);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.Вперед);
            this.Controls.Add(this.X);
            this.Controls.Add(this.richTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Вперед;
        private System.Windows.Forms.Button Назад;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Заменить;
        private System.Windows.Forms.Button ЗаменитьВсе;
    }
}