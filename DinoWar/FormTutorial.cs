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
    public partial class FormTutorial : Form
    {
        public FormTutorial()
        {
            InitializeComponent();
        }
        bool hover2;
        private void FormTutorial_Load(object sender, EventArgs e)
        {
            hover2 = true;
        }

        private void timerTutorial_Tick(object sender, EventArgs e)
        {
           
            if (hover2)
            {
                lbTutorial.ForeColor = Color.LightPink;
                lbTutorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            }
            else
            {
                lbTutorial.ForeColor = Color.Yellow;
                lbTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            hover2 = !hover2;
        }       
        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
