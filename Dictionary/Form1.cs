using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> item;

        public static OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database11.mdb;Persist Security Info=True");
        OleDbDataAdapter adaptor = new OleDbDataAdapter("", connect);
        DataTable data;






        private void Form1_Load(object sender, EventArgs e)
        {
            reflectionLabel1.Parent = pictureBox1;
            glassButton18.Hide();
            glassButton18.Parent = pictureBox1;
            groupBox1.Parent = pictureBox1;
            groupBox2.Parent = pictureBox1;
            groupBox3.Parent = pictureBox1;
            label11.Parent = groupBox2;
            label13.Parent = groupBox3;
            label11.Show();
            label13.Show();
            data = new DataTable();


            connect.Open();
            string save="select speed_speak,volume_speak from speak where id=1";
            adaptor.SelectCommand.CommandText = save;
            adaptor.Fill(data);
            spea.Rate =(int) data.Rows[0].ItemArray[0];
            spea.Volume = (int)data.Rows[0].ItemArray[1];
            connect.Close();




            hScrollBar1.Parent = g;
            hScrollBar2.Parent = g;
            label5.Parent = g;
            label6.Parent = g;
            label7.Parent = g;
            label8.Parent = g;
            glassButton8.Parent = g;
            g.Hide();


            toolTip1.SetToolTip(pictureBox4, "تنظیمات تلفظ");
            toolTip1.SetToolTip(pictureBox2, "تلفظ");
            System.Globalization.PersianCalendar persian = new System.Globalization.PersianCalendar();
            int h, m, s;
            string ss="";
            h = persian.GetHour(DateTime.Now);
            m = persian.GetMinute(DateTime.Now);
            s = persian.GetSecond(DateTime.Now);
               
                switch (persian.GetDayOfWeek(DateTime.Now).ToString())
                {
                    case "Sunday":
                                    ss = "یکشنبه";
                                    break;
                    case "Monday":
                                    ss = "دوشنبه";
                                    break;
                    case "Tuseday":
                                    ss = "سه شنبه";
                                    break;
                    case "Wednesday":
                                    ss = "چهارشنبه";
                                    break;
                    case "Thursday":
                                    ss = "پنج شنبه";
                                    break;
                    case "Friday":
                                    ss = "جمعه";
                                    break;
                    case "Saturday":
                                    ss = "شنبه";
                                    break;
                }


                label4.Text = persian.GetYear(DateTime.Now) + "/" + persian.GetMonth(DateTime.Now)
                   + "/" + persian.GetDayOfMonth(DateTime.Now) + "  " + ss;



            connect.Open();
            string S = "select Count(id) from dictionary where id is not null";// baray bedast amadan tedad  satrha
            OleDbCommand com = new OleDbCommand(S, connect);
            object da= com.ExecuteScalar();
            connect.Close();
            
            
            int k = Int32.Parse(da.ToString());
            if (k < 2)
            {
                glassButton2.Visible = false;
            }
            else
            {
                glassButton2.Visible = true;
            }



            connect.Open();
            S = "select Skin from Skin";
            com = new OleDbCommand(S,connect);
             da= com.ExecuteScalar();
            connect.Close();


            comboBox1.Text = da.ToString();
            this.skinEngine1.SkinFile = Environment.CurrentDirectory + @"\Skin\" + comboBox1.Text + @".ssk";
            this.skinEngine1.Active = true;

            //change skin first from database
            



            // TODO: This line of code loads data into the 'database11DataSet1.Skin' table. You can move, or remove it, as needed.
            //this.skinTableAdapter.Fill(this.database11DataSet1.Skin);
            System.Globalization.CultureInfo language_persion = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language_persion);



            //groupBox1.Parent = pictureBox1;
            label10.Parent = groupBox1;
            label9.Parent = groupBox1;
            groupBox1.Hide();
            glassButton4.Visible = false;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            vistaClock2.Parent = pictureBox1;
            glassButton1.Parent = pictureBox1;
            glassButton2.Parent = pictureBox1;
            glassButton3.Parent = pictureBox1;
            glassButton4.Parent = pictureBox1;
            glassButton5.Parent = pictureBox1;
            glassButton7.Parent = pictureBox1;
            glassButton6.Parent = pictureBox1;
            glassButton9.Parent = pictureBox1;
            glassButton10.Parent = pictureBox1;
            glassButton11.Parent = pictureBox1;
            glassButton12.Parent = pictureBox1;
            glassButton13.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            glassButton6.Visible = false;
            glassButton7.Visible = false;
            glassButton10.Visible = false;
            textBox2.Hide();
            textBox1.Hide();






            glassButton7.Visible = true;
            label2.ForeColor = Color.Yellow;
            label3.ForeColor = Color.Yellow;


            data = new DataTable();

            try
            {
                connect.Open();
                adaptor.SelectCommand.CommandText = "SELECT loghat,mani FROM dictionary WHERE ID>0";
                adaptor.Fill(data);
               savetxt1= label11.Text = data.Rows[0].ItemArray[0].ToString();
               savetxt2= label13.Text = data.Rows[0].ItemArray[1].ToString();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connect.Close();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            this.skinEngine1.SkinFile = Environment.CurrentDirectory + @"\Skin\" + comboBox1.Text + @".ssk";
            this.skinEngine1.Active = true;

            connect.Open();
            string s = "update Skin set skin='" + comboBox1.Text + "'where id=1";
            OleDbCommand com = new OleDbCommand(s, connect);
            com.ExecuteNonQuery();
            connect.Close();
        }


        public SpVoice spea = new SpVoice();

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
            //spea.Rate = -10;
            spea.Speak(label11.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync);
            spea.WaitUntilDone(5000);

        }

        private void glassButton4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("هم لغت و هم معنی باید وارد شوند نباید خالی باشند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (virayesh)
                {
                    try
                    {
                        connect.Open();

                        string s = "select ID FROM dictionary WHERE loghat='" + savetxt1 + "'and mani='" + savetxt2 + "'";
                        OleDbCommand com = new OleDbCommand(s, connect);
                        Object idx = com.ExecuteScalar();
                        int id = Int32.Parse(idx.ToString());
                        connect.Close();

                        connect.Open();
                        s = "UPDATE dictionary SET loghat='" + textBox1.Text + "',mani='" + textBox2.Text + "' where ID=" + id;

                        savetxt1 = textBox1.Text;
                        savetxt2 = textBox2.Text;


                        com = new OleDbCommand(s, connect);
                        com.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("ویرایش با موفقیت انجام شد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    glassButton2.Show();
                    glassButton9.Show();
                    glassButton18.Show();
                    virayesh = false;
                }
                else
                {
                    bool x = false;
                    try
                    {
                        connect.Open();
                        string s = "select loghat from dictionary where loghat='" + textBox1.Text + "'";
                        OleDbCommand com = new OleDbCommand(s, connect);
                        com = new OleDbCommand(s, connect);
                        object moshabeh = com.ExecuteScalar();
                        connect.Close();



                        if (moshabeh == null)
                        {
                            connect.Open();
                            s = "INSERT INTO dictionary(loghat,mani)VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                            com = new OleDbCommand(s, connect);
                            com.ExecuteNonQuery();
                            connect.Close();
                            glassButton4.Visible = false;
                            MessageBox.Show("ذخیره سازی با موفقیت انجام شد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            x = true;

                        }



                        if (!x)
                        {
                            MessageBox.Show("این لغت قبلا ذخیره شده است", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connect.Close();
                    }
                }
                glassButton2.Visible = true;
                glassButton10.Visible = false;
                glassButton9.Visible = true;
                glassButton18.Hide();
                glassButton2.Show();
                glassButton3.Show();
                label11.Text = textBox1.Text;
                label11.Show();
                textBox1.Hide();
                label13.Text = textBox2.Text;
                label13.Show();
                textBox2.Hide();
                textBox2.Clear();
                textBox1.Clear();
                //textBox1.ReadOnly = true;
                //textBox2.ReadOnly = true;
            }
        }

        private void glassButton7_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            groupBox3.Hide();
            //textBox2.Visible = false;
            glassButton6.Visible = true;
            glassButton7.Visible = false;
        }

        private void glassButton6_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            groupBox3.Show();
            //textBox2.Visible = true;
            glassButton6.Visible = false;
            glassButton7.Visible = true;
        }




        string savetxt1, savetxt2;



        public bool virayesh = false;

        private void glassButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = label11.Text;
            label11.Hide();
            textBox1.Show();
            textBox1.Focus();
            textBox2.Text = label13.Text;
            label13.Hide();
            textBox2.Show();
            glassButton9.Hide();
            //glassButton10.Hide();
            glassButton2.Hide();
           // textBox1.Hide();
           // textBox2.Hide();
            //textBox1.ReadOnly = false;
            //textBox2.ReadOnly = false;
            virayesh = true;
            glassButton3.Hide();
            glassButton4.Show();
            glassButton10.Show();
        }


        private void glassButton9_Click(object sender, EventArgs e)
        {
            glassButton3.Hide();
            glassButton2.Hide();
            label11.Hide();
            label13.Hide();
            textBox1.Show();
            textBox2.Show();
            textBox1.Focus();
            glassButton4.Visible = true;
            glassButton9.Visible = false;
            glassButton18.Visible = true;
        }




        public int didan_kalame=0;
        private void glassButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string s = "DELETE FROM dictionary WHERE loghat='" + label11.Text + "'and mani='" + label13.Text + "'";
                OleDbCommand com = new OleDbCommand(s, connect);
                com.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("حذف با موفقیت انجام شد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connect.Open();
                string S = "select Count(id) from dictionary";// baray bedast amadan tedad  satrha
                com = new OleDbCommand(S, connect);
                object da = com.ExecuteScalar();
                connect.Close();

                int k=Int32.Parse(da.ToString());
                if (k == 0)
                    MessageBox.Show("لغتی در بانک اطلاعاتی وجود ندارد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /////////////////////////////////////////////////////////
                else
                {
                    s = "select loghat,mani from dictionary where id  > 0 ";
                    adaptor = new OleDbDataAdapter(s,connect);
                    data = new DataTable();
                    //adaptor.SelectCommand.CommandText = s;
                    adaptor.Fill(data);
                    if (data.Rows[0].ItemArray[0].ToString() != "")
                    {
                        savetxt1 = label11.Text = data.Rows[0].ItemArray[0].ToString();
                        savetxt2 = label13.Text = data.Rows[0].ItemArray[1].ToString();
                    }
                }
                connect.Close();       ////////////////////////////////////////////////////////
                    //else
                //{
                //    Form1_Load(sender, e);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connect.Close();
            }

        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            Pervious();
        }

        private void glassButton5_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language_persion = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language_persion);
            
       
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language_persion = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language_persion);
       

        }


        public void Pervious()
        {
             try
            {

                connect.Open();
                string s = "select ID FROM dictionary WHERE loghat='" + label11.Text + "'and mani='" + label13.Text + "'";
                OleDbCommand com = new OleDbCommand(s, connect);
                object idx = com.ExecuteScalar();
                //com.ExecuteNonQuery();
                //connect.Close();

                data = new DataTable();
                //adaptor.SelectCommand.CommandText = "select ID from dictionary where loghat='" + textBox1.Text + "'and mani='" + textBox2.Text + "'";
                //adaptor.Fill(data);
                int id = Int32.Parse(idx.ToString());
                id--;
                while (id > 0)
                {
                    
                    adaptor.SelectCommand.CommandText = "SELECT loghat,mani FROM dictionary WHERE ID=" + id + "";
                    adaptor.Fill(data);
                    if (data.Rows[0].ItemArray[0].ToString() != "")
                    {
                       savetxt1= label11.Text = data.Rows[0].ItemArray[0].ToString();
                       savetxt2= label13.Text = data.Rows[0].ItemArray[1].ToString();
                        break;
                    }
                    id--;
                }
                if(id==0)
                    MessageBox.Show(" قبلی دیگری وجود ندارد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connect.Close();
        
        }




        public void Next()
        {
             try
            {

                connect.Open();

                 //gereftan max baraye bady
                 string ss = "select MAX(ID) FROM dictionary" ;
                 OleDbCommand com = new OleDbCommand(ss, connect);
                 object idx = com.ExecuteScalar();
                 int id_max = Int32.Parse(idx.ToString());


                
                string s = "select ID FROM dictionary WHERE loghat='" + label11.Text + "'and mani='" + label13.Text + "'";
                com = new OleDbCommand(s, connect);
                idx = com.ExecuteScalar();
                int id = Int32.Parse(idx.ToString());
                id++;
                data = new DataTable();
                while (id <= id_max )
                {
                    
                    adaptor.SelectCommand.CommandText = "SELECT loghat,mani FROM dictionary WHERE ID=" + id + "";
                    adaptor.Fill(data);
                    if (data.Rows[0].ItemArray[0].ToString() != "")
                    {
                       savetxt1= label11.Text = data.Rows[0].ItemArray[0].ToString();
                       savetxt2= label13.Text = data.Rows[0].ItemArray[1].ToString();
                        break;
                    }
                    id++;
                }
                if(id>id_max)
                    MessageBox.Show(" بعدی دیگری وجود ندارد", "M.Kh", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private void glassButton10_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            //label2.Text = textBox2.Text;
            //textBox2.ReadOnly = true;
            label11.Show();
            label13.Show();
            glassButton4.Visible = false;
            glassButton10.Visible = false;
            glassButton9.Visible = true;
            glassButton3.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Hide();
            textBox2.Hide();
        }

        private void glassButton11_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            glassButton11.Visible = false;
            this.Hide();
        }

        private void glassButton12_Click(object sender, EventArgs e)
        {
            Form3 search = new Form3();
            search.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            g.Show();
            pictureBox4.Hide();
        }

        private void glassButton8_Click(object sender, EventArgs e)
        {
            pictureBox4.Show();
            g.Hide();
            connect.Open();
            string s= "Update speak set speed_speak=" + hScrollBar1.Value + ",volume_speak="+hScrollBar2.Value+"where id=1";
            OleDbCommand com = new OleDbCommand(s, connect);
            com.ExecuteNonQuery();
            connect.Close();

        }


        private void glassButton8_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                string s = "Update speak set speed_speak=" + hScrollBar1.Value+ ",volume_speak=" + hScrollBar2.Value + " where ID=1";
                OleDbCommand com = new OleDbCommand(s, connect);
                connect.Open();
                com.ExecuteNonQuery();
                connect.Close();


                pictureBox4.Show();
                g.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            spea.Rate = hScrollBar1.Value;
            label5.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

            spea.Volume = hScrollBar2.Value;
            label6.Text = hScrollBar2.Value.ToString();

        }

        private void glassButton14_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "back up(*.bak)|*.bak";
            if (save.ShowDialog() == DialogResult.OK)
            {
                txtProNet1.Text = save.FileName;
            }

            x = 1;
        }

        private void glassButton13_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void glassButton16_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void glassButton15_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "back up(*.bak)|*.bak";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtProNet2.Text = open.FileName;
            }
            x = 2;
        }



        public void backup()
        {
            try
            {

                string s = Environment.CurrentDirectory + @"\Database11.mdb";
                File.Copy(s, txtProNet1.Text, true);
                MessageBox.Show("پشتیبان گیری با موفقیت انجام شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void restore()
        {
            try
            {

                string s = Environment.CurrentDirectory + @"\Database11.mdb";
                File.Copy(txtProNet2.Text, s, true);
                MessageBox.Show("بازیابی با موفقیت انجام شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public int x = 0;
        private void glassButton17_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                backup();
                x = 0;
            }
            if (x == 2) 
            {
                restore();
                x = 0;
            }

            txtProNet1.Clear();
            txtProNet2.Clear();


            connect.Open();
            string S = "select Count(id) from dictionary where id<>null";// baray bedast amadan tedad  satrha
            OleDbCommand com = new OleDbCommand(S, connect);
            object da = com.ExecuteScalar();
            connect.Close();


            int k = Int32.Parse(da.ToString());
            if (k < 2)
            {
                glassButton2.Visible = false;
            }
            else
            {
                glassButton2.Visible = true;
            }
        
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language_persion = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language_persion);
        }

        private void glassButton18_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            //label2.Text = textBox2.Text;
            textBox1.Hide();
            textBox2.Hide();
            label11.Show();
            label13.Show();
            //textBox2.ReadOnly = true;
            glassButton4.Visible = false;
            glassButton10.Visible = false;
            glassButton9.Visible = true;
            glassButton18.Hide();
            glassButton3.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            item=new List<int>();
            for(int i=0;i<10;i++)
            {
                Thread.Sleep(300);
                item.Add(i);
            }
            e.Result = item;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            item.AddRange((List<int>)e.Result);
        }


        


    }
}
