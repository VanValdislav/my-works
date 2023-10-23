using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtRedactor
{
    public partial class Form2 : Form
    {
        public Point lastpoint;
        private bool flag = false;

        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }
        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.currentIndex = 0;
            form1.previousIndex = 0;
            form1.nextIndex = 0;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Вперед_Click(object sender, EventArgs e)
        {   
            form1.richTextBox1.SelectAll();
            form1.richTextBox1.SelectionBackColor = Color.White;
            if(form1.currentIndex <= form1.richTextBox1.Text.LastIndexOf(richTextBox2.Text)) 
            {
                form1.richTextBox1.Find(richTextBox2.Text,form1.currentIndex, form1.richTextBox1.TextLength,RichTextBoxFinds.MatchCase);
                form1.richTextBox1.SelectionLength = richTextBox2.Text.Length;
                form1.richTextBox1.Focus();
                form1.previousIndex = form1.currentIndex;
                form1.currentIndex = form1.richTextBox1.Text.IndexOf(richTextBox2.Text,form1.currentIndex) +1;
            }
            else 
            {
                form1.currentIndex = 0;
                Вперед_Click(sender,e);
            }


        }

        private void Назад_Click(object sender, EventArgs e)
        {
            if (form1.currentIndex == 0)
            {
                form1.nextIndex = form1.richTextBox1.Text.LastIndexOf(richTextBox2.Text);
            }
            else 
            { 
                form1.nextIndex = form1.previousIndex - 1;
                if (form1.previousIndex == 0) 
                {
                    form1.nextIndex = form1.richTextBox1.Text.LastIndexOf(richTextBox2.Text);
                }
            }
            
            form1.currentIndex = 0;
            form1.richTextBox1.SelectAll();
            form1.richTextBox1.SelectionBackColor = Color.White;

            while (form1.currentIndex <= form1.nextIndex)
            {
                form1.richTextBox1.Find(richTextBox2.Text, form1.currentIndex, form1.richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                form1.richTextBox1.SelectionLength = richTextBox2.Text.Length;
                form1.richTextBox1.Focus();
                form1.previousIndex = form1.currentIndex;
                form1.currentIndex = form1.richTextBox1.Text.IndexOf(richTextBox2.Text, form1.currentIndex)+1;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Заменить_Click(object sender, EventArgs e)
        {
            if (form1.richTextBox1.SelectedText.Length > 0)
            {
                form1.richTextBox1.SelectedText = richTextBox3.Text;
            }
        }

        private void ЗаменитьВсе_Click(object sender, EventArgs e)
        {
            form1.currentIndex = 0;
            form1.richTextBox1.SelectAll();
            form1.richTextBox1.SelectionBackColor = Color.White;
            while (form1.currentIndex <= form1.richTextBox1.Text.LastIndexOf(richTextBox2.Text))
            {
                form1.richTextBox1.Find(richTextBox2.Text, form1.currentIndex, form1.richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                form1.richTextBox1.SelectionLength = richTextBox2.Text.Length;
                form1.richTextBox1.Focus();
                form1.previousIndex = form1.currentIndex;
                form1.currentIndex = form1.richTextBox1.Text.IndexOf(richTextBox2.Text, form1.currentIndex) + 1;
                form1.richTextBox1.SelectedText = richTextBox3.Text;
                form1.currentIndex += richTextBox3.TextLength;
            }
        }
    }
}
