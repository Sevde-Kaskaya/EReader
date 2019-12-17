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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public string kullaniciAdi;
        public string userID;
        public string pdf_yol;

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3O0AFDH;Initial Catalog=kitap_okuma;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            listView2.Visible = false;
            listView1.Visible = true;
            listView3.Visible = false;
            kitaplar();

            baglan.Open();
            SqlCommand komut0 = new SqlCommand("Select * From Users Where kAdi = @kullaniciAdi", baglan);
            komut0.Parameters.Add("@kullaniciAdi", kullaniciAdi);
            SqlDataReader read = komut0.ExecuteReader();
            while (read.Read())
            {
                label5.Text = read["userID"].ToString();
                label6.Text = read["kAdi"].ToString();
                label7.Text = read["age"].ToString();
                label8.Text = read["location"].ToString();
            }
            baglan.Close();


        }
        
        private void kitaplar()
        {
            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut1.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        //OKU Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                for (int i = 0; i < listView1.Items.Count; i++)
                    if (listView1.Items[i].Checked)
                    {
                        string kayit0 = string.Format("select * from Kitaplar where ISBN ='{0}'", listView1.Items[i].SubItems[0].Text);
                        SqlCommand komut2 = new SqlCommand(kayit0, baglan);
                        SqlDataReader read = komut2.ExecuteReader();
                        while (read.Read())
                        {
                            PDF_Form pdf_form = new PDF_Form();
                            pdf_form.pdf_url = read["dosya_yolu"].ToString();
                            pdf_form.Show();
                        }
                        baglan.Close();
                    }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        //rate 
        private void rate_cntrl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Checked)
                        {
                            string kayit1 = "select * from Rate where userID = @userid AND ISBN = @ISBN";
                            SqlCommand komut3 = new SqlCommand(kayit1, baglan);
                            if (komut3 == null)
                            {
                                string kayit2 = "insert into Rate(userID,ISBN,ratings) values (@userid,@ISBN,@ratings)";
                                SqlCommand komut4 = new SqlCommand(kayit2, baglan);
                                komut4.Parameters.AddWithValue("@userid", label5.Text);
                                komut4.Parameters.AddWithValue("@ISBN", listView1.Items[i].SubItems[0].Text);
                                komut4.Parameters.AddWithValue("@ratings", rate_cntrl.EditValue);
                                komut4.ExecuteNonQuery();
                                baglan.Close();
                            }
                            else
                            {
                                string kayit3 = "UPDATE Rate SET ratings=@ratings ";
                                SqlCommand komut5 = new SqlCommand(kayit3, baglan);
                                komut5.Parameters.AddWithValue("@userid", label5.Text);
                                komut5.Parameters.AddWithValue("@ISBN", listView1.Items[i].SubItems[0].Text);
                                komut5.Parameters.AddWithValue("@ratings", rate_cntrl.EditValue);
                                komut5.ExecuteNonQuery();
                                baglan.Close();
                            }


                        }
                    }
                }
                MessageBox.Show("Oylama İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Buyukten kucuge oy
        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            listView1.Visible = false;
            listView3.Visible = false;
            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut6 = new SqlCommand("SELECT ISBN, AVG(ratings) as avarage FROM Rate GROUP BY ISBN ORDER BY avarage DESC", baglan);
            SqlDataReader read = komut6.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["avarage"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }

        //Kucukten buyuge oy
        private void button6_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            listView1.Visible = false;
            listView3.Visible = false;
            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut7 = new SqlCommand("SELECT ISBN, AVG(ratings) as avarage FROM Rate GROUP BY ISBN ORDER BY avarage ASC", baglan);
            SqlDataReader read = komut7.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["avarage"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }

        //populer kitaplar
        private void button5_Click(object sender, EventArgs e)
        {

            listView2.Visible = false;
            listView1.Visible = false;
            listView3.Visible = true;
            listView3.Items.Clear();

            baglan.Open();
            SqlCommand komut8 = new SqlCommand(" SELECT TOP 10 ISBN,COUNT(ratings) AS sayi FROM Rate GROUP BY ISBN ORDER BY sayi DESC", baglan);
            SqlDataReader read = komut8.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["sayi"].ToString());
                listView3.Items.Add(ekle);
            }
            baglan.Close();
           
        }

        //TOP 10 en yi kitaplar
        private void button1_Click(object sender, EventArgs e)
        {

            listView2.Visible = true;
            listView1.Visible = false;
            listView3.Visible = false;
            listView2.Items.Clear();

            baglan.Open();
            SqlCommand komut9= new SqlCommand("SELECT TOP 10 ISBN, AVG(ratings) as avarage FROM Rate GROUP BY ISBN ORDER BY avarage DESC", baglan);
            SqlDataReader read = komut9.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["avarage"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }

        //Tum kitaplar
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView3.Visible = false;

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand komut10 = new SqlCommand("Select * From Kitaplar", baglan);
            SqlDataReader read = komut10.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["ISBN"].ToString();
                ekle.SubItems.Add(read["bookTitle"].ToString());
                ekle.SubItems.Add(read["author"].ToString());
                ekle.SubItems.Add(read["publicYear"].ToString());
                ekle.SubItems.Add(read["publisher"].ToString());
                ekle.SubItems.Add(read["image"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();

        }

        //Kitap Bilgileri
        private void button7_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                    for (int i = 0; i < listView1.Items.Count; i++)
                        if (listView1.Items[i].Checked)
                        {
                        string kayit4 = string.Format("select * from Kitaplar where ISBN ='{0}'", listView1.Items[i].SubItems[0].Text);
                        SqlCommand komut11 = new SqlCommand(kayit4, baglan);
                        SqlDataReader read = komut11.ExecuteReader();
                        while (read.Read())
                        {
                            label13.Text = read["bookTitle"].ToString();
                            label14.Text = read["author"].ToString();
                            label15.Text = read["publisher"].ToString();
                            label16.Text = read["publicYear"].ToString();
                        }
                        baglan.Close();
                    }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}
