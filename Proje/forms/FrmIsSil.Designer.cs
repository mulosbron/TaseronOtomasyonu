namespace Proje
{
    partial class FrmIsSil
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
            this.grpbxIsSil = new System.Windows.Forms.GroupBox();
            this.btnIsDBSil = new System.Windows.Forms.Button();
            this.txtIsSil = new System.Windows.Forms.TextBox();
            this.btnIsSil = new System.Windows.Forms.Button();
            this.lblIsSil = new System.Windows.Forms.Label();
            this.grpbxIsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxIsSil
            // 
            this.grpbxIsSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIsSil.BackColor = System.Drawing.Color.Gray;
            this.grpbxIsSil.Controls.Add(this.btnIsDBSil);
            this.grpbxIsSil.Controls.Add(this.txtIsSil);
            this.grpbxIsSil.Controls.Add(this.btnIsSil);
            this.grpbxIsSil.Controls.Add(this.lblIsSil);
            this.grpbxIsSil.Location = new System.Drawing.Point(12, 12);
            this.grpbxIsSil.Name = "grpbxIsSil";
            this.grpbxIsSil.Size = new System.Drawing.Size(438, 229);
            this.grpbxIsSil.TabIndex = 2;
            this.grpbxIsSil.TabStop = false;
            this.grpbxIsSil.Text = "İş Kaydı Sil";
            // 
            // btnIsDBSil
            // 
            this.btnIsDBSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIsDBSil.Location = new System.Drawing.Point(16, 171);
            this.btnIsDBSil.Name = "btnIsDBSil";
            this.btnIsDBSil.Size = new System.Drawing.Size(255, 42);
            this.btnIsDBSil.TabIndex = 5;
            this.btnIsDBSil.Text = "Tüm Kayıtlı İşleri Sil";
            this.btnIsDBSil.UseVisualStyleBackColor = true;
            this.btnIsDBSil.Click += new System.EventHandler(this.btnIsDBSil_Click);
            // 
            // txtIsSil
            // 
            this.txtIsSil.BackColor = System.Drawing.Color.Silver;
            this.txtIsSil.Location = new System.Drawing.Point(351, 65);
            this.txtIsSil.Name = "txtIsSil";
            this.txtIsSil.Size = new System.Drawing.Size(75, 40);
            this.txtIsSil.TabIndex = 4;
            // 
            // btnIsSil
            // 
            this.btnIsSil.Location = new System.Drawing.Point(351, 127);
            this.btnIsSil.Name = "btnIsSil";
            this.btnIsSil.Size = new System.Drawing.Size(75, 42);
            this.btnIsSil.TabIndex = 2;
            this.btnIsSil.Text = "Sil";
            this.btnIsSil.UseVisualStyleBackColor = true;
            this.btnIsSil.Click += new System.EventHandler(this.btnIsSil_Click);
            // 
            // lblIsSil
            // 
            this.lblIsSil.AutoSize = true;
            this.lblIsSil.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsSil.Location = new System.Drawing.Point(10, 65);
            this.lblIsSil.Name = "lblIsSil";
            this.lblIsSil.Size = new System.Drawing.Size(335, 35);
            this.lblIsSil.TabIndex = 0;
            this.lblIsSil.Text = "Silmek İstediğiniz İşin ID\'si :";
            // 
            // FrmIsSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(462, 253);
            this.Controls.Add(this.grpbxIsSil);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FrmIsSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Kaydı Sil";
            this.grpbxIsSil.ResumeLayout(false);
            this.grpbxIsSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxIsSil;
        private System.Windows.Forms.TextBox txtIsSil;
        private System.Windows.Forms.Button btnIsSil;
        private System.Windows.Forms.Label lblIsSil;
        private System.Windows.Forms.Button btnIsDBSil;
    }
}