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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        //    string conn = "SERVER=localhost;DATABASE=eokul;UID=root;PWD=1234";
        //    using (var baglan = new MySqlConnection(conn))
        //    {
        //        try
        //        {
        //            // bağlantıyı açalım
        //            baglan.Open();
        //            // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
        //            MySqlCommand ekle = new MySqlCommand("insert into ogrencibilgi (ogrenciad,ogrencısoyad,ogrencıbolum,ogrencisinif,ogrencı_no,ogrencıdogumtrh) values ('" + isim.Text + "','" + soyisim.Text + "','" + ogrecibolum.Text + "','" + ogrencisinif.Text + "','" + ogrno.Text + "','" + dogumtrh.Text + "')", baglan);
        //            // sorguyu çalıştırıyorum.
        //            object sonuc = null;
        //            sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
        //            if (sonuc != null)
        //                MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            else
        //                MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            // bağlantıyı kapatalım
        //            baglan.Close();
        //        }
        //        catch (Exception HataYakala)
        //        {
        //            MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        }
      
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void kayitGetir()
        {
            string conn = "SERVER=localhost;DATABASE=eokul;UID=root;PWD=1234";
            var baglan = new MySqlConnection(conn);
            baglan.Open();
            string kayit = "SELECT * from eokul";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            MySqlCommand komut = new MySqlCommand(kayit, baglan);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglan.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kayitGetir();

        }
    }
}
