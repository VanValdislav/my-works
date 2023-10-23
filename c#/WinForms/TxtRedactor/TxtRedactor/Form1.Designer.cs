namespace TxtRedactor
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьCTRLZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьCTRLXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироваnьCTRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьCTRLMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиCTRLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьCTRLHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьDELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеОкноToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            this.новоеОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьCTRLZToolStripMenuItem,
            this.вырезатьCTRLXToolStripMenuItem,
            this.копироваnьCTRLToolStripMenuItem,
            this.вставитьCTRLMToolStripMenuItem,
            this.найтиCTRLAToolStripMenuItem,
            this.заменитьCTRLHToolStripMenuItem,
            this.удалитьDELETEToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // отменитьCTRLZToolStripMenuItem
            // 
            this.отменитьCTRLZToolStripMenuItem.Enabled = false;
            this.отменитьCTRLZToolStripMenuItem.Name = "отменитьCTRLZToolStripMenuItem";
            this.отменитьCTRLZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьCTRLZToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.отменитьCTRLZToolStripMenuItem.Text = "Отменить";
            this.отменитьCTRLZToolStripMenuItem.Click += new System.EventHandler(this.отменитьCTRLZToolStripMenuItem_Click);
            // 
            // вырезатьCTRLXToolStripMenuItem
            // 
            this.вырезатьCTRLXToolStripMenuItem.Enabled = false;
            this.вырезатьCTRLXToolStripMenuItem.Name = "вырезатьCTRLXToolStripMenuItem";
            this.вырезатьCTRLXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьCTRLXToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.вырезатьCTRLXToolStripMenuItem.Text = "Вырезать";
            this.вырезатьCTRLXToolStripMenuItem.Click += new System.EventHandler(this.вырезатьCTRLXToolStripMenuItem_Click);
            // 
            // копироваnьCTRLToolStripMenuItem
            // 
            this.копироваnьCTRLToolStripMenuItem.Enabled = false;
            this.копироваnьCTRLToolStripMenuItem.Name = "копироваnьCTRLToolStripMenuItem";
            this.копироваnьCTRLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироваnьCTRLToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.копироваnьCTRLToolStripMenuItem.Text = "Копировать";
            this.копироваnьCTRLToolStripMenuItem.Click += new System.EventHandler(this.копироваnьCTRLToolStripMenuItem_Click);
            // 
            // вставитьCTRLMToolStripMenuItem
            // 
            this.вставитьCTRLMToolStripMenuItem.Name = "вставитьCTRLMToolStripMenuItem";
            this.вставитьCTRLMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.вставитьCTRLMToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.вставитьCTRLMToolStripMenuItem.Text = "Вставить";
            this.вставитьCTRLMToolStripMenuItem.Click += new System.EventHandler(this.вставитьCTRLMToolStripMenuItem_Click);
            // 
            // найтиCTRLAToolStripMenuItem
            // 
            this.найтиCTRLAToolStripMenuItem.Enabled = false;
            this.найтиCTRLAToolStripMenuItem.Name = "найтиCTRLAToolStripMenuItem";
            this.найтиCTRLAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.найтиCTRLAToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.найтиCTRLAToolStripMenuItem.Text = "Найти";
            this.найтиCTRLAToolStripMenuItem.Click += new System.EventHandler(this.найтиCTRLAToolStripMenuItem_Click);
            // 
            // заменитьCTRLHToolStripMenuItem
            // 
            this.заменитьCTRLHToolStripMenuItem.Enabled = false;
            this.заменитьCTRLHToolStripMenuItem.Name = "заменитьCTRLHToolStripMenuItem";
            this.заменитьCTRLHToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.заменитьCTRLHToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.заменитьCTRLHToolStripMenuItem.Text = "Заменить";
            this.заменитьCTRLHToolStripMenuItem.Click += new System.EventHandler(this.заменитьCTRLHToolStripMenuItem_Click);
            // 
            // удалитьDELETEToolStripMenuItem
            // 
            this.удалитьDELETEToolStripMenuItem.Enabled = false;
            this.удалитьDELETEToolStripMenuItem.Name = "удалитьDELETEToolStripMenuItem";
            this.удалитьDELETEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьDELETEToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.удалитьDELETEToolStripMenuItem.Text = "Удалить";
            this.удалитьDELETEToolStripMenuItem.Click += new System.EventHandler(this.удалитьDELETEToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.Location = new System.Drawing.Point(184, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Перенос слова";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TxtRedactor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьCTRLZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьCTRLXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироваnьCTRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьCTRLMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиCTRLAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьCTRLHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьDELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

