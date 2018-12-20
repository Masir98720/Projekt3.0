namespace Projekt
{
    partial class Hauptanzeige
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
            this.Btn_Weller = new System.Windows.Forms.Button();
            this.Btn_Hafner = new System.Windows.Forms.Button();
            this.Btn_Ernst = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.TrackbarGreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackbarBlue = new System.Windows.Forms.TrackBar();
            this.TrackbarRed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Weller
            // 
            this.Btn_Weller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Weller.Location = new System.Drawing.Point(686, 200);
            this.Btn_Weller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Weller.Name = "Btn_Weller";
            this.Btn_Weller.Size = new System.Drawing.Size(132, 53);
            this.Btn_Weller.TabIndex = 0;
            this.Btn_Weller.Text = "Weller/Spannungsfall/          Berechnung";
            this.Btn_Weller.UseVisualStyleBackColor = true;
            this.Btn_Weller.Click += new System.EventHandler(this.Btn_Weller_Click);
            // 
            // Btn_Hafner
            // 
            this.Btn_Hafner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Hafner.Location = new System.Drawing.Point(686, 258);
            this.Btn_Hafner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Hafner.Name = "Btn_Hafner";
            this.Btn_Hafner.Size = new System.Drawing.Size(132, 53);
            this.Btn_Hafner.TabIndex = 1;
            this.Btn_Hafner.Text = "Hafner/                             Sicherungsauswahl";
            this.Btn_Hafner.UseVisualStyleBackColor = true;
            this.Btn_Hafner.Click += new System.EventHandler(this.Btn_Hafner_Click);
            // 
            // Btn_Ernst
            // 
            this.Btn_Ernst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ernst.Location = new System.Drawing.Point(686, 315);
            this.Btn_Ernst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Ernst.Name = "Btn_Ernst";
            this.Btn_Ernst.Size = new System.Drawing.Size(132, 53);
            this.Btn_Ernst.TabIndex = 2;
            this.Btn_Ernst.Text = "Ernst/          Querschnittsberechnung";
            this.Btn_Ernst.UseVisualStyleBackColor = true;
            this.Btn_Ernst.Click += new System.EventHandler(this.Btn_Ernst_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Location = new System.Drawing.Point(535, 315);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(146, 53);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Beenden";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // TrackbarGreen
            // 
            this.TrackbarGreen.Location = new System.Drawing.Point(16, 308);
            this.TrackbarGreen.Margin = new System.Windows.Forms.Padding(2);
            this.TrackbarGreen.Maximum = 255;
            this.TrackbarGreen.Name = "TrackbarGreen";
            this.TrackbarGreen.Size = new System.Drawing.Size(452, 45);
            this.TrackbarGreen.TabIndex = 4;
            this.TrackbarGreen.Scroll += new System.EventHandler(this.Trackbar_Hintergrundfarbe_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hintergrundfarbe";
            // 
            // TrackbarBlue
            // 
            this.TrackbarBlue.Location = new System.Drawing.Point(16, 258);
            this.TrackbarBlue.Margin = new System.Windows.Forms.Padding(2);
            this.TrackbarBlue.Maximum = 255;
            this.TrackbarBlue.Name = "TrackbarBlue";
            this.TrackbarBlue.Size = new System.Drawing.Size(452, 45);
            this.TrackbarBlue.TabIndex = 6;
            // 
            // TrackbarRed
            // 
            this.TrackbarRed.Location = new System.Drawing.Point(16, 200);
            this.TrackbarRed.Margin = new System.Windows.Forms.Padding(2);
            this.TrackbarRed.Maximum = 255;
            this.TrackbarRed.Name = "TrackbarRed";
            this.TrackbarRed.Size = new System.Drawing.Size(452, 45);
            this.TrackbarRed.TabIndex = 7;
            // 
            // Hauptanzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 378);
            this.Controls.Add(this.TrackbarRed);
            this.Controls.Add(this.TrackbarBlue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackbarGreen);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Ernst);
            this.Controls.Add(this.Btn_Hafner);
            this.Controls.Add(this.Btn_Weller);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hauptanzeige";
            this.Text = "Hauptanzeige";
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Weller;
        private System.Windows.Forms.Button Btn_Hafner;
        private System.Windows.Forms.Button Btn_Ernst;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TrackBar TrackbarGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackbarBlue;
        private System.Windows.Forms.TrackBar TrackbarRed;
    }
}

