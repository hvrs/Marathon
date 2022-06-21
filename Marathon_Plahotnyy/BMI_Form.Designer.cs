namespace Marathon_Plahotnyy
{
    partial class BMI_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_information = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_nameMarph = new System.Windows.Forms.Label();
            this.lbl_timeEnd = new System.Windows.Forms.Label();
            this.lbl_oo = new System.Windows.Forms.Label();
            this.btn_otmena = new System.Windows.Forms.Button();
            this.btn_raschet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ves = new System.Windows.Forms.TextBox();
            this.tb_rost = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pb_healthVisual = new System.Windows.Forms.PictureBox();
            this.btn_woman = new System.Windows.Forms.Button();
            this.btn_men = new System.Windows.Forms.Button();
            this.pb_strelka = new System.Windows.Forms.PictureBox();
            this.lbl_bmI = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_healthVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_strelka)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_bmI);
            this.panel1.Controls.Add(this.pb_strelka);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pb_healthVisual);
            this.panel1.Controls.Add(this.btn_otmena);
            this.panel1.Controls.Add(this.btn_raschet);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_ves);
            this.panel1.Controls.Add(this.tb_rost);
            this.panel1.Controls.Add(this.btn_woman);
            this.panel1.Controls.Add(this.btn_men);
            this.panel1.Controls.Add(this.lbl_oo);
            this.panel1.Controls.Add(this.lbl_information);
            this.panel1.Location = new System.Drawing.Point(-33, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 417);
            this.panel1.TabIndex = 1;
            // 
            // lbl_information
            // 
            this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_information.Location = new System.Drawing.Point(0, 11);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(877, 25);
            this.lbl_information.TabIndex = 0;
            this.lbl_information.Text = "BMI КАЛЬКУЛЯТОР";
            this.lbl_information.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(32, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 27);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_nameMarph
            // 
            this.lbl_nameMarph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_nameMarph.ForeColor = System.Drawing.Color.White;
            this.lbl_nameMarph.Location = new System.Drawing.Point(3, 9);
            this.lbl_nameMarph.Name = "lbl_nameMarph";
            this.lbl_nameMarph.Size = new System.Drawing.Size(785, 23);
            this.lbl_nameMarph.TabIndex = 7;
            this.lbl_nameMarph.Text = "MARATHON SKILLS 2016";
            this.lbl_nameMarph.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_timeEnd
            // 
            this.lbl_timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timeEnd.ForeColor = System.Drawing.Color.White;
            this.lbl_timeEnd.Location = new System.Drawing.Point(0, 462);
            this.lbl_timeEnd.Name = "lbl_timeEnd";
            this.lbl_timeEnd.Size = new System.Drawing.Size(990, 24);
            this.lbl_timeEnd.TabIndex = 5;
            this.lbl_timeEnd.Text = "18 дней 8 часов 17 минут до старта марафона";
            this.lbl_timeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_oo
            // 
            this.lbl_oo.AutoSize = true;
            this.lbl_oo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_oo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_oo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_oo.Location = new System.Drawing.Point(45, 53);
            this.lbl_oo.Name = "lbl_oo";
            this.lbl_oo.Size = new System.Drawing.Size(383, 78);
            this.lbl_oo.TabIndex = 27;
            this.lbl_oo.Text = resources.GetString("lbl_oo.Text");
            this.lbl_oo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_otmena
            // 
            this.btn_otmena.BackColor = System.Drawing.Color.White;
            this.btn_otmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_otmena.Location = new System.Drawing.Point(183, 355);
            this.btn_otmena.Name = "btn_otmena";
            this.btn_otmena.Size = new System.Drawing.Size(88, 27);
            this.btn_otmena.TabIndex = 69;
            this.btn_otmena.Text = "Отмена";
            this.btn_otmena.UseVisualStyleBackColor = false;
            this.btn_otmena.Click += new System.EventHandler(this.btn_otmena_Click);
            // 
            // btn_raschet
            // 
            this.btn_raschet.BackColor = System.Drawing.Color.White;
            this.btn_raschet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raschet.Location = new System.Drawing.Point(89, 355);
            this.btn_raschet.Name = "btn_raschet";
            this.btn_raschet.Size = new System.Drawing.Size(88, 27);
            this.btn_raschet.TabIndex = 60;
            this.btn_raschet.Text = "Рассчитать";
            this.btn_raschet.UseVisualStyleBackColor = false;
            this.btn_raschet.Click += new System.EventHandler(this.btn_raschet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(215, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "кг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(215, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(106, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Вес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(100, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Рост:";
            // 
            // tb_ves
            // 
            this.tb_ves.Location = new System.Drawing.Point(149, 315);
            this.tb_ves.Name = "tb_ves";
            this.tb_ves.Size = new System.Drawing.Size(60, 20);
            this.tb_ves.TabIndex = 64;
            // 
            // tb_rost
            // 
            this.tb_rost.Location = new System.Drawing.Point(149, 289);
            this.tb_rost.Name = "tb_rost";
            this.tb_rost.Size = new System.Drawing.Size(60, 20);
            this.tb_rost.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(460, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 17);
            this.panel2.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chartreuse;
            this.panel3.Location = new System.Drawing.Point(590, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 17);
            this.panel3.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(720, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 17);
            this.panel4.TabIndex = 72;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(850, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 17);
            this.panel5.TabIndex = 72;
            // 
            // pb_healthVisual
            // 
            this.pb_healthVisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_healthVisual.Location = new System.Drawing.Point(686, 11);
            this.pb_healthVisual.Name = "pb_healthVisual";
            this.pb_healthVisual.Size = new System.Drawing.Size(241, 239);
            this.pb_healthVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_healthVisual.TabIndex = 70;
            this.pb_healthVisual.TabStop = false;
            // 
            // btn_woman
            // 
            this.btn_woman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_woman.Image = global::Marathon_Plahotnyy.Properties.Resources.woman_icon_icons_com_49954;
            this.btn_woman.Location = new System.Drawing.Point(183, 134);
            this.btn_woman.Name = "btn_woman";
            this.btn_woman.Size = new System.Drawing.Size(126, 148);
            this.btn_woman.TabIndex = 62;
            this.btn_woman.Text = "Женский";
            this.btn_woman.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_woman.UseVisualStyleBackColor = true;
            this.btn_woman.Click += new System.EventHandler(this.btn_woman_Click);
            // 
            // btn_men
            // 
            this.btn_men.FlatAppearance.BorderSize = 4;
            this.btn_men.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_men.Image = global::Marathon_Plahotnyy.Properties.Resources.man_icon_icons_com_50102;
            this.btn_men.Location = new System.Drawing.Point(51, 134);
            this.btn_men.Name = "btn_men";
            this.btn_men.Size = new System.Drawing.Size(126, 148);
            this.btn_men.TabIndex = 61;
            this.btn_men.Text = "Мужской";
            this.btn_men.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_men.UseVisualStyleBackColor = true;
            this.btn_men.Click += new System.EventHandler(this.btn_men_Click);
            // 
            // pb_strelka
            // 
            this.pb_strelka.BackgroundImage = global::Marathon_Plahotnyy.Properties.Resources.unknown;
            this.pb_strelka.Location = new System.Drawing.Point(695, 299);
            this.pb_strelka.Name = "pb_strelka";
            this.pb_strelka.Size = new System.Drawing.Size(50, 36);
            this.pb_strelka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_strelka.TabIndex = 73;
            this.pb_strelka.TabStop = false;
            // 
            // lbl_bmI
            // 
            this.lbl_bmI.Location = new System.Drawing.Point(695, 273);
            this.lbl_bmI.Name = "lbl_bmI";
            this.lbl_bmI.Size = new System.Drawing.Size(50, 23);
            this.lbl_bmI.TabIndex = 74;
            this.lbl_bmI.Text = " ";
            this.lbl_bmI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.Controls.Add(this.lbl_timeEnd);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_nameMarph);
            this.Name = "BMI_Form";
            this.Text = "Marathon Skills 2016 - BMI calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_healthVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_strelka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_nameMarph;
        private System.Windows.Forms.Label lbl_oo;
        private System.Windows.Forms.Label lbl_timeEnd;
        private System.Windows.Forms.Button btn_otmena;
        private System.Windows.Forms.Button btn_raschet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ves;
        private System.Windows.Forms.TextBox tb_rost;
        private System.Windows.Forms.Button btn_woman;
        private System.Windows.Forms.Button btn_men;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_healthVisual;
        private System.Windows.Forms.PictureBox pb_strelka;
        private System.Windows.Forms.Label lbl_bmI;
    }
}