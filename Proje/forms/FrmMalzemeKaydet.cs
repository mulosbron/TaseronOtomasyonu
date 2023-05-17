using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmMalzemeKaydet : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmMalzemeKaydet()
        {
            InitializeComponent();
        }

        void Listele()
        {
            tblMalzemeTableAdapter.Fill(taseronDataSet1.tblMalzeme);
        }

        void Kaydet()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtMalAd.Text.Length != 0)
            {
                if (long.TryParse(txtMalBirimFiyat.Text, out long birimfiyat) && birimfiyat > 0 && birimfiyat < 2147483648)
                {
                    DialogResult result = MessageBox.Show("Malzeme kayıt panelindeki verileri kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        baglanti.Open();
                        SqlCommand kmtKaydet = new SqlCommand("insert into tblMalzeme (MalzemeAd,MalzemeBirimFiyat) values (@i1,@i2)", baglanti);
                        kmtKaydet.Parameters.AddWithValue("@i1", txtMalAd.Text);
                        kmtKaydet.Parameters.AddWithValue("@i2", txtMalBirimFiyat.Text);
                        kmtKaydet.ExecuteNonQuery();
                        baglanti.Close();
                        Listele();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen [1-2147483647] arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Malzeme isim kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guncelle()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtMalID.Text.Length != 0)
            {
                if (txtMalAd.Text.Length != 0)
                {
                    if (long.TryParse(txtMalBirimFiyat.Text, out long birimfiyat) && birimfiyat > 0 && birimfiyat < 2147483648)
                    {
                        DialogResult result = MessageBox.Show(txtMalID.Text + " ID'li malzemenin bilgilerini güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            baglanti.Open();
                            SqlCommand kmtSec = new SqlCommand("select * from tblMalzeme where MalzemeID=@s1", baglanti);
                            kmtSec.Parameters.AddWithValue("@s1", txtMalID.Text);
                            SqlDataReader okuyucu = kmtSec.ExecuteReader();
                            if (okuyucu.Read())
                            {
                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand kmtGuncelle = new SqlCommand("update tblMalzeme set MalzemeAd=@u1,MalzemeBirimFiyat=@u2 where MalzemeID=@u3", baglanti);
                                kmtGuncelle.Parameters.AddWithValue("@u1", txtMalAd.Text);
                                kmtGuncelle.Parameters.AddWithValue("@u2", txtMalBirimFiyat.Text);
                                kmtGuncelle.Parameters.AddWithValue("@u3", txtMalID.Text);
                                kmtGuncelle.ExecuteNonQuery();
                                Listele();
                            }
                            else MessageBox.Show("Malzeme ID veri tabanında bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            okuyucu.Close();
                            baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen [1-2147483647] arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Malzeme isim kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Malzeme ID kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Temizle()
        {
            DialogResult result = MessageBox.Show("Malzeme kayıt tablosundaki verileri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                txtMalID.Text = "";
                txtMalAd.Text = "";
                txtMalBirimFiyat.Text = "";
            }
        }

        void BilgiTasi()
        {
            int secilen = dtgrdMalKayitlar.SelectedCells[0].RowIndex;
            txtMalID.Text = dtgrdMalKayitlar.Rows[secilen].Cells[0].Value.ToString();
            txtMalAd.Text = dtgrdMalKayitlar.Rows[secilen].Cells[1].Value.ToString();
            txtMalBirimFiyat.Text = dtgrdMalKayitlar.Rows[secilen].Cells[2].Value.ToString();
        }
        
        private void FrmMalzemeKaydet_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtMalAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMalAd.Text.Length >= 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtMalBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (long.TryParse(txtMalBirimFiyat.Text + e.KeyChar, out long sayi))
            {
                if (sayi < 0 || sayi > 2147483647)
                {
                    MessageBox.Show("Lütfen [1-2147483647] arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    txtMalBirimFiyat.Text = "";
                }
            }
        }

        private void btnMalKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void btnMalSilForm_Click(object sender, EventArgs e)
        {
            FrmMalzemeSil frmMalSil = new FrmMalzemeSil();
            frmMalSil.ShowDialog();
            Listele();
        }

        private void btnMalGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnMalTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dtgrdMalKayitlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BilgiTasi();
        }
    }
}
