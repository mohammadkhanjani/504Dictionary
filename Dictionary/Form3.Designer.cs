namespace Dictionary
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.glassButton1 = new Glass.GlassButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loghat_txt = new TextBoxtest.TxtProNet();
            this.mana_txt = new TextBoxtest.TxtProNet();
            this.glassButton11 = new Glass.GlassButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(495, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "لغت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "معنا";
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.Transparent;
            this.glassButton1.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.glassButton1.ForeColor = System.Drawing.Color.Blue;
            this.glassButton1.GlowColor = System.Drawing.Color.Transparent;
            this.glassButton1.Location = new System.Drawing.Point(52, 38);
            this.glassButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.ShineColor = System.Drawing.Color.Transparent;
            this.glassButton1.Size = new System.Drawing.Size(114, 32);
            this.glassButton1.TabIndex = 34;
            this.glassButton1.Text = "برگشت";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.loghat_txt);
            this.groupBox1.Controls.Add(this.mana_txt);
            this.groupBox1.Controls.Add(this.glassButton11);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(202, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(294, 179);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // loghat_txt
            // 
            this.loghat_txt.AutoSprator = false;
            this.loghat_txt.EnterToTab = true;
            this.loghat_txt.EscToClose = true;
            this.loghat_txt.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loghat_txt.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loghat_txt.FocusForeColor = System.Drawing.Color.Black;
            this.loghat_txt.FocusTextSelect = true;
            this.loghat_txt.Font = new System.Drawing.Font("Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loghat_txt.Location = new System.Drawing.Point(13, 43);
            this.loghat_txt.MessageEmptyShowDialog = false;
            this.loghat_txt.MessegeEmpty = "";
            this.loghat_txt.MessegeEmptyInFormRight = true;
            this.loghat_txt.MessegeEmptyShowInForm = false;
            this.loghat_txt.Name = "loghat_txt";
            this.loghat_txt.Size = new System.Drawing.Size(153, 28);
            this.loghat_txt.TabIndex = 30;
            this.loghat_txt.TypeAllChar = true;
            this.loghat_txt.TypeDateShamsi = false;
            this.loghat_txt.TypeEnglishOnly = false;
            this.loghat_txt.TypeFarsiOnly = false;
            this.loghat_txt.TypeNumricOnly = false;
            this.loghat_txt.TypeOtherChar = "";
            // 
            // mana_txt
            // 
            this.mana_txt.AutoSprator = false;
            this.mana_txt.EnterToTab = true;
            this.mana_txt.EscToClose = true;
            this.mana_txt.FocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mana_txt.FocusFont = new System.Drawing.Font("Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mana_txt.FocusForeColor = System.Drawing.Color.Black;
            this.mana_txt.FocusTextSelect = true;
            this.mana_txt.Font = new System.Drawing.Font("Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mana_txt.Location = new System.Drawing.Point(13, 90);
            this.mana_txt.MessageEmptyShowDialog = false;
            this.mana_txt.MessegeEmpty = "";
            this.mana_txt.MessegeEmptyInFormRight = true;
            this.mana_txt.MessegeEmptyShowInForm = false;
            this.mana_txt.Name = "mana_txt";
            this.mana_txt.Size = new System.Drawing.Size(153, 28);
            this.mana_txt.TabIndex = 29;
            this.mana_txt.TypeAllChar = true;
            this.mana_txt.TypeDateShamsi = false;
            this.mana_txt.TypeEnglishOnly = false;
            this.mana_txt.TypeFarsiOnly = false;
            this.mana_txt.TypeNumricOnly = false;
            this.mana_txt.TypeOtherChar = "";
            // 
            // glassButton11
            // 
            this.glassButton11.BackColor = System.Drawing.Color.Transparent;
            this.glassButton11.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.glassButton11.ForeColor = System.Drawing.Color.Blue;
            this.glassButton11.GlowColor = System.Drawing.Color.Transparent;
            this.glassButton11.Location = new System.Drawing.Point(13, 140);
            this.glassButton11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glassButton11.Name = "glassButton11";
            this.glassButton11.ShineColor = System.Drawing.Color.Transparent;
            this.glassButton11.Size = new System.Drawing.Size(110, 31);
            this.glassButton11.TabIndex = 28;
            this.glassButton11.Text = "جستجو";
            this.glassButton11.Click += new System.EventHandler(this.glassButton11_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton2.Location = new System.Drawing.Point(170, 87);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 30);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "بر اساس معنا";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton1.Location = new System.Drawing.Point(170, 39);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 30);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "بر اساس لغت";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(279, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(214, 47);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(5, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(233, 47);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 1;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(527, 300);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "جستجو";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Glass.GlassButton glassButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Glass.GlassButton glassButton11;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private TextBoxtest.TxtProNet loghat_txt;
        private TextBoxtest.TxtProNet mana_txt;
        private System.Windows.Forms.Label label4;
    }
}