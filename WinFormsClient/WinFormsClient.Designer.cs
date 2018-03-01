namespace WinFormsClient
{
    partial class WinFormsClient
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdVerbinden = new System.Windows.Forms.Button();
            this.txtIpAdresse = new IPv4Address.IPv4AddressTextBox();
            this.pbVerbindung = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerbindung)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdVerbinden
            // 
            this.cmdVerbinden.Location = new System.Drawing.Point(214, 7);
            this.cmdVerbinden.Name = "cmdVerbinden";
            this.cmdVerbinden.Size = new System.Drawing.Size(75, 23);
            this.cmdVerbinden.TabIndex = 1;
            this.cmdVerbinden.Text = "Verbinden";
            this.cmdVerbinden.UseVisualStyleBackColor = true;
            this.cmdVerbinden.Click += new System.EventHandler(this.cmdVerbinden_Click);
            // 
            // txtIpAdresse
            // 
            this.txtIpAdresse.Location = new System.Drawing.Point(11, 6);
            this.txtIpAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIpAdresse.Name = "txtIpAdresse";
            this.txtIpAdresse.Size = new System.Drawing.Size(185, 24);
            this.txtIpAdresse.TabIndex = 2;
            // 
            // pbVerbindung
            // 
            this.pbVerbindung.BackColor = System.Drawing.Color.Red;
            this.pbVerbindung.Location = new System.Drawing.Point(295, 7);
            this.pbVerbindung.Name = "pbVerbindung";
            this.pbVerbindung.Size = new System.Drawing.Size(28, 22);
            this.pbVerbindung.TabIndex = 3;
            this.pbVerbindung.TabStop = false;
            // 
            // WinFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 351);
            this.Controls.Add(this.pbVerbindung);
            this.Controls.Add(this.txtIpAdresse);
            this.Controls.Add(this.cmdVerbinden);
            this.Name = "WinFormsClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.WinFormsClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVerbindung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdVerbinden;
        private IPv4Address.IPv4AddressTextBox txtIpAdresse;
        private System.Windows.Forms.PictureBox pbVerbindung;
    }
}

