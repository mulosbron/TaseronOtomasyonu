using System;
using System.Windows.Forms;
using System.IO;

namespace Proje
{
    public partial class FrmIsMalzemeler : Form
    {
        public FrmIsMalzemeler()
        {
            InitializeComponent();
        }
        
        private void FrmIsMalzemeler_Load(object sender, EventArgs e)
        {
            this.tblMalzemeTableAdapter.Fill(this.taseronDataSet4.tblMalzeme);
            StreamReader sr = new StreamReader(@"C:\TaseronOtomasyonu\Proje\db\Malzemeler.txt");
            while (!sr.EndOfStream)
            {
                lstbxIsMalzemeler.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void txtIsMalzeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIsMalzemelerEkle_Click(object sender, EventArgs e)
        {
            if (txtIsMalzemeler.Text == "") MessageBox.Show("Adet sayısı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else lstbxIsMalzemeler.Items.Add(cmbbxIsMalzemeler.Text+"-"+txtIsMalzemeler.Text);
        }

        private void btnIsMalzemelerCikar_Click(object sender, EventArgs e)
        {
            if (lstbxIsMalzemeler.SelectedItems.Count > 0) lstbxIsMalzemeler.Items.RemoveAt(lstbxIsMalzemeler.SelectedIndex);
        }
        
        private void btnIsMalzemelerKaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Malzemeler listesini kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StreamWriter sw = new StreamWriter(@"C:\TaseronOtomasyonu\Proje\db\Malzemeler.txt");
                foreach (var item in lstbxIsMalzemeler.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                this.Close();
            }
        }

        private void btnIsMalzemelerTemizleVeKaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Listeyi temizleyip kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(@"C:\TaseronOtomasyonu\Proje\db\Malzemeler.txt", "");
                this.Close();
            }
        }
    }
}
