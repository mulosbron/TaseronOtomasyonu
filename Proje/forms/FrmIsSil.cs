using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmIsSil : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmIsSil()
        {
            InitializeComponent();
        }
        
        private void btnIsSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtIsSil.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show(txtIsSil.Text + " ID'li işi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand kmtSec = new SqlCommand("select * from tblIs where IsID = @d1", baglanti);
                    kmtSec.Parameters.AddWithValue("@d1", txtIsSil.Text);
                    SqlDataReader okuyucu = kmtSec.ExecuteReader();
                    if (okuyucu.HasRows)
                    {
                        okuyucu.Close();
                        SqlCommand kmtSil = new SqlCommand("delete from tblIs where IsID = @d1", baglanti);
                        kmtSil.Parameters.AddWithValue("@d1", txtIsSil.Text);
                        kmtSil.ExecuteNonQuery();
                        this.Close();
                    }
                    else
                    {
                        okuyucu.Close();
                        MessageBox.Show("Veri tabanında aradığınız ID'ye sahip bir iş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglanti.Close();
                }
            }
        }
        
        private void btnIsDBSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İş kayıtlarındaki tüm verileri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection(bglt.Adres);
                baglanti.Open();
                SqlCommand kmtSil = new SqlCommand("delete from tblIs", baglanti);
                kmtSil.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
        }
    }
}
