
namespace oop1._1
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.lbDvishx = new System.Windows.Forms.Label();
            this.lbDvishy = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CHB = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.lbrus = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.listBoxIndex = new System.Windows.Forms.ListBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.notifWIn = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.TboxParol = new System.Windows.Forms.TextBox();
            this.btnParol = new System.Windows.Forms.Button();
            this.parol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnShirft = new System.Windows.Forms.Button();
            this.Btnimage1 = new System.Windows.Forms.Button();
            this.BtnImage2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Btnbrows = new System.Windows.Forms.Button();
            this.textBrows = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLBUsatu = new System.Windows.Forms.LinkLabel();
            this.lBperexod = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cohfybnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDvishx
            // 
            this.lbDvishx.AutoSize = true;
            this.lbDvishx.Location = new System.Drawing.Point(9, 418);
            this.lbDvishx.Name = "lbDvishx";
            this.lbDvishx.Size = new System.Drawing.Size(16, 17);
            this.lbDvishx.TabIndex = 1;
            this.lbDvishx.Text = "0";
            // 
            // lbDvishy
            // 
            this.lbDvishy.AutoSize = true;
            this.lbDvishy.Location = new System.Drawing.Point(9, 445);
            this.lbDvishy.Name = "lbDvishy";
            this.lbDvishy.Size = new System.Drawing.Size(16, 17);
            this.lbDvishy.TabIndex = 2;
            this.lbDvishy.Text = "0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CHB
            // 
            this.CHB.AutoSize = true;
            this.CHB.Location = new System.Drawing.Point(1079, 42);
            this.CHB.Name = "CHB";
            this.CHB.Size = new System.Drawing.Size(70, 21);
            this.CHB.TabIndex = 3;
            this.CHB.Text = "Алиса";
            this.CHB.UseVisualStyleBackColor = true;
            this.CHB.CheckedChanged += new System.EventHandler(this.CHB_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "PHP",
            "Python",
            "Java",
            "JavaScript",
            "SQL"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 79);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 174);
            this.checkedListBox1.TabIndex = 4;
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(12, 259);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(111, 50);
            this.btnGetItem.TabIndex = 5;
            this.btnGetItem.Text = "Получить имя элемента";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.btnGetItem_Click);
            // 
            // lbrus
            // 
            this.lbrus.AutoSize = true;
            this.lbrus.BackColor = System.Drawing.SystemColors.Control;
            this.lbrus.Location = new System.Drawing.Point(9, 59);
            this.lbrus.Name = "lbrus";
            this.lbrus.Size = new System.Drawing.Size(180, 17);
            this.lbrus.TabIndex = 6;
            this.lbrus.Text = "Языки программирования";
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 16;
            this.listBoxItem.Location = new System.Drawing.Point(12, 315);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(120, 84);
            this.listBoxItem.TabIndex = 7;
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Location = new System.Drawing.Point(157, 259);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(109, 50);
            this.btnGetIndex.TabIndex = 5;
            this.btnGetIndex.Text = "Получить номер ";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // listBoxIndex
            // 
            this.listBoxIndex.FormattingEnabled = true;
            this.listBoxIndex.ItemHeight = 16;
            this.listBoxIndex.Location = new System.Drawing.Point(157, 315);
            this.listBoxIndex.Name = "listBoxIndex";
            this.listBoxIndex.Size = new System.Drawing.Size(120, 84);
            this.listBoxIndex.TabIndex = 7;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(1266, 155);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(186, 90);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Поменять цвет формы";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(1232, 28);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 22);
            this.Date.TabIndex = 9;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1239, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // notifWIn
            // 
            this.notifWIn.Icon = ((System.Drawing.Icon)(resources.GetObject("notifWIn.Icon")));
            this.notifWIn.Text = "открыть форму";
            this.notifWIn.Visible = true;
            this.notifWIn.Click += new System.EventHandler(this.notifWIn_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(335, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Старт ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(430, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(394, 43);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(50, 17);
            this.time.TabIndex = 13;
            this.time.Text = "Время";
            // 
            // TboxParol
            // 
            this.TboxParol.Location = new System.Drawing.Point(517, 71);
            this.TboxParol.Name = "TboxParol";
            this.TboxParol.Size = new System.Drawing.Size(146, 22);
            this.TboxParol.TabIndex = 14;
            // 
            // btnParol
            // 
            this.btnParol.Location = new System.Drawing.Point(548, 105);
            this.btnParol.Name = "btnParol";
            this.btnParol.Size = new System.Drawing.Size(75, 23);
            this.btnParol.TabIndex = 15;
            this.btnParol.Text = "Принять";
            this.btnParol.UseVisualStyleBackColor = true;
            this.btnParol.Click += new System.EventHandler(this.btnParol_Click);
            // 
            // parol
            // 
            this.parol.AutoSize = true;
            this.parol.BackColor = System.Drawing.SystemColors.HighlightText;
            this.parol.Location = new System.Drawing.Point(530, 43);
            this.parol.Name = "parol";
            this.parol.Size = new System.Drawing.Size(114, 17);
            this.parol.TabIndex = 16;
            this.parol.Text = "Введите пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(754, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclr.Location = new System.Drawing.Point(1296, 374);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(170, 70);
            this.btnclr.TabIndex = 18;
            this.btnclr.Text = "Поменять цвет кнопки на красный?";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnShirft
            // 
            this.btnShirft.Location = new System.Drawing.Point(1217, 272);
            this.btnShirft.Name = "btnShirft";
            this.btnShirft.Size = new System.Drawing.Size(249, 72);
            this.btnShirft.TabIndex = 19;
            this.btnShirft.Text = "Поменять шрифт кнопки";
            this.btnShirft.UseVisualStyleBackColor = true;
            this.btnShirft.Click += new System.EventHandler(this.btnShirft_Click);
            // 
            // Btnimage1
            // 
            this.Btnimage1.Location = new System.Drawing.Point(764, 230);
            this.Btnimage1.Name = "Btnimage1";
            this.Btnimage1.Size = new System.Drawing.Size(75, 23);
            this.Btnimage1.TabIndex = 20;
            this.Btnimage1.Text = "фото1";
            this.Btnimage1.UseVisualStyleBackColor = true;
            this.Btnimage1.Click += new System.EventHandler(this.Btnimage1_Click);
            // 
            // BtnImage2
            // 
            this.BtnImage2.Location = new System.Drawing.Point(868, 230);
            this.BtnImage2.Name = "BtnImage2";
            this.BtnImage2.Size = new System.Drawing.Size(75, 23);
            this.BtnImage2.TabIndex = 21;
            this.BtnImage2.Text = "фото2";
            this.BtnImage2.UseVisualStyleBackColor = true;
            this.BtnImage2.Click += new System.EventHandler(this.BtnImage2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(384, 238);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(300, 300);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Btnbrows
            // 
            this.Btnbrows.Location = new System.Drawing.Point(573, 188);
            this.Btnbrows.Name = "Btnbrows";
            this.Btnbrows.Size = new System.Drawing.Size(90, 23);
            this.Btnbrows.TabIndex = 23;
            this.Btnbrows.Text = "Перейти";
            this.Btnbrows.UseVisualStyleBackColor = true;
            this.Btnbrows.Click += new System.EventHandler(this.Btnbrows_Click);
            // 
            // textBrows
            // 
            this.textBrows.Location = new System.Drawing.Point(397, 189);
            this.textBrows.Name = "textBrows";
            this.textBrows.Size = new System.Drawing.Size(153, 22);
            this.textBrows.TabIndex = 24;
            // 
            // linkLBUsatu
            // 
            this.linkLBUsatu.AutoSize = true;
            this.linkLBUsatu.Location = new System.Drawing.Point(992, 401);
            this.linkLBUsatu.Name = "linkLBUsatu";
            this.linkLBUsatu.Size = new System.Drawing.Size(94, 17);
            this.linkLBUsatu.TabIndex = 25;
            this.linkLBUsatu.TabStop = true;
            this.linkLBUsatu.Text = "www.ugatu.su";
            this.linkLBUsatu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLBUsatu_LinkClicked);
            // 
            // lBperexod
            // 
            this.lBperexod.AutoSize = true;
            this.lBperexod.Location = new System.Drawing.Point(826, 401);
            this.lBperexod.Name = "lBperexod";
            this.lBperexod.Size = new System.Drawing.Size(135, 17);
            this.lBperexod.TabIndex = 26;
            this.lBperexod.Text = "Переход по ссылке";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cohfybnmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cohfybnmToolStripMenuItem
            // 
            this.cohfybnmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.cohfybnmToolStripMenuItem.Name = "cohfybnmToolStripMenuItem";
            this.cohfybnmToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.cohfybnmToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1478, 671);
            this.Controls.Add(this.lBperexod);
            this.Controls.Add(this.linkLBUsatu);
            this.Controls.Add(this.textBrows);
            this.Controls.Add(this.Btnbrows);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BtnImage2);
            this.Controls.Add(this.Btnimage1);
            this.Controls.Add(this.btnShirft);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.parol);
            this.Controls.Add(this.btnParol);
            this.Controls.Add(this.TboxParol);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.listBoxIndex);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.lbrus);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.CHB);
            this.Controls.Add(this.lbDvishy);
            this.Controls.Add(this.lbDvishx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm1";
            this.Text = "Fm1";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDvishx;
        private System.Windows.Forms.Label lbDvishy;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox CHB;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnGetItem;
        private System.Windows.Forms.Label lbrus;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.Button btnGetIndex;
        private System.Windows.Forms.ListBox listBoxIndex;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifWIn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox TboxParol;
        private System.Windows.Forms.Button btnParol;
        private System.Windows.Forms.Label parol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnShirft;
        private System.Windows.Forms.Button Btnimage1;
        private System.Windows.Forms.Button BtnImage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Btnbrows;
        private System.Windows.Forms.TextBox textBrows;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLBUsatu;
        private System.Windows.Forms.Label lBperexod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cohfybnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}

