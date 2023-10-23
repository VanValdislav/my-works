using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;//печать
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Threading;

namespace TxtRedactor
{
    public partial class Form1 : Form
    {
        private string _openFile;
        public int currentIndex = 0;
        public int nextIndex = 0;
        public int previousIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();
            if (myFont.ShowDialog () == DialogResult.OK) 
            {
                richTextBox1.SelectionFont = myFont.Font;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog Fdialog = new OpenFileDialog();
            Fdialog.DefaultExt = "*.rtf | *.txt";
            Fdialog.Filter = "RTF Files|*.rtf |TXT Files|*.txt";
            if (Fdialog.ShowDialog() == DialogResult.OK &&
               Fdialog.FileName.Length > 0)
            {
                richTextBox1.LoadFile(Fdialog.FileName);
                _openFile = Fdialog.FileName;
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog Sdialog = new SaveFileDialog();
                Sdialog.DefaultExt = "*.rtf | *.txt";
                //Sdialog.Filter = "RTF Files|*.rtf |TXT Files|*.txt";

                Sdialog.Filter = "Text Files (*.txt)|*.txt|RTF (*.rtf)|*.rtf";
                //if (Sdialog.ShowDialog() == DialogResult.OK &&
                //   Sdialog.FileName.Length > 0)
                //{
                //    richTextBox1.SaveFile(Sdialog.FileName, RichTextBoxStreamType.RichText);
                //    _openFile = Sdialog.FileName;
                //}
            
                if (Sdialog.ShowDialog() == DialogResult.OK &&
                    Sdialog.FileName.Length > 0)
                    {
                    if (Sdialog.FilterIndex == 1)
                    {
                        File.WriteAllText(Sdialog.FileName, richTextBox1.Text);
                        _openFile = Sdialog.FileName;
                    }
                    else 
                    {
                        richTextBox1.SaveFile(Sdialog.FileName, RichTextBoxStreamType.RichText);
                        _openFile = Sdialog.FileName;
                    }
                        
                }

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(_openFile, richTextBox1.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("save error");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void отменитьCTRLZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Определите, можно ли отменить последнюю операцию в текстовом поле.   
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();

            }
        }

        private void вырезатьCTRLXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void копироваnьCTRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void вставитьCTRLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                // Определите, выделен ли какой-либо текст в текстовом поле..
                if (richTextBox1.SelectionLength > 0)
                {
                    // Спросите пользователя, хотят ли они вставить текущий выделенный текст.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Переместите выделение в точку после текущего выделения и вставьте.
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                // Вставьте текущий текст из буфера обмена в текстовое поле.
                richTextBox1.Paste();
            }
        }

        private void найтиCTRLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            
        }

        private void заменитьCTRLHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        private void удалитьDELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectedText = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                richTextBox1.WordWrap = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
            }
            
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            отменитьCTRLZToolStripMenuItem.Enabled = richTextBox1.CanUndo == true;
            вырезатьCTRLXToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length != 0;
            копироваnьCTRLToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length != 0;
            удалитьDELETEToolStripMenuItem.Enabled = richTextBox1.SelectedText.Length != 0;
            найтиCTRLAToolStripMenuItem.Enabled = richTextBox1.CanUndo == true;
            заменитьCTRLHToolStripMenuItem.Enabled= richTextBox1.CanUndo == true;
        }
    }
}
