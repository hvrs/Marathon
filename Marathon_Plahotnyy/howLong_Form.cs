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
    public partial class howLong_Form : Form
    {
        public Image f1_car = Properties.Resources.f1_car;
        public Image worm = Properties.Resources.worm;
        public Image sloth = Properties.Resources.sloth;
        public Image capibara = Properties.Resources.capybara;
        public Image jaguar = Properties.Resources.jaguar;
        public Image a380 = Properties.Resources.airbus_a380;
        public Image tapki = Properties.Resources.pair_of_havaianas;
        public Image pole = Properties.Resources.football_field;
        public Image men = Properties.Resources.ronaldinho;
        public Image bus = Properties.Resources.bus;
        public howLong_Form()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main_Form main_Form = new main_Form();
            main_Form.ShowDialog();
            Close();
        }
        public void ResultTime(string name, double speed)
        {
            double hour = 42 / speed;
            double celHour = Math.Truncate(hour);
            double ostFromHour = hour - celHour;
            double minuts = ostFromHour * 60;
            double celMinuts = Math.Truncate(minuts);
            double ostFromMinuts = minuts - celMinuts;
            double celseconds = Math.Round(ostFromMinuts * 60, 0);
            lbl_info.Text = $"Максимальная скорость {name}: {speed}км/ч.\nЭто займет {celHour} часов, {celMinuts} минут, {celseconds} секунд, чтобы завершить 42км марафон.";

        }
        public void ResultRast(string name, double dlina)
        {
            double sectors = 4200 / dlina;
            double kolv = Math.Truncate(sectors);
            double ostatok = sectors - kolv;
            if (ostatok > 0) kolv++;
            lbl_info.Text = $"Длина {name}: {dlina}. Их будет находиться: {kolv} на расстоянии 42км.";
        }

        private void pb_auto_Click(object sender, EventArgs e)
        {
            pb_main.Image = f1_car;
            lbl_namePunct.Text = "Автомобиль Формулы-1";
            ResultTime(lbl_namePunct.Text, 345);
        }

        private void pb_worm_Click(object sender, EventArgs e)
        {
            pb_main.Image = worm;
            lbl_namePunct.Text = "Червяк";
            ResultTime(lbl_namePunct.Text, 0.03);
        }

        private void pb_lenivec_Click(object sender, EventArgs e)
        {
            pb_main.Image = sloth;
            lbl_namePunct.Text = "Ленивец";
            ResultTime(lbl_namePunct.Text, 0.12);
        }

        private void pb_kapibara_Click(object sender, EventArgs e)
        {
            pb_main.Image = capibara;
            lbl_namePunct.Text = "Капибара";
            ResultTime(lbl_namePunct.Text, 35);
        }

        private void pb_jaguar_Click(object sender, EventArgs e)
        {
            pb_main.Image = jaguar;
            lbl_namePunct.Text = "Ягуар";
            ResultTime(lbl_namePunct.Text, 80);
        }

        private void pb_aircraft_Click(object sender, EventArgs e)
        {
            pb_main.Image = a380;
            lbl_namePunct.Text = "Airbus A380";
            ResultRast(lbl_namePunct.Text, 73);
        }

        private void pb_havaians_Click(object sender, EventArgs e)
        {
            pb_main.Image = tapki;
            lbl_namePunct.Text = "Havaianas";
            ResultRast(lbl_namePunct.Text, 0.245);
        }

        private void pb_footbl_Click(object sender, EventArgs e)
        {
            pb_main.Image = pole;
            lbl_namePunct.Text = "Футбольное поле";
            ResultRast(lbl_namePunct.Text, 105);
        }

        private void pb_ronald_Click(object sender, EventArgs e)
        {
            pb_main.Image = men;
            lbl_namePunct.Text = "Роналдиньо";
            ResultRast(lbl_namePunct.Text, 1.81);
        }

        private void pb_bus_Click(object sender, EventArgs e)
        {
            pb_main.Image = bus;
            lbl_namePunct.Text = "Автобус";
            ResultRast(lbl_namePunct.Text, 10);
        }
    }
}
