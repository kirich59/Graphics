using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                        g.DrawLine(new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width), oldX, oldY, e.X, e.Y);
                        oldX = e.X;
                        oldY = e.Y;
                        pictureBox1.Refresh();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        //g.DrawEllipse(new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width))
                        break;
                    case 5:
                        break;
                    case 6:
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
                switch ((this.MdiParent as Form1).currentInstrument)
                {
                    case 1:
                        break;
                    case 2:
                        g.DrawLine(new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width), oldX, oldY, e.X, e.Y);
                        pictureBox1.Refresh();
                        break;
                    case 3:
                        double R = (e.X - oldX) / 2, r = e.X-oldX;   // радиусы
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

                        g.DrawLines(new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width), points);
                        pictureBox1.Refresh();
                        break;
                    case 4:
                        g.DrawEllipse(new Pen((this.MdiParent as Form1).color, (this.MdiParent as Form1).width), oldX, oldY, e.X - oldX, e.Y - oldY);
                        pictureBox1.Refresh();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }

            }
        }

        public void Save(string _path)
        {
            pictureBox1.Image.Save(_path);
        }
    }
}
