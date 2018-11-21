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

namespace Graphic
{
    public partial class FrmChild : Form
    {
        int oldX, oldY;
        Bitmap bmp;
        Size _oldSize;
        static readonly int StoreCapacity = 20;
        Stack<Bitmap> Store = new Stack<Bitmap>(StoreCapacity);
        public FrmChild()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }
        public FrmChild(string _path)
        {
            InitializeComponent();
            bmp = new Bitmap(Image.FromFile(_path), pictureBox1.Size);
            pictureBox1.Image = bmp;
            //pictureBox1.Width = pictureBox1.Image.Width;
            //pictureBox1.Height = pictureBox1.Image.Height;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                switch ((this.MdiParent as Form1).currentInstrument)
                {
                    case 1:
                        g.DrawLine(new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round }, oldX, oldY, e.X, e.Y);
                        oldX = e.X;
                        oldY = e.Y;
                        pictureBox1.Refresh();
                        bmp = (Bitmap)pictureBox1.Image;
                        break;
                    case 7:
                        g.DrawLine(new Pen(pictureBox1.BackColor, (this.MdiParent as Form1).width) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round }, oldX, oldY, e.X, e.Y);
                        oldX = e.X;
                        oldY = e.Y;
                        pictureBox1.Refresh();
                        bmp = (Bitmap)pictureBox1.Image;
                        break;
                }

            }
        }

        private void FrmChild_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldX = e.X;
                oldY = e.Y;
            }
            GoToPrevious();
            SaveState();
        }

        private void FrmChild_SizeChanged(object sender, EventArgs e)
        {
        }

        private void FrmChild_ResizeBegin(object sender, EventArgs e)
        {
            _oldSize = this.Size;
        }

        private void FrmChild_ResizeEnd(object sender, EventArgs e)
        {
            if (pictureBox1.Size != new Size(0, 0))
            {
                if (pictureBox1.Image != null && (pictureBox1.Image.Width < pictureBox1.Width || pictureBox1.Image.Height < pictureBox1.Height))
                {
                    var photoBitmap = (Bitmap)bmp.Clone();
                    var sketchBitmap = (Bitmap)pictureBox1.Image.Clone();

                    bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                    System.Drawing.Graphics g1 = System.Drawing.Graphics.FromImage(bmp);
                    System.Drawing.Graphics g2 = System.Drawing.Graphics.FromImage(pictureBox1.Image);

                    g1.DrawImage(photoBitmap, new Rectangle(0, 0, photoBitmap.Width, photoBitmap.Height));
                    g2.DrawImage(sketchBitmap, new Rectangle(0, 0, sketchBitmap.Width, sketchBitmap.Height));
                }
                pictureBox1.Refresh();
                bmp = new Bitmap(pictureBox1.Image, pictureBox1.Size);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                Pen pen = new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
                switch ((this.MdiParent as Form1).currentInstrument)
                {
                    case 2:
                        g.DrawLine(pen, oldX, oldY, e.X, e.Y);
                        pictureBox1.Refresh();
                        bmp = (Bitmap)pictureBox1.Image;
                        break;
                    case 3:
                        double R = (e.X - oldX) / 2, r = e.X - oldX;   // радиусы
                        double alpha = 60;        // поворот
                        double x0 = (e.X + oldX) / 2, y0 = (e.Y + oldY) / 2; // центр
                        PointF[] points = new PointF[11];
                        double a = alpha, da = Math.PI / 5, l;
                        for (int k = 0; k < 11; k++)
                        {
                            l = k % 2 == 0 ? r : R;
                            points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                            a += da;
                        }
                        g.DrawLines(pen, points);
                        pictureBox1.Refresh();
                        bmp = (Bitmap)pictureBox1.Image;
                        break;
                    case 4:
                        g.DrawEllipse(pen, oldX, oldY, e.X - oldX, e.Y - oldY);
                        pictureBox1.Refresh();
                        bmp = (Bitmap)pictureBox1.Image;
                        break;
                }

            }
        }

        public void ZoomIn()
        {
            if (pictureBox1.Image.Width <= this.Width * 4)
            {
                Image result = new Bitmap(pictureBox1.Image.Width * 2, pictureBox1.Image.Height * 2);
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage((Image)result))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(bmp, 0, 0, pictureBox1.Image.Width * 2, pictureBox1.Image.Height * 2);
                    g.Dispose();
                }
                pictureBox1.Image = result;
                bmp = (Bitmap)result;
                pictureBox1.Refresh();
            }
            else MessageBox.Show("Невозможно увеличить изображение");
        }

        public void ZoomOut()
        {
            if (pictureBox1.Image.Width >= this.Width / 10)
            {
                Image result = new Bitmap(pictureBox1.Image.Width / 2, pictureBox1.Image.Height / 2);
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage((Image)result))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(bmp, 0, 0, pictureBox1.Image.Width / 2, pictureBox1.Image.Height / 2);
                    g.Dispose();
                }
                pictureBox1.Image = result;
                bmp = (Bitmap)result;
                pictureBox1.Refresh();
            }
            else MessageBox.Show("Невозможно уменьшить изображение");
        }

        public void Save(string _path)
        {
            pictureBox1.Image.Save(_path);
        }

        public void GoToPrevious()
        {
            if (Store.Count > StoreCapacity)
            {
                Bitmap[] bitmaps = Store.ToArray();
                Store.Clear();

                for (int i = StoreCapacity - 1, j = 0; j < StoreCapacity && i > -1; i--, j++)
                    Store.Push(bitmaps[i]);
            }

            if (Store.Count > 0)
            {
                bmp = Store.Pop();

                if (bmp.Width < pictureBox1.Width || bmp.Height < pictureBox1.Height)
                {
                    var sketchBitmap = (Bitmap)pictureBox1.Image.Clone();
                    pictureBox1.Image = new Bitmap(bmp.Width < pictureBox1.Width ? pictureBox1.Width : bmp.Width,
bmp.Height < pictureBox1.Height ? pictureBox1.Height : bmp.Height);
                    System.Drawing.Graphics g2 = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                    g2.DrawImage(sketchBitmap, new Rectangle(0, 0, sketchBitmap.Width, sketchBitmap.Height));
                }
            }
        }
        void SaveState()
        {
            if (pictureBox1.Image != null)
                Store.Push((Bitmap)pictureBox1.Image.Clone());
        }

        public void Emboss()
        {
            bmp = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = bmp;
            Bitmap temp = new Bitmap(pictureBox1.Image);
            int i, j, DispX = 1, DispY = 1, red, green, blue;
            for (i = 0; i <= temp.Height - 2; i++)
            {
                for (j = 0; j <= temp.Width - 2; j++)
                {
                    Color pixel1, pixel2;
                    pixel1 = temp.GetPixel(j, i);
                    pixel2 = temp.GetPixel(j + DispX, i + DispY);
                    red = Math.Min(Math.Abs(pixel1.R - pixel2.R) + 128, 255);
                    green = Math.Min(Math.Abs(pixel1.G - pixel2.G) + 128, 255);
                    blue = Math.Min(Math.Abs(pixel1.B - pixel2.B) + 128, 255);
                    bmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                }
            }
            this.Text = "Дочерняя форма";
            pictureBox1.Image = (Image)bmp;
            pictureBox1.Refresh();
        }
        public void Diffuse()
        {
            bmp = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = bmp;
            Bitmap temp = new Bitmap(pictureBox1.Image);
            int i, j, DispX = 1, DispY = 1, red, green, blue;
            var random = new Random();
            for (i = 3; i < temp.Height - 3; i++)
            {
                for (j = 3; j < temp.Width - 3; j++)
                {
                    DispX = (int)(random.NextDouble() * 4 - 2);
                    DispY = (int)(random.NextDouble() * 4 - 2);
                    red = temp.GetPixel(j + DispX, i + DispY).R;
                    green = temp.GetPixel(j + DispX, i + DispY).G;
                    blue = temp.GetPixel(j + DispX, i + DispY).B;
                    bmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }

                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                }
            }
            this.Text = "Дочерняя форма";
            pictureBox1.Refresh();
        }
        public void Sharpen()
        {
            bmp = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = bmp;
            Bitmap temp = new Bitmap(pictureBox1.Image);
            int i, j, DispX = 1, DispY = 1, red, green, blue;
            for (i = DispX; i < temp.Height - DispX - 1; i++)
            {
                for (j = DispY; j < temp.Width - DispY - 1; j++)
                {
                    red = (Int32)((temp.GetPixel(j, i).R) + 0.5 * ((temp.GetPixel(j, i).R) - (temp.GetPixel(j - DispX, i - DispY).R)));
                    green = (Int32)((temp.GetPixel(j, i).G) + 0.5 * ((temp.GetPixel(j, i).G) - (temp.GetPixel(j - DispX, i - DispY).G)));
                    blue = (Int32)((temp.GetPixel(j, i).B) + 0.5 * ((temp.GetPixel(j, i).B) - (temp.GetPixel(j - DispX, i - DispY).B)));
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    bmp.SetPixel(j, i, Color.FromArgb(red, green, blue));

                }
                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                }
            }
            this.Text = "Дочерняя форма";
            pictureBox1.Refresh();
        }
        public void Smooth()
        {
            bmp = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = bmp;
            Bitmap temp = new Bitmap(pictureBox1.Image);
            int i, j, DispX = 1, DispY = 1, red, green, blue;
            for (i = DispX; i < temp.Height - DispX - 1; i++)
            {
                for (j = DispY; j < temp.Width - DispY - 1; j++)
                {
                    red = (int)(((int)(temp.GetPixel(j - 1, i - 1).R) +
                            (int)(temp.GetPixel(j - 1, i).R) +
                            (int)(temp.GetPixel(j - 1, i + 1).R) +
                            (int)(temp.GetPixel(j, i - 1).R) +
                            (int)(temp.GetPixel(j, i).R) +
                            (int)(temp.GetPixel(j, i + 1).R) +
                            (int)(temp.GetPixel(j + 1, i - 1).R) +
                            (int)(temp.GetPixel(j + 1, i).R) +
                            (int)(temp.GetPixel(j + 1, i + 1).R)) / 9);

                    green = (int)(((int)(temp.GetPixel(j - 1, i - 1).G) +
                            (int)(temp.GetPixel(j - 1, i).G) +
                            (int)(temp.GetPixel(j - 1, i + 1).G) +
                            (int)(temp.GetPixel(j, i - 1).G) +
                            (int)(temp.GetPixel(j, i).G) +
                            (int)(temp.GetPixel(j, i + 1).G) +
                            (int)(temp.GetPixel(j + 1, i - 1).G) +
                            (int)(temp.GetPixel(j + 1, i).G) +
                            (int)(temp.GetPixel(j + 1, i + 1).G)) / 9);

                    blue = (int)(((int)(temp.GetPixel(j - 1, i - 1).B) +
                            (int)(temp.GetPixel(j - 1, i).B) +
                            (int)(temp.GetPixel(j - 1, i + 1).B) +
                            (int)(temp.GetPixel(j, i - 1).B) +
                            (int)(temp.GetPixel(j, i).B) +
                            (int)(temp.GetPixel(j, i + 1).B) +
                            (int)(temp.GetPixel(j + 1, i - 1).B) +
                            (int)(temp.GetPixel(j + 1, i).B) +
                            (int)(temp.GetPixel(j + 1, i + 1).B)) / 9);
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    bmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                }
            }
            this.Text = "Дочерняя форма";
            pictureBox1.Refresh();
        }
        public void ViewNormal()
        {
            //pictureBox1.Width = pictureBox1.Image.Width;
            //pictureBox1.Height = pictureBox1.Image.Height;
            //pictureBox1.Refresh();
            Image result = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, 0, 0, pictureBox1.Width, pictureBox1.Height);
                g.Dispose();
            }
            pictureBox1.Image = result;
            bmp = (Bitmap)result;
            pictureBox1.Refresh();
        }
        public void ViewZoomOut()
        {
            ZoomOut();
        }
        public void ViewZoomIn()
        {
            ZoomIn();
        }
        public void RotateLeft()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Width = pictureBox1.Height * pictureBox1.Image.Width / pictureBox1.Image.Height;
            pictureBox1.Refresh();
        }
        public void RotateRight()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Width = pictureBox1.Height * pictureBox1.Image.Width / pictureBox1.Image.Height;
            pictureBox1.Refresh();
        }
        public void FlipHorizontal()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }
        public void FlipVertical()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }
    }
}
