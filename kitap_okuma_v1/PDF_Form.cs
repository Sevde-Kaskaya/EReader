using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraPdfViewer;

namespace kitap_okuma_v1
{
    public partial class PDF_Form : Form
    {
        public PDF_Form()
        {
            InitializeComponent();
        }

        
        public string pdf_url;

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3O0AFDH;Initial Catalog=kitap_okuma;Integrated Security=True");

        private void pdfViewer1_Load_1(object sender, EventArgs e)
        {
            this.pdfViewer1.LoadDocument(@"C:\Users\Sevde\Desktop\yazlab\ITEBOOKS\" + pdf_url);
            
           
        }
    }
}
