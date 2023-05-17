using TaseronOtomasyonu;
using TaseronOtomasyonu.TaseronDataSetTableAdapters;

namespace Proje
{
    partial class FrmIsciKaydet
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
            this.grpbxIsciKayitlar = new System.Windows.Forms.GroupBox();
            this.dtgrdIsciKayitlar = new System.Windows.Forms.DataGridView();
            this.ısciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısciIsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısciYevmiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIsciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taseronDataSet = new Proje.TaseronDataSet();
            this.grpbxIsciIslemler = new System.Windows.Forms.GroupBox();
            this.pnlIsciIslemler = new System.Windows.Forms.Panel();
            this.btnIsciSilForm = new System.Windows.Forms.Button();
            this.btnIsciKaydet = new System.Windows.Forms.Button();
            this.btnIsciGuncelle = new System.Windows.Forms.Button();
            this.btnIsciTemizle = new System.Windows.Forms.Button();
            this.grpbxIsciKayit = new System.Windows.Forms.GroupBox();
            this.txtIsciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblIsciTelefon = new System.Windows.Forms.Label();
            this.txtIsciTC = new System.Windows.Forms.MaskedTextBox();
            this.txtIsciIs = new System.Windows.Forms.TextBox();
            this.lblIsciIs = new System.Windows.Forms.Label();
            this.txtIsciSoyad = new System.Windows.Forms.TextBox();
            this.lblIsciSoyad = new System.Windows.Forms.Label();
            this.txtIsciYevmiye = new System.Windows.Forms.TextBox();
            this.lblIsciYevmiye = new System.Windows.Forms.Label();
            this.txtIsciAd = new System.Windows.Forms.TextBox();
            this.lblIsciAd = new System.Windows.Forms.Label();
            this.lblIsciTC = new System.Windows.Forms.Label();
            this.tblIsciTableAdapter = new Proje.TaseronDataSetTableAdapters.tblIsciTableAdapter();
            this.grpbxIsciKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdIsciKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet)).BeginInit();
            this.grpbxIsciIslemler.SuspendLayout();
            this.pnlIsciIslemler.SuspendLayout();
            this.grpbxIsciKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxIsciKayitlar
            // 
            this.grpbxIsciKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsciKayitlar.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsciKayitlar.Controls.Add(this.dtgrdIsciKayitlar);
            this.grpbxIsciKayitlar.Location = new System.Drawing.Point(12, 496);
            this.grpbxIsciKayitlar.Name = "grpbxIsciKayitlar";
            this.grpbxIsciKayitlar.Size = new System.Drawing.Size(1158, 245);
            this.grpbxIsciKayitlar.TabIndex = 8;
            this.grpbxIsciKayitlar.TabStop = false;
            this.grpbxIsciKayitlar.Text = "Kayıtlar";
            // 
            // dtgrdIsciKayitlar
            // 
            this.dtgrdIsciKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdIsciKayitlar.AutoGenerateColumns = false;
            this.dtgrdIsciKayitlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdIsciKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdIsciKayitlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ısciTCDataGridViewTextBoxColumn,
            this.ısciAdDataGridViewTextBoxColumn,
            this.ısciSoyadDataGridViewTextBoxColumn,
            this.ısciIsDataGridViewTextBoxColumn,
            this.ısciYevmiyeDataGridViewTextBoxColumn,
            this.ısciTelefonDataGridViewTextBoxColumn});
            this.dtgrdIsciKayitlar.DataSource = this.tblIsciBindingSource;
            this.dtgrdIsciKayitlar.Location = new System.Drawing.Point(6, 36);
            this.dtgrdIsciKayitlar.Name = "dtgrdIsciKayitlar";
            this.dtgrdIsciKayitlar.RowHeadersWidth = 30;
            this.dtgrdIsciKayitlar.RowTemplate.Height = 50;
            this.dtgrdIsciKayitlar.Size = new System.Drawing.Size(1146, 203);
            this.dtgrdIsciKayitlar.TabIndex = 3;
            this.dtgrdIsciKayitlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdIsciKayitlar_CellDoubleClick);
            // 
            // ısciTCDataGridViewTextBoxColumn
            // 
            this.ısciTCDataGridViewTextBoxColumn.DataPropertyName = "IsciTC";
            this.ısciTCDataGridViewTextBoxColumn.HeaderText = "IsciTC";
            this.ısciTCDataGridViewTextBoxColumn.Name = "ısciTCDataGridViewTextBoxColumn";
            // 
            // ısciAdDataGridViewTextBoxColumn
            // 
            this.ısciAdDataGridViewTextBoxColumn.DataPropertyName = "IsciAd";
            this.ısciAdDataGridViewTextBoxColumn.HeaderText = "IsciAd";
            this.ısciAdDataGridViewTextBoxColumn.Name = "ısciAdDataGridViewTextBoxColumn";
            // 
            // ısciSoyadDataGridViewTextBoxColumn
            // 
            this.ısciSoyadDataGridViewTextBoxColumn.DataPropertyName = "IsciSoyad";
            this.ısciSoyadDataGridViewTextBoxColumn.HeaderText = "IsciSoyad";
            this.ısciSoyadDataGridViewTextBoxColumn.Name = "ısciSoyadDataGridViewTextBoxColumn";
            // 
            // ısciIsDataGridViewTextBoxColumn
            // 
            this.ısciIsDataGridViewTextBoxColumn.DataPropertyName = "IsciIs";
            this.ısciIsDataGridViewTextBoxColumn.HeaderText = "IsciIs";
            this.ısciIsDataGridViewTextBoxColumn.Name = "ısciIsDataGridViewTextBoxColumn";
            // 
            // ısciYevmiyeDataGridViewTextBoxColumn
            // 
            this.ısciYevmiyeDataGridViewTextBoxColumn.DataPropertyName = "IsciYevmiye";
            this.ısciYevmiyeDataGridViewTextBoxColumn.HeaderText = "IsciYevmiye";
            this.ısciYevmiyeDataGridViewTextBoxColumn.Name = "ısciYevmiyeDataGridViewTextBoxColumn";
            // 
            // ısciTelefonDataGridViewTextBoxColumn
            // 
            this.ısciTelefonDataGridViewTextBoxColumn.DataPropertyName = "IsciTelefon";
            this.ısciTelefonDataGridViewTextBoxColumn.HeaderText = "IsciTelefon";
            this.ısciTelefonDataGridViewTextBoxColumn.Name = "ısciTelefonDataGridViewTextBoxColumn";
            // 
            // tblIsciBindingSource
            // 
            this.tblIsciBindingSource.DataMember = "tblIsci";
            this.tblIsciBindingSource.DataSource = this.taseronDataSet;
            // 
            // taseronDataSet
            // 
            this.taseronDataSet.DataSetName = "TaseronDataSet";
            this.taseronDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpbxIsciIslemler
            // 
            this.grpbxIsciIslemler.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsciIslemler.Controls.Add(this.pnlIsciIslemler);
            this.grpbxIsciIslemler.Location = new System.Drawing.Point(12, 12);
            this.grpbxIsciIslemler.Name = "grpbxIsciIslemler";
            this.grpbxIsciIslemler.Size = new System.Drawing.Size(272, 478);
            this.grpbxIsciIslemler.TabIndex = 7;
            this.grpbxIsciIslemler.TabStop = false;
            this.grpbxIsciIslemler.Text = "İşlemler";
            // 
            // pnlIsciIslemler
            // 
            this.pnlIsciIslemler.BackColor = System.Drawing.Color.DimGray;
            this.pnlIsciIslemler.Controls.Add(this.btnIsciSilForm);
            this.pnlIsciIslemler.Controls.Add(this.btnIsciKaydet);
            this.pnlIsciIslemler.Controls.Add(this.btnIsciGuncelle);
            this.pnlIsciIslemler.Controls.Add(this.btnIsciTemizle);
            this.pnlIsciIslemler.Location = new System.Drawing.Point(25, 39);
            this.pnlIsciIslemler.Name = "pnlIsciIslemler";
            this.pnlIsciIslemler.Size = new System.Drawing.Size(222, 408);
            this.pnlIsciIslemler.TabIndex = 20;
            this.pnlIsciIslemler.Tag = "";
            // 
            // btnIsciSilForm
            // 
            this.btnIsciSilForm.Location = new System.Drawing.Point(12, 129);
            this.btnIsciSilForm.Name = "btnIsciSilForm";
            this.btnIsciSilForm.Size = new System.Drawing.Size(198, 50);
            this.btnIsciSilForm.TabIndex = 8;
            this.btnIsciSilForm.Text = "Sil";
            this.btnIsciSilForm.UseVisualStyleBackColor = true;
            this.btnIsciSilForm.Click += new System.EventHandler(this.btnIsciSilForm_Click);
            // 
            // btnIsciKaydet
            // 
            this.btnIsciKaydet.Location = new System.Drawing.Point(12, 29);
            this.btnIsciKaydet.Name = "btnIsciKaydet";
            this.btnIsciKaydet.Size = new System.Drawing.Size(198, 50);
            this.btnIsciKaydet.TabIndex = 7;
            this.btnIsciKaydet.Text = "Kaydet";
            this.btnIsciKaydet.UseVisualStyleBackColor = true;
            this.btnIsciKaydet.Click += new System.EventHandler(this.btnIsciKaydet_Click);
            // 
            // btnIsciGuncelle
            // 
            this.btnIsciGuncelle.Location = new System.Drawing.Point(12, 229);
            this.btnIsciGuncelle.Name = "btnIsciGuncelle";
            this.btnIsciGuncelle.Size = new System.Drawing.Size(198, 50);
            this.btnIsciGuncelle.TabIndex = 9;
            this.btnIsciGuncelle.Text = "Güncelle";
            this.btnIsciGuncelle.UseVisualStyleBackColor = true;
            this.btnIsciGuncelle.Click += new System.EventHandler(this.btnIsciGuncelle_Click);
            // 
            // btnIsciTemizle
            // 
            this.btnIsciTemizle.Location = new System.Drawing.Point(12, 329);
            this.btnIsciTemizle.Name = "btnIsciTemizle";
            this.btnIsciTemizle.Size = new System.Drawing.Size(198, 50);
            this.btnIsciTemizle.TabIndex = 10;
            this.btnIsciTemizle.Text = "Temizle";
            this.btnIsciTemizle.UseVisualStyleBackColor = true;
            this.btnIsciTemizle.Click += new System.EventHandler(this.btnIsciTemizle_Click);
            // 
            // grpbxIsciKayit
            // 
            this.grpbxIsciKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsciKayit.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsciKayit.Controls.Add(this.txtIsciTelefon);
            this.grpbxIsciKayit.Controls.Add(this.lblIsciTelefon);
            this.grpbxIsciKayit.Controls.Add(this.txtIsciTC);
            this.grpbxIsciKayit.Controls.Add(this.txtIsciIs);
            this.grpbxIsciKayit.Controls.Add(this.lblIsciIs);
            this.grpbxIsciKayit.Controls.Add(this.txtIsciSoyad);
            this.grpbxIsciKayit.Controls.Add(this.lblIsciSoyad);
            this.grpbxIsciKayit.Controls.Add(this.txtIsciYevmiye);
            this.grpbxIsciKayit.Controls.Add(this.lblIsciYevmiye);
            this.grpbxIsciKayit.Controls.Add(this.txtIsciAd);
            this.grpbxIsciKayit.Controls.Add(this.lblIsciAd);
            this.grpbxIsciKayit.Controls.Add(this.lblIsciTC);
            this.grpbxIsciKayit.Location = new System.Drawing.Point(290, 12);
            this.grpbxIsciKayit.Name = "grpbxIsciKayit";
            this.grpbxIsciKayit.Size = new System.Drawing.Size(880, 478);
            this.grpbxIsciKayit.TabIndex = 6;
            this.grpbxIsciKayit.TabStop = false;
            this.grpbxIsciKayit.Text = "İşçi Kayıt";
            // 
            // txtIsciTelefon
            // 
            this.txtIsciTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsciTelefon.BackColor = System.Drawing.Color.Silver;
            this.txtIsciTelefon.Location = new System.Drawing.Point(182, 399);
            this.txtIsciTelefon.Mask = "(999) 000-0000";
            this.txtIsciTelefon.Name = "txtIsciTelefon";
            this.txtIsciTelefon.Size = new System.Drawing.Size(621, 40);
            this.txtIsciTelefon.TabIndex = 5;
            // 
            // lblIsciTelefon
            // 
            this.lblIsciTelefon.Location = new System.Drawing.Point(19, 402);
            this.lblIsciTelefon.Name = "lblIsciTelefon";
            this.lblIsciTelefon.Size = new System.Drawing.Size(157, 35);
            this.lblIsciTelefon.TabIndex = 12;
            this.lblIsciTelefon.Text = "İşçi Telefon :";
            // 
            // txtIsciTC
            // 
            this.txtIsciTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsciTC.BackColor = System.Drawing.Color.Silver;
            this.txtIsciTC.Location = new System.Drawing.Point(182, 74);
            this.txtIsciTC.Mask = "00000000000";
            this.txtIsciTC.Name = "txtIsciTC";
            this.txtIsciTC.Size = new System.Drawing.Size(621, 40);
            this.txtIsciTC.TabIndex = 0;
            this.txtIsciTC.ValidatingType = typeof(int);
            // 
            // txtIsciIs
            // 
            this.txtIsciIs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsciIs.BackColor = System.Drawing.Color.Silver;
            this.txtIsciIs.Location = new System.Drawing.Point(182, 269);
            this.txtIsciIs.Name = "txtIsciIs";
            this.txtIsciIs.Size = new System.Drawing.Size(621, 40);
            this.txtIsciIs.TabIndex = 3;
            this.txtIsciIs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsciIs_KeyPress);
            // 
            // lblIsciIs
            // 
            this.lblIsciIs.Location = new System.Drawing.Point(82, 272);
            this.lblIsciIs.Name = "lblIsciIs";
            this.lblIsciIs.Size = new System.Drawing.Size(94, 35);
            this.lblIsciIs.TabIndex = 9;
            this.lblIsciIs.Text = "İşçi İş :";
            // 
            // txtIsciSoyad
            // 
            this.txtIsciSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsciSoyad.BackColor = System.Drawing.Color.Silver;
            this.txtIsciSoyad.Location = new System.Drawing.Point(182, 204);
            this.txtIsciSoyad.Name = "txtIsciSoyad";
            this.txtIsciSoyad.Size = new System.Drawing.Size(621, 40);
            this.txtIsciSoyad.TabIndex = 2;
            this.txtIsciSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsciSoyad_KeyPress);
            // 
            // lblIsciSoyad
            // 
            this.lblIsciSoyad.Location = new System.Drawing.Point(34, 207);
            this.lblIsciSoyad.Name = "lblIsciSoyad";
            this.lblIsciSoyad.Size = new System.Drawing.Size(142, 35);
            this.lblIsciSoyad.TabIndex = 6;
            this.lblIsciSoyad.Text = "İşçi Soyad :";
            // 
            // txtIsciYevmiye
            // 
            this.txtIsciYevmiye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsciYevmiye.BackColor = System.Drawing.Color.Silver;
            this.txtIsciYevmiye.Location = new System.Drawing.Point(182, 334);
            this.txtIsciYevmiye.Name = "txtIsciYevmiye";
            this.txtIsciYevmiye.Size = new System.Drawing.Size(621, 40);
            this.txtIsciYevmiye.TabIndex = 4;
            this.txtIsciYevmiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsciYevmiye_KeyPress);
            // 
            // lblIsciYevmiye
            // 
            this.lblIsciYevmiye.Location = new System.Drawing.Point(19, 337);
            this.lblIsciYevmiye.Name = "lblIsciYevmiye";
            this.lblIsciYevmiye.Size = new System.Drawing.Size(170, 35);
            this.lblIsciYevmiye.TabIndex = 4;
            this.lblIsciYevmiye.Text = "İşçi Yevmiye :";
            // 
            // txtIsciAd
            // 
            this.txtIsciAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsciAd.BackColor = System.Drawing.Color.Silver;
            this.txtIsciAd.Location = new System.Drawing.Point(182, 139);
            this.txtIsciAd.Name = "txtIsciAd";
            this.txtIsciAd.Size = new System.Drawing.Size(621, 40);
            this.txtIsciAd.TabIndex = 1;
            this.txtIsciAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsciAd_KeyPress);
            // 
            // lblIsciAd
            // 
            this.lblIsciAd.Location = new System.Drawing.Point(66, 142);
            this.lblIsciAd.Name = "lblIsciAd";
            this.lblIsciAd.Size = new System.Drawing.Size(110, 35);
            this.lblIsciAd.TabIndex = 2;
            this.lblIsciAd.Text = "İşçi Ad :";
            // 
            // lblIsciTC
            // 
            this.lblIsciTC.Location = new System.Drawing.Point(75, 77);
            this.lblIsciTC.Name = "lblIsciTC";
            this.lblIsciTC.Size = new System.Drawing.Size(101, 35);
            this.lblIsciTC.TabIndex = 0;
            this.lblIsciTC.Text = "İşçi TC :";
            // 
            // tblIsciTableAdapter
            // 
            this.tblIsciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIsciKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.grpbxIsciKayitlar);
            this.Controls.Add(this.grpbxIsciIslemler);
            this.Controls.Add(this.grpbxIsciKayit);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmIsciKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşçi";
            this.Load += new System.EventHandler(this.FrmIsciKaydet_Load);
            this.grpbxIsciKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdIsciKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet)).EndInit();
            this.grpbxIsciIslemler.ResumeLayout(false);
            this.pnlIsciIslemler.ResumeLayout(false);
            this.grpbxIsciKayit.ResumeLayout(false);
            this.grpbxIsciKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxIsciKayitlar;
        private System.Windows.Forms.DataGridView dtgrdIsciKayitlar;
        private System.Windows.Forms.GroupBox grpbxIsciIslemler;
        private System.Windows.Forms.Button btnIsciSilForm;
        private System.Windows.Forms.Button btnIsciGuncelle;
        private System.Windows.Forms.Button btnIsciTemizle;
        private System.Windows.Forms.Button btnIsciKaydet;
        private System.Windows.Forms.GroupBox grpbxIsciKayit;
        private System.Windows.Forms.TextBox txtIsciYevmiye;
        private System.Windows.Forms.Label lblIsciYevmiye;
        private System.Windows.Forms.TextBox txtIsciAd;
        private System.Windows.Forms.Label lblIsciAd;
        private System.Windows.Forms.Label lblIsciTC;
        private System.Windows.Forms.TextBox txtIsciSoyad;
        private System.Windows.Forms.Label lblIsciSoyad;
        private System.Windows.Forms.TextBox txtIsciIs;
        private System.Windows.Forms.Label lblIsciIs;
        private System.Windows.Forms.MaskedTextBox txtIsciTelefon;
        private System.Windows.Forms.Label lblIsciTelefon;
        private System.Windows.Forms.MaskedTextBox txtIsciTC;
        private TaseronOtomasyonu.TaseronDataSet taseronDataSet;
        private System.Windows.Forms.BindingSource tblIsciBindingSource;
        private TaseronOtomasyonu.TaseronDataSetTableAdapters.tblIsciTableAdapter tblIsciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısciTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısciIsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısciYevmiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısciTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlIsciIslemler;
    }

    internal class TaseronDataSetTableAdapters
    {
        internal class tblIsciTableAdapter : TaseronOtomasyonu.TaseronDataSetTableAdapters.tblIsciTableAdapter
        {
        }
    }

    internal class TaseronDataSet : TaseronOtomasyonu.TaseronDataSet
    {
    }
}