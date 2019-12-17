using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kitap_okuma_v1
{
    public partial class Uyelik : Form
    {
        public Uyelik()
        {
            InitializeComponent();
        }


        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3O0AFDH;Initial Catalog=kitap_okuma;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                string kayit = "insert into users(userID,location,age,kAdi,sifre) values (@userid,@konum,@yas,@kadi,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@userid", textBox3.Text);
                komut.Parameters.AddWithValue("@konum", textBox2.Text);
                komut.Parameters.AddWithValue("@yas", textBox1.Text);
                komut.Parameters.AddWithValue("@kadi", textBox6.Text);
                komut.Parameters.AddWithValue("@sifre", textBox4.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kaydınız Tamamlandı :)");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            baglan.Close();
        }

        private void Uyelik_Load(object sender, EventArgs e)
        {

        }
    }
}
