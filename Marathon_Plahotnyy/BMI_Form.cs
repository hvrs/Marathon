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
    public partial class BMI_Form : Form
    {
        bool isMen = true;
        public BMI_Form()
        {
            InitializeComponent();
        }
        double bmiZnach = 0;
        private void btn_raschet_Click(object sender, EventArgs e)
        {
            bmiZnach = Math.Round(Convert.ToDouble(tb_ves.Text) / Math.Pow(Convert.ToDouble(tb_rost.Text) / 100, 2), 2);
           /* double x1 = (130 / 18.5 * bmiZnach) - 25;
            double x2 = (130 / 6.5 * (bmiZnach - 18.5)) - 25;
            double x3 = (130 / 5 * (bmiZnach - 25)) - 25;
            double x4 = (130 / 15 * (bmiZnach - 30)) - 25;*/

            if (bmiZnach < 18.5)
            {
                pb_strelka.Location = new Point(460 + (int)((7.02 * bmiZnach) - 25),299);
                lbl_bmI.Location = new Point(460 + (int)((7.02 * bmiZnach) - 25),273);
                pb_healthVisual.BackgroundImage = Properties.Resources.underweigt;

            }
            if (bmiZnach >= 18.5 && bmiZnach <25)
            {
                pb_strelka.Location = new Point(590 + (int)((20 * (bmiZnach - 18.5)-25)),299);
                lbl_bmI.Location = new Point(590 + (int)((20 * (bmiZnach - 18.5) - 25)),273);
                pb_healthVisual.BackgroundImage = Properties.Resources.healthy;

            }
            if (bmiZnach >= 25 && bmiZnach < 30)
            {
                pb_strelka.Location = new Point(720 + (int)((26 * (bmiZnach - 25) - 25)),299);
                lbl_bmI.Location = new Point(720 + (int)((26 * (bmiZnach - 25) - 25)),273);
                pb_healthVisual.BackgroundImage = Properties.Resources.over;

            }
            if (bmiZnach >= 30 && bmiZnach < 45)
            {
                pb_strelka.Location = new Point(850 + (int)((8.6 * (bmiZnach - 30) - 25)),299);
                lbl_bmI.Location = new Point(850 + (int)((8.6 * (bmiZnach - 30) - 25)),273);
                pb_healthVisual.BackgroundImage = Properties.Resources.obese;

            }
            if (bmiZnach>45)
            {
                MessageBox.Show("Слишком большой вес");
            }
            lbl_bmI.Text = bmiZnach.ToString();
        }

        private void btn_men_Click(object sender, EventArgs e)
        {
            isMen = true;
            btn_men.FlatAppearance.BorderSize = 4;
            btn_woman.FlatAppearance.BorderSize = 0;
        }

        private void btn_woman_Click(object sender, EventArgs e)
        {
            isMen = true;
            btn_men.FlatAppearance.BorderSize = 0;
            btn_woman.FlatAppearance.BorderSize = 4;
        }

        private void btn_otmena_Click(object sender, EventArgs e)
        {
            Hide();
            main_Form main_Form = new main_Form();
            main_Form.ShowDialog();
            Close();
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
