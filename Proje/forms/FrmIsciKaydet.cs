using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmIsciKaydet : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmIsciKaydet()
        {
            InitializeComponent();
        }

        void Listele()
        {
            this.tblIsciTableAdapter.Fill(this.taseronDataSet.tblIsci);
        }

        void Kaydet()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            SqlCommand kmtSay = new SqlCommand("select count(*) from tblIsci where IsciTC = @s1", baglanti);
            kmtSay.Parameters.AddWithValue("@s1", txtIsciTC.Text);
            baglanti.Open();
            int sayac = (int)kmtSay.ExecuteScalar();
            if (sayac < 1)
            {
                baglanti.Close();
                if (txtIsciTC.MaskFull)
                {
                    if (txtIsciAd.Text.Length != 0)
                    {
                        if (txtIsciSoyad.Text.Length != 0)
                        {
                            if (txtIsciIs.Text.Length != 0)
                            {
                                if (int.TryParse(txtIsciYevmiye.Text, out int yevmiye) && yevmiye > 0 && yevmiye < 32768)
                                {
                                    if (txtIsciTelefon.MaskFull)
                                    {
                                        DialogResult result = MessageBox.Show("İşçi kayıt panelindeki verileri kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (result == DialogResult.Yes)
                                        {
                                            baglanti.Open();
                                            SqlCommand kmtKaydet = new SqlCommand("insert into tblIsci (IsciTC,IsciAd,IsciSoyad,IsciIs,IsciYevmiye,IsciTelefon) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
                                            kmtKaydet.Parameters.AddWithValue("@p1", txtIsciTC.Text);
                                            kmtKaydet.Parameters.AddWithValue("@p2", txtIsciAd.Text);
                                            kmtKaydet.Parameters.AddWithValue("@p3", txtIsciSoyad.Text);
                                            kmtKaydet.Parameters.AddWithValue("@p4", txtIsciIs.Text);
                                            kmtKaydet.Parameters.AddWithValue("@p5", txtIsciYevmiye.Text);
                                            string a = "";
                                            a = txtIsciTelefon.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                                            kmtKaydet.Parameters.AddWithValue("@p6", a);
                                            kmtKaydet.ExecuteNonQuery();
                                            baglanti.Close();
                                            Listele();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Telefon kısmında boşluk bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Yevmiye [1-32767] arasında bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("İş kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Soyad kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ad kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("T.C. Kimlik Numarasında boşluk bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu T.C. Kimlik Numarası zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guncelle()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtIsciTC.MaskFull)
            {
                if (txtIsciAd.Text.Length != 0)
                {
                    if (txtIsciSoyad.Text.Length != 0)
                    {
                        if (txtIsciIs.Text.Length != 0)
                        {
                            if (int.TryParse(txtIsciYevmiye.Text, out int yevmiye) && yevmiye > 0 && yevmiye < 32768)
                            {
                                if (txtIsciTelefon.MaskFull)
                                {
                                    DialogResult result = MessageBox.Show(txtIsciTC.Text + " T.C. Kimlik Numaralı işçinin bilgilerini güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (result == DialogResult.Yes)
                                    {
                                        baglanti.Open();
                                        SqlCommand kmtSec = new SqlCommand("select * from tblIsci where IsciTC=@s1", baglanti);
                                        kmtSec.Parameters.AddWithValue("@s1", txtIsciTC.Text);
                                        SqlDataReader okuyucu = kmtSec.ExecuteReader();
                                        if (okuyucu.Read())
                                        {
                                            baglanti.Close();
                                            baglanti.Open();
                                            SqlCommand kmtGuncelle = new SqlCommand("update tblIsci set IsciAd=@u1,IsciSoyad=@u2,IsciIs=@u3,IsciYevmiye=@u4,IsciTelefon=@u5 where IsciTC=@u6", baglanti);
                                            kmtGuncelle.Parameters.AddWithValue("@u1", txtIsciAd.Text);
                                            kmtGuncelle.Parameters.AddWithValue("@u2", txtIsciSoyad.Text);
                                            kmtGuncelle.Parameters.AddWithValue("@u3", txtIsciIs.Text);
                                            kmtGuncelle.Parameters.AddWithValue("@u4", txtIsciYevmiye.Text);
                                            string a = "";
                                            a = txtIsciTelefon.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                                            kmtGuncelle.Parameters.AddWithValue("@u5", a);
                                            kmtGuncelle.Parameters.AddWithValue("@u6", txtIsciTC.Text);
                                            kmtGuncelle.ExecuteNonQuery();
                                            Listele();
                                        }
                                        else MessageBox.Show("T.C. Kimlik Numarası veri tabanında bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        okuyucu.Close();
                                        baglanti.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Telefon kısmında boşluk bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Yevmiye [1-32767] arasında bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("İş kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Soyad kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ad kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("T.C. Kimlik Numarası boşluk bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Temizle()
        {
            DialogResult result = MessageBox.Show("İşçi kayıt panelindeki bilgileri temizlemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtIsciAd.Text = "";
                txtIsciIs.Text = "";
                txtIsciSoyad.Text = "";
                txtIsciTC.Text = "";
                txtIsciTelefon.Text = "";
                txtIsciYevmiye.Text = "";
            }
        }

        void BilgiTasi()
        {
            int secilen = dtgrdIsciKayitlar.SelectedCells[0].RowIndex;
            txtIsciTC.Text = dtgrdIsciKayitlar.Rows[secilen].Cells[0].Value.ToString();
            txtIsciAd.Text = dtgrdIsciKayitlar.Rows[secilen].Cells[1].Value.ToString();
            txtIsciSoyad.Text = dtgrdIsciKayitlar.Rows[secilen].Cells[2].Value.ToString();
            txtIsciIs.Text = dtgrdIsciKayitlar.Rows[secilen].Cells[3].Value.ToString();
            txtIsciYevmiye.Text = dtgrdIsciKayitlar.Rows[secilen].Cells[4].Value.ToString();
            txtIsciTelefon.Text = dtgrdIsciKayitlar.Rows[secilen].Cells[5].Value.ToString();
        }

        private void FrmIsciKaydet_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtIsciAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || txtIsciAd.Text.Length >= 39)
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtIsciSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || txtIsciSoyad.Text.Length >= 39)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtIsciIs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || txtIsciIs.Text.Length >= 19)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtIsciYevmiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            int sayi = 0;
            if (int.TryParse(txtIsciYevmiye.Text + e.KeyChar, out sayi))
            {
                if (sayi < 0 || sayi > 32767)
                {
                    MessageBox.Show("Lütfen [1-32767] arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    txtIsciYevmiye.Text = "";
                }
            }
        }

        private void btnIsciKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();    
        }
        
        private void btnIsciSilForm_Click(object sender, EventArgs e)
        {
            FrmIsciSil frmIsciSil = new FrmIsciSil();
            frmIsciSil.ShowDialog();
            Listele();
        }

        private void btnIsciGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        
        private void btnIsciTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dtgrdIsciKayitlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BilgiTasi();
        }
    }
}
