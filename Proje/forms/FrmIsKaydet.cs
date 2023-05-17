using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Proje
{
    public partial class FrmIsKaydet : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmIsKaydet()
        {
            InitializeComponent();
        }
        
        string ListBoxToText(ListBox listBox)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object item in listBox.Items)
            {
                sb.Append(item.ToString() + ";");
            }
            string s = sb.ToString();
            return s;
        }

        ListBox TextToListBox(string s)
        {
            ListBox lstbxDizi = new ListBox();
            string[] dizi = s.Split(';');
            foreach (string item in dizi)
            {
                lstbxDizi.Items.Add(item);
            }
            if (lstbxDizi.Items.Count > 0) lstbxDizi.Items.RemoveAt(lstbxDizi.Items.Count - 1);
            return lstbxDizi;
        }

        void BilgiTasi()
        {
            int secilen = dtgrdIsKayitlar.SelectedCells[0].RowIndex;
            txtIsID.Text = dtgrdIsKayitlar.Rows[secilen].Cells[0].Value.ToString();
            txtIsAd.Text = dtgrdIsKayitlar.Rows[secilen].Cells[1].Value.ToString();
            txtIsTeklif.Text = dtgrdIsKayitlar.Rows[secilen].Cells[2].Value.ToString();
            txtIsGun.Text = dtgrdIsKayitlar.Rows[secilen].Cells[3].Value.ToString();
            lstbxIsIscilerListe.Items.Clear();
            lstbxIsIscilerListe.Items.AddRange(TextToListBox(dtgrdIsKayitlar.Rows[secilen].Cells[4].Value.ToString()).Items);
            lstbxIsMalzemelerListe.Items.Clear();
            lstbxIsMalzemelerListe.Items.AddRange(TextToListBox(dtgrdIsKayitlar.Rows[secilen].Cells[5].Value.ToString()).Items);
        }

        void Listele()
        {
            this.tblIsTableAdapter.Fill(this.taseronDataSet3.tblIs);
        }

        void Kaydet()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtIsAd.Text.Length != 0)
            {
                if (long.TryParse(txtIsTeklif.Text, out long teklif) && teklif > 0 && teklif < 2147483648)
                {
                    if (int.TryParse(txtIsGun.Text, out int gun) && gun > 0 && gun < 256)
                    {
                        DialogResult result = MessageBox.Show("İş kayıt panelindeki verileri kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            baglanti.Open();
                            SqlCommand kmtKaydet = new SqlCommand("insert into tblIs (IsAd,IsTeklif,IsGun,IsIsciler,IsMalzemeler) values (@i1,@i2,@i3,@i4,@i5)", baglanti);
                            kmtKaydet.Parameters.AddWithValue("@i1", txtIsAd.Text);
                            kmtKaydet.Parameters.AddWithValue("@i2", txtIsTeklif.Text);
                            kmtKaydet.Parameters.AddWithValue("@i3", txtIsGun.Text);
                            kmtKaydet.Parameters.AddWithValue("@i4", ListBoxToText(lstbxIsIscilerListe));
                            kmtKaydet.Parameters.AddWithValue("@i5", ListBoxToText(lstbxIsMalzemelerListe));
                            kmtKaydet.ExecuteNonQuery();
                            baglanti.Close();
                            Listele();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gün [1-255] arasında bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Teklif [1-2147483647] arasında bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İş adı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guncelle()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            if (txtIsID.Text.Length != 0)
            {
                if (txtIsAd.Text.Length != 0)
                {
                    if (long.TryParse(txtIsTeklif.Text, out long teklif) && teklif > 0 && teklif < 2147483648)
                    {
                        if (int.TryParse(txtIsGun.Text, out int gun) && gun > 0 && gun < 256)
                        {
                            DialogResult result = MessageBox.Show(txtIsID.Text + " ID'li işin bilgilerini güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                baglanti.Open();
                                SqlCommand kmtSec = new SqlCommand("select * from tblIs where IsID=@s1", baglanti);
                                kmtSec.Parameters.AddWithValue("@s1", txtIsID.Text);
                                SqlDataReader dr = kmtSec.ExecuteReader();
                                if (dr.Read())
                                {
                                    baglanti.Close();
                                    baglanti.Open();
                                    SqlCommand kmtGuncelle = new SqlCommand("update tblIs set IsAd=@u1,IsTeklif=@u2,IsGun=@u3,IsIsciler=@u4,IsMalzemeler=@u5 where IsID=@u6", baglanti);
                                    kmtGuncelle.Parameters.AddWithValue("@u1", txtIsAd.Text);
                                    kmtGuncelle.Parameters.AddWithValue("@u2", txtIsTeklif.Text);
                                    kmtGuncelle.Parameters.AddWithValue("@u3", txtIsGun.Text);
                                    kmtGuncelle.Parameters.AddWithValue("@u4", ListBoxToText(lstbxIsIscilerListe));
                                    kmtGuncelle.Parameters.AddWithValue("@u5", ListBoxToText(lstbxIsMalzemelerListe));
                                    kmtGuncelle.Parameters.AddWithValue("@u6", txtIsID.Text);
                                    kmtGuncelle.ExecuteNonQuery();
                                    Listele();
                                }
                                else MessageBox.Show("İş ID veri tabanında bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                baglanti.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gun [1-255] arasında bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Teklif [1-2147483647] arasında bir sayı olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("İş adı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İş ID boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Temizle()
        {
            DialogResult result = MessageBox.Show("İş kayıt tablosundaki tüm verileri temizlemek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                txtIsAd.Text = "";
                txtIsID.Text = "";
                txtIsTeklif.Text = "";
                txtIsGun.Text = "";
                lstbxIsIscilerListe.Items.Clear();
                lstbxIsMalzemelerListe.Items.Clear();
            }
        }

        void Yenile(ListBox listbox, string s)
        {
            listbox.Items.Clear();
            StreamReader sr = new StreamReader(@"C:\TaseronOtomasyonu\Proje\db\" + s+".txt");
            while (!sr.EndOfStream)
            {
                listbox.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void FrmIsKaydet_Load(object sender, EventArgs e)
        {
            Listele();
        }
        
        private void txtIsAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || txtIsAd.Text.Length >= 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtIsTeklif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (long.TryParse(txtIsTeklif.Text + e.KeyChar, out long sayi))
            {
                if (sayi < 0 || sayi > 2147483647)
                {
                    MessageBox.Show("Lütfen [1-2147483647] arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    txtIsTeklif.Text = "";
                }
            }
        }

        private void txtIsGun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (int.TryParse(txtIsGun.Text + e.KeyChar, out int sayi))
            {
                if (sayi < 0 || sayi > 255)
                {
                    MessageBox.Show("Lütfen [1-255] arasında bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    txtIsGun.Text = "";
                }
            }
        }

        private void btnIsKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void btnIsSilForm_Click(object sender, EventArgs e)
        {
            FrmIsSil frmIsSil = new FrmIsSil();
            frmIsSil.ShowDialog();
            Listele();
        }

        private void btnIsGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle(); 
        }

        private void btnIsTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnIsMalzemelerForm_Click(object sender, EventArgs e)
        {
            FrmIsMalzemeler frmMalzemeler = new FrmIsMalzemeler();
            frmMalzemeler.ShowDialog();
            Listele();
        }
        
        private void btnIsIscilerForm_Click(object sender, EventArgs e)
        {
            FrmIsIsciler frmIsciler = new FrmIsIsciler();
            frmIsciler.ShowDialog();
            Listele();
        }

        private void btnIsMalzemelerListe_Click(object sender, EventArgs e)
        {
            Yenile(lstbxIsMalzemelerListe, "Malzemeler");
        }

        private void btnIsIscilerListe_Click(object sender, EventArgs e)
        {
            Yenile(lstbxIsIscilerListe, "Isciler2");
        }

        private void dtgrdIsKayitlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BilgiTasi();
        }

    }
}
