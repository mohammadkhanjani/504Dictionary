namespace Dictionary
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet2 = new Dictionary.Database11DataSet2();
            this.glassButton11 = new Glass.GlassButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loghatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database11DataSet3 = new Dictionary.Database11DataSet3();
            this.dictionaryTableAdapter = new Dictionary.Database11DataSet3TableAdapters.dictionaryTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dictionaryBindingSource
            // 
            this.dictionaryBindingSource.DataMember = "dictionary";
            this.dictionaryBindingSource.DataSource = this.database11DataSet2;
            // 
            // database11DataSet2
            // 
            this.database11DataSet2.DataSetName = "Database11DataSet2";
            this.database11DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glassButton11
            // 
            this.glassButton11.BackColor = System.Drawing.Color.Transparent;
            this.glassButton11.Font = new System.Drawing.Font("Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.glassButton11.ForeColor = System.Drawing.Color.Blue;
            this.glassButton11.GlowColor = System.Drawing.Color.Transparent;
            this.glassButton11.Location = new System.Drawing.Point(12, 186);
            this.glassButton11.Name = "glassButton11";
            this.glassButton11.ShineColor = System.Drawing.Color.Transparent;
            this.glassButton11.Size = new System.Drawing.Size(95, 24);
            this.glassButton11.TabIndex = 23;
            this.glassButton11.Text = "برگشت";
            this.glassButton11.Click += new System.EventHandler(this.glassButton11_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loghatDataGridViewTextBoxColumn,
            this.maniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dictionaryBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(344, 151);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 24;
            // 
            // loghatDataGridViewTextBoxColumn
            // 
            this.loghatDataGridViewTextBoxColumn.DataPropertyName = "loghat";
            this.loghatDataGridViewTextBoxColumn.HeaderText = "لغت";
            this.loghatDataGridViewTextBoxColumn.Name = "loghatDataGridViewTextBoxColumn";
            this.loghatDataGridViewTextBoxColumn.ReadOnly = true;
            this.loghatDataGridViewTextBoxColumn.Width = 150;
            // 
            // maniDataGridViewTextBoxColumn
            // 
            this.maniDataGridViewTextBoxColumn.DataPropertyName = "mani";
            this.maniDataGridViewTextBoxColumn.HeaderText = "معنا";
            this.maniDataGridViewTextBoxColumn.Name = "maniDataGridViewTextBoxColumn";
            this.maniDataGridViewTextBoxColumn.ReadOnly = true;
            this.maniDataGridViewTextBoxColumn.Width = 150;
            // 
            // dictionaryBindingSource1
            // 
            this.dictionaryBindingSource1.DataMember = "dictionary";
            this.dictionaryBindingSource1.DataSource = this.database11DataSet3;
            // 
            // database11DataSet3
            // 
            this.database11DataSet3.DataSetName = "Database11DataSet3";
            this.database11DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dictionaryTableAdapter
            // 
            this.dictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 219);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.glassButton11);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "نمایش همه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database11DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database11DataSet2 database11DataSet2;
        private Glass.GlassButton glassButton11;
        private System.Windows.Forms.BindingSource dictionaryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database11DataSet3 database11DataSet3;
        private System.Windows.Forms.BindingSource dictionaryBindingSource1;
        private Database11DataSet3TableAdapters.dictionaryTableAdapter dictionaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loghatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maniDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}