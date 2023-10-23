namespace Paint2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btn_cler = new Button();
            btn_highlight = new Button();
            btn_cut = new Button();
            btn_get_up = new Button();
            btn_copy = new Button();
            trackBar1 = new TrackBar();
            color_picker = new PictureBox();
            btn_line = new Button();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            btm_colot = new Button();
            pic_color = new Button();
            panel3 = new Panel();
            btn_pipette = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btn_cler);
            panel1.Controls.Add(btn_highlight);
            panel1.Controls.Add(btn_cut);
            panel1.Controls.Add(btn_get_up);
            panel1.Controls.Add(btn_copy);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_rect);
            panel1.Controls.Add(btn_ellipse);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(btm_colot);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 126);
            panel1.TabIndex = 0;
            // 
            // btn_cler
            // 
            btn_cler.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_cler.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_cler.FlatStyle = FlatStyle.Flat;
            btn_cler.ForeColor = SystemColors.ButtonFace;
            btn_cler.ImageAlign = ContentAlignment.TopCenter;
            btn_cler.Location = new Point(1037, 30);
            btn_cler.Name = "btn_cler";
            btn_cler.Size = new Size(50, 46);
            btn_cler.TabIndex = 16;
            btn_cler.Text = "Clear";
            btn_cler.TextAlign = ContentAlignment.BottomCenter;
            btn_cler.UseVisualStyleBackColor = true;
            btn_cler.Click += btn_cler_Click;
            // 
            // btn_highlight
            // 
            btn_highlight.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_highlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_highlight.FlatStyle = FlatStyle.Flat;
            btn_highlight.ForeColor = SystemColors.ButtonFace;
            btn_highlight.Image = (Image)resources.GetObject("btn_highlight.Image");
            btn_highlight.ImageAlign = ContentAlignment.TopCenter;
            btn_highlight.Location = new Point(969, 30);
            btn_highlight.Name = "btn_highlight";
            btn_highlight.Size = new Size(50, 46);
            btn_highlight.TabIndex = 15;
            btn_highlight.Tag = "11";
            btn_highlight.TextAlign = ContentAlignment.BottomCenter;
            btn_highlight.UseVisualStyleBackColor = true;
            btn_highlight.Click += btn_highlight_Click;
            // 
            // btn_cut
            // 
            btn_cut.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_cut.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_cut.FlatStyle = FlatStyle.Flat;
            btn_cut.ForeColor = SystemColors.ButtonFace;
            btn_cut.Image = (Image)resources.GetObject("btn_cut.Image");
            btn_cut.ImageAlign = ContentAlignment.TopCenter;
            btn_cut.Location = new Point(913, 30);
            btn_cut.Name = "btn_cut";
            btn_cut.Size = new Size(50, 46);
            btn_cut.TabIndex = 14;
            btn_cut.TextAlign = ContentAlignment.BottomCenter;
            btn_cut.UseVisualStyleBackColor = true;
            btn_cut.Click += btn_cut_Click;
            // 
            // btn_get_up
            // 
            btn_get_up.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_get_up.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_get_up.FlatStyle = FlatStyle.Flat;
            btn_get_up.ForeColor = SystemColors.ButtonFace;
            btn_get_up.Image = (Image)resources.GetObject("btn_get_up.Image");
            btn_get_up.ImageAlign = ContentAlignment.TopCenter;
            btn_get_up.Location = new Point(859, 30);
            btn_get_up.Name = "btn_get_up";
            btn_get_up.Size = new Size(50, 46);
            btn_get_up.TabIndex = 13;
            btn_get_up.TextAlign = ContentAlignment.BottomCenter;
            btn_get_up.UseVisualStyleBackColor = true;
            btn_get_up.Click += btn_get_up_Click;
            // 
            // btn_copy
            // 
            btn_copy.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_copy.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_copy.FlatStyle = FlatStyle.Flat;
            btn_copy.ForeColor = SystemColors.ButtonFace;
            btn_copy.Image = Properties.Resources.copyTO;
            btn_copy.ImageAlign = ContentAlignment.TopCenter;
            btn_copy.Location = new Point(803, 30);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(50, 46);
            btn_copy.TabIndex = 12;
            btn_copy.TextAlign = ContentAlignment.BottomCenter;
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btn_copy_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(803, 78);
            trackBar1.Maximum = 8;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(159, 45);
            trackBar1.TabIndex = 10;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // color_picker
            // 
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(3, 26);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(170, 100);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // btn_line
            // 
            btn_line.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = SystemColors.ButtonFace;
            btn_line.Image = Properties.Resources.line;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(648, 38);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(64, 60);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rect
            // 
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = SystemColors.ButtonFace;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(568, 38);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(74, 60);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rectangle";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = true;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = SystemColors.ButtonFace;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(498, 38);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(64, 60);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = SystemColors.ButtonFace;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eraser.Location = new Point(428, 38);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(64, 60);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = SystemColors.ButtonFace;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pencil.Location = new Point(358, 38);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(64, 60);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_fill
            // 
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = SystemColors.ButtonFace;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fill.Location = new Point(288, 38);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(64, 60);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btm_colot
            // 
            btm_colot.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btm_colot.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btm_colot.FlatStyle = FlatStyle.Flat;
            btm_colot.ForeColor = SystemColors.ButtonFace;
            btm_colot.Image = Properties.Resources.color;
            btm_colot.ImageAlign = ContentAlignment.MiddleLeft;
            btm_colot.Location = new Point(218, 38);
            btm_colot.Name = "btm_colot";
            btm_colot.Size = new Size(64, 60);
            btm_colot.TabIndex = 1;
            btm_colot.Text = "Color";
            btm_colot.TextAlign = ContentAlignment.BottomCenter;
            btm_colot.UseVisualStyleBackColor = true;
            btm_colot.Click += btm_colot_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(179, 51);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(30, 28);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(btn_pipette);
            panel3.Location = new Point(215, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(573, 75);
            panel3.TabIndex = 8;
            // 
            // btn_pipette
            // 
            btn_pipette.BackColor = SystemColors.AppWorkspace;
            btn_pipette.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pipette.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            btn_pipette.FlatStyle = FlatStyle.Flat;
            btn_pipette.ForeColor = SystemColors.ButtonFace;
            btn_pipette.Image = (Image)resources.GetObject("btn_pipette.Image");
            btn_pipette.ImageAlign = ContentAlignment.TopCenter;
            btn_pipette.Location = new Point(505, 8);
            btn_pipette.Name = "btn_pipette";
            btn_pipette.Size = new Size(64, 60);
            btn_pipette.TabIndex = 15;
            btn_pipette.Text = "Пипетка";
            btn_pipette.TextAlign = ContentAlignment.BottomCenter;
            btn_pipette.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1109, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(154, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(154, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(154, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 501);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 10);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1109, 511);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick_1;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button btm_colot;
        private Button pic_color;
        private Button btn_line;
        private Button btn_rect;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private Panel panel3;
        private PictureBox color_picker;
        private TrackBar trackBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private Button btn_cler;
        private Button btn_highlight;
        private Button btn_cut;
        private Button btn_get_up;
        private Button btn_copy;
        private Button btn_pipette;
    }
}