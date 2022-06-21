using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Plahotnyy
{
    public partial class BMR_Form : Form
    {
        public BMR_Form()
        {
            InitializeComponent();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            pnl_urvnAct.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_urvnAct.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            main_Form main_Form = new main_Form();
            main_Form.ShowDialog();
            Close();
        }
    }
}
