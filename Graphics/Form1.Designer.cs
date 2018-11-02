namespace Graphic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreate_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.риунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядчитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.penToolStrip = new System.Windows.Forms.ToolStripButton();
            this.lineToolStrip = new System.Windows.Forms.ToolStripButton();
            this.starToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ellipseToolStrip = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStrip = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.риунокToolStripMenuItem,
            this.windowMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate_Click,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.tsmiSaveAs_Click,
            this.exitMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiCreate_Click
            // 
            this.tsmiCreate_Click.Name = "tsmiCreate_Click";
            this.tsmiCreate_Click.Size = new System.Drawing.Size(162, 22);
            this.tsmiCreate_Click.Text = "Создать";
            this.tsmiCreate_Click.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // tsmiSaveAs_Click
            // 
            this.tsmiSaveAs_Click.Name = "tsmiSaveAs_Click";
            this.tsmiSaveAs_Click.Size = new System.Drawing.Size(162, 22);
            this.tsmiSaveAs_Click.Text = "Сохранить как...";
            this.tsmiSaveAs_Click.Click += new System.EventHandler(this.tsmiSaveAs_Click_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // риунокToolStripMenuItem
            // 
            this.риунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эффект1ToolStripMenuItem,
            this.эффект2ToolStripMenuItem,
            this.эффект3ToolStripMenuItem,
            this.эффект4ToolStripMenuItem,
            this.эффект5ToolStripMenuItem,
            this.эффект6ToolStripMenuItem,
            this.эффект7ToolStripMenuItem,
            this.эффект8ToolStripMenuItem,
            this.эффект9ToolStripMenuItem,
            this.эффект10ToolStripMenuItem,
            this.эффект11ToolStripMenuItem});
            this.риунокToolStripMenuItem.Name = "риунокToolStripMenuItem";
            this.риунокToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.риунокToolStripMenuItem.Text = "Риунок";
            // 
            // эффект1ToolStripMenuItem
            // 
            this.эффект1ToolStripMenuItem.Name = "эффект1ToolStripMenuItem";
            this.эффект1ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект1ToolStripMenuItem.Text = "Эффект 1";
            // 
            // эффект2ToolStripMenuItem
            // 
            this.эффект2ToolStripMenuItem.Name = "эффект2ToolStripMenuItem";
            this.эффект2ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект2ToolStripMenuItem.Text = "Эффект 2";
            // 
            // эффект3ToolStripMenuItem
            // 
            this.эффект3ToolStripMenuItem.Name = "эффект3ToolStripMenuItem";
            this.эффект3ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект3ToolStripMenuItem.Text = "Эффект 3";
            // 
            // эффект4ToolStripMenuItem
            // 
            this.эффект4ToolStripMenuItem.Name = "эффект4ToolStripMenuItem";
            this.эффект4ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект4ToolStripMenuItem.Text = "Эффект 4";
            // 
            // эффект5ToolStripMenuItem
            // 
            this.эффект5ToolStripMenuItem.Name = "эффект5ToolStripMenuItem";
            this.эффект5ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект5ToolStripMenuItem.Text = "Эффект 5";
            // 
            // эффект6ToolStripMenuItem
            // 
            this.эффект6ToolStripMenuItem.Name = "эффект6ToolStripMenuItem";
            this.эффект6ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект6ToolStripMenuItem.Text = "Эффект 6";
            // 
            // эффект7ToolStripMenuItem
            // 
            this.эффект7ToolStripMenuItem.Name = "эффект7ToolStripMenuItem";
            this.эффект7ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект7ToolStripMenuItem.Text = "Эффект 7";
            // 
            // эффект8ToolStripMenuItem
            // 
            this.эффект8ToolStripMenuItem.Name = "эффект8ToolStripMenuItem";
            this.эффект8ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект8ToolStripMenuItem.Text = "Эффект 8";
            // 
            // эффект9ToolStripMenuItem
            // 
            this.эффект9ToolStripMenuItem.Name = "эффект9ToolStripMenuItem";
            this.эффект9ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект9ToolStripMenuItem.Text = "Эффект 9";
            // 
            // эффект10ToolStripMenuItem
            // 
            this.эффект10ToolStripMenuItem.Name = "эффект10ToolStripMenuItem";
            this.эффект10ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект10ToolStripMenuItem.Text = "Эффект 10";
            // 
            // эффект11ToolStripMenuItem
            // 
            this.эффект11ToolStripMenuItem.Name = "эффект11ToolStripMenuItem";
            this.эффект11ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.эффект11ToolStripMenuItem.Text = "Эффект 11";
            // 
            // windowMenuItem
            // 
            this.windowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядчитьЗначкиToolStripMenuItem});
            this.windowMenuItem.Name = "windowMenuItem";
            this.windowMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowMenuItem.Text = "Окно";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.слеваНаправоToolStripMenuItem.Text = "Слева направо";
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сверхуВнизToolStripMenuItem.Text = "Сверху вниз";
            // 
            // упорядчитьЗначкиToolStripMenuItem
            // 
            this.упорядчитьЗначкиToolStripMenuItem.Name = "упорядчитьЗначкиToolStripMenuItem";
            this.упорядчитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.упорядчитьЗначкиToolStripMenuItem.Text = "Упорядчить значки";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.penToolStrip,
            this.lineToolStrip,
            this.starToolStrip,
            this.ellipseToolStrip,
            this.zoomInToolStrip,
            this.zoomOutToolStrip,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 24);
            this.toolStripLabel1.Text = "Цвет";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 24);
            this.toolStripLabel2.Text = "Толщина";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click_1);
            // 
            // penToolStrip
            // 
            this.penToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("penToolStrip.Image")));
            this.penToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penToolStrip.Name = "penToolStrip";
            this.penToolStrip.Size = new System.Drawing.Size(24, 24);
            this.penToolStrip.Text = "toolStripButton1";
            this.penToolStrip.Click += new System.EventHandler(this.penToolStrip_Click);
            // 
            // lineToolStrip
            // 
            this.lineToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStrip.Image")));
            this.lineToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStrip.Name = "lineToolStrip";
            this.lineToolStrip.Size = new System.Drawing.Size(24, 24);
            this.lineToolStrip.Text = "toolStripButton2";
            this.lineToolStrip.Click += new System.EventHandler(this.lineToolStrip_Click);
            // 
            // starToolStrip
            // 
            this.starToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.starToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("starToolStrip.Image")));
            this.starToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.starToolStrip.Name = "starToolStrip";
            this.starToolStrip.Size = new System.Drawing.Size(24, 24);
            this.starToolStrip.Text = "toolStripButton3";
            this.starToolStrip.Click += new System.EventHandler(this.starToolStrip_Click);
            // 
            // ellipseToolStrip
            // 
            this.ellipseToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStrip.Image")));
            this.ellipseToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseToolStrip.Name = "ellipseToolStrip";
            this.ellipseToolStrip.Size = new System.Drawing.Size(24, 24);
            this.ellipseToolStrip.Text = "toolStripButton4";
            this.ellipseToolStrip.Click += new System.EventHandler(this.ellipseToolStrip_Click);
            // 
            // zoomInToolStrip
            // 
            this.zoomInToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStrip.Image")));
            this.zoomInToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStrip.Name = "zoomInToolStrip";
            this.zoomInToolStrip.Size = new System.Drawing.Size(24, 24);
            this.zoomInToolStrip.Text = "toolStripButton5";
            this.zoomInToolStrip.Click += new System.EventHandler(this.zoomInToolStrip_Click);
            // 
            // zoomOutToolStrip
            // 
            this.zoomOutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStrip.Image")));
            this.zoomOutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStrip.Name = "zoomOutToolStrip";
            this.zoomOutToolStrip.Size = new System.Drawing.Size(24, 24);
            this.zoomOutToolStrip.Text = "toolStripButton6";
            this.zoomOutToolStrip.Click += new System.EventHandler(this.zoomOutToolStrip_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBar1.Location = new System.Drawing.Point(0, 51);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 563);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 614);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "  Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate_Click;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs_Click;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem риунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядчитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton penToolStrip;
        private System.Windows.Forms.ToolStripButton lineToolStrip;
        private System.Windows.Forms.ToolStripButton starToolStrip;
        private System.Windows.Forms.ToolStripButton ellipseToolStrip;
        private System.Windows.Forms.ToolStripButton zoomInToolStrip;
        private System.Windows.Forms.ToolStripButton zoomOutToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

