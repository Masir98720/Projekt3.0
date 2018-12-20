namespace Projekt
{
    partial class Ernst
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
            this.Btn_Querschnitt_Reset = new System.Windows.Forms.Button();
            this.Btn_Querschnitt_Close = new System.Windows.Forms.Button();
            this.Btn_Querschnitt_Berechnen = new System.Windows.Forms.Button();
            this.txt_Leitungslänge_Quer = new System.Windows.Forms.TextBox();
            this.txt_Strom_Quer = new System.Windows.Forms.TextBox();
            this.lbl_ergebniss_Querschnittsberechnung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rad_Aluminium_Quer = new System.Windows.Forms.RadioButton();
            this.rad_Kupfer_Quer = new System.Windows.Forms.RadioButton();
            this.Spannungsfall = new System.Windows.Forms.Label();
            this.txt_Spann_Quer = new System.Windows.Forms.TextBox();
            this.rad_Drehstrom_Quer = new System.Windows.Forms.RadioButton();
            this.rad_Wechselstrom_Quer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Quer_Cosinus = new System.Windows.Forms.TextBox();
            this.Cosinus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Querschnitt_Reset
            // 
            this.Btn_Querschnitt_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Querschnitt_Reset.Location = new System.Drawing.Point(930, 317);
            this.Btn_Querschnitt_Reset.Name = "Btn_Querschnitt_Reset";
            this.Btn_Querschnitt_Reset.Size = new System.Drawing.Size(153, 61);
            this.Btn_Querschnitt_Reset.TabIndex = 5;
            this.Btn_Querschnitt_Reset.Text = "Reset";
            this.Btn_Querschnitt_Reset.UseVisualStyleBackColor = true;
            this.Btn_Querschnitt_Reset.Click += new System.EventHandler(this.Btn_Querschnitt_Reset_Click);
            // 
            // Btn_Querschnitt_Close
            // 
            this.Btn_Querschnitt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Querschnitt_Close.Location = new System.Drawing.Point(880, 407);
            this.Btn_Querschnitt_Close.Name = "Btn_Querschnitt_Close";
            this.Btn_Querschnitt_Close.Size = new System.Drawing.Size(203, 94);
            this.Btn_Querschnitt_Close.TabIndex = 4;
            this.Btn_Querschnitt_Close.Text = "Beenden";
            this.Btn_Querschnitt_Close.UseVisualStyleBackColor = true;
            this.Btn_Querschnitt_Close.Click += new System.EventHandler(this.Btn_Querschnitt_Close_Click);
            // 
            // Btn_Querschnitt_Berechnen
            // 
            this.Btn_Querschnitt_Berechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Querschnitt_Berechnen.Location = new System.Drawing.Point(635, 407);
            this.Btn_Querschnitt_Berechnen.Name = "Btn_Querschnitt_Berechnen";
            this.Btn_Querschnitt_Berechnen.Size = new System.Drawing.Size(203, 94);
            this.Btn_Querschnitt_Berechnen.TabIndex = 3;
            this.Btn_Querschnitt_Berechnen.Text = "Berechnen";
            this.Btn_Querschnitt_Berechnen.UseVisualStyleBackColor = true;
            this.Btn_Querschnitt_Berechnen.Click += new System.EventHandler(this.Btn_Querschnitt_Berechnen_Click);
            // 
            // txt_Leitungslänge_Quer
            // 
            this.txt_Leitungslänge_Quer.Location = new System.Drawing.Point(95, 73);
            this.txt_Leitungslänge_Quer.Name = "txt_Leitungslänge_Quer";
            this.txt_Leitungslänge_Quer.Size = new System.Drawing.Size(100, 22);
            this.txt_Leitungslänge_Quer.TabIndex = 6;
            this.txt_Leitungslänge_Quer.Text = "0";
            // 
            // txt_Strom_Quer
            // 
            this.txt_Strom_Quer.Location = new System.Drawing.Point(98, 168);
            this.txt_Strom_Quer.Name = "txt_Strom_Quer";
            this.txt_Strom_Quer.Size = new System.Drawing.Size(100, 22);
            this.txt_Strom_Quer.TabIndex = 8;
            this.txt_Strom_Quer.Text = "0";
            // 
            // lbl_ergebniss_Querschnittsberechnung
            // 
            this.lbl_ergebniss_Querschnittsberechnung.AutoSize = true;
            this.lbl_ergebniss_Querschnittsberechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ergebniss_Querschnittsberechnung.Location = new System.Drawing.Point(619, 75);
            this.lbl_ergebniss_Querschnittsberechnung.Name = "lbl_ergebniss_Querschnittsberechnung";
            this.lbl_ergebniss_Querschnittsberechnung.Size = new System.Drawing.Size(0, 91);
            this.lbl_ergebniss_Querschnittsberechnung.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Leitungslänge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Strom";
            // 
            // rad_Aluminium_Quer
            // 
            this.rad_Aluminium_Quer.AutoSize = true;
            this.rad_Aluminium_Quer.Location = new System.Drawing.Point(17, 21);
            this.rad_Aluminium_Quer.Name = "rad_Aluminium_Quer";
            this.rad_Aluminium_Quer.Size = new System.Drawing.Size(93, 21);
            this.rad_Aluminium_Quer.TabIndex = 13;
            this.rad_Aluminium_Quer.TabStop = true;
            this.rad_Aluminium_Quer.Text = "Aluminium";
            this.rad_Aluminium_Quer.UseVisualStyleBackColor = true;
            this.rad_Aluminium_Quer.CheckedChanged += new System.EventHandler(this.rad_Aluminium_Quer_CheckedChanged);
            // 
            // rad_Kupfer_Quer
            // 
            this.rad_Kupfer_Quer.AutoSize = true;
            this.rad_Kupfer_Quer.Location = new System.Drawing.Point(17, 48);
            this.rad_Kupfer_Quer.Name = "rad_Kupfer_Quer";
            this.rad_Kupfer_Quer.Size = new System.Drawing.Size(71, 21);
            this.rad_Kupfer_Quer.TabIndex = 14;
            this.rad_Kupfer_Quer.TabStop = true;
            this.rad_Kupfer_Quer.Text = "Kupfer";
            this.rad_Kupfer_Quer.UseVisualStyleBackColor = true;
            // 
            // Spannungsfall
            // 
            this.Spannungsfall.AutoSize = true;
            this.Spannungsfall.Location = new System.Drawing.Point(100, 225);
            this.Spannungsfall.Name = "Spannungsfall";
            this.Spannungsfall.Size = new System.Drawing.Size(98, 17);
            this.Spannungsfall.TabIndex = 15;
            this.Spannungsfall.Text = "Spannungsfall";
            this.Spannungsfall.Click += new System.EventHandler(this.Spannungsfall_Click);
            // 
            // txt_Spann_Quer
            // 
            this.txt_Spann_Quer.Location = new System.Drawing.Point(103, 264);
            this.txt_Spann_Quer.Name = "txt_Spann_Quer";
            this.txt_Spann_Quer.Size = new System.Drawing.Size(100, 22);
            this.txt_Spann_Quer.TabIndex = 16;
            this.txt_Spann_Quer.Text = "0";
            // 
            // rad_Drehstrom_Quer
            // 
            this.rad_Drehstrom_Quer.AutoSize = true;
            this.rad_Drehstrom_Quer.Location = new System.Drawing.Point(6, 21);
            this.rad_Drehstrom_Quer.Name = "rad_Drehstrom_Quer";
            this.rad_Drehstrom_Quer.Size = new System.Drawing.Size(95, 21);
            this.rad_Drehstrom_Quer.TabIndex = 17;
            this.rad_Drehstrom_Quer.TabStop = true;
            this.rad_Drehstrom_Quer.Text = "Drehstrom";
            this.rad_Drehstrom_Quer.UseVisualStyleBackColor = true;
            // 
            // rad_Wechselstrom_Quer
            // 
            this.rad_Wechselstrom_Quer.AutoSize = true;
            this.rad_Wechselstrom_Quer.Location = new System.Drawing.Point(6, 48);
            this.rad_Wechselstrom_Quer.Name = "rad_Wechselstrom_Quer";
            this.rad_Wechselstrom_Quer.Size = new System.Drawing.Size(118, 21);
            this.rad_Wechselstrom_Quer.TabIndex = 18;
            this.rad_Wechselstrom_Quer.TabStop = true;
            this.rad_Wechselstrom_Quer.Text = "Wechselstrom";
            this.rad_Wechselstrom_Quer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Drehstrom_Quer);
            this.groupBox1.Controls.Add(this.rad_Wechselstrom_Quer);
            this.groupBox1.Location = new System.Drawing.Point(332, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betriebsart";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_Aluminium_Quer);
            this.groupBox2.Controls.Add(this.rad_Kupfer_Quer);
            this.groupBox2.Location = new System.Drawing.Point(332, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leitwert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ampere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Volt";
            // 
            // Txt_Quer_Cosinus
            // 
            this.Txt_Quer_Cosinus.Location = new System.Drawing.Point(103, 347);
            this.Txt_Quer_Cosinus.Name = "Txt_Quer_Cosinus";
            this.Txt_Quer_Cosinus.Size = new System.Drawing.Size(100, 22);
            this.Txt_Quer_Cosinus.TabIndex = 24;
            this.Txt_Quer_Cosinus.Text = "0";
            // 
            // Cosinus
            // 
            this.Cosinus.AutoSize = true;
            this.Cosinus.Location = new System.Drawing.Point(100, 317);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(58, 17);
            this.Cosinus.TabIndex = 25;
            this.Cosinus.Text = "Cosinus";
            // 
            // Ernst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 528);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Txt_Quer_Cosinus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Spann_Quer);
            this.Controls.Add(this.Spannungsfall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ergebniss_Querschnittsberechnung);
            this.Controls.Add(this.txt_Strom_Quer);
            this.Controls.Add(this.txt_Leitungslänge_Quer);
            this.Controls.Add(this.Btn_Querschnitt_Reset);
            this.Controls.Add(this.Btn_Querschnitt_Close);
            this.Controls.Add(this.Btn_Querschnitt_Berechnen);
            this.Name = "Ernst";
            this.Text = "Ernst/Querschnittsberechnung";
            this.Load += new System.EventHandler(this.Ernst_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Querschnitt_Reset;
        private System.Windows.Forms.Button Btn_Querschnitt_Close;
        private System.Windows.Forms.Button Btn_Querschnitt_Berechnen;
        private System.Windows.Forms.TextBox txt_Leitungslänge_Quer;
        private System.Windows.Forms.TextBox txt_Strom_Quer;
        private System.Windows.Forms.Label lbl_ergebniss_Querschnittsberechnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rad_Aluminium_Quer;
        private System.Windows.Forms.RadioButton rad_Kupfer_Quer;
        private System.Windows.Forms.Label Spannungsfall;
        private System.Windows.Forms.TextBox txt_Spann_Quer;
        private System.Windows.Forms.RadioButton rad_Drehstrom_Quer;
        private System.Windows.Forms.RadioButton rad_Wechselstrom_Quer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Quer_Cosinus;
        private System.Windows.Forms.Label Cosinus;
    }
}