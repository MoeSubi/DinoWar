using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoWar
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        #region biến toàn cục
        bool flag = true;
        bool flagMu = true;
        bool chuyenDong;
        int color = 0;
        SoundPlayer a = new SoundPlayer(Properties.Resources.MusicMenu);
        #endregion

        private void chuyenChu()
        {
            if (chuyenDong)
            {
                lbTitle.TextAlign = ContentAlignment.MiddleCenter;
                lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)))
                    , System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                lbTitle.TextAlign = ContentAlignment.MiddleCenter;
                lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            chuyenDong = !chuyenDong;
        }

        private void mauChu()
        {
            if (color == 0)
            {
                lbTitle.ForeColor = Color.Red;
                color = 1;
            }
            else if (color == 1)
            {
                lbTitle.ForeColor = Color.Yellow;
                color = 2;
            }
            else
            {
                lbTitle.ForeColor = Color.Orange;
                color = 0;
            }
        }

        private void chuyenAnh()
        {
            if (flag)
            {
                picDino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino1.png");
                picDino.BringToFront();
                flag = false;
            }
            else
            {
                picDino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino2.png");
                picDino.BringToFront();
                flag = true;
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a.Play();
            lbTitle.Text = "DINO WAR";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //a.Stop(); btSound.BackgroundImage = Properties.Resources.music_off;
            this.Hide();
            dinoWar f = new dinoWar();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            this.Show();
            a.Play(); btSound.BackgroundImage = Properties.Resources.music;
        }

        private void btHow_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTutorial tutorial = new FormTutorial();
            tutorial.StartPosition = FormStartPosition.CenterScreen;
            tutorial.ShowDialog();
            this.Show();
        }

        private void btCredit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCre cre = new FormCre();
            cre.StartPosition = FormStartPosition.CenterScreen;
            cre.ShowDialog();
            this.Show();
        }

        private void btSound_Click(object sender, EventArgs e)
        {

            if (flagMu)
            {
                a.Stop();
                btSound.BackgroundImage = Properties.Resources.music_on;
                flagMu = false;
            }
            else
            {
                a.Play();
                btSound.BackgroundImage = Properties.Resources.music;
                flagMu = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btRank_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRank rank = new FormRank();
            rank.StartPosition = FormStartPosition.CenterScreen;
            rank.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chuyenAnh();
            mauChu();
            chuyenChu();
        }
       
    }
}
