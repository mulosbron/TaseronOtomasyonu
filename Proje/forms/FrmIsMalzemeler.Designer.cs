using TaseronOtomasyonu;
using TaseronOtomasyonu.TaseronDataSet4TableAdapters;

namespace Proje
{
    partial class FrmIsMalzemeler
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
            this.tblMalzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taseronDataSet4 = new Proje.TaseronDataSet4();
            this.tblMalzemeTableAdapter = new Proje.TaseronDataSet4TableAdapters.tblMalzemeTableAdapter();
            this.grpbxIsMalzemeler = new System.Windows.Forms.GroupBox();
            this.btnIsMalzemelerTemizleVeKaydet = new System.Windows.Forms.Button();
            this.txtIsMalzemeler = new System.Windows.Forms.TextBox();
            this.btnIsMalzemelerKaydet = new System.Windows.Forms.Button();
            this.btnIsMalzemelerCikar = new System.Windows.Forms.Button();
            this.btnIsMalzemelerEkle = new System.Windows.Forms.Button();
            this.cmbbxIsMalzemeler = new System.Windows.Forms.ComboBox();
            this.lstbxIsMalzemeler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet4)).BeginInit();
            this.grpbxIsMalzemeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMalzemeBindingSource
            // 
            this.tblMalzemeBindingSource.DataMember = "tblMalzeme";
            this.tblMalzemeBindingSource.DataSource = this.taseronDataSet4;
            // 
            // taseronDataSet4
            // 
            this.taseronDataSet4.DataSetName = "TaseronDataSet4";
            this.taseronDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMalzemeTableAdapter
            // 
            this.tblMalzemeTableAdapter.ClearBeforeFill = true;
            // 
            // grpbxIsMalzemeler
            // 
            this.grpbxIsMalzemeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsMalzemeler.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsMalzemeler.Controls.Add(this.btnIsMalzemelerTemizleVeKaydet);
            this.grpbxIsMalzemeler.Controls.Add(this.txtIsMalzemeler);
            this.grpbxIsMalzemeler.Controls.Add(this.btnIsMalzemelerKaydet);
            this.grpbxIsMalzemeler.Controls.Add(this.btnIsMalzemelerCikar);
            this.grpbxIsMalzemeler.Controls.Add(this.btnIsMalzemelerEkle);
            this.grpbxIsMalzemeler.Controls.Add(this.cmbbxIsMalzemeler);
            this.grpbxIsMalzemeler.Controls.Add(this.lstbxIsMalzemeler);
            this.grpbxIsMalzemeler.Location = new System.Drawing.Point(14, 15);
            this.grpbxIsMalzemeler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpbxIsMalzemeler.Name = "grpbxIsMalzemeler";
            this.grpbxIsMalzemeler.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpbxIsMalzemeler.Size = new System.Drawing.Size(434, 223);
            this.grpbxIsMalzemeler.TabIndex = 3;
            this.grpbxIsMalzemeler.TabStop = false;
            this.grpbxIsMalzemeler.Text = "Malzeme Ekle";
            // 
            // btnIsMalzemelerTemizleVeKaydet
            // 
            this.btnIsMalzemelerTemizleVeKaydet.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsMalzemelerTemizleVeKaydet.Location = new System.Drawing.Point(191, 172);
            this.btnIsMalzemelerTemizleVeKaydet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnIsMalzemelerTemizleVeKaydet.Name = "btnIsMalzemelerTemizleVeKaydet";
            this.btnIsMalzemelerTemizleVeKaydet.Size = new System.Drawing.Size(230, 39);
            this.btnIsMalzemelerTemizleVeKaydet.TabIndex = 17;
            this.btnIsMalzemelerTemizleVeKaydet.Text = "Temizle ve Kaydet";
            this.btnIsMalzemelerTemizleVeKaydet.UseVisualStyleBackColor = true;
            this.btnIsMalzemelerTemizleVeKaydet.Click += new System.EventHandler(this.btnIsMalzemelerTemizleVeKaydet_Click);
            // 
            // txtIsMalzemeler
            // 
            this.txtIsMalzemeler.Location = new System.Drawing.Point(376, 45);
            this.txtIsMalzemeler.MaxLength = 4;
            this.txtIsMalzemeler.Name = "txtIsMalzemeler";
            this.txtIsMalzemeler.Size = new System.Drawing.Size(45, 40);
            this.txtIsMalzemeler.TabIndex = 16;
            this.txtIsMalzemeler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsMalzeme_KeyPress);
            // 
            // btnIsMalzemelerKaydet
            // 
            this.btnIsMalzemelerKaydet.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsMalzemelerKaydet.Location = new System.Drawing.Point(10, 172);
            this.btnIsMalzemelerKaydet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnIsMalzemelerKaydet.Name = "btnIsMalzemelerKaydet";
            this.btnIsMalzemelerKaydet.Size = new System.Drawing.Size(175, 39);
            this.btnIsMalzemelerKaydet.TabIndex = 15;
            this.btnIsMalzemelerKaydet.Text = "Kaydet";
            this.btnIsMalzemelerKaydet.UseVisualStyleBackColor = true;
            this.btnIsMalzemelerKaydet.Click += new System.EventHandler(this.btnIsMalzemelerKaydet_Click);
            // 
            // btnIsMalzemelerCikar
            // 
            this.btnIsMalzemelerCikar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsMalzemelerCikar.Location = new System.Drawing.Point(376, 126);
            this.btnIsMalzemelerCikar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnIsMalzemelerCikar.Name = "btnIsMalzemelerCikar";
            this.btnIsMalzemelerCikar.Size = new System.Drawing.Size(45, 30);
            this.btnIsMalzemelerCikar.TabIndex = 14;
            this.btnIsMalzemelerCikar.Text = "-";
            this.btnIsMalzemelerCikar.UseVisualStyleBackColor = true;
            this.btnIsMalzemelerCikar.Click += new System.EventHandler(this.btnIsMalzemelerCikar_Click);
            // 
            // btnIsMalzemelerEkle
            // 
            this.btnIsMalzemelerEkle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsMalzemelerEkle.Location = new System.Drawing.Point(376, 98);
            this.btnIsMalzemelerEkle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnIsMalzemelerEkle.Name = "btnIsMalzemelerEkle";
            this.btnIsMalzemelerEkle.Size = new System.Drawing.Size(45, 30);
            this.btnIsMalzemelerEkle.TabIndex = 12;
            this.btnIsMalzemelerEkle.Text = "+";
            this.btnIsMalzemelerEkle.UseVisualStyleBackColor = true;
            this.btnIsMalzemelerEkle.Click += new System.EventHandler(this.btnIsMalzemelerEkle_Click);
            // 
            // cmbbxIsMalzemeler
            // 
            this.cmbbxIsMalzemeler.BackColor = System.Drawing.Color.Silver;
            this.cmbbxIsMalzemeler.DataSource = this.tblMalzemeBindingSource;
            this.cmbbxIsMalzemeler.DisplayMember = "MalzemeAd";
            this.cmbbxIsMalzemeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxIsMalzemeler.FormattingEnabled = true;
            this.cmbbxIsMalzemeler.Location = new System.Drawing.Point(10, 45);
            this.cmbbxIsMalzemeler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbbxIsMalzemeler.Name = "cmbbxIsMalzemeler";
            this.cmbbxIsMalzemeler.Size = new System.Drawing.Size(359, 41);
            this.cmbbxIsMalzemeler.TabIndex = 11;
            // 
            // lstbxIsMalzemeler
            // 
            this.lstbxIsMalzemeler.BackColor = System.Drawing.Color.Silver;
            this.lstbxIsMalzemeler.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbxIsMalzemeler.FormattingEnabled = true;
            this.lstbxIsMalzemeler.ItemHeight = 33;
            this.lstbxIsMalzemeler.Location = new System.Drawing.Point(10, 98);
            this.lstbxIsMalzemeler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstbxIsMalzemeler.Name = "lstbxIsMalzemeler";
            this.lstbxIsMalzemeler.Size = new System.Drawing.Size(356, 70);
            this.lstbxIsMalzemeler.TabIndex = 10;
            // 
            // FrmIsMalzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.grpbxIsMalzemeler);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FrmIsMalzemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzemeler";
            this.Load += new System.EventHandler(this.FrmIsMalzemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet4)).EndInit();
            this.grpbxIsMalzemeler.ResumeLayout(false);
            this.grpbxIsMalzemeler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TaseronDataSet4 taseronDataSet4;
        private System.Windows.Forms.BindingSource tblMalzemeBindingSource;
        private TaseronOtomasyonu.TaseronDataSet4TableAdapters.tblMalzemeTableAdapter tblMalzemeTableAdapter;
        private System.Windows.Forms.GroupBox grpbxIsMalzemeler;
        private System.Windows.Forms.Button btnIsMalzemelerKaydet;
        private System.Windows.Forms.Button btnIsMalzemelerCikar;
        private System.Windows.Forms.Button btnIsMalzemelerEkle;
        private System.Windows.Forms.ComboBox cmbbxIsMalzemeler;
        private System.Windows.Forms.ListBox lstbxIsMalzemeler;
        private System.Windows.Forms.TextBox txtIsMalzemeler;
        private System.Windows.Forms.Button btnIsMalzemelerTemizleVeKaydet;
    }

    internal class TaseronDataSet4TableAdapters
    {
        internal class tblMalzemeTableAdapter : TaseronOtomasyonu.TaseronDataSet4TableAdapters.tblMalzemeTableAdapter
        {
        }
    }

    internal class TaseronDataSet4 : TaseronOtomasyonu.TaseronDataSet4
    {
    }
}