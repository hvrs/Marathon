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
    public partial class map_Form : Form
    {
        private Image drinks = Properties.Resources.drinks;
        private Image enrgy_bars = Properties.Resources.enrgy_bars;
        private Image toilets = Properties.Resources.toilets;
        private Image inform = Properties.Resources.information;
        private Image medical = Properties.Resources.medical;

        public map_Form()
        {
            InitializeComponent();
            pnl_checkpoints.Visible = false;
        }

       
    }
}
