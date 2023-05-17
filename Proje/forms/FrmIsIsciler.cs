using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proje
{
    public partial class FrmIsIsciler : Form
    {
        BaglantiSinif bglt = new BaglantiSinif();

        public FrmIsIsciler()
        {
            InitializeComponent();
        }

        private void FrmIsIsciler_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bglt.Adres);
            baglanti.Open();
            SqlCommand kmtSec = new SqlCommand("select * from tblIsci", baglanti);
            SqlDataReader yazdir = kmtSec.ExecuteReader();
            StreamWriter swIsciler1 = new StreamWriter(@"C:\TaseronOtomasyonu\Proje\db\Isciler1.txt");
            while (yazdir.Read())
            {
                swIsciler1.WriteLine(yazdir["IsciAd"] + "_" + yazdir["IsciIs"] + "-" + yazdir["IsciTC"]);
            }
            swIsciler1.Close();
            StreamReader srIsciler1 = new StreamReader(@"C:\TaseronOtomasyonu\Proje\db\Isciler1.txt");
            while (!srIsciler1.EndOfStream)
            {
                lstbxDBIsciler.Items.Add(srIsciler1.ReadLine());
            }
            srIsciler1.Close();
            baglanti.Close();
        }

        private void btnIsIscilerBirdenIkiye_Click(object sender, EventArgs e)
        {
            if (lstbxDBIsciler.SelectedItems.Count > 0)
            {
                lstbxIsIsciler.Items.Add(lstbxDBIsciler.SelectedItem);
                lstbxDBIsciler.Items.Remove(lstbxDBIsciler.SelectedItem);
            }
        }

        private void btnIsIscilerIkidenBire_Click(object sender, EventArgs e)
        {
            if (lstbxIsIsciler.SelectedItems.Count > 0)
            {
                lstbxDBIsciler.Items.Add(lstbxIsIsciler.SelectedItem);
                lstbxIsIsciler.Items.Remove(lstbxIsIsciler.SelectedItem);
            }
        }

        private void btnIsIscilerKaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Listeyi kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StreamWriter swIsciler2 = new StreamWriter(@"C:\TaseronOtomasyonu\Proje\db\Isciler2.txt");
                foreach (var item in lstbxIsIsciler.Items)
                {
                    swIsciler2.WriteLine(item.ToString());
                }
                swIsciler2.Close();
                this.Close();
            }
        }

    }
}
