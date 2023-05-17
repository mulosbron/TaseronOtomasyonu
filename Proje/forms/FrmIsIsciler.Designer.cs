using TaseronOtomasyonu;

namespace Proje
{
    partial class FrmIsIsciler
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
            this.grpbxIsIsciKayitSil = new System.Windows.Forms.GroupBox();
            this.btnIsIscilerKaydet = new System.Windows.Forms.Button();
            this.btnIsIscilerIkidenBire = new System.Windows.Forms.Button();
            this.btnIsIscilerBirdenIkiye = new System.Windows.Forms.Button();
            this.lstbxIsIsciler = new System.Windows.Forms.ListBox();
            this.lstbxDBIsciler = new System.Windows.Forms.ListBox();
            this.taseronDataSet6 = new Proje.TaseronDataSet6();
            this.grpbxIsIsciKayitSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxIsIsciKayitSil
            // 
            this.grpbxIsIsciKayitSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsIsciKayitSil.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsIsciKayitSil.Controls.Add(this.btnIsIscilerKaydet);
            this.grpbxIsIsciKayitSil.Controls.Add(this.btnIsIscilerIkidenBire);
            this.grpbxIsIsciKayitSil.Controls.Add(this.btnIsIscilerBirdenIkiye);
            this.grpbxIsIsciKayitSil.Controls.Add(this.lstbxIsIsciler);
            this.grpbxIsIsciKayitSil.Controls.Add(this.lstbxDBIsciler);
            this.grpbxIsIsciKayitSil.Location = new System.Drawing.Point(12, 12);
            this.grpbxIsIsciKayitSil.Name = "grpbxIsIsciKayitSil";
            this.grpbxIsIsciKayitSil.Size = new System.Drawing.Size(438, 229);
            this.grpbxIsIsciKayitSil.TabIndex = 1;
            this.grpbxIsIsciKayitSil.TabStop = false;
            this.grpbxIsIsciKayitSil.Text = "İşçi Ekle";
            // 
            // btnIsIscilerKaydet
            // 
            this.btnIsIscilerKaydet.Location = new System.Drawing.Point(188, 103);
            this.btnIsIscilerKaydet.Name = "btnIsIscilerKaydet";
            this.btnIsIscilerKaydet.Size = new System.Drawing.Size(62, 40);
            this.btnIsIscilerKaydet.TabIndex = 4;
            this.btnIsIscilerKaydet.Text = "✓";
            this.btnIsIscilerKaydet.UseVisualStyleBackColor = true;
            this.btnIsIscilerKaydet.Click += new System.EventHandler(this.btnIsIscilerKaydet_Click);
            // 
            // btnIsIscilerIkidenBire
            // 
            this.btnIsIscilerIkidenBire.Location = new System.Drawing.Point(188, 168);
            this.btnIsIscilerIkidenBire.Name = "btnIsIscilerIkidenBire";
            this.btnIsIscilerIkidenBire.Size = new System.Drawing.Size(62, 40);
            this.btnIsIscilerIkidenBire.TabIndex = 3;
            this.btnIsIscilerIkidenBire.Text = "<--";
            this.btnIsIscilerIkidenBire.UseVisualStyleBackColor = true;
            this.btnIsIscilerIkidenBire.Click += new System.EventHandler(this.btnIsIscilerIkidenBire_Click);
            // 
            // btnIsIscilerBirdenIkiye
            // 
            this.btnIsIscilerBirdenIkiye.Location = new System.Drawing.Point(188, 40);
            this.btnIsIscilerBirdenIkiye.Name = "btnIsIscilerBirdenIkiye";
            this.btnIsIscilerBirdenIkiye.Size = new System.Drawing.Size(62, 40);
            this.btnIsIscilerBirdenIkiye.TabIndex = 2;
            this.btnIsIscilerBirdenIkiye.Text = "-->";
            this.btnIsIscilerBirdenIkiye.UseVisualStyleBackColor = true;
            this.btnIsIscilerBirdenIkiye.Click += new System.EventHandler(this.btnIsIscilerBirdenIkiye_Click);
            // 
            // lstbxIsIsciler
            // 
            this.lstbxIsIsciler.BackColor = System.Drawing.Color.Silver;
            this.lstbxIsIsciler.FormattingEnabled = true;
            this.lstbxIsIsciler.ItemHeight = 33;
            this.lstbxIsIsciler.Location = new System.Drawing.Point(256, 39);
            this.lstbxIsIsciler.Name = "lstbxIsIsciler";
            this.lstbxIsIsciler.Size = new System.Drawing.Size(174, 169);
            this.lstbxIsIsciler.TabIndex = 1;
            // 
            // lstbxDBIsciler
            // 
            this.lstbxDBIsciler.BackColor = System.Drawing.Color.Silver;
            this.lstbxDBIsciler.DisplayMember = "IsciAd";
            this.lstbxDBIsciler.FormattingEnabled = true;
            this.lstbxDBIsciler.ItemHeight = 33;
            this.lstbxDBIsciler.Location = new System.Drawing.Point(8, 40);
            this.lstbxDBIsciler.Name = "lstbxDBIsciler";
            this.lstbxDBIsciler.Size = new System.Drawing.Size(174, 169);
            this.lstbxDBIsciler.TabIndex = 0;
            this.lstbxDBIsciler.ValueMember = "IsciAd";
            // 
            // taseronDataSet6
            // 
            this.taseronDataSet6.DataSetName = "TaseronDataSet6";
            this.taseronDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmIsIsciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.grpbxIsIsciKayitSil);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FrmIsIsciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşçiler";
            this.Load += new System.EventHandler(this.FrmIsIsciler_Load);
            this.grpbxIsIsciKayitSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taseronDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxIsIsciKayitSil;
        private System.Windows.Forms.Button btnIsIscilerIkidenBire;
        private System.Windows.Forms.Button btnIsIscilerBirdenIkiye;
        private System.Windows.Forms.ListBox lstbxIsIsciler;
        private System.Windows.Forms.Button btnIsIscilerKaydet;
        private TaseronDataSet6 taseronDataSet6;
        private System.Windows.Forms.ListBox lstbxDBIsciler;
    }

    internal class TaseronDataSet6 : TaseronOtomasyonu.TaseronDataSet6
    {
    }
}