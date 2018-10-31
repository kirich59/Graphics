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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Color color { get; set; }
        public int width { get; set; }
        public int currentInstrument { get; set; }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChild child = new FrmChild();
            child.MdiParent = this;
            child.Show();
            toolStrip1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            numericUpDown1.Visible = false;
            color = Color.Black;
            currentInstrument = 1;
        }

        private void tsmiSaveAs_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Bitmap file (*.bmp)|*.bmp|JPEG (*.jpeg)|*.jpeg|GIF (*.gif)|*.gif|All files (*.*)|*.*";
            sfd.Title = "Сохранение изображения";


            if (this.ActiveMdiChild != null)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ((FrmChild)this.ActiveMdiChild).Save(sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("Не выбран рисунок для сохранения", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Bitmap file (*.bmp)|*.bmp|JPEG (*.jpeg)|*.jpeg|GIF (*.gif)|*.gif|All files (*.*)|*.*";
            ofd.Title = "Открытие изображения";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists == true)
                {
                    FrmChild child = new FrmChild(ofd.FileName);
                    child.MdiParent = this;
                    child.Show();
                    toolStrip1.Visible = true;
                    numericUpDown1.Visible = true;
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                color = colorDialog.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            width = (int)numericUpDown1.Value;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Visible == true) numericUpDown1.Visible = false;
            else numericUpDown1.Visible = true;
        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Visible == true) numericUpDown1.Visible = false;
            else numericUpDown1.Visible = true;
        }

        private void lineToolStrip_Click(object sender, EventArgs e)
        {
            currentInstrument = 2;
            lineToolStrip.BackColor = Color.IndianRed;
            starToolStrip.BackColor = Control.DefaultBackColor;
            ellipseToolStrip.BackColor = Control.DefaultBackColor;
            zoomInToolStrip.BackColor = Control.DefaultBackColor;
            zoomOutToolStrip.BackColor = Control.DefaultBackColor;
            penToolStrip.BackColor = Control.DefaultBackColor;
        }

        private void starToolStrip_Click(object sender, EventArgs e)
        {
            currentInstrument = 3;
            starToolStrip.BackColor = Color.IndianRed;
            lineToolStrip.BackColor = Control.DefaultBackColor;
            ellipseToolStrip.BackColor = Control.DefaultBackColor;
            zoomInToolStrip.BackColor = Control.DefaultBackColor;
            zoomOutToolStrip.BackColor = Control.DefaultBackColor;
            penToolStrip.BackColor = Control.DefaultBackColor;
        }

        private void ellipseToolStrip_Click(object sender, EventArgs e)
        {
            currentInstrument = 4;
            ellipseToolStrip.BackColor = Color.IndianRed;
            starToolStrip.BackColor = Control.DefaultBackColor;
            lineToolStrip.BackColor = Control.DefaultBackColor;
            zoomInToolStrip.BackColor = Control.DefaultBackColor;
            zoomOutToolStrip.BackColor = Control.DefaultBackColor;
            penToolStrip.BackColor = Control.DefaultBackColor;
        }

        private void zoomInToolStrip_Click(object sender, EventArgs e)
        {
            currentInstrument = 5;
            zoomInToolStrip.BackColor = Color.IndianRed;
            ellipseToolStrip.BackColor = Control.DefaultBackColor;
            starToolStrip.BackColor = Control.DefaultBackColor;
            lineToolStrip.BackColor = Control.DefaultBackColor;
            zoomOutToolStrip.BackColor = Control.DefaultBackColor;
            penToolStrip.BackColor = Control.DefaultBackColor;
        }

        private void zoomOutToolStrip_Click(object sender, EventArgs e)
        {
            currentInstrument = 6;
            zoomOutToolStrip.BackColor = Color.IndianRed;
            zoomInToolStrip.BackColor = Control.DefaultBackColor;
            ellipseToolStrip.BackColor = Control.DefaultBackColor;
            starToolStrip.BackColor = Control.DefaultBackColor;
            lineToolStrip.BackColor = Control.DefaultBackColor;
            penToolStrip.BackColor = Control.DefaultBackColor;
        }

        private void penToolStrip_Click(object sender, EventArgs e)
        {
            currentInstrument = 1;
            penToolStrip.BackColor = Color.IndianRed;
            zoomOutToolStrip.BackColor = Control.DefaultBackColor;
            zoomInToolStrip.BackColor = Control.DefaultBackColor;
            ellipseToolStrip.BackColor = Control.DefaultBackColor;
            starToolStrip.BackColor = Control.DefaultBackColor;
            lineToolStrip.BackColor = Control.DefaultBackColor;
        }
    }
}
