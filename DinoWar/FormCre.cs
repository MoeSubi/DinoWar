using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoWar
{
    public partial class FormCre : Form
    {
        public FormCre()
        {
            InitializeComponent();
        }
        bool hover;
        int chkDino = 1;
        private void FormCre_Load(object sender, EventArgs e)
        {
            hover = true;
            lbText.Text = "Đây là những thành viên của nhóm thực hiện tựa game tên Dino War này: " +
                "\n1. Nguyễn Vũ Quang Long - 1951052105" +
                "\n2. Trần Đức Trọng Hiền - 1951052051 " +
                "\n3. Trần Điền Long - 1951052106 " +
                "\n4. Nguyễn Hữu Thắng - 1951052186 " +
                "\nTựa game này được viết theo ngôn ngữ C#.NET qua nhiều tuần lên kế hoạch và thực hiện đồ án. Do đây là sản phẩm game đầu tay của nhóm nên " +
                "chưa có nhiều ý tưởng tạo dựng kịch bản và nội dung để phát triển game nhưng rất mong được mọi người đón nhận. Best Wishes to you <3.";
        }

        private void timerCre_Tick(object sender, EventArgs e)
        {
            changeAnh();
            if (hover)
            {
                lbCre.ForeColor = Color.LightPink;
                lbCre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
            else
            {
                lbCre.ForeColor = Color.Yellow;
                lbCre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            }
            hover = !hover;
        }
        private void changeAnh()
        {
            if (chkDino == 1)
            {

                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino1.png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino3.png");
                chkDino = 0;
                pictureBox1.BringToFront();
            }
            else
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino2.png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino4.png");
                chkDino = 1;
                pictureBox1.BringToFront();
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Escape:
                    Close();
                    return true;
            }    
            return base.ProcessDialogKey(keyData);
        }
    }
}
