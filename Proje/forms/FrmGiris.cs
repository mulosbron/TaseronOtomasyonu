using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmGiris : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmGiris()
        {
            InitializeComponent();
        }
        
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            this.tblIsciTableAdapter.Fill(this.taseronDataSet7.tblIsci);
        }

        private void btnGirisMain_Click(object sender, EventArgs e)
        {
            FrmMain frmMain= new FrmMain();
            this.Hide();
            frmMain.FormClosed += (s, args) =>
            {
                frmMain.Dispose();
                frmMain = new FrmMain();
                this.Show();
            };
            frmMain.ShowDialog();
        }

        private void btnGirisIsciTC_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            baglanti.Open();
            SqlCommand kmtSec = new SqlCommand("select IsciAd, IsciSoyad, IsciIs, IsciYevmiye from tblIsci where IsciTC = @s1", baglanti);
            kmtSec.Parameters.AddWithValue("@s1", txtGirisIsciTC.Text);
            SqlDataReader okuyucu = kmtSec.ExecuteReader();
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    string isciAd = okuyucu.GetString(0);
                    string isciSoyad = okuyucu.GetString(1);
                    string isciIs = okuyucu.GetString(2);
                    short isciYevmiye = okuyucu.GetInt16(3);
                    MessageBox.Show($"İşçi Adı: {isciAd}\nİşçi Soyadı: {isciSoyad}\nİşçinin Çalıştığı İş: {isciIs}\nİşçinin Yevmiye Ücreti: {isciYevmiye}", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Girilen İşçi T.C.'si bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            okuyucu.Close();
            baglanti.Close();
        }

    }
}
