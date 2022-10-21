using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop1._1
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("http://google.com");
        }


        private void Frm1_MouseMove(object sender, MouseEventArgs e)
        {
            lbDvishx.Text = e.X.ToString();
            lbDvishy.Text = e.Y.ToString();
        }

        

       
        private void CHB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CHB = (CheckBox)sender;
            if (CHB.Checked == true)
            {
                MessageBox.Show("Флажок " + CHB.Text + " теперь отмечен");

            }
            else
            {
                MessageBox.Show("Флажок " + CHB.Text + " теперь не отмечен");
            }
        }

        private void btnGetItem_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBoxItem.Items.Add(s);
        }

        private void btnGetIndex_Click(object sender, EventArgs e)
        {
            listBoxIndex.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                listBoxIndex.Items.Add(checkedListBox1.CheckedIndices[i]);

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            this.BackColor = colorDialog1.Color;
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            Date.Format = DateTimePickerFormat.Long;
            Date.ValueChanged += Date_ValueChanged;
            label1.Text=String.Format("Вы выбрали: {0}", Date.Text);
        }

        private void notifWIn_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            notifWIn.Click += notifWIn_Click;
            //задаем текст подсказки
            notifWIn.BalloonTipIcon = ToolTipIcon.Info;
            //задаем текст подсказки
            notifWIn.BalloonTipText = "Нажмите, чтобы отобразить окно";
            //устанавливаем заголовок
            notifWIn.BalloonTipTitle = "Подсказка";
            //отображаем подсказку 10 сек
            notifWIn.ShowBalloonTip(10);
            this.WindowState = FormWindowState.Normal;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            
        }
        int i = 0;
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
            i = 0;
            time.Text = i.ToString();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            time.Text = i.ToString();
        }

        private void btnParol_Click(object sender, EventArgs e)
        {
            string pas = "1234";
            if (TboxParol.Text == pas)
                MessageBox.Show("Верно");

            else MessageBox.Show("неверно");
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Окрасить кнопку в красный цвет?",
       "Сообщение",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                btnclr.BackColor = Color.Red;
            else btnclr.BackColor = Color.White;

            this.TopMost = true;
        }

        private void btnShirft_Click(object sender, EventArgs e)
        {
            // возможность выбора цвета шрифта
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            btnShirft.Font = fontDialog1.Font;
            // установка цвета шрифта
            btnShirft.ForeColor = fontDialog1.Color;
        }

        private void Btnimage1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\ggalm\Downloads\a.jpg";
        }

        private void BtnImage2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\ggalm\Downloads\b.jpg";
        }

        private void Btnbrows_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(textBrows.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.Style = "zoom:50%;";
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(TboxParol, "Введите\nпароль");
            toolTip1.IsBalloon = true;
        }

        private void linkLBUsatu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.ugatu.su");
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранено",
      "Сообщение",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void Frm1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Location = new System.Drawing.Point(e.X-btn.Size.Width/2,e.Y- btn.Size.Width / 2);
            btn.Click += new System.EventHandler(this.Btnimage1_Click);
            this.Controls.Add(btn);

        }
    }
    }
    


