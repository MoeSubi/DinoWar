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

namespace DinoWar
{
    public partial class FormRank : Form
    {
        public FormRank()
        {
            InitializeComponent();
        }
        bool hover3;
        
        private void FormRank_Load(object sender, EventArgs e)
        {
            label3.Text = "               ENJOY OUR GAME!!!                   ";
            hover3 = true;
            StreamReader streamReader;
            OpenFileDialog open;
            string fileName = "";
            string file = "";
            file = @"D:\FileTg.txt";
            fileName = @"D:\FileDiem.txt";
            if (!File.Exists(file) || !File.Exists(fileName))
            {
                MessageBox.Show("Do bạn chưa chơi game lần nào nên hệ thống chưa có thông tin để lưu file.");
            }
            else
            {
                streamReader = File.OpenText(fileName);
                textBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
                streamReader = File.OpenText(file);
                textBox2.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }           

        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0, 1);
        }

        private void timerHistory_Tick(object sender, EventArgs e)
        {
            if (hover3)
            {
                lbHistory.ForeColor = Color.LightPink;
                lbHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            }
            else
            {
                lbHistory.ForeColor = Color.Yellow;
                lbHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            hover3 = !hover3;
        }
    }
}
