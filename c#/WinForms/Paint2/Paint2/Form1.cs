using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Drawing.Imaging;
using System.Reflection;
using System.IO;

namespace Paint2
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false, colOL = false, isDrag = false, isSelection = false;
        Point px, py;
        int lineWidth;
        int index;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 1);
        Color new_color, old_color;
        int x, y, sX, sY, cX, cY, x1, y1;
        Point point1, point2;
        private Stack<Bitmap> undostackCrop = new Stack<Bitmap>();
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();
        private Rectangle selectionRectangle;
        private Bitmap selectedImage;
        private Bitmap selectedImageCrop;
        private Point imageOffset;

        ColorDialog cd = new ColorDialog();

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }
        public Form1()
        {
            InitializeComponent();

            this.Width = 1280;
            this.Height = 720;
            lineWidth = 1;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            new_color = Color.Black;
            pic_color.BackColor = new_color;
        }

        private void SaveState()
        {
            // Сохраняем текущее состояние изображения в стеке отмены 
            undoStack.Push((Bitmap)bm.Clone());
        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            isSelection = true;

            x1 = e.X;
            y1 = e.Y;

            cX = e.X;
            cY = e.Y;
            point1 = e.Location;

            ChekCrop();
            if (index != 11)
            {
                SaveState();
            }
            //if (index == 11)
            //{
            //    if (draggedFragment != null && !draggedFragment.Rect.Contains(e.Location))
            //    {
            //          //уничтожаем фрагмент
            //          draggedFragment = null;
            //          pic.Invalidate();
            //    }

            //}
            // Проверяем, находится ли курсор мыши внутри выделенной области
            if (selectionRectangle.Contains(e.Location) && index == 11)
            {
                if (!isDrag)
                {
                    SaveState();
                    // Копирование выделенной области изображения
                    selectedImage = new Bitmap(selectionRectangle.Width, selectionRectangle.Height);

                    using (Graphics g = Graphics.FromImage(selectedImage))
                    {
                        g.DrawImage(bm, new Rectangle(0, 0, selectedImage.Width, selectedImage.Height), selectionRectangle, GraphicsUnit.Pixel);
                    }

                    // Очистка выделенной области на исходном изображении
                    g.FillRectangle(Brushes.White, selectionRectangle);
                    //selectedImageCrop = (Bitmap)bitmapN.Clone();
                    undostackCrop.Push((Bitmap)bm.Clone());
                    // Сохранение смещения курсора относительно верхнего левого угла выделенного изображения
                    imageOffset = new Point(cX - selectionRectangle.X, cY - selectionRectangle.Y);

                    // Начало перетаскивания
                    isDrag = true;
                }
                else
                {
                    if (selectionRectangle.Contains(e.Location))
                    {
                        if (isDrag)
                        {
                            imageOffset = new Point(cX - selectionRectangle.X, cY - selectionRectangle.Y);
                            pic.Invalidate();
                        }
                    }
                    else
                    {
                        while (undostackCrop.Count > 0)
                        {
                            undostackCrop.Pop();
                        }
                        isDrag = false;
                    }
                }

            }
            else
            {
                //
                if (isDrag && index == 11)
                {
                    bm = undostackCrop.Pop();
                    g = Graphics.FromImage(bm);
                    pic.Image = bm;
                    undostackCrop.Push((Bitmap)bm.Clone());
                    g.DrawImage(selectedImage, selectionRectangle);
                }
                //
                while (undostackCrop.Count > 0)
                {
                    undostackCrop.Pop();
                }
                selectionRectangle = Rectangle.Empty;
                //selectionRectangle.Location = new Point(0, 0);
                isDrag = false;
            }

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(pic, e.Location);
            if (isDrag && index != 11)
            {
                bm = undostackCrop.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                undostackCrop.Push((Bitmap)bm.Clone());
                g.DrawImage(selectedImage, selectionRectangle);

                while (undostackCrop.Count > 0)
                {
                    undostackCrop.Pop();
                }
                selectionRectangle = Rectangle.Empty;
                //selectionRectangle.Location = new Point(0, 0);
                isDrag = false;
            }
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            point2 = e.Location;
            if (paint)
            {
                if (colOL == true)
                {
                    new_color = old_color;
                    pic_color.BackColor = new_color;
                    colOL = false;
                }
                if (index == 1)
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen = new Pen(new_color, lineWidth);
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    erase = new Pen(Color.White, lineWidth);
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;

                    old_color = new_color;
                    new_color = Color.White;
                    pic_color.BackColor = Color.White;
                    colOL = true;
                }

            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

            //if (index == 11)
            //{
            //    if (e.Button == MouseButtons.Left)
            //    {
            //        //юзер тянет фрагмент?
            //        if (draggedFragment != null)
            //        {
            //            //сдвигаем фрагмент
            //            draggedFragment.Location.Offset(e.Location.X - point2.X, e.Location.Y - point2.Y);
            //            point1 = e.Location;
            //        }
            //        //сдвигаем выделенную область
            //        point2 = e.Location;
            //        pic.Invalidate();
            //    }
            //    else
            //    {
            //        point1 = point2 = e.Location;
            //    }
            //}
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;


            if (index == 3)
            {
                g.DrawEllipse(pen, cX, cY, sX, sY);

            }
            if (index == 4)
            {
                if (point1.X > point2.X && point1.Y > point2.Y)
                {
                    g.DrawRectangle(pen, x, y, x1 - x, y1 - y);
                }
                if (point1.X > point2.X && point1.Y < point2.Y)
                {
                    g.DrawRectangle(pen, x, y1, x1 - x, y - y1);
                }
                if (point1.X < point2.X && point1.Y > point2.Y)
                {
                    g.DrawRectangle(pen, x1, y, x - x1, y1 - y);
                }
                g.DrawRectangle(pen, x1, y1, x - x1, y - y1);
            }
            if (index == 5)
            {
                g.DrawLine(pen, cX, cY, x, y);
            }
            //if (index == 11)
            //{
            //    //пользователь выделил фрагмент и отпустил мышь?
            //    if (point1 != point2)
            //    {
            //        //создаем DraggedFragment
            //        var rect = GetRect(point1, point2);
            //        draggedFragment = new DraggedFragment() { SourceRect = rect, Location = rect.Location };
            //    }
            //    else
            //    {
            //        //пользователь сдвинул фрагмент и отпутил мышь?
            //        if (draggedFragment != null)
            //        {
            //            //фиксируем изменения в исходном изображении
            //            draggedFragment.Fix(pic.Image);
            //            //уничтожаем фрагмент
            //            //draggedFragment = null;
            //            point1 = point2 = e.Location;
            //        }
            //    }
            //    pic.Invalidate();
            //рисуем прямоугольник выделения
            //}
            if (isSelection && index == 11 && !selectionRectangle.Contains(e.Location))
            {
                // очищаем предыд прямоуг выделения
                //graphics.DrawImage(bitmapN, 0, 0);
                //вычесляем размер прямогольника выделения
                //возможно вместо у х
                int x = Math.Min(px.X, e.X);
                int y = Math.Min(py.Y, e.Y);
                int width = Math.Abs(e.X - py.X);
                int height = Math.Abs(e.Y - py.Y);
                selectionRectangle = new Rectangle(x, y, width, height);
                //CopyRectangle = new Rectangle(x, y, width, height);//////////

                //Рисуем прямоугольник выделения
                Pen pen1 = new Pen(Color.Black, 1);
                pen1.DashStyle = DashStyle.Dash;
                undostackCrop.Push((Bitmap)bm.Clone());

                g.DrawRectangle(pen1, selectionRectangle);
                //Обговляем PictureBox
                pic.Invalidate();
                isSelection = false;
            }
            // Перемещаем выделенную область изображения
            if (isDrag)
            {
                Pen pen1 = new Pen(Color.Black, 1);
                pen1.DashStyle = DashStyle.Dash;
                // Закрепление выделенного изображения в новой позиции
                //graphics.Clear(Color.White);
                // graphics.DrawImage(bitmap, 0, 0);
                int X = x - imageOffset.X;
                int Y = y - imageOffset.Y;
                selectionRectangle.Location = new Point(X, Y);
                //graphics.DrawImage(selectedImage, selectionRectangle);
                //bitmapN = selectedImageCrop;
                bm = undostackCrop.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                undostackCrop.Push((Bitmap)bm.Clone());

                g.DrawImage(selectedImage, selectionRectangle);
                g.DrawRectangle(pen1, selectionRectangle);//
                // Окончание перетаскивания
                //isDragging = false;
                pic.Invalidate();
            }
        }
        void ChekCrop()
        {
            if (undostackCrop.Count != 0 && !isDrag)
            {
                bm = undostackCrop.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm; pic.Invalidate();

                //selectionRectangle.Location = new Point(0, 0);
            }

        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lineWidth = trackBar1.Value;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Graphics graphicsPaint = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(pen, cX, cY, sX, sY);

                }
                if (index == 4)
                {
                    // g.DrawRectangle(pen, cX, cY, sX, sY);
                    if (point1.X > point2.X && point1.Y > point2.Y)
                    {
                        g.DrawRectangle(pen, x, y, x1 - x, y1 - y);
                    }
                    if (point1.X > point2.X && point1.Y < point2.Y)
                    {
                        g.DrawRectangle(pen, x, y1, x1 - x, y - y1);
                    }
                    if (point1.X < point2.X && point1.Y > point2.Y)
                    {
                        g.DrawRectangle(pen, x1, y, x - x1, y1 - y);
                    }
                    g.DrawRectangle(pen, x1, y1, x - x1, y - y1);
                }
                if (index == 5)
                {
                    g.DrawLine(pen, cX, cY, x, y);
                }
            }
            if (index == 11 && !isDrag)
            {
                if (x > cX && y > cY)
                {
                    Pen pen1 = new Pen(Color.Black, 1);
                    pen1.DashStyle = DashStyle.Dash;
                    graphicsPaint.DrawRectangle(pen1, cX, cY, sX, sY);
                }
                else if (x < cX && y < cY)
                {
                    Pen pen1 = new Pen(Color.Black, 1);
                    pen1.DashStyle = DashStyle.Dash;
                    graphicsPaint.DrawRectangle(pen1, x, y, cX - x, cY - y);
                }
                else if (x < cX && y > cY)
                {
                    Pen pen1 = new Pen(Color.Black, 1);
                    pen1.DashStyle = DashStyle.Dash;
                    graphicsPaint.DrawRectangle(pen1, x, cY, cX - x, sY);
                }
                else if (x > cX && y < cY)
                {
                    Pen pen1 = new Pen(Color.Black, 1);
                    pen1.DashStyle = DashStyle.Dash;
                    graphicsPaint.DrawRectangle(pen1, cX, y, sX, cY - y);
                }
                ////если есть сдвигаемый фрагмент
                //if (draggedFragment != null)
                //{
                //    //рисуем вырезанное белое место
                //    e.Graphics.SetClip(draggedFragment.SourceRect);
                //    e.Graphics.Clear(Color.White);

                //    //рисуем сдвинутый фрагмент
                //    e.Graphics.SetClip(draggedFragment.Rect);
                //    e.Graphics.DrawImage(pic.Image, draggedFragment.Location.X - draggedFragment.SourceRect.X, draggedFragment.Location.Y - draggedFragment.SourceRect.Y);

                //    //рисуем рамку
                //    e.Graphics.ResetClip();
                //    ControlPaint.DrawFocusRectangle(e.Graphics, draggedFragment.Rect);
                //}
                //else
                //{
                //    //если выделена область
                //    if (point1 != point2)
                //        ControlPaint.DrawFocusRectangle(e.Graphics, GetRect(point1, point2));
                //    //рисуем рамку
                //}
            }
            if (isDrag)
            {
                Pen pen1 = new Pen(Color.Black, 1);
                pen1.DashStyle = DashStyle.Dash;
                //Rectangle rectangle = new Rectangle();
                int X = x - imageOffset.X;
                int Y = y - imageOffset.Y;
                selectionRectangle.Location = new Point(X, Y);

                bm = undostackCrop.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;

                undostackCrop.Push((Bitmap)bm.Clone());
                g.DrawImage(selectedImage, selectionRectangle);

                graphicsPaint.DrawRectangle(pen1, selectionRectangle);///

                pic.Invalidate();
            }
        }

        private void btm_colot_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            pen.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }


        private void Validate(Bitmap bitmap, Stack<Point> pointStack, int x, int y, Color colorNew, Color colorOld)
        {
            Color cx = bitmap.GetPixel(x, y);
            if (cx == colorOld)
            {
                pointStack.Push(new Point(x, y));
                bitmap.SetPixel(x, y, colorNew);
            }
        }
        public void Fill(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);
            if (oldColor == newColor) return;
            while (pixel.Count > 0)
            {

                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 & pt.Y > 0 & pt.X < bitmap.Width - 1 && pt.Y < bitmap.Height - 1)
                {
                    Validate(bitmap, pixel, pt.X - 1, pt.Y, newColor, oldColor);
                    Validate(bitmap, pixel, pt.X, pt.Y - 1, newColor, oldColor);
                    Validate(bitmap, pixel, pt.X + 1, pt.Y, newColor, oldColor);
                    Validate(bitmap, pixel, pt.X, pt.Y + 1, newColor, oldColor);
                }

            }
        }
        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        private void pic_MouseClick_1(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(pic, e.Location);
            if (index == 7)
            {
                point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }

            if (isDrag && index != 11)
            {
                bm = undostackCrop.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                undostackCrop.Push((Bitmap)bm.Clone());
                g.DrawImage(selectedImage, selectionRectangle);

                while (undostackCrop.Count > 0)
                {
                    undostackCrop.Pop();
                }
                selectionRectangle = Rectangle.Empty;
                //selectionRectangle.Location = new Point(0, 0);
                isDrag = false;
            }
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            pen.Color = pic_color.BackColor;
        }

        private void btn_cler_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {

        }

        private void btn_get_up_Click(object sender, EventArgs e)
        {

        }

        private void btn_cut_Click(object sender, EventArgs e)
        {

        }

        private void btn_highlight_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            index = Convert.ToInt32(button.Tag);
            if (isDrag && index != 11)
            {
                bm = undostackCrop.Pop();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                undostackCrop.Push((Bitmap)bm.Clone());
                g.DrawImage(selectedImage, selectionRectangle);
                while (undostackCrop.Count > 0)
                {
                    undostackCrop.Pop();
                }
                selectionRectangle = Rectangle.Empty;
                isDrag = false;
            }
            
            ChekCrop();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "PNG File(*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                string fileName = sfd.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        btm.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        btm.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        btm.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        btm.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        btm.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Image Saved ...");
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string programmName = Properties.Settings.Default.programmName;
            OpenFileDialog openDocument = new OpenFileDialog();
            openDocument.Title = "Открыть графический документ";
            openDocument.Filter = "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "PNG File(*.png)|*.png";
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(openDocument.FileName);
                g = Graphics.FromImage(pic.Image);
                Form1.ActiveForm.Text = openDocument.SafeFileName + " — ";
            }
        }
        //  private DraggedFragment draggedFragment;--------------------------------------------------------------------------------------------

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pbImage_Paint(object sender, PaintEventArgs e)
        {

        }

        ////получение Rectangle из двух точек
        //Rectangle GetRect(Point p1, Point p2)
        //{
        //    var x1 = Math.Min(p1.X, p2.X);
        //    var x2 = Math.Max(p1.X, p2.X);
        //    var y1 = Math.Min(p1.Y, p2.Y);
        //    var y2 = Math.Max(p1.Y, p2.Y);
        //    return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        //}
    }

    ////сдвигаемый фрагмент
    //class DraggedFragment
    //{
    //    public Rectangle SourceRect;//прямоугольник фрагмента в исходном изображении
    //    public Point Location;//положение сдвинутого фрагмента

    //    //прямоугольник сдвинутого фрагмента
    //    public Rectangle Rect
    //    {
    //        get { return new Rectangle(Location, SourceRect.Size); }
    //    }

    //    //фиксация изменений в исх изображении
    //    public void Fix(Image image)
    //    {
    //        using (var clone = (Image)image.Clone())
    //        using (var gr = Graphics.FromImage(image))
    //        {
    //            //рисуем вырезанное белое место
    //            gr.SetClip(SourceRect);
    //            gr.Clear(Color.White);

    //            //рисуем сдвинутый фрагмент
    //            gr.SetClip(Rect);
    //            gr.DrawImage(clone, Location.X - SourceRect.X, Location.Y - SourceRect.Y);
    //        }
    //    }
    //}
}
