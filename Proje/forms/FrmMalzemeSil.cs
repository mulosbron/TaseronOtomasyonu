using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmMalzemeSil : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmMalzemeSil()
        {
            InitializeComponent();
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtMalzemeSil.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show(txtMalzemeSil.Text + " ID'li malzemeyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand kmtSec = new SqlCommand("select * from tblMalzeme where MalzemeID=@s1", baglanti);
                    kmtSec.Parameters.AddWithValue("@s1", txtMalzemeSil.Text);
                    SqlDataReader okuyucu = kmtSec.ExecuteReader();
                    if (okuyucu.HasRows)
                    {
                        okuyucu.Close();
                        SqlCommand kmtSil = new SqlCommand("delete from tblMalzeme where MalzemeID = @d1", baglanti);
                        kmtSil.Parameters.AddWithValue("@d1", txtMalzemeSil.Text);
                        kmtSil.ExecuteNonQuery();
                        this.Close();
                    }
                    else
                    {
                        okuyucu.Close();
                        MessageBox.Show("Veri tabanında aradığınız ID'ye sahip bir malzeme bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglanti.Close();
                }
            }
        }

        private void btnMalzemeDBSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            DialogResult result = MessageBox.Show("Malzeme kayıtlarındaki tüm verileri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand kmtSil = new SqlCommand("delete from tblMalzeme", baglanti);
                kmtSil.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
        }
    }
}
