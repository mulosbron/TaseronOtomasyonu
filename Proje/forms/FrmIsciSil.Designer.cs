namespace Proje
{
    partial class FrmIsciSil
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
            this.grpbxIsciKayitSil = new System.Windows.Forms.GroupBox();
            this.txtIsciSil = new System.Windows.Forms.MaskedTextBox();
            this.lblIsciSil2 = new System.Windows.Forms.Label();
            this.btnIsciDBSil = new System.Windows.Forms.Button();
            this.btnIsciSil = new System.Windows.Forms.Button();
            this.lblIsciSil1 = new System.Windows.Forms.Label();
            this.grpbxIsciKayitSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxIsciKayitSil
            // 
            this.grpbxIsciKayitSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsciKayitSil.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsciKayitSil.Controls.Add(this.txtIsciSil);
            this.grpbxIsciKayitSil.Controls.Add(this.lblIsciSil2);
            this.grpbxIsciKayitSil.Controls.Add(this.btnIsciDBSil);
            this.grpbxIsciKayitSil.Controls.Add(this.btnIsciSil);
            this.grpbxIsciKayitSil.Controls.Add(this.lblIsciSil1);
            this.grpbxIsciKayitSil.Location = new System.Drawing.Point(12, 12);
            this.grpbxIsciKayitSil.Name = "grpbxIsciKayitSil";
            this.grpbxIsciKayitSil.Size = new System.Drawing.Size(438, 229);
            this.grpbxIsciKayitSil.TabIndex = 3;
            this.grpbxIsciKayitSil.TabStop = false;
            this.grpbxIsciKayitSil.Text = "İşçi Kaydı Sil";
            // 
            // txtIsciSil
            // 
            this.txtIsciSil.BackColor = System.Drawing.Color.Silver;
            this.txtIsciSil.Location = new System.Drawing.Point(293, 68);
            this.txtIsciSil.Mask = "00000000000";
            this.txtIsciSil.Name = "txtIsciSil";
            this.txtIsciSil.Size = new System.Drawing.Size(139, 40);
            this.txtIsciSil.TabIndex = 7;
            this.txtIsciSil.ValidatingType = typeof(int);
            // 
            // lblIsciSil2
            // 
            this.lblIsciSil2.AutoSize = true;
            this.lblIsciSil2.Location = new System.Drawing.Point(10, 71);
            this.lblIsciSil2.Name = "lblIsciSil2";
            this.lblIsciSil2.Size = new System.Drawing.Size(277, 35);
            this.lblIsciSil2.TabIndex = 6;
            this.lblIsciSil2.Text = " T.C. Kimlik Numarası :";
            // 
            // btnIsciDBSil
            // 
            this.btnIsciDBSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIsciDBSil.Location = new System.Drawing.Point(16, 171);
            this.btnIsciDBSil.Name = "btnIsciDBSil";
            this.btnIsciDBSil.Size = new System.Drawing.Size(271, 42);
            this.btnIsciDBSil.TabIndex = 5;
            this.btnIsciDBSil.Text = "Tüm Kayıtlı İşçileri Sil";
            this.btnIsciDBSil.UseVisualStyleBackColor = true;
            this.btnIsciDBSil.Click += new System.EventHandler(this.btnIsciDBSil_Click);
            // 
            // btnIsciSil
            // 
            this.btnIsciSil.Location = new System.Drawing.Point(317, 130);
            this.btnIsciSil.Name = "btnIsciSil";
            this.btnIsciSil.Size = new System.Drawing.Size(115, 42);
            this.btnIsciSil.TabIndex = 2;
            this.btnIsciSil.Text = "Sil";
            this.btnIsciSil.UseVisualStyleBackColor = true;
            this.btnIsciSil.Click += new System.EventHandler(this.btnIsciSil_Click);
            // 
            // lblIsciSil1
            // 
            this.lblIsciSil1.AutoSize = true;
            this.lblIsciSil1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsciSil1.Location = new System.Drawing.Point(10, 36);
            this.lblIsciSil1.Name = "lblIsciSil1";
            this.lblIsciSil1.Size = new System.Drawing.Size(301, 35);
            this.lblIsciSil1.TabIndex = 0;
            this.lblIsciSil1.Text = "Silmek İstediğiniz İşçinin";
            // 
            // FrmIsciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.grpbxIsciKayitSil);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FrmIsciSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşçi Kaydı Sil";
            this.grpbxIsciKayitSil.ResumeLayout(false);
            this.grpbxIsciKayitSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxIsciKayitSil;
        private System.Windows.Forms.MaskedTextBox txtIsciSil;
        private System.Windows.Forms.Label lblIsciSil2;
        private System.Windows.Forms.Button btnIsciDBSil;
        private System.Windows.Forms.Button btnIsciSil;
        private System.Windows.Forms.Label lblIsciSil1;
    }
}