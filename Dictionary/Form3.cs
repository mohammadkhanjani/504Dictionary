using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Dictionary
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public bool y = false;

        public static OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database11.mdb;Persist Security Info=True");
        OleDbDataAdapter adaptor = new OleDbDataAdapter("", connect);
        DataTable data;




        private void glassButton1_Click(object sender, EventArgs e)
        {

            Form1 x = new Form1();
            x.Show();
            y = true;
            this.Close();
        }

        private void glassButton11_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (loghat_txt.Text != "" && radioButton1.Checked)
            {
                try
                {
                    data = new DataTable();
                    connect.Open();
                    adaptor.SelectCommand.CommandText = "select loghat,mani from dictionary where loghat='" + loghat_txt.Text + "'";
                    adaptor.Fill(data);
                    label3.Text = data.Rows[0].ItemArray[0].ToString();
                    label4.Text = data.Rows[0].ItemArray[1].ToString();
                }
                catch 
                {
                    MessageBox.Show("این لغت یافت نشد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    x = true;
                }
                connect.Close();
            }
            else if (mana_txt.Text != "" && radioButton2.Checked)
            {
                try
                {
                    data = new DataTable();
                    connect.Open();
                    adaptor.SelectCommand.CommandText = "select loghat,mani from dictionary where mani like '" + mana_txt.Text + "'+'%'";
                    adaptor.Fill(data);
                    label3.Text = data.Rows[0].ItemArray[0].ToString();
                    label4.Text = data.Rows[0].ItemArray[1].ToString();
                }
                catch 
                {
                    MessageBox.Show("این لغت یافت نشد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    x = true;
                }
                connect.Close();
            }
            if (!x)
            {
                label1.Show();
                label2.Show();
                groupBox2.Show();
                groupBox3.Show();
            }
            else if(label3.Text=="" || label4.Text=="")
            {
                if (!x)
                    MessageBox.Show("لطفا ابتدا یکی از فیلد ها را پر کنید و سپس دکمه ی جستجو را بزنید","M.Kh",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language_persion = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language_persion);
            loghat_txt.Clear();
            mana_txt.Hide();
            loghat_txt.Visible = true;
            loghat_txt.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language_persion = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language_persion);
            mana_txt.Clear();
            loghat_txt.Hide();
            mana_txt.Visible = true;
            mana_txt.Focus();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!y)
            {
                Application.Exit();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loghat_txt.Hide();
            mana_txt.Hide();
            label1.Hide();
            label2.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

    }
}
