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
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
        }

        private void btn_MSk2016_Click(object sender, EventArgs e)
        {
            Hide();
            inform_Form inform_Form = new inform_Form();
            inform_Form.ShowDialog();
            Close();
        }

        private void btn_BMI_Click(object sender, EventArgs e)
        {
            Hide();
            BMI_Form bBMI_Form = new BMI_Form();
            bBMI_Form.ShowDialog();
            Close();
        }

        private void btn_BMR_Click(object sender, EventArgs e)
        {
            Hide();
            BMR_Form bMR_Form = new BMR_Form();
            bMR_Form.ShowDialog();
            Close();
        }

        private void btn_timeMarph_Click(object sender, EventArgs e)
        {
            Hide();
            howLong_Form howLong_Form = new howLong_Form();
            howLong_Form.ShowDialog();
            Close();
        }
    }
}
