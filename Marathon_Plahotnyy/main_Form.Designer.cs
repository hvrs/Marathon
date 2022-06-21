namespace Marathon_Plahotnyy
{
    partial class main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nameMarph = new System.Windows.Forms.Label();
            this.lbl_information = new System.Windows.Forms.Label();
            this.btn_MSk2016 = new System.Windows.Forms.Button();
            this.btn_timeMarph = new System.Windows.Forms.Button();
            this.btn_BMI = new System.Windows.Forms.Button();
            this.btn_BMR = new System.Windows.Forms.Button();
            this.lbl_timeEnd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_BMR);
            this.panel1.Controls.Add(this.btn_BMI);
            this.panel1.Controls.Add(this.btn_timeMarph);
            this.panel1.Controls.Add(this.btn_MSk2016);
            this.panel1.Controls.Add(this.lbl_information);
            this.panel1.Location = new System.Drawing.Point(-1, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 372);
            this.panel1.TabIndex = 0;
            // 
            // lbl_nameMarph
            // 
            this.lbl_nameMarph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_nameMarph.ForeColor = System.Drawing.Color.White;
            this.lbl_nameMarph.Location = new System.Drawing.Point(-1, 9);
            this.lbl_nameMarph.Name = "lbl_nameMarph";
            this.lbl_nameMarph.Size = new System.Drawing.Size(877, 23);
            this.lbl_nameMarph.TabIndex = 1;
            this.lbl_nameMarph.Text = "MARATHON SKILLS 2016";
            this.lbl_nameMarph.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_information
            // 
            this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_information.Location = new System.Drawing.Point(0, 11);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(877, 25);
            this.lbl_information.TabIndex = 0;
            this.lbl_information.Text = "ИНФОРМАЦИЯ О MARATHON SKILLS 2016";
            this.lbl_information.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_MSk2016
            // 
            this.btn_MSk2016.BackColor = System.Drawing.Color.Transparent;
            this.btn_MSk2016.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MSk2016.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MSk2016.Location = new System.Drawing.Point(225, 74);
            this.btn_MSk2016.Name = "btn_MSk2016";
            this.btn_MSk2016.Size = new System.Drawing.Size(204, 87);
            this.btn_MSk2016.TabIndex = 1;
            this.btn_MSk2016.Text = "Marathon Skills 2016";
            this.btn_MSk2016.UseVisualStyleBackColor = false;
            this.btn_MSk2016.Click += new System.EventHandler(this.btn_MSk2016_Click);
            // 
            // btn_timeMarph
            // 
            this.btn_timeMarph.BackColor = System.Drawing.Color.Transparent;
            this.btn_timeMarph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timeMarph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_timeMarph.Location = new System.Drawing.Point(444, 74);
            this.btn_timeMarph.Name = "btn_timeMarph";
            this.btn_timeMarph.Size = new System.Drawing.Size(204, 87);
            this.btn_timeMarph.TabIndex = 2;
            this.btn_timeMarph.Text = "Насколько долгий марафон";
            this.btn_timeMarph.UseVisualStyleBackColor = false;
            this.btn_timeMarph.Click += new System.EventHandler(this.btn_timeMarph_Click);
            // 
            // btn_BMI
            // 
            this.btn_BMI.BackColor = System.Drawing.Color.Transparent;
            this.btn_BMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BMI.Location = new System.Drawing.Point(225, 167);
            this.btn_BMI.Name = "btn_BMI";
            this.btn_BMI.Size = new System.Drawing.Size(204, 87);
            this.btn_BMI.TabIndex = 3;
            this.btn_BMI.Text = "BMI калькулятор";
            this.btn_BMI.UseVisualStyleBackColor = false;
            this.btn_BMI.Click += new System.EventHandler(this.btn_BMI_Click);
            // 
            // btn_BMR
            // 
            this.btn_BMR.BackColor = System.Drawing.Color.Transparent;
            this.btn_BMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BMR.Location = new System.Drawing.Point(444, 167);
            this.btn_BMR.Name = "btn_BMR";
            this.btn_BMR.Size = new System.Drawing.Size(204, 87);
            this.btn_BMR.TabIndex = 4;
            this.btn_BMR.Text = "BMR калькулятор";
            this.btn_BMR.UseVisualStyleBackColor = false;
            this.btn_BMR.Click += new System.EventHandler(this.btn_BMR_Click);
            // 
            // lbl_timeEnd
            // 
            this.lbl_timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timeEnd.ForeColor = System.Drawing.Color.White;
            this.lbl_timeEnd.Location = new System.Drawing.Point(0, 424);
            this.lbl_timeEnd.Name = "lbl_timeEnd";
            this.lbl_timeEnd.Size = new System.Drawing.Size(867, 24);
            this.lbl_timeEnd.TabIndex = 2;
            this.lbl_timeEnd.Text = "18 дней 8 часов 17 минут до старта марафона";
            this.lbl_timeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.lbl_timeEnd);
            this.Controls.Add(this.lbl_nameMarph);
            this.Controls.Add(this.panel1);
            this.Name = "main_Form";
            this.Text = "Marathon Skills 2016 - Find out more information";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BMR;
        private System.Windows.Forms.Button btn_BMI;
        private System.Windows.Forms.Button btn_timeMarph;
        private System.Windows.Forms.Button btn_MSk2016;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Label lbl_nameMarph;
        private System.Windows.Forms.Label lbl_timeEnd;
    }
}

