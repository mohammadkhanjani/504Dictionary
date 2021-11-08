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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public static OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database11.mdb;Persist Security Info=True");
        OleDbDataAdapter adaptor = new OleDbDataAdapter("", connect);


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Parent = pictureBox1;
            glassButton11.Parent = pictureBox1;
            // TODO: This line of code loads data into the 'database11DataSet3.dictionary' table. You can move, or remove it, as needed.
            this.dictionaryTableAdapter.Fill(this.database11DataSet3.dictionary);
            

            //connect.Open();
            //string S = "select Skin from Skin";
            //OleDbCommand com = new OleDbCommand(S, connect);
            //object da = com.ExecuteScalar();
            //connect.Close();


            
            
            
            
            // TODO: This line of code loads data into the 'database11DataSet2.dictionary' table. You can move, or remove it, as needed.
            

        }



        public bool ayabasteshavadform = false;

        private void glassButton11_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            ayabasteshavadform = true;
            this.Close();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ayabasteshavadform )
            {
                Application.Exit();
            }
        }

    }
}
