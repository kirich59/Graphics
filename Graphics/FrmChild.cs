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
                        break;
                    case 7:
                        g.DrawLine(new Pen(pictureBox1.BackColor, (this.MdiParent as Form1).width) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round }, oldX, oldY, e.X, e.Y);
                        oldX = e.X;
                        oldY = e.Y;
                        pictureBox1.Refresh();
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
            //if (bmp != null)
            //{
            //    pictureBox1.Dock = DockStyle.Fill;
            //    pictureBox1.Size = this.Size;
            //    Bitmap tmp = new Bitmap(bmp, pictureBox1.Size);
            //    bmp = tmp;
            //}
        }

        private void FrmChild_ResizeBegin(object sender, EventArgs e)
        {
            _oldSize = this.Size;
        }

        private void FrmChild_ResizeEnd(object sender, EventArgs e)
        {
            //pictureBox1.Size += (this.Size-_oldSize);
            //Bitmap tmp = new Bitmap(bmp, pictureBox1.Size);
            //bmp = tmp;
            //pictureBox1.Image = bmp;
            //pictureBox1.Refresh();


            var bmp = (Bitmap)pictureBox1.Image.Clone();

            if (bmp.Height < Height && bmp.Width < Width)
            {
                pictureBox1.Image = new Bitmap(Width, Height);
                System.Drawing.Graphics G = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                G.DrawImageUnscaledAndClipped(bmp, new Rectangle(0, 0, bmp.Height, bmp.Width));
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
                        break;
                    case 4:
                        g.DrawEllipse(pen, oldX, oldY, e.X - oldX, e.Y - oldY);
                        pictureBox1.Refresh();
                        break;
                }

            }
        }

        public void ZoomIn()
        {
            //Bitmap bitmap = new Bitmap(pictureBox1.Image, pictureBox1.Width * 2, pictureBox1.Height * 2);
            //bmp = bitmap;
            //pictureBox1.Image = bmp;
            //pictureBox1.Refresh();

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

        public void ZoomOut()
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
    }
}
