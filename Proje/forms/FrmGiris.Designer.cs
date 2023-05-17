using TaseronOtomasyonu;
using TaseronOtomasyonu.TaseronDataSet7TableAdapters;

namespace Proje
{
    partial class FrmGiris
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
            this.grpbxGirisMain = new System.Windows.Forms.GroupBox();
            this.btnGirisMain = new System.Windows.Forms.Button();
            this.grpbxGirisIsciTC = new System.Windows.Forms.GroupBox();
            this.lblGirisIsciTC2 = new System.Windows.Forms.Label();
            this.lblGirisIsciTC1 = new System.Windows.Forms.Label();
            this.btnGirisIsciTC = new System.Windows.Forms.Button();
            this.txtGirisIsciTC = new System.Windows.Forms.MaskedTextBox();
            this.taseronDataSet7 = new Proje.TaseronDataSet7();
            this.tblIsciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblIsciTableAdapter = new Proje.TaseronDataSet7TableAdapters.tblIsciTableAdapter();
            this.grpbxGirisMain.SuspendLayout();
            this.grpbxGirisIsciTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxGirisMain
            // 
            this.grpbxGirisMain.BackColor = System.Drawing.Color.Gray;
            this.grpbxGirisMain.Controls.Add(this.btnGirisMain);
            this.grpbxGirisMain.Location = new System.Drawing.Point(12, 12);
            this.grpbxGirisMain.Name = "grpbxGirisMain";
            this.grpbxGirisMain.Size = new System.Drawing.Size(469, 229);
            this.grpbxGirisMain.TabIndex = 0;
            this.grpbxGirisMain.TabStop = false;
            this.grpbxGirisMain.Text = "Giriş";
            // 
            // btnGirisMain
            // 
            this.btnGirisMain.Location = new System.Drawing.Point(81, 63);
            this.btnGirisMain.Name = "btnGirisMain";
            this.btnGirisMain.Size = new System.Drawing.Size(288, 120);
            this.btnGirisMain.TabIndex = 4;
            this.btnGirisMain.Text = "Giriş Yap";
            this.btnGirisMain.UseVisualStyleBackColor = true;
            this.btnGirisMain.Click += new System.EventHandler(this.btnGirisMain_Click);
            // 
            // grpbxGirisIsciTC
            // 
            this.grpbxGirisIsciTC.BackColor = System.Drawing.Color.Gray;
            this.grpbxGirisIsciTC.Controls.Add(this.lblGirisIsciTC2);
            this.grpbxGirisIsciTC.Controls.Add(this.lblGirisIsciTC1);
            this.grpbxGirisIsciTC.Controls.Add(this.btnGirisIsciTC);
            this.grpbxGirisIsciTC.Controls.Add(this.txtGirisIsciTC);
            this.grpbxGirisIsciTC.Location = new System.Drawing.Point(487, 12);
            this.grpbxGirisIsciTC.Name = "grpbxGirisIsciTC";
            this.grpbxGirisIsciTC.Size = new System.Drawing.Size(367, 229);
            this.grpbxGirisIsciTC.TabIndex = 1;
            this.grpbxGirisIsciTC.TabStop = false;
            this.grpbxGirisIsciTC.Text = "İşçi Sorgu";
            // 
            // lblGirisIsciTC2
            // 
            this.lblGirisIsciTC2.AutoSize = true;
            this.lblGirisIsciTC2.Location = new System.Drawing.Point(50, 88);
            this.lblGirisIsciTC2.Name = "lblGirisIsciTC2";
            this.lblGirisIsciTC2.Size = new System.Drawing.Size(104, 35);
            this.lblGirisIsciTC2.TabIndex = 7;
            this.lblGirisIsciTC2.Text = "Giriniz :";
            // 
            // lblGirisIsciTC1
            // 
            this.lblGirisIsciTC1.AutoSize = true;
            this.lblGirisIsciTC1.Location = new System.Drawing.Point(50, 42);
            this.lblGirisIsciTC1.Name = "lblGirisIsciTC1";
            this.lblGirisIsciTC1.Size = new System.Drawing.Size(282, 35);
            this.lblGirisIsciTC1.TabIndex = 6;
            this.lblGirisIsciTC1.Text = "T.C. Kimlik Numarasını";
            // 
            // btnGirisIsciTC
            // 
            this.btnGirisIsciTC.Location = new System.Drawing.Point(50, 167);
            this.btnGirisIsciTC.Name = "btnGirisIsciTC";
            this.btnGirisIsciTC.Size = new System.Drawing.Size(267, 44);
            this.btnGirisIsciTC.TabIndex = 5;
            this.btnGirisIsciTC.Text = "Sorgula";
            this.btnGirisIsciTC.UseVisualStyleBackColor = true;
            this.btnGirisIsciTC.Click += new System.EventHandler(this.btnGirisIsciTC_Click);
            // 
            // txtGirisIsciTC
            // 
            this.txtGirisIsciTC.Location = new System.Drawing.Point(173, 85);
            this.txtGirisIsciTC.Mask = "00000000000";
            this.txtGirisIsciTC.Name = "txtGirisIsciTC";
            this.txtGirisIsciTC.Size = new System.Drawing.Size(144, 40);
            this.txtGirisIsciTC.TabIndex = 0;
            this.txtGirisIsciTC.ValidatingType = typeof(int);
            // 
            // taseronDataSet7
            // 
            this.taseronDataSet7.DataSetName = "TaseronDataSet7";
            this.taseronDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblIsciBindingSource
            // 
            this.tblIsciBindingSource.DataMember = "tblIsci";
            this.tblIsciBindingSource.DataSource = this.taseronDataSet7;
            // 
            // tblIsciTableAdapter
            // 
            this.tblIsciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(866, 253);
            this.Controls.Add(this.grpbxGirisIsciTC);
            this.Controls.Add(this.grpbxGirisMain);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(884, 300);
            this.MinimumSize = new System.Drawing.Size(884, 300);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.grpbxGirisMain.ResumeLayout(false);
            this.grpbxGirisIsciTC.ResumeLayout(false);
            this.grpbxGirisIsciTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIsciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxGirisMain;
        private System.Windows.Forms.GroupBox grpbxGirisIsciTC;
        private System.Windows.Forms.Button btnGirisMain;
        private System.Windows.Forms.MaskedTextBox txtGirisIsciTC;
        private System.Windows.Forms.Label lblGirisIsciTC2;
        private System.Windows.Forms.Label lblGirisIsciTC1;
        private System.Windows.Forms.Button btnGirisIsciTC;
        private TaseronDataSet7 taseronDataSet7;
        private System.Windows.Forms.BindingSource tblIsciBindingSource;
        private TaseronOtomasyonu.TaseronDataSet7TableAdapters.tblIsciTableAdapter tblIsciTableAdapter;
    }

    internal class TaseronDataSet7TableAdapters
    {
        internal class tblIsciTableAdapter : TaseronOtomasyonu.TaseronDataSet7TableAdapters.tblIsciTableAdapter
        {
        }
    }

    internal class TaseronDataSet7 : TaseronOtomasyonu.TaseronDataSet7
    {
    }
}