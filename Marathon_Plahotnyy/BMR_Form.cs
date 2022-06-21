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
        private bool isMen=true;
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

        private void btn_raschet_Click(object sender, EventArgs e)
        {
            double bmr = 10*Convert.ToInt32(tb_ves.Text)+6.25*Convert.ToInt32(tb_rost.Text)-5*Convert.ToInt32(tb_yearsOld.Text);
            if (isMen)
                bmr += 5;
            else
                bmr -= 161;
            lbl_bmr.Text = $"{Math.Round(bmr)}";
            lbl_bmrSit.Text = $"{Math.Round(bmr*1.2)}";
            lbl_bmrSmall.Text = $"{Math.Round(bmr * 1.4)}";
            lbl_bmrSredn.Text = $"{Math.Round(bmr * 1.6)}";
            lbl_bmrSiln.Text = $"{Math.Round(bmr *1.8)}";
            lbl_bmrMaks.Text = $"{Math.Round(bmr * 1.9)}";
        }

        private void btn_men_Click(object sender, EventArgs e)
        {
            isMen = true;
            btn_men.FlatAppearance.BorderSize = 4;
            btn_woman.FlatAppearance.BorderSize = 0;
        }

        private void btn_woman_Click(object sender, EventArgs e)
        {
            isMen = false;
            btn_men.FlatAppearance.BorderSize = 0;
            btn_woman.FlatAppearance.BorderSize = 4;
        }
    }
}
