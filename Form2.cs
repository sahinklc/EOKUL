using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;



namespace E_OKUL
{
    public partial class Form2 : Form
    {

     
        public Form2()
        {
            InitializeComponent();
        }
        
        Form1 anasayfa = new Form1();
   
        private void button2_Click(object sender, EventArgs e)
        {
          /*  tabControl1.SelectedIndex = 1*/;
            textBox3.Text = "";
            textBox4.Text = "";
           
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox2.Text = "";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
     
        private void button4_Click(object sender, EventArgs e)
        { 
          
            if ( textBox2.Text != ""&&string.IsNullOrWhiteSpace(textBox2.Text)!=true && string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {

                anasayfa.ShowDialog();
                  
            }
            else
            MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz..!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sifre();
        }
        private void sifre()
        {   
             
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
        }
        Form3 kayıt = new Form3();
        private void Form2_Load(object sender, EventArgs e)
        {

            string conn = "SERVER=localhost;DATABASE=eokul;UID=root;PWD=1234";
            using (var baglan = new MySqlConnection(conn))
            {
                using (var komut = new MySqlCommand("SELECT * FROM ogrsfrad where ad ", baglan))
                {
                    try
                    {
                        baglan.Open();
                        MessageBox.Show("Bağlantı açıldı");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.ToString(), "Hata");
                    }
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            //if (textBox5.Text == "admin" && textBox6.Text == "1234")
            //{


            //    anasayfa.ShowDialog();
                
            //}
            //else
            //    MessageBox.Show("Lütfen Alanları Kontrol Ediniz..!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                anasayfa.ShowDialog();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
         Application.Exit();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
               textBox2.UseSystemPasswordChar = false;
                label1.Text = "Gizle";

            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = true;
                label1.Text = "Göster";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kayıt.ShowDialog();
        }
    }
}
