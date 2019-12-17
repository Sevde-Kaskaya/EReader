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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //baglanti
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3O0AFDH;Initial Catalog=kitap_okuma;Integrated Security=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Giris 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "SELECT * FROM Users WHERE kAdi = @kullanici_adi AND sifre = @sifresi";
                SqlParameter p1 = new SqlParameter("kullanici_adi", textBox6.Text.Trim());
                SqlParameter p2 = new SqlParameter("sifresi", textBox4.Text.Trim());
                SqlCommand komut1 = new SqlCommand(sql, baglan);
                komut1.Parameters.Add(p1);
                komut1.Parameters.Add(p2);
                DataTable sql_dt = new DataTable();
                SqlDataAdapter sql_da = new SqlDataAdapter(komut1);
                sql_da.Fill(sql_dt);
                baglan.Close();

                if (sql_dt.Rows.Count > 0)
                {
                    if (textBox6.Text.Trim() == "admin" && textBox4.Text.Trim() == "1111")
                    {
                        Form3 form3 = new Form3();
                        form3.Show();

                    }

                    else
                    {
                        Form2 form2 = new Form2();
                        form2.kullaniciAdi = textBox6.Text.Trim();
                        form2.Show();
                    }  
                    
                }

                
            }
            catch(Exception)
            {
                MessageBox.Show("Yanlış giriş yaptınız.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                throw;
            }
        }

        //UYE OL
        private void label8_Click(object sender, EventArgs e)
        {
            Uyelik uyelik = new Uyelik();
            uyelik.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


