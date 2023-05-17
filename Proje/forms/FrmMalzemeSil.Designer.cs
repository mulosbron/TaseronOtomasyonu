namespace Proje
{
    partial class FrmMalzemeSil
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
            this.grpbxMalzemeSil = new System.Windows.Forms.GroupBox();
            this.lblMalzemeSil2 = new System.Windows.Forms.Label();
            this.btnMalzemeDBSil = new System.Windows.Forms.Button();
            this.txtMalzemeSil = new System.Windows.Forms.TextBox();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.lblMalzemeSil1 = new System.Windows.Forms.Label();
            this.grpbxMalzemeSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxMalzemeSil
            // 
            this.grpbxMalzemeSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxMalzemeSil.BackColor = System.Drawing.Color.Gray;
            this.grpbxMalzemeSil.Controls.Add(this.lblMalzemeSil2);
            this.grpbxMalzemeSil.Controls.Add(this.btnMalzemeDBSil);
            this.grpbxMalzemeSil.Controls.Add(this.txtMalzemeSil);
            this.grpbxMalzemeSil.Controls.Add(this.btnMalzemeSil);
            this.grpbxMalzemeSil.Controls.Add(this.lblMalzemeSil1);
            this.grpbxMalzemeSil.Location = new System.Drawing.Point(12, 12);
            this.grpbxMalzemeSil.Name = "grpbxMalzemeSil";
            this.grpbxMalzemeSil.Size = new System.Drawing.Size(438, 229);
            this.grpbxMalzemeSil.TabIndex = 3;
            this.grpbxMalzemeSil.TabStop = false;
            this.grpbxMalzemeSil.Text = "Malzeme Kaydı Sil";
            // 
            // lblMalzemeSil2
            // 
            this.lblMalzemeSil2.AutoSize = true;
            this.lblMalzemeSil2.Location = new System.Drawing.Point(44, 82);
            this.lblMalzemeSil2.Name = "lblMalzemeSil2";
            this.lblMalzemeSil2.Size = new System.Drawing.Size(227, 35);
            this.lblMalzemeSil2.TabIndex = 6;
            this.lblMalzemeSil2.Text = "Malzemenin ID\'si :";
            // 
            // btnMalzemeDBSil
            // 
            this.btnMalzemeDBSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMalzemeDBSil.Location = new System.Drawing.Point(16, 171);
            this.btnMalzemeDBSil.Name = "btnMalzemeDBSil";
            this.btnMalzemeDBSil.Size = new System.Drawing.Size(356, 42);
            this.btnMalzemeDBSil.TabIndex = 5;
            this.btnMalzemeDBSil.Text = "Tüm Kayıtlı Malzemeleri Sil";
            this.btnMalzemeDBSil.UseVisualStyleBackColor = true;
            this.btnMalzemeDBSil.Click += new System.EventHandler(this.btnMalzemeDBSil_Click);
            // 
            // txtMalzemeSil
            // 
            this.txtMalzemeSil.BackColor = System.Drawing.Color.Silver;
            this.txtMalzemeSil.Location = new System.Drawing.Point(277, 82);
            this.txtMalzemeSil.Name = "txtMalzemeSil";
            this.txtMalzemeSil.Size = new System.Drawing.Size(149, 40);
            this.txtMalzemeSil.TabIndex = 4;
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.Location = new System.Drawing.Point(351, 127);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(75, 42);
            this.btnMalzemeSil.TabIndex = 2;
            this.btnMalzemeSil.Text = "Sil";
            this.btnMalzemeSil.UseVisualStyleBackColor = true;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // lblMalzemeSil1
            // 
            this.lblMalzemeSil1.AutoSize = true;
            this.lblMalzemeSil1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalzemeSil1.Location = new System.Drawing.Point(16, 50);
            this.lblMalzemeSil1.Name = "lblMalzemeSil1";
            this.lblMalzemeSil1.Size = new System.Drawing.Size(221, 35);
            this.lblMalzemeSil1.TabIndex = 0;
            this.lblMalzemeSil1.Text = "Silmek İstediğiniz";
            // 
            // FrmMalzemeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.grpbxMalzemeSil);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FrmMalzemeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Kaydı Sil";
            this.grpbxMalzemeSil.ResumeLayout(false);
            this.grpbxMalzemeSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxMalzemeSil;
        private System.Windows.Forms.Label lblMalzemeSil2;
        private System.Windows.Forms.Button btnMalzemeDBSil;
        private System.Windows.Forms.TextBox txtMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Label lblMalzemeSil1;
    }
}