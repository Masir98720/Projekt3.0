namespace Projekt
{
    partial class Weller
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
            this.Btn_Spann_Berechnen = new System.Windows.Forms.Button();
            this.Btn_Spann_Close = new System.Windows.Forms.Button();
            this.Btn_Spann_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Ergebniss = new System.Windows.Forms.Label();
            this.Txt_Spann_Laenge = new System.Windows.Forms.TextBox();
            this.Txt_Spann_Kabelquerschnitt = new System.Windows.Forms.TextBox();
            this.Txt_Spann_Ampere = new System.Windows.Forms.TextBox();
            this.rad_Spannungsfall_Drehstrom = new System.Windows.Forms.RadioButton();
            this.rad_Spannungsfall_Wechsel = new System.Windows.Forms.RadioButton();
            this.Txt_Spann_Cosinus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_Spann_Aluminium = new System.Windows.Forms.RadioButton();
            this.rad_Spann_Kupfer = new System.Windows.Forms.RadioButton();
            this.Txt_Spann_Spannung = new System.Windows.Forms.TextBox();
            this.Spannung = new System.Windows.Forms.Label();
            this.pic_Daumen_Runter = new System.Windows.Forms.PictureBox();
            this.pic_Daumen_Hoch = new System.Windows.Forms.PictureBox();
            this.lbl_Spannungstoleranz = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Daumen_Runter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Daumen_Hoch)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Spann_Berechnen
            // 
            this.Btn_Spann_Berechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Spann_Berechnen.Location = new System.Drawing.Point(638, 423);
            this.Btn_Spann_Berechnen.Name = "Btn_Spann_Berechnen";
            this.Btn_Spann_Berechnen.Size = new System.Drawing.Size(203, 94);
            this.Btn_Spann_Berechnen.TabIndex = 0;
            this.Btn_Spann_Berechnen.Text = "Berechnen";
            this.Btn_Spann_Berechnen.UseVisualStyleBackColor = true;
            this.Btn_Spann_Berechnen.Click += new System.EventHandler(this.Btn_Spann_Berechnen_Click);
            // 
            // Btn_Spann_Close
            // 
            this.Btn_Spann_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Spann_Close.Location = new System.Drawing.Point(883, 423);
            this.Btn_Spann_Close.Name = "Btn_Spann_Close";
            this.Btn_Spann_Close.Size = new System.Drawing.Size(203, 94);
            this.Btn_Spann_Close.TabIndex = 1;
            this.Btn_Spann_Close.Text = "Beenden";
            this.Btn_Spann_Close.UseVisualStyleBackColor = true;
            this.Btn_Spann_Close.Click += new System.EventHandler(this.Btn_Spann_Close_Click);
            // 
            // Btn_Spann_Reset
            // 
            this.Btn_Spann_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Spann_Reset.Location = new System.Drawing.Point(933, 341);
            this.Btn_Spann_Reset.Name = "Btn_Spann_Reset";
            this.Btn_Spann_Reset.Size = new System.Drawing.Size(153, 61);
            this.Btn_Spann_Reset.TabIndex = 2;
            this.Btn_Spann_Reset.Text = "Reset";
            this.Btn_Spann_Reset.UseVisualStyleBackColor = true;
            this.Btn_Spann_Reset.Click += new System.EventHandler(this.Btn_Spann_Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Länge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kabelquerschnitt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stromstärke ";
            // 
            // lbl_Ergebniss
            // 
            this.lbl_Ergebniss.AutoSize = true;
            this.lbl_Ergebniss.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ergebniss.Location = new System.Drawing.Point(576, 12);
            this.lbl_Ergebniss.Name = "lbl_Ergebniss";
            this.lbl_Ergebniss.Size = new System.Drawing.Size(0, 46);
            this.lbl_Ergebniss.TabIndex = 7;
            // 
            // Txt_Spann_Laenge
            // 
            this.Txt_Spann_Laenge.Location = new System.Drawing.Point(26, 136);
            this.Txt_Spann_Laenge.Name = "Txt_Spann_Laenge";
            this.Txt_Spann_Laenge.Size = new System.Drawing.Size(100, 22);
            this.Txt_Spann_Laenge.TabIndex = 9;
            this.Txt_Spann_Laenge.Text = "0";
            // 
            // Txt_Spann_Kabelquerschnitt
            // 
            this.Txt_Spann_Kabelquerschnitt.Location = new System.Drawing.Point(26, 200);
            this.Txt_Spann_Kabelquerschnitt.Name = "Txt_Spann_Kabelquerschnitt";
            this.Txt_Spann_Kabelquerschnitt.Size = new System.Drawing.Size(100, 22);
            this.Txt_Spann_Kabelquerschnitt.TabIndex = 10;
            this.Txt_Spann_Kabelquerschnitt.Text = "0";
            // 
            // Txt_Spann_Ampere
            // 
            this.Txt_Spann_Ampere.Location = new System.Drawing.Point(245, 136);
            this.Txt_Spann_Ampere.Name = "Txt_Spann_Ampere";
            this.Txt_Spann_Ampere.Size = new System.Drawing.Size(100, 22);
            this.Txt_Spann_Ampere.TabIndex = 11;
            this.Txt_Spann_Ampere.Text = "0";
            // 
            // rad_Spannungsfall_Drehstrom
            // 
            this.rad_Spannungsfall_Drehstrom.AutoSize = true;
            this.rad_Spannungsfall_Drehstrom.Location = new System.Drawing.Point(6, 21);
            this.rad_Spannungsfall_Drehstrom.Name = "rad_Spannungsfall_Drehstrom";
            this.rad_Spannungsfall_Drehstrom.Size = new System.Drawing.Size(95, 21);
            this.rad_Spannungsfall_Drehstrom.TabIndex = 12;
            this.rad_Spannungsfall_Drehstrom.TabStop = true;
            this.rad_Spannungsfall_Drehstrom.Text = "Drehstrom";
            this.rad_Spannungsfall_Drehstrom.UseVisualStyleBackColor = true;
            // 
            // rad_Spannungsfall_Wechsel
            // 
            this.rad_Spannungsfall_Wechsel.AutoSize = true;
            this.rad_Spannungsfall_Wechsel.Location = new System.Drawing.Point(6, 50);
            this.rad_Spannungsfall_Wechsel.Name = "rad_Spannungsfall_Wechsel";
            this.rad_Spannungsfall_Wechsel.Size = new System.Drawing.Size(118, 21);
            this.rad_Spannungsfall_Wechsel.TabIndex = 13;
            this.rad_Spannungsfall_Wechsel.TabStop = true;
            this.rad_Spannungsfall_Wechsel.Text = "Wechselstrom";
            this.rad_Spannungsfall_Wechsel.UseVisualStyleBackColor = true;
            // 
            // Txt_Spann_Cosinus
            // 
            this.Txt_Spann_Cosinus.Location = new System.Drawing.Point(245, 200);
            this.Txt_Spann_Cosinus.Name = "Txt_Spann_Cosinus";
            this.Txt_Spann_Cosinus.Size = new System.Drawing.Size(100, 22);
            this.Txt_Spann_Cosinus.TabIndex = 14;
            this.Txt_Spann_Cosinus.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cosinus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Spannungsfall_Drehstrom);
            this.groupBox1.Controls.Add(this.rad_Spannungsfall_Wechsel);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betriebsart";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_Spann_Aluminium);
            this.groupBox2.Controls.Add(this.rad_Spann_Kupfer);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leitwert";
            // 
            // rad_Spann_Aluminium
            // 
            this.rad_Spann_Aluminium.AutoSize = true;
            this.rad_Spann_Aluminium.Location = new System.Drawing.Point(7, 55);
            this.rad_Spann_Aluminium.Name = "rad_Spann_Aluminium";
            this.rad_Spann_Aluminium.Size = new System.Drawing.Size(93, 21);
            this.rad_Spann_Aluminium.TabIndex = 1;
            this.rad_Spann_Aluminium.TabStop = true;
            this.rad_Spann_Aluminium.Text = "Aluminium";
            this.rad_Spann_Aluminium.UseVisualStyleBackColor = true;
            // 
            // rad_Spann_Kupfer
            // 
            this.rad_Spann_Kupfer.AutoSize = true;
            this.rad_Spann_Kupfer.Location = new System.Drawing.Point(7, 27);
            this.rad_Spann_Kupfer.Name = "rad_Spann_Kupfer";
            this.rad_Spann_Kupfer.Size = new System.Drawing.Size(71, 21);
            this.rad_Spann_Kupfer.TabIndex = 0;
            this.rad_Spann_Kupfer.TabStop = true;
            this.rad_Spann_Kupfer.Text = "Kupfer";
            this.rad_Spann_Kupfer.UseVisualStyleBackColor = true;
            // 
            // Txt_Spann_Spannung
            // 
            this.Txt_Spann_Spannung.Location = new System.Drawing.Point(26, 251);
            this.Txt_Spann_Spannung.Name = "Txt_Spann_Spannung";
            this.Txt_Spann_Spannung.Size = new System.Drawing.Size(100, 22);
            this.Txt_Spann_Spannung.TabIndex = 22;
            this.Txt_Spann_Spannung.Text = "0";
            // 
            // Spannung
            // 
            this.Spannung.AutoSize = true;
            this.Spannung.Location = new System.Drawing.Point(26, 228);
            this.Spannung.Name = "Spannung";
            this.Spannung.Size = new System.Drawing.Size(73, 17);
            this.Spannung.TabIndex = 23;
            this.Spannung.Text = "Spannung";
            // 
            // pic_Daumen_Runter
            // 
            this.pic_Daumen_Runter.Image = global::Projekt.Properties.Resources._1f44e_1f3fc;
            this.pic_Daumen_Runter.Location = new System.Drawing.Point(631, 180);
            this.pic_Daumen_Runter.Name = "pic_Daumen_Runter";
            this.pic_Daumen_Runter.Size = new System.Drawing.Size(251, 232);
            this.pic_Daumen_Runter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Daumen_Runter.TabIndex = 25;
            this.pic_Daumen_Runter.TabStop = false;
            this.pic_Daumen_Runter.Visible = false;
            // 
            // pic_Daumen_Hoch
            // 
            this.pic_Daumen_Hoch.Image = global::Projekt.Properties.Resources._1f44d_1f3fc;
            this.pic_Daumen_Hoch.Location = new System.Drawing.Point(631, 180);
            this.pic_Daumen_Hoch.Name = "pic_Daumen_Hoch";
            this.pic_Daumen_Hoch.Size = new System.Drawing.Size(249, 232);
            this.pic_Daumen_Hoch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Daumen_Hoch.TabIndex = 24;
            this.pic_Daumen_Hoch.TabStop = false;
            this.pic_Daumen_Hoch.Visible = false;
            // 
            // lbl_Spannungstoleranz
            // 
            this.lbl_Spannungstoleranz.AutoSize = true;
            this.lbl_Spannungstoleranz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spannungstoleranz.ForeColor = System.Drawing.Color.Black;
            this.lbl_Spannungstoleranz.Location = new System.Drawing.Point(889, 180);
            this.lbl_Spannungstoleranz.Name = "lbl_Spannungstoleranz";
            this.lbl_Spannungstoleranz.Size = new System.Drawing.Size(0, 32);
            this.lbl_Spannungstoleranz.TabIndex = 26;
            // 
            // Weller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 553);
            this.Controls.Add(this.lbl_Spannungstoleranz);
            this.Controls.Add(this.pic_Daumen_Runter);
            this.Controls.Add(this.pic_Daumen_Hoch);
            this.Controls.Add(this.Spannung);
            this.Controls.Add(this.Txt_Spann_Spannung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Spann_Cosinus);
            this.Controls.Add(this.Txt_Spann_Ampere);
            this.Controls.Add(this.Txt_Spann_Kabelquerschnitt);
            this.Controls.Add(this.Txt_Spann_Laenge);
            this.Controls.Add(this.lbl_Ergebniss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Spann_Reset);
            this.Controls.Add(this.Btn_Spann_Close);
            this.Controls.Add(this.Btn_Spann_Berechnen);
            this.Name = "Weller";
            this.Text = "Weller/Spannungsfall";
            this.Load += new System.EventHandler(this.Weller_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Daumen_Runter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Daumen_Hoch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Spann_Berechnen;
        private System.Windows.Forms.Button Btn_Spann_Close;
        private System.Windows.Forms.Button Btn_Spann_Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Ergebniss;
        private System.Windows.Forms.TextBox Txt_Spann_Laenge;
        private System.Windows.Forms.TextBox Txt_Spann_Kabelquerschnitt;
        private System.Windows.Forms.TextBox Txt_Spann_Ampere;
        private System.Windows.Forms.RadioButton rad_Spannungsfall_Drehstrom;
        private System.Windows.Forms.RadioButton rad_Spannungsfall_Wechsel;
        private System.Windows.Forms.TextBox Txt_Spann_Cosinus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_Spann_Aluminium;
        private System.Windows.Forms.RadioButton rad_Spann_Kupfer;
        private System.Windows.Forms.TextBox Txt_Spann_Spannung;
        private System.Windows.Forms.Label Spannung;
        private System.Windows.Forms.PictureBox pic_Daumen_Hoch;
        private System.Windows.Forms.PictureBox pic_Daumen_Runter;
        private System.Windows.Forms.Label lbl_Spannungstoleranz;
    }
}