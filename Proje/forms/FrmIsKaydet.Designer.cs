using TaseronOtomasyonu;
using TaseronOtomasyonu.TaseronDataSet3TableAdapters;

namespace Proje
{
    partial class FrmIsKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIsKaydet));
            this.grpbxIsKayitlar = new System.Windows.Forms.GroupBox();
            this.dtgrdIsKayitlar = new System.Windows.Forms.DataGridView();
            this.ısIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısTeklifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısIscilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısMalzemelerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taseronDataSet3 = new Proje.TaseronDataSet3();
            this.grpbxIsIslemler = new System.Windows.Forms.GroupBox();
            this.pnlIsForum = new System.Windows.Forms.Panel();
            this.btnIsMalzemelerForm = new System.Windows.Forms.Button();
            this.btnIsIscilerForm = new System.Windows.Forms.Button();
            this.pnlIsIslemler = new System.Windows.Forms.Panel();
            this.btnIsSilForm = new System.Windows.Forms.Button();
            this.btnIsKaydet = new System.Windows.Forms.Button();
            this.btnIsTemizle = new System.Windows.Forms.Button();
            this.btnIsGuncelle = new System.Windows.Forms.Button();
            this.grpbxIsKayit = new System.Windows.Forms.GroupBox();
            this.txtIsTeklif = new System.Windows.Forms.TextBox();
            this.txtIsGun = new System.Windows.Forms.TextBox();
            this.lblIsGun = new System.Windows.Forms.Label();
            this.btnIsMalzemelerList = new System.Windows.Forms.Button();
            this.btnIsIscilerList = new System.Windows.Forms.Button();
            this.lstbxIsMalzemelerListe = new System.Windows.Forms.ListBox();
            this.lstbxIsIscilerListe = new System.Windows.Forms.ListBox();
            this.lblIsTeklif = new System.Windows.Forms.Label();
            this.lblIsMalzemeList = new System.Windows.Forms.Label();
            this.lblIsIsciList = new System.Windows.Forms.Label();
            this.txtIsID = new System.Windows.Forms.TextBox();
            this.txtIsAd = new System.Windows.Forms.TextBox();
            this.lblIsAd = new System.Windows.Forms.Label();
            this.lblIsID = new System.Windows.Forms.Label();
            this.tblIsTableAdapter = new Proje.TaseronDataSet3TableAdapters.tblIsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbxIsKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdIsKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet3)).BeginInit();
            this.grpbxIsIslemler.SuspendLayout();
            this.pnlIsForum.SuspendLayout();
            this.pnlIsIslemler.SuspendLayout();
            this.grpbxIsKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxIsKayitlar
            // 
            this.grpbxIsKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsKayitlar.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsKayitlar.Controls.Add(this.dtgrdIsKayitlar);
            this.grpbxIsKayitlar.Location = new System.Drawing.Point(12, 496);
            this.grpbxIsKayitlar.Name = "grpbxIsKayitlar";
            this.grpbxIsKayitlar.Size = new System.Drawing.Size(1158, 245);
            this.grpbxIsKayitlar.TabIndex = 11;
            this.grpbxIsKayitlar.TabStop = false;
            this.grpbxIsKayitlar.Text = "Kayıtlar";
            // 
            // dtgrdIsKayitlar
            // 
            this.dtgrdIsKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdIsKayitlar.AutoGenerateColumns = false;
            this.dtgrdIsKayitlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdIsKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdIsKayitlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ısIDDataGridViewTextBoxColumn,
            this.ısAdDataGridViewTextBoxColumn,
            this.ısTeklifDataGridViewTextBoxColumn,
            this.ısGunDataGridViewTextBoxColumn,
            this.ısIscilerDataGridViewTextBoxColumn,
            this.ısMalzemelerDataGridViewTextBoxColumn});
            this.dtgrdIsKayitlar.DataSource = this.tblIsBindingSource;
            this.dtgrdIsKayitlar.Location = new System.Drawing.Point(6, 36);
            this.dtgrdIsKayitlar.Name = "dtgrdIsKayitlar";
            this.dtgrdIsKayitlar.RowHeadersWidth = 30;
            this.dtgrdIsKayitlar.RowTemplate.Height = 50;
            this.dtgrdIsKayitlar.Size = new System.Drawing.Size(1146, 203);
            this.dtgrdIsKayitlar.TabIndex = 3;
            this.dtgrdIsKayitlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdIsKayitlar_CellDoubleClick);
            // 
            // ısIDDataGridViewTextBoxColumn
            // 
            this.ısIDDataGridViewTextBoxColumn.DataPropertyName = "IsID";
            this.ısIDDataGridViewTextBoxColumn.FillWeight = 38.16749F;
            this.ısIDDataGridViewTextBoxColumn.HeaderText = "IsID";
            this.ısIDDataGridViewTextBoxColumn.Name = "ısIDDataGridViewTextBoxColumn";
            this.ısIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ısAdDataGridViewTextBoxColumn
            // 
            this.ısAdDataGridViewTextBoxColumn.DataPropertyName = "IsAd";
            this.ısAdDataGridViewTextBoxColumn.FillWeight = 60.9137F;
            this.ısAdDataGridViewTextBoxColumn.HeaderText = "IsAd";
            this.ısAdDataGridViewTextBoxColumn.Name = "ısAdDataGridViewTextBoxColumn";
            // 
            // ısTeklifDataGridViewTextBoxColumn
            // 
            this.ısTeklifDataGridViewTextBoxColumn.DataPropertyName = "IsTeklif";
            this.ısTeklifDataGridViewTextBoxColumn.FillWeight = 77.1498F;
            this.ısTeklifDataGridViewTextBoxColumn.HeaderText = "IsTeklif";
            this.ısTeklifDataGridViewTextBoxColumn.Name = "ısTeklifDataGridViewTextBoxColumn";
            // 
            // ısGunDataGridViewTextBoxColumn
            // 
            this.ısGunDataGridViewTextBoxColumn.DataPropertyName = "IsGun";
            this.ısGunDataGridViewTextBoxColumn.FillWeight = 65.63366F;
            this.ısGunDataGridViewTextBoxColumn.HeaderText = "IsGun";
            this.ısGunDataGridViewTextBoxColumn.Name = "ısGunDataGridViewTextBoxColumn";
            // 
            // ısIscilerDataGridViewTextBoxColumn
            // 
            this.ısIscilerDataGridViewTextBoxColumn.DataPropertyName = "IsIsciler";
            this.ısIscilerDataGridViewTextBoxColumn.FillWeight = 179.0676F;
            this.ısIscilerDataGridViewTextBoxColumn.HeaderText = "IsIsciler";
            this.ısIscilerDataGridViewTextBoxColumn.Name = "ısIscilerDataGridViewTextBoxColumn";
            // 
            // ısMalzemelerDataGridViewTextBoxColumn
            // 
            this.ısMalzemelerDataGridViewTextBoxColumn.DataPropertyName = "IsMalzemeler";
            this.ısMalzemelerDataGridViewTextBoxColumn.FillWeight = 179.0676F;
            this.ısMalzemelerDataGridViewTextBoxColumn.HeaderText = "IsMalzemeler";
            this.ısMalzemelerDataGridViewTextBoxColumn.Name = "ısMalzemelerDataGridViewTextBoxColumn";
            // 
            // tblIsBindingSource
            // 
            this.tblIsBindingSource.DataMember = "tblIs";
            this.tblIsBindingSource.DataSource = this.taseronDataSet3;
            // 
            // taseronDataSet3
            // 
            this.taseronDataSet3.DataSetName = "TaseronDataSet3";
            this.taseronDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpbxIsIslemler
            // 
            this.grpbxIsIslemler.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsIslemler.Controls.Add(this.pnlIsForum);
            this.grpbxIsIslemler.Controls.Add(this.pnlIsIslemler);
            this.grpbxIsIslemler.Location = new System.Drawing.Point(12, 12);
            this.grpbxIsIslemler.Name = "grpbxIsIslemler";
            this.grpbxIsIslemler.Size = new System.Drawing.Size(476, 478);
            this.grpbxIsIslemler.TabIndex = 10;
            this.grpbxIsIslemler.TabStop = false;
            this.grpbxIsIslemler.Text = "İşlemler";
            // 
            // pnlIsForum
            // 
            this.pnlIsForum.BackColor = System.Drawing.Color.DimGray;
            this.pnlIsForum.Controls.Add(this.btnIsMalzemelerForm);
            this.pnlIsForum.Controls.Add(this.btnIsIscilerForm);
            this.pnlIsForum.Location = new System.Drawing.Point(233, 39);
            this.pnlIsForum.Name = "pnlIsForum";
            this.pnlIsForum.Size = new System.Drawing.Size(218, 408);
            this.pnlIsForum.TabIndex = 20;
            // 
            // btnIsMalzemelerForm
            // 
            this.btnIsMalzemelerForm.Location = new System.Drawing.Point(22, 229);
            this.btnIsMalzemelerForm.Name = "btnIsMalzemelerForm";
            this.btnIsMalzemelerForm.Size = new System.Drawing.Size(174, 150);
            this.btnIsMalzemelerForm.TabIndex = 22;
            this.btnIsMalzemelerForm.Text = "Malzemeler";
            this.btnIsMalzemelerForm.UseVisualStyleBackColor = true;
            this.btnIsMalzemelerForm.Click += new System.EventHandler(this.btnIsMalzemelerForm_Click);
            // 
            // btnIsIscilerForm
            // 
            this.btnIsIscilerForm.Location = new System.Drawing.Point(22, 29);
            this.btnIsIscilerForm.Name = "btnIsIscilerForm";
            this.btnIsIscilerForm.Size = new System.Drawing.Size(174, 150);
            this.btnIsIscilerForm.TabIndex = 21;
            this.btnIsIscilerForm.Text = "İşçiler";
            this.btnIsIscilerForm.UseVisualStyleBackColor = true;
            this.btnIsIscilerForm.Click += new System.EventHandler(this.btnIsIscilerForm_Click);
            // 
            // pnlIsIslemler
            // 
            this.pnlIsIslemler.BackColor = System.Drawing.Color.DimGray;
            this.pnlIsIslemler.Controls.Add(this.btnIsSilForm);
            this.pnlIsIslemler.Controls.Add(this.btnIsKaydet);
            this.pnlIsIslemler.Controls.Add(this.btnIsTemizle);
            this.pnlIsIslemler.Controls.Add(this.btnIsGuncelle);
            this.pnlIsIslemler.Location = new System.Drawing.Point(25, 39);
            this.pnlIsIslemler.Name = "pnlIsIslemler";
            this.pnlIsIslemler.Size = new System.Drawing.Size(201, 408);
            this.pnlIsIslemler.TabIndex = 19;
            this.pnlIsIslemler.Tag = "";
            // 
            // btnIsSilForm
            // 
            this.btnIsSilForm.Location = new System.Drawing.Point(12, 129);
            this.btnIsSilForm.Name = "btnIsSilForm";
            this.btnIsSilForm.Size = new System.Drawing.Size(177, 50);
            this.btnIsSilForm.TabIndex = 21;
            this.btnIsSilForm.Text = "Sil";
            this.btnIsSilForm.UseVisualStyleBackColor = true;
            this.btnIsSilForm.Click += new System.EventHandler(this.btnIsSilForm_Click);
            // 
            // btnIsKaydet
            // 
            this.btnIsKaydet.Location = new System.Drawing.Point(12, 29);
            this.btnIsKaydet.Name = "btnIsKaydet";
            this.btnIsKaydet.Size = new System.Drawing.Size(177, 50);
            this.btnIsKaydet.TabIndex = 20;
            this.btnIsKaydet.Text = "Kaydet";
            this.btnIsKaydet.UseVisualStyleBackColor = true;
            this.btnIsKaydet.Click += new System.EventHandler(this.btnIsKaydet_Click);
            // 
            // btnIsTemizle
            // 
            this.btnIsTemizle.Location = new System.Drawing.Point(12, 329);
            this.btnIsTemizle.Name = "btnIsTemizle";
            this.btnIsTemizle.Size = new System.Drawing.Size(177, 50);
            this.btnIsTemizle.TabIndex = 23;
            this.btnIsTemizle.Text = "Temizle";
            this.btnIsTemizle.UseVisualStyleBackColor = true;
            this.btnIsTemizle.Click += new System.EventHandler(this.btnIsTemizle_Click);
            // 
            // btnIsGuncelle
            // 
            this.btnIsGuncelle.Location = new System.Drawing.Point(12, 229);
            this.btnIsGuncelle.Name = "btnIsGuncelle";
            this.btnIsGuncelle.Size = new System.Drawing.Size(177, 50);
            this.btnIsGuncelle.TabIndex = 22;
            this.btnIsGuncelle.Text = "Güncelle";
            this.btnIsGuncelle.UseVisualStyleBackColor = true;
            this.btnIsGuncelle.Click += new System.EventHandler(this.btnIsGuncelle_Click);
            // 
            // grpbxIsKayit
            // 
            this.grpbxIsKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsKayit.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsKayit.Controls.Add(this.pictureBox1);
            this.grpbxIsKayit.Controls.Add(this.txtIsTeklif);
            this.grpbxIsKayit.Controls.Add(this.txtIsGun);
            this.grpbxIsKayit.Controls.Add(this.lblIsGun);
            this.grpbxIsKayit.Controls.Add(this.btnIsMalzemelerList);
            this.grpbxIsKayit.Controls.Add(this.btnIsIscilerList);
            this.grpbxIsKayit.Controls.Add(this.lstbxIsMalzemelerListe);
            this.grpbxIsKayit.Controls.Add(this.lstbxIsIscilerListe);
            this.grpbxIsKayit.Controls.Add(this.lblIsTeklif);
            this.grpbxIsKayit.Controls.Add(this.lblIsMalzemeList);
            this.grpbxIsKayit.Controls.Add(this.lblIsIsciList);
            this.grpbxIsKayit.Controls.Add(this.txtIsID);
            this.grpbxIsKayit.Controls.Add(this.txtIsAd);
            this.grpbxIsKayit.Controls.Add(this.lblIsAd);
            this.grpbxIsKayit.Controls.Add(this.lblIsID);
            this.grpbxIsKayit.Location = new System.Drawing.Point(494, 12);
            this.grpbxIsKayit.Name = "grpbxIsKayit";
            this.grpbxIsKayit.Size = new System.Drawing.Size(676, 478);
            this.grpbxIsKayit.TabIndex = 9;
            this.grpbxIsKayit.TabStop = false;
            this.grpbxIsKayit.Text = "İş Kayıt";
            // 
            // txtIsTeklif
            // 
            this.txtIsTeklif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsTeklif.BackColor = System.Drawing.Color.Silver;
            this.txtIsTeklif.Location = new System.Drawing.Point(221, 174);
            this.txtIsTeklif.MaxLength = 10;
            this.txtIsTeklif.Name = "txtIsTeklif";
            this.txtIsTeklif.Size = new System.Drawing.Size(384, 40);
            this.txtIsTeklif.TabIndex = 27;
            this.txtIsTeklif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsTeklif_KeyPress);
            // 
            // txtIsGun
            // 
            this.txtIsGun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsGun.BackColor = System.Drawing.Color.Silver;
            this.txtIsGun.Location = new System.Drawing.Point(221, 224);
            this.txtIsGun.MaxLength = 3;
            this.txtIsGun.Name = "txtIsGun";
            this.txtIsGun.Size = new System.Drawing.Size(384, 40);
            this.txtIsGun.TabIndex = 25;
            this.txtIsGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsGun_KeyPress);
            // 
            // lblIsGun
            // 
            this.lblIsGun.Location = new System.Drawing.Point(118, 227);
            this.lblIsGun.Name = "lblIsGun";
            this.lblIsGun.Size = new System.Drawing.Size(97, 35);
            this.lblIsGun.TabIndex = 26;
            this.lblIsGun.Text = "İş Gün:";
            // 
            // btnIsMalzemelerList
            // 
            this.btnIsMalzemelerList.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsMalzemelerList.Location = new System.Drawing.Point(585, 311);
            this.btnIsMalzemelerList.Name = "btnIsMalzemelerList";
            this.btnIsMalzemelerList.Size = new System.Drawing.Size(40, 40);
            this.btnIsMalzemelerList.TabIndex = 24;
            this.btnIsMalzemelerList.Text = "⟲";
            this.btnIsMalzemelerList.UseVisualStyleBackColor = true;
            this.btnIsMalzemelerList.Click += new System.EventHandler(this.btnIsMalzemelerListe_Click);
            // 
            // btnIsIscilerList
            // 
            this.btnIsIscilerList.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsIscilerList.Location = new System.Drawing.Point(309, 311);
            this.btnIsIscilerList.Name = "btnIsIscilerList";
            this.btnIsIscilerList.Size = new System.Drawing.Size(40, 40);
            this.btnIsIscilerList.TabIndex = 23;
            this.btnIsIscilerList.Text = "⟲";
            this.btnIsIscilerList.UseVisualStyleBackColor = true;
            this.btnIsIscilerList.Click += new System.EventHandler(this.btnIsIscilerListe_Click);
            // 
            // lstbxIsMalzemelerListe
            // 
            this.lstbxIsMalzemelerListe.BackColor = System.Drawing.Color.Silver;
            this.lstbxIsMalzemelerListe.FormattingEnabled = true;
            this.lstbxIsMalzemelerListe.ItemHeight = 33;
            this.lstbxIsMalzemelerListe.Location = new System.Drawing.Point(354, 311);
            this.lstbxIsMalzemelerListe.Name = "lstbxIsMalzemelerListe";
            this.lstbxIsMalzemelerListe.Size = new System.Drawing.Size(224, 136);
            this.lstbxIsMalzemelerListe.TabIndex = 22;
            // 
            // lstbxIsIscilerListe
            // 
            this.lstbxIsIscilerListe.BackColor = System.Drawing.Color.Silver;
            this.lstbxIsIscilerListe.FormattingEnabled = true;
            this.lstbxIsIscilerListe.ItemHeight = 33;
            this.lstbxIsIscilerListe.Location = new System.Drawing.Point(79, 311);
            this.lstbxIsIscilerListe.Name = "lstbxIsIscilerListe";
            this.lstbxIsIscilerListe.Size = new System.Drawing.Size(224, 136);
            this.lstbxIsIscilerListe.TabIndex = 21;
            // 
            // lblIsTeklif
            // 
            this.lblIsTeklif.Location = new System.Drawing.Point(79, 177);
            this.lblIsTeklif.Name = "lblIsTeklif";
            this.lblIsTeklif.Size = new System.Drawing.Size(149, 35);
            this.lblIsTeklif.TabIndex = 20;
            this.lblIsTeklif.Text = "İş Teklif(₺) :";
            // 
            // lblIsMalzemeList
            // 
            this.lblIsMalzemeList.AutoSize = true;
            this.lblIsMalzemeList.Location = new System.Drawing.Point(354, 277);
            this.lblIsMalzemeList.Name = "lblIsMalzemeList";
            this.lblIsMalzemeList.Size = new System.Drawing.Size(203, 35);
            this.lblIsMalzemeList.TabIndex = 16;
            this.lblIsMalzemeList.Text = "Malzeme Listesi";
            // 
            // lblIsIsciList
            // 
            this.lblIsIsciList.AutoSize = true;
            this.lblIsIsciList.Location = new System.Drawing.Point(79, 273);
            this.lblIsIsciList.Name = "lblIsIsciList";
            this.lblIsIsciList.Size = new System.Drawing.Size(133, 35);
            this.lblIsIsciList.TabIndex = 14;
            this.lblIsIsciList.Text = "İşçi Listesi";
            // 
            // txtIsID
            // 
            this.txtIsID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsID.BackColor = System.Drawing.Color.Silver;
            this.txtIsID.Enabled = false;
            this.txtIsID.Location = new System.Drawing.Point(221, 74);
            this.txtIsID.Name = "txtIsID";
            this.txtIsID.Size = new System.Drawing.Size(384, 40);
            this.txtIsID.TabIndex = 13;
            // 
            // txtIsAd
            // 
            this.txtIsAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsAd.BackColor = System.Drawing.Color.Silver;
            this.txtIsAd.Location = new System.Drawing.Point(221, 124);
            this.txtIsAd.Name = "txtIsAd";
            this.txtIsAd.Size = new System.Drawing.Size(382, 40);
            this.txtIsAd.TabIndex = 1;
            this.txtIsAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsAd_KeyPress);
            // 
            // lblIsAd
            // 
            this.lblIsAd.Location = new System.Drawing.Point(125, 127);
            this.lblIsAd.Name = "lblIsAd";
            this.lblIsAd.Size = new System.Drawing.Size(90, 35);
            this.lblIsAd.TabIndex = 2;
            this.lblIsAd.Text = "İş Ad :";
            // 
            // lblIsID
            // 
            this.lblIsID.Location = new System.Drawing.Point(133, 77);
            this.lblIsID.Name = "lblIsID";
            this.lblIsID.Size = new System.Drawing.Size(82, 35);
            this.lblIsID.TabIndex = 0;
            this.lblIsID.Text = "İş ID :";
            // 
            // tblIsTableAdapter
            // 
            this.tblIsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(631, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIsKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.grpbxIsKayitlar);
            this.Controls.Add(this.grpbxIsIslemler);
            this.Controls.Add(this.grpbxIsKayit);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmIsKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş";
            this.Load += new System.EventHandler(this.FrmIsKaydet_Load);
            this.grpbxIsKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdIsKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet3)).EndInit();
            this.grpbxIsIslemler.ResumeLayout(false);
            this.pnlIsForum.ResumeLayout(false);
            this.pnlIsIslemler.ResumeLayout(false);
            this.grpbxIsKayit.ResumeLayout(false);
            this.grpbxIsKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxIsKayitlar;
        private System.Windows.Forms.DataGridView dtgrdIsKayitlar;
        private System.Windows.Forms.GroupBox grpbxIsIslemler;
        private System.Windows.Forms.GroupBox grpbxIsKayit;
        private System.Windows.Forms.Panel pnlIsIslemler;
        private System.Windows.Forms.Button btnIsSilForm;
        private System.Windows.Forms.Button btnIsKaydet;
        private System.Windows.Forms.Button btnIsTemizle;
        private System.Windows.Forms.Button btnIsGuncelle;
        private System.Windows.Forms.Panel pnlIsForum;
        private System.Windows.Forms.Button btnIsMalzemelerForm;
        private System.Windows.Forms.Button btnIsIscilerForm;
        private System.Windows.Forms.Label lblIsTeklif;
        private System.Windows.Forms.Label lblIsMalzemeList;
        private System.Windows.Forms.Label lblIsIsciList;
        private System.Windows.Forms.TextBox txtIsID;
        private System.Windows.Forms.TextBox txtIsAd;
        private System.Windows.Forms.Label lblIsAd;
        private System.Windows.Forms.Label lblIsID;
        private System.Windows.Forms.ListBox lstbxIsIscilerListe;
        public System.Windows.Forms.ListBox lstbxIsMalzemelerListe;
        private System.Windows.Forms.Button btnIsMalzemelerList;
        private System.Windows.Forms.Button btnIsIscilerList;
        private System.Windows.Forms.Label lblIsGun;
        private TaseronDataSet3 taseronDataSet3;
        private System.Windows.Forms.BindingSource tblIsBindingSource;
        private TaseronOtomasyonu.TaseronDataSet3TableAdapters.tblIsTableAdapter tblIsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısTeklifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısIscilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısMalzemelerDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIsTeklif;
        private System.Windows.Forms.TextBox txtIsGun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

    internal class TaseronDataSet3TableAdapters
    {
        internal class tblIsTableAdapter : TaseronOtomasyonu.TaseronDataSet3TableAdapters.tblIsTableAdapter
        {
        }
    }

    internal class TaseronDataSet3 : TaseronOtomasyonu.TaseronDataSet3
    {
    }
}