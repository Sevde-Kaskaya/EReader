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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3O0AFDH;Initial Catalog=kitap_okuma;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
       
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            listView2.Visible = false;
            listView3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        //oylamalar
        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView3.Visible = true;

            button2.Visible = false;
            listView2.Visible = false;
            listView1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            button3.Visible = false;
            button4.Visible = false;

            listView3.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Rate", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["userID"].ToString();
                ekle.SubItems.Add(read["ISBN"].ToString());
                ekle.SubItems.Add(read["ratings"].ToString());

                listView3.Items.Add(ekle);
            }

            baglan.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //kullanıcı ekle
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            listView2.Visible = false;
            listView3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Users", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["userID"].ToString();
                ekle.SubItems.Add(read["location"].ToString());
                ekle.SubItems.Add(read["age"].ToString());
                ekle.SubItems.Add(read["kAdi"].ToString());
                ekle.SubItems.Add(read["sifre"].ToString());

                listView1.Items.Add(ekle);
            }

            baglan.Close();


        }

        //kullanıcı sil
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            listView1.Visible = true;

            listView2.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            listView3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Users", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["userID"].ToString();
                ekle.SubItems.Add(read["location"].ToString());
                ekle.SubItems.Add(read["age"].ToString());
                ekle.SubItems.Add(read["kAdi"].ToString());
                ekle.SubItems.Add(read["sifre"].ToString());
                listView1.Items.Add(ekle);
            }

            baglan.Close();

        }

        //kullanıcı listele
        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            listView1.Visible = true;

            listView2.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            listView3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Users", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["userID"].ToString();
                ekle.SubItems.Add(read["kAdi"].ToString());
                ekle.SubItems.Add(read["age"].ToString());
                ekle.SubItems.Add(read["location"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        //kitap ekle
        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            button4.Visible = true;

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;

            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            listView1.Visible = false;
            listView3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;

            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();

        }

        //kitaplar sil
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            listView2.Visible = true;

            listView1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            listView3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }

        //kitaplar listele
        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            listView2.Visible = true;

            listView1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            listView3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            listView2.Items.Clear();
            
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }

        //kullanıcı ekle butonu
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                baglan.Open();
                string kayit = "insert into users(userID,location,age,kAdi,sifre) values (@userid,@konum,@yas,@kadi,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@userid", textBox1.Text);
                komut.Parameters.AddWithValue("@konum", textBox3.Text);
                komut.Parameters.AddWithValue("@yas", textBox2.Text);
                komut.Parameters.AddWithValue("@kadi", textBox5.Text);
                komut.Parameters.AddWithValue("@sifre", textBox4.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }


            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Users", baglan);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["userID"].ToString();
                ekle.SubItems.Add(read["location"].ToString());
                ekle.SubItems.Add(read["age"].ToString());
                ekle.SubItems.Add(read["kAdi"].ToString());
                ekle.SubItems.Add(read["sifre"].ToString());
                listView1.Items.Add(ekle);
            }

            baglan.Close();
        }

        //Kitap Ekle Butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                baglan.Open();
                string kayit = "insert into Kitaplar(ISBN,bookTitle,author,publicYear,publisher,image) values (@ISBN,@baslik,@yazar,@yayinyili,@yayinci,@resim)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@ISBN", textBox6.Text);
                komut.Parameters.AddWithValue("@baslik", textBox7.Text);
                komut.Parameters.AddWithValue("@yazar", textBox8.Text);
                komut.Parameters.AddWithValue("@yayinyili", textBox9.Text);
                komut.Parameters.AddWithValue("@yayinci", textBox10.Text);
                komut.Parameters.AddWithValue("@resim", textBox11.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }


            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }

        //Kullanıcı Sil Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                for (int i = 0; i < listView1.Items.Count; i++)
                    if (listView1.Items[i].Checked)
                    {
                        string kayit = string.Format("delete from users where userID ='{0}'", listView1.Items[i].SubItems[0].Text);
                        SqlCommand komut = new SqlCommand(kayit, baglan);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Users", baglan);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["userID"].ToString();
                ekle.SubItems.Add(read["location"].ToString());
                ekle.SubItems.Add(read["age"].ToString());
                ekle.SubItems.Add(read["kAdi"].ToString());
                ekle.SubItems.Add(read["sifre"].ToString());
                listView1.Items.Add(ekle);
            }

            baglan.Close();


        }

        //Kitap Sil Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                for (int i = 0; i < listView2.Items.Count; i++)
                    if (listView2.Items[i].Checked)
                    {
                        string kayit = string.Format("delete from Kitaplar where ISBN ='{0}'", listView2.Items[i].SubItems[0].Text);
                        SqlCommand komut = new SqlCommand(kayit, baglan);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
