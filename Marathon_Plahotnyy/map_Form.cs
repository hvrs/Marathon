using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public void CirclButton(Control control)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g;
            g = CreateGraphics();
            Rectangle rectangle = control.ClientRectangle;
            rectangle.Inflate(-3,-3);
            gp.AddEllipse(rectangle);
            control.Region = new Region(gp);
            g.DrawEllipse(new Pen(Color.FromArgb(255, 255, 128), 1),
            control.Left + 1,
            control.Top + 1, control.Width - 3, control.Height - 3);
            g.Dispose();
        }

        private void map_Form_Load(object sender, EventArgs e)
        {
            CirclButton(btn_checkpoint1);
            CirclButton(btn_checkpoint2);
            CirclButton(btn_checkpoint3);
            CirclButton(btn_checkpoint4);
            CirclButton(btn_checkpoint5);
            CirclButton(btn_checkpoint6);
            CirclButton(btn_checkpoint7);
            CirclButton(btn_checkpoint8);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            inform_Form inform_Form = new inform_Form();
            inform_Form.ShowDialog();
            Close();

        }
        private void ClearPanel()
        {      
            
            pb_3.Image = null;
            pb_4.Image = null;
            pb_5.Image = null;
            
            
            bl_par3.Text = "";
            bl_par4.Text = "";
            bl_par5.Text = "";

        }

        private void btn_checkpoint1_Click(object sender, EventArgs e)
        {
            ClearPanel();
            pnl_checkpoints.Visible = true;
            lbl_chekpoint.Text = "Checkpoint 1"; 
            lbl_orien.Text = "Avenida Rudge";
        }

        private void btn_checkpoint2_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 2";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Theatro Municipal";
            pb_3.Image = toilets;
            pb_4.Image = inform;
            pb_5.Image = medical;
            bl_par3.Text = "Туалет";
            bl_par4.Text = "Инф.Пункт";
            bl_par5.Text = "Медпункт";
        }

        private void btn_checkpoint3_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 3";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Parque do Ibirapuera";
            pb_3.Image = toilets;
            bl_par3.Text = "Туалет";
        }

        private void btn_checkpoint4_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 4";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Jardim Luzitania";
            pb_3.Image = toilets;
            pb_4.Image = medical;
            bl_par3.Text = "Туалет";
            bl_par4.Text = "Медпункт";
        }

        private void btn_checkpoint5_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 5";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Iguatemi";
            pb_3.Image = toilets;
            pb_4.Image = inform;
            bl_par3.Text = "Туалет";
            bl_par4.Text = "Инф.Пункт";
        }

        private void btn_checkpoint6_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 6";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Rua Lisboa";
            pb_3.Image = toilets;
            bl_par3.Text = "Туалет";
        }

        private void btn_checkpoint7_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 7";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Cemitério da Consolação";
            pb_3.Image = toilets;
            pb_4.Image = inform;
            pb_5.Image = medical;
            bl_par3.Text = "Туалет";
            bl_par4.Text = "Инф.Пункт";
            bl_par5.Text = "Медпункт";
        }

        private void btn_checkpoint8_Click(object sender, EventArgs e)
        {
            ClearPanel();
            lbl_chekpoint.Text = "Checkpoint 8";
            pnl_checkpoints.Visible = true;
            lbl_orien.Text = "Cemitério da Consolação";
            pb_3.Image = toilets;
            pb_4.Image = inform;
            pb_5.Image = medical;
            bl_par3.Text = "Туалет";
            bl_par4.Text = "Инф.Пункт";
            bl_par5.Text = "Медпункт";
        }

        private void btn_closePanel_Click(object sender, EventArgs e)
        {
            ClearPanel();
            pnl_checkpoints.Visible = false;
        }
    }
}
