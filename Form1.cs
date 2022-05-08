
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;

namespace E_OKUL
{
    public partial class Form1 : Form
    { 
        
        public Form1()
        {
            InitializeComponent();
            control = false;
            menu_yukseklýk = panel3.Width;
        }
        bool control;
        int menu_yukseklýk;
        private void çýkýþYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çýkýþYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void DersYukle()
        {
        //    dataGridView1.RowHeadersVisible = false;//Satýr baþlýklarý görünmez yapýlýr.
        //   dataGridView1.Font = new Font("Verdana", 12);// Datagridview için font ayarlamasý yapýlýr.
        //    dataGridView1.Columns.Clear();// Tablonun önceki kullanýmýndan kalan sütunlar temizlenir.
        //     // Tablo temizlenir.
        //    MySqlDataAdapter komut = new MySqlDataAdapter();// Komut ve baðlantý
            
        ////DataAdapter nesnesine yüklenen bilgiler tabloya aktarýlýr.
        //  //Datagridview bileþeni data kaynaðý olarak table seçilir.
        //  dataGridView1.Columns["derskodu"].HeaderText = "Ders Kodu"; //MySQL’den gelen kolon adý Datagridview’de
            
        //     dataGridView1.Columns["dersadi"].HeaderText = "Ders Adý";
        }
            
            private void Form1_Load(object sender, EventArgs e)
            {
            
              string api = "88b5eba4a2dbaf6f6d88340e8382b45b";
              string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
              XDocument hava = XDocument.Load(connection);
              var sýcaklýk = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
              label1.Text = sýcaklýk.ToString();
              var durum=hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
             
            if (durum=="açýk")
            {
                gunes.ImageLocation = @"C:\Users\sahin\OneDrive\Masaüstü\-29.png";
            }
            if (durum=="parçalý az bulutlu"&& durum == "bulutlu")
            {
                gunes.ImageLocation = @"C:\Users\sahin\OneDrive\Masaüstü\-25.png";
            }
            if (durum=="rüzgarlý")
            {
                gunes.ImageLocation = @"C:\Users\sahin\OneDrive\Masaüstü\-42.png";
            }
            if (durum == "yaðýþlý")
                gunes.ImageLocation = @"C:\Users\sahin\OneDrive\Masaüstü\61.png";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=3;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
       
        
        private void button8_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
           
        }
         
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
    
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
                    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            if (control)
            {
                panel3.Width = panel3.Width + 10;
                if (panel3.Width>=menu_yukseklýk)
                {
                    timer2.Stop();
                    control = false;    
                    this.Refresh();
                }
            }
            else 
            {
                panel3.Width = panel3.Width - 10;
                if (panel3.Width <= 0)
                {
                    timer2.Stop();
                    control = true;
                    this.Refresh();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Çýkýþ Yapýlýyor", "ÇIKIÞ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (cevap == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}