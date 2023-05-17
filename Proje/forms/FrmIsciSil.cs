using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmIsciSil : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmIsciSil()
        {
            InitializeComponent();
        }
        
        private void btnIsciSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtIsciSil.MaskFull)
            {
                baglanti.Open();
                SqlCommand kmtSec = new SqlCommand("select * from tblIsci where IsciTC=@s1", baglanti);
                kmtSec.Parameters.AddWithValue("@s1", txtIsciSil.Text);
                SqlDataReader okuyucu = kmtSec.ExecuteReader();
                if (okuyucu.Read())
                {
                    DialogResult result = MessageBox.Show(txtIsciSil.Text + " T.C. Kimlik Numaralı kişiyi silmek istediğinize emin misiniz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        baglanti.Close();
                        baglanti.Open();
                        SqlCommand kmtSil = new SqlCommand("delete from tblIsci where IsciTC=@d1", baglanti);
                        kmtSil.Parameters.AddWithValue("@d1", txtIsciSil.Text);
                        kmtSil.ExecuteNonQuery();
                        okuyucu.Close();
                        baglanti.Close();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Aradığınız T.C. Kimlik Numarası veritabanında bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                okuyucu.Close();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tam 11 haneli bir T.C. Kimlik Numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIsciDBSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            DialogResult result = MessageBox.Show("İşçi kayıtlarındaki tüm verileri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand kmtSil = new SqlCommand("delete from tblIsci", baglanti);
                kmtSil.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
        }
        
    }
}
