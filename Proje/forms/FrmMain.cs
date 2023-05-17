using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Proje
{
    public partial class FrmMain : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmMain()
        {
            InitializeComponent();
        }
        
        void DBIsID()
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            cmbbxMainIsID.Items.Clear();
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select IsID from tblIs", baglanti);
            SqlDataReader okuyucu = kmt.ExecuteReader();
            while (okuyucu.Read())
            {
                cmbbxMainIsID.Items.Add(okuyucu.GetInt32(0));
            }
            okuyucu.Close();
            baglanti.Close();
        }
        
        void Goster(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) =>
            {
                form.Dispose();
                form = new FrmMalzemeKaydet();
                Yenile();
                this.Show();
            };
            form.ShowDialog();
        }
        
        long IsciMaliyet(int id)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            List<string> listIsciler = new List<string>();
            List<string> listKimlikler = new List<string>();
            List<int> listYevmiyeler = new List<int>();
            byte? gun = null;
            long toplam = 0;
            int ID = id;
            baglanti.Open();
            SqlCommand kmtSec = new SqlCommand("select IsIsciler from tblIs where IsID = @s1", baglanti);
            kmtSec.Parameters.AddWithValue("@s1", ID);
            SqlDataReader okuyucu = kmtSec.ExecuteReader();
            while (okuyucu.Read())
            {
                string isIsciler = okuyucu.GetString(0);
                listIsciler.AddRange(isIsciler.Split(';'));
            }
            okuyucu.Close();
            listIsciler.RemoveAt(listIsciler.Count - 1);
            foreach (string isci in listIsciler)
            {
                listKimlikler.Add(isci.Split('-')[1]);
            }
            foreach (string kimlik in listKimlikler)
            {
                SqlCommand kmtSec2 = new SqlCommand("select IsciYevmiye from tblIsci where IsciTC = @s1", baglanti);
                kmtSec2.Parameters.AddWithValue("@s1", kimlik);
                SqlDataReader okuyucu2 = kmtSec2.ExecuteReader();
                while (okuyucu2.Read())
                {
                    listYevmiyeler.Add(okuyucu2.GetInt16(0));
                }
                okuyucu2.Close();
            }
            SqlCommand kmtSec3 = new SqlCommand("select IsGun from tblIs where IsID = @s1", baglanti);
            kmtSec3.Parameters.AddWithValue("@s1", ID);
            SqlDataReader okuyucu3 = kmtSec3.ExecuteReader();
            while (okuyucu3.Read())
            {
                gun = okuyucu3.GetByte(0);
            }
            okuyucu3.Close();
            foreach (int yevmiye in listYevmiyeler)
            {
                toplam += yevmiye * (byte)gun;
            }
            baglanti.Close();
            return toplam;
        }
        
        long MalzemeMaliyet(int id)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            List<string> listMalzemeler = new List<string>();
            List<string> listMalzemeMiktar = new List<string>();
            List<string> listMalzeme = new List<string>();
            List<int> listMiktar = new List<int>();
            List<int> listMalzemeBirimFiyat = new List<int>();
            long toplam = 0;
            int ID = id;
            baglanti.Open();
            SqlCommand kmtSec = new SqlCommand("select IsMalzemeler from tblIs where IsID = @s1", baglanti);
            kmtSec.Parameters.AddWithValue("@s1", ID);
            SqlDataReader okuyucu = kmtSec.ExecuteReader();
            if (okuyucu.Read())
            {
                string isMalzemeler = okuyucu.GetString(0);
                listMalzemeler.AddRange(isMalzemeler.Split(';'));
            }
            okuyucu.Close();
            foreach (string malzeme in listMalzemeler)
            {
                listMalzemeMiktar.Add(malzeme);
            }
            listMalzemeMiktar.RemoveAt(listMalzemeMiktar.Count - 1);
            foreach (string miktar in listMalzemeMiktar)
            {
                string[] parcalar = miktar.Split('-');
                listMiktar.Add(int.Parse(parcalar[1]));
                listMalzeme.Add(parcalar[0]);
            }
            foreach (string malzeme in listMalzeme)
            {
                SqlCommand kmtSec2 = new SqlCommand("select MalzemeBirimFiyat from tblMalzeme where MalzemeAd = @s1", baglanti);
                kmtSec2.Parameters.AddWithValue("@s1", malzeme);
                SqlDataReader okuyucu2 = kmtSec2.ExecuteReader();
                while (okuyucu2.Read())
                {
                    listMalzemeBirimFiyat.Add(okuyucu2.GetInt32(0));
                }
                okuyucu2.Close();
            }
            for(int i=0; i < listMalzemeBirimFiyat.Count; i++)
            {
                toplam += listMalzemeBirimFiyat[i] * listMiktar[i];
            }
            baglanti.Close();
            return toplam;
        }

        long Teklif(int id)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            int ID = id;
            long teklif = 0;
            baglanti.Open();
            SqlCommand kmtSec = new SqlCommand("select IsTeklif from tblIs where IsID = @s1", baglanti);
            kmtSec.Parameters.AddWithValue("@s1", ID);
            SqlDataReader okuyucu = kmtSec.ExecuteReader();
            if (okuyucu.Read())
            {
                teklif = okuyucu.GetInt32(0);
            }
            okuyucu.Close();
            baglanti.Close();
            return teklif;
        }

        string MaliyetHesaplaString(string s)
        {
            if (int.TryParse(s, out int i))
            {
                return (Teklif(i) - (MalzemeMaliyet(i) + IsciMaliyet(i))).ToString();
            }
            else return "0";
        }

        void Sayi(Label label, string tablo)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            baglanti.Open();
            SqlCommand kmtSay = new SqlCommand("select count(*) from " + tablo, baglanti);
            int say = (int)kmtSay.ExecuteScalar();
            label.Text = say.ToString();
            baglanti.Close();
        }

        void Yenile()
        {
            DBIsID();
            Sayi(lblMainIslerSayi, "tblIs");
            Sayi(lblMainIscilerSayi, "tblIsci");
            Sayi(lblMainMalzemelerSayi, "tblMalzeme");
            lblMainKarSayi.Text = MaliyetHesaplaString(cmbbxMainIsID.Text);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnMainMalzemeForm_Click(object sender, EventArgs e)
        {
            FrmMalzemeKaydet frmMalzemeKaydet = new FrmMalzemeKaydet();
            Goster(frmMalzemeKaydet);
        }

        private void btnMainIsciForm_Click(object sender, EventArgs e)
        {
            FrmIsciKaydet frmIsciKaydet = new FrmIsciKaydet();
            Goster(frmIsciKaydet);
        }

        private void btnMainIsForm_Click(object sender, EventArgs e)
        {
            FrmIsKaydet frmIsKaydet = new FrmIsKaydet();
            Goster(frmIsKaydet);
        }

        private void cmbbxMainIsID_TextChanged(object sender, EventArgs e)
        {
            lblMainKarSayi.Text = MaliyetHesaplaString(cmbbxMainIsID.Text);
        }
    }
}
