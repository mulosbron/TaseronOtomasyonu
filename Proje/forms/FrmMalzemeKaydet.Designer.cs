using TaseronOtomasyonu;
using TaseronOtomasyonu.TaseronDataSet1TableAdapters;

namespace Proje
{
    partial class FrmMalzemeKaydet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMalzemeKaydet));
            this.grpbxMalKayitlar = new System.Windows.Forms.GroupBox();
            this.dtgrdMalKayitlar = new System.Windows.Forms.DataGridView();
            this.malzemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeBirimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taseronDataSet1 = new Proje.TaseronDataSet1();
            this.grpbxMalKayit = new System.Windows.Forms.GroupBox();
            this.txtMalBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblMalBirimFiyat = new System.Windows.Forms.Label();
            this.txtMalAd = new System.Windows.Forms.TextBox();
            this.lblMalAd = new System.Windows.Forms.Label();
            this.txtMalID = new System.Windows.Forms.TextBox();
            this.lblMalID = new System.Windows.Forms.Label();
            this.btnMalSil = new System.Windows.Forms.Button();
            this.btnMalGuncelle = new System.Windows.Forms.Button();
            this.btnMalTemizle = new System.Windows.Forms.Button();
            this.btnMalKaydet = new System.Windows.Forms.Button();
            this.grpbxMalIslemler = new System.Windows.Forms.GroupBox();
            this.pnlMalIslemler = new System.Windows.Forms.Panel();
            this.tblMalzemeTableAdapter = new Proje.tblMalzemeTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grpbxMalKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdMalKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet1)).BeginInit();
            this.grpbxMalKayit.SuspendLayout();
            this.grpbxMalIslemler.SuspendLayout();
            this.pnlMalIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxMalKayitlar
            // 
            this.grpbxMalKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxMalKayitlar.BackColor = System.Drawing.Color.Gray;
            this.grpbxMalKayitlar.Controls.Add(this.dtgrdMalKayitlar);
            this.grpbxMalKayitlar.Location = new System.Drawing.Point(12, 496);
            this.grpbxMalKayitlar.Name = "grpbxMalKayitlar";
            this.grpbxMalKayitlar.Size = new System.Drawing.Size(1158, 245);
            this.grpbxMalKayitlar.TabIndex = 11;
            this.grpbxMalKayitlar.TabStop = false;
            this.grpbxMalKayitlar.Text = "Kayıtlar";
            // 
            // dtgrdMalKayitlar
            // 
            this.dtgrdMalKayitlar.AutoGenerateColumns = false;
            this.dtgrdMalKayitlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdMalKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdMalKayitlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeIDDataGridViewTextBoxColumn,
            this.malzemeAdDataGridViewTextBoxColumn,
            this.malzemeBirimFiyatDataGridViewTextBoxColumn});
            this.dtgrdMalKayitlar.DataSource = this.tblMalzemeBindingSource;
            this.dtgrdMalKayitlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdMalKayitlar.Location = new System.Drawing.Point(3, 36);
            this.dtgrdMalKayitlar.Name = "dtgrdMalKayitlar";
            this.dtgrdMalKayitlar.RowHeadersWidth = 30;
            this.dtgrdMalKayitlar.RowTemplate.Height = 50;
            this.dtgrdMalKayitlar.Size = new System.Drawing.Size(1152, 206);
            this.dtgrdMalKayitlar.TabIndex = 4;
            this.dtgrdMalKayitlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdMalKayitlar_CellDoubleClick);
            // 
            // malzemeIDDataGridViewTextBoxColumn
            // 
            this.malzemeIDDataGridViewTextBoxColumn.DataPropertyName = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            this.malzemeIDDataGridViewTextBoxColumn.HeaderText = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.Name = "malzemeIDDataGridViewTextBoxColumn";
            this.malzemeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemeAdDataGridViewTextBoxColumn
            // 
            this.malzemeAdDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAd";
            this.malzemeAdDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.malzemeAdDataGridViewTextBoxColumn.HeaderText = "MalzemeAd";
            this.malzemeAdDataGridViewTextBoxColumn.Name = "malzemeAdDataGridViewTextBoxColumn";
            // 
            // malzemeBirimFiyatDataGridViewTextBoxColumn
            // 
            this.malzemeBirimFiyatDataGridViewTextBoxColumn.DataPropertyName = "MalzemeBirimFiyat";
            this.malzemeBirimFiyatDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.malzemeBirimFiyatDataGridViewTextBoxColumn.HeaderText = "MalzemeBirimFiyat";
            this.malzemeBirimFiyatDataGridViewTextBoxColumn.Name = "malzemeBirimFiyatDataGridViewTextBoxColumn";
            // 
            // tblMalzemeBindingSource
            // 
            this.tblMalzemeBindingSource.DataMember = "tblMalzeme";
            this.tblMalzemeBindingSource.DataSource = this.taseronDataSet1;
            // 
            // taseronDataSet1
            // 
            this.taseronDataSet1.DataSetName = "TaseronDataSet1";
            this.taseronDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpbxMalKayit
            // 
            this.grpbxMalKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxMalKayit.BackColor = System.Drawing.Color.Gray;
            this.grpbxMalKayit.Controls.Add(this.pictureBox3);
            this.grpbxMalKayit.Controls.Add(this.pictureBox2);
            this.grpbxMalKayit.Controls.Add(this.pictureBox1);
            this.grpbxMalKayit.Controls.Add(this.txtMalBirimFiyat);
            this.grpbxMalKayit.Controls.Add(this.lblMalBirimFiyat);
            this.grpbxMalKayit.Controls.Add(this.txtMalAd);
            this.grpbxMalKayit.Controls.Add(this.lblMalAd);
            this.grpbxMalKayit.Controls.Add(this.txtMalID);
            this.grpbxMalKayit.Controls.Add(this.lblMalID);
            this.grpbxMalKayit.Location = new System.Drawing.Point(290, 12);
            this.grpbxMalKayit.Name = "grpbxMalKayit";
            this.grpbxMalKayit.Size = new System.Drawing.Size(880, 478);
            this.grpbxMalKayit.TabIndex = 9;
            this.grpbxMalKayit.TabStop = false;
            this.grpbxMalKayit.Text = "Malzeme Kayıt";
            // 
            // txtMalBirimFiyat
            // 
            this.txtMalBirimFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalBirimFiyat.BackColor = System.Drawing.Color.Silver;
            this.txtMalBirimFiyat.Location = new System.Drawing.Point(295, 204);
            this.txtMalBirimFiyat.Name = "txtMalBirimFiyat";
            this.txtMalBirimFiyat.Size = new System.Drawing.Size(530, 40);
            this.txtMalBirimFiyat.TabIndex = 5;
            this.txtMalBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMalBirimFiyat_KeyPress);
            // 
            // lblMalBirimFiyat
            // 
            this.lblMalBirimFiyat.AutoSize = true;
            this.lblMalBirimFiyat.Location = new System.Drawing.Point(16, 207);
            this.lblMalBirimFiyat.Name = "lblMalBirimFiyat";
            this.lblMalBirimFiyat.Size = new System.Drawing.Size(304, 35);
            this.lblMalBirimFiyat.TabIndex = 4;
            this.lblMalBirimFiyat.Text = "Malzeme Birim Fiyatı(₺) :";
            // 
            // txtMalAd
            // 
            this.txtMalAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalAd.BackColor = System.Drawing.Color.Silver;
            this.txtMalAd.Location = new System.Drawing.Point(295, 139);
            this.txtMalAd.Name = "txtMalAd";
            this.txtMalAd.Size = new System.Drawing.Size(530, 40);
            this.txtMalAd.TabIndex = 3;
            this.txtMalAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMalAd_KeyPress);
            // 
            // lblMalAd
            // 
            this.lblMalAd.AutoSize = true;
            this.lblMalAd.Location = new System.Drawing.Point(109, 142);
            this.lblMalAd.Name = "lblMalAd";
            this.lblMalAd.Size = new System.Drawing.Size(180, 35);
            this.lblMalAd.TabIndex = 2;
            this.lblMalAd.Text = "Malzeme Adı :";
            // 
            // txtMalID
            // 
            this.txtMalID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalID.BackColor = System.Drawing.Color.Silver;
            this.txtMalID.Enabled = false;
            this.txtMalID.Location = new System.Drawing.Point(295, 74);
            this.txtMalID.Name = "txtMalID";
            this.txtMalID.Size = new System.Drawing.Size(530, 40);
            this.txtMalID.TabIndex = 1;
            // 
            // lblMalID
            // 
            this.lblMalID.AutoSize = true;
            this.lblMalID.Location = new System.Drawing.Point(122, 77);
            this.lblMalID.Name = "lblMalID";
            this.lblMalID.Size = new System.Drawing.Size(167, 35);
            this.lblMalID.TabIndex = 0;
            this.lblMalID.Text = "Malzeme ID :";
            // 
            // btnMalSil
            // 
            this.btnMalSil.Location = new System.Drawing.Point(12, 129);
            this.btnMalSil.Name = "btnMalSil";
            this.btnMalSil.Size = new System.Drawing.Size(198, 50);
            this.btnMalSil.TabIndex = 8;
            this.btnMalSil.Text = "Sil";
            this.btnMalSil.UseVisualStyleBackColor = true;
            this.btnMalSil.Click += new System.EventHandler(this.btnMalSilForm_Click);
            // 
            // btnMalGuncelle
            // 
            this.btnMalGuncelle.Location = new System.Drawing.Point(12, 229);
            this.btnMalGuncelle.Name = "btnMalGuncelle";
            this.btnMalGuncelle.Size = new System.Drawing.Size(198, 50);
            this.btnMalGuncelle.TabIndex = 9;
            this.btnMalGuncelle.Text = "Güncelle";
            this.btnMalGuncelle.UseVisualStyleBackColor = true;
            this.btnMalGuncelle.Click += new System.EventHandler(this.btnMalGuncelle_Click);
            // 
            // btnMalTemizle
            // 
            this.btnMalTemizle.Location = new System.Drawing.Point(12, 329);
            this.btnMalTemizle.Name = "btnMalTemizle";
            this.btnMalTemizle.Size = new System.Drawing.Size(198, 50);
            this.btnMalTemizle.TabIndex = 10;
            this.btnMalTemizle.Text = "Temizle";
            this.btnMalTemizle.UseVisualStyleBackColor = true;
            this.btnMalTemizle.Click += new System.EventHandler(this.btnMalTemizle_Click);
            // 
            // btnMalKaydet
            // 
            this.btnMalKaydet.Location = new System.Drawing.Point(12, 29);
            this.btnMalKaydet.Name = "btnMalKaydet";
            this.btnMalKaydet.Size = new System.Drawing.Size(198, 50);
            this.btnMalKaydet.TabIndex = 7;
            this.btnMalKaydet.Text = "Kaydet";
            this.btnMalKaydet.UseVisualStyleBackColor = true;
            this.btnMalKaydet.Click += new System.EventHandler(this.btnMalKaydet_Click);
            // 
            // grpbxMalIslemler
            // 
            this.grpbxMalIslemler.BackColor = System.Drawing.Color.Gray;
            this.grpbxMalIslemler.Controls.Add(this.pnlMalIslemler);
            this.grpbxMalIslemler.Location = new System.Drawing.Point(12, 12);
            this.grpbxMalIslemler.Name = "grpbxMalIslemler";
            this.grpbxMalIslemler.Size = new System.Drawing.Size(272, 478);
            this.grpbxMalIslemler.TabIndex = 12;
            this.grpbxMalIslemler.TabStop = false;
            this.grpbxMalIslemler.Text = "İşlemler";
            // 
            // pnlMalIslemler
            // 
            this.pnlMalIslemler.BackColor = System.Drawing.Color.DimGray;
            this.pnlMalIslemler.Controls.Add(this.btnMalSil);
            this.pnlMalIslemler.Controls.Add(this.btnMalKaydet);
            this.pnlMalIslemler.Controls.Add(this.btnMalTemizle);
            this.pnlMalIslemler.Controls.Add(this.btnMalGuncelle);
            this.pnlMalIslemler.Location = new System.Drawing.Point(25, 39);
            this.pnlMalIslemler.Name = "pnlMalIslemler";
            this.pnlMalIslemler.Size = new System.Drawing.Size(222, 408);
            this.pnlMalIslemler.TabIndex = 21;
            this.pnlMalIslemler.Tag = "";
            // 
            // tblMalzemeTableAdapter
            // 
            this.tblMalzemeTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(654, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMalzemeKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.grpbxMalIslemler);
            this.Controls.Add(this.grpbxMalKayitlar);
            this.Controls.Add(this.grpbxMalKayit);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmMalzemeKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme";
            this.Load += new System.EventHandler(this.FrmMalzemeKaydet_Load);
            this.grpbxMalKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdMalKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet1)).EndInit();
            this.grpbxMalKayit.ResumeLayout(false);
            this.grpbxMalKayit.PerformLayout();
            this.grpbxMalIslemler.ResumeLayout(false);
            this.pnlMalIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxMalKayitlar;
        private System.Windows.Forms.GroupBox grpbxMalKayit;
        private System.Windows.Forms.TextBox txtMalBirimFiyat;
        private System.Windows.Forms.Label lblMalBirimFiyat;
        private System.Windows.Forms.TextBox txtMalAd;
        private System.Windows.Forms.Label lblMalAd;
        private System.Windows.Forms.TextBox txtMalID;
        private System.Windows.Forms.Label lblMalID;
        private System.Windows.Forms.Button btnMalSil;
        private System.Windows.Forms.Button btnMalGuncelle;
        private System.Windows.Forms.Button btnMalTemizle;
        private System.Windows.Forms.Button btnMalKaydet;
        private System.Windows.Forms.GroupBox grpbxMalIslemler;
        private TaseronOtomasyonu.TaseronDataSet1 taseronDataSet1;
        private System.Windows.Forms.BindingSource tblMalzemeBindingSource;
        private TaseronOtomasyonu.TaseronDataSet1TableAdapters.tblMalzemeTableAdapter tblMalzemeTableAdapter;
        private System.Windows.Forms.DataGridView dtgrdMalKayitlar;
        private System.Windows.Forms.Panel pnlMalIslemler;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeBirimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

    internal class TaseronDataSet1 : TaseronOtomasyonu.TaseronDataSet1
    {
    }

    internal class tblMalzemeTableAdapter : TaseronOtomasyonu.TaseronDataSet1TableAdapters.tblMalzemeTableAdapter
    {
    }
}

