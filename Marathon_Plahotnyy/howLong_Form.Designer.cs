namespace Marathon_Plahotnyy
{
    partial class howLong_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_information = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_nameMarph = new System.Windows.Forms.Label();
            this.lbl_timeEnd = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_namePunct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_namePunct);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.lbl_information);
            this.panel1.Location = new System.Drawing.Point(-33, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 408);
            this.panel1.TabIndex = 1;
            // 
            // lbl_information
            // 
            this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_information.Location = new System.Drawing.Point(0, 11);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(877, 25);
            this.lbl_information.TabIndex = 0;
            this.lbl_information.Text = "НАСКОЛЬКО ДОЛГИЙ МАРАФОН?";
            this.lbl_information.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(32, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 27);
            this.btn_back.TabIndex = 6;
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
            this.lbl_nameMarph.TabIndex = 5;
            this.lbl_nameMarph.Text = "MARATHON SKILLS 2016";
            this.lbl_nameMarph.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_timeEnd
            // 
            this.lbl_timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timeEnd.ForeColor = System.Drawing.Color.White;
            this.lbl_timeEnd.Location = new System.Drawing.Point(4, 453);
            this.lbl_timeEnd.Name = "lbl_timeEnd";
            this.lbl_timeEnd.Size = new System.Drawing.Size(840, 24);
            this.lbl_timeEnd.TabIndex = 4;
            this.lbl_timeEnd.Text = "18 дней 8 часов 17 минут до старта марафона";
            this.lbl_timeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(606, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(262, 357);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(254, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Скорость";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(232, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дистанция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(75, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 226);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_namePunct
            // 
            this.lbl_namePunct.AutoSize = true;
            this.lbl_namePunct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_namePunct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_namePunct.Location = new System.Drawing.Point(94, 46);
            this.lbl_namePunct.Name = "lbl_namePunct";
            this.lbl_namePunct.Size = new System.Drawing.Size(15, 24);
            this.lbl_namePunct.TabIndex = 22;
            this.lbl_namePunct.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(81, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Информация";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // howLong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(847, 486);
            this.Controls.Add(this.lbl_timeEnd);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_nameMarph);
            this.Controls.Add(this.panel1);
            this.Name = "howLong_Form";
            this.Text = "howLong_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_nameMarph;
        private System.Windows.Forms.Label lbl_timeEnd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_namePunct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}