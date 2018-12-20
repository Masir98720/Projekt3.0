using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Weller : Form
    {
        //Globale Variable für Buttonabfrage
        int Stop;
        public Weller()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        //Methode für die Berechnung des Spannungsfalls für Wechselstrom
        public double Berechne(double Wechselstrom) //Übergabe der Werte
        {
            double Ergebniss1=0;
            // Variable Länge
            double Länge = Convert.ToDouble(Txt_Spann_Laenge.Text);
            //Variable Cosinus
            double Cosinus = Convert.ToDouble(Txt_Spann_Cosinus.Text);
            //Variable Ampere(Strom)
            double Ampere = Convert.ToDouble(Txt_Spann_Ampere.Text);

            Ergebniss1 = Länge *Cosinus*Ampere*Wechselstrom;
            return Ergebniss1;

        }
        //Methode für die Berechnung des Spannungsfalls für Drehstrom
        public double Berechne2(double Drehstrom) //Übergabe der Werte
        {
            double Ergebniss1 = 0;
            // Variable Länge
            double Länge = Convert.ToDouble(Txt_Spann_Laenge.Text);
            //Variable Cosinus
            double Cosinus = Convert.ToDouble(Txt_Spann_Cosinus.Text);
            //Variable Ampere(Strom)
            double Ampere = Convert.ToDouble(Txt_Spann_Ampere.Text);

            Ergebniss1 = Länge * Cosinus * Ampere * Drehstrom;
            return Ergebniss1;

        }
        //Missklick
        private void Weller_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Spann_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Spann_Reset_Click(object sender, EventArgs e)
        {
            //Resetten der Eingaben
            Txt_Spann_Cosinus.Text = "0";
            Txt_Spann_Ampere.Text = "0";
            Txt_Spann_Kabelquerschnitt.Text = "0";
            Txt_Spann_Laenge.Text = "0";
            lbl_Ergebniss.Text = "0";
            Txt_Spann_Spannung.Text = "0";
            pic_Daumen_Runter.Visible = false;
            pic_Daumen_Hoch.Visible = false;
            lbl_Spannungstoleranz.Text = " ";

        }

        private void Btn_Spann_Berechnen_Click(object sender, EventArgs e)
        {
            //Resetten des Bildes Daumen Hoch/Daumen Runter
            pic_Daumen_Runter.Visible = false;
            pic_Daumen_Hoch.Visible = false;
            lbl_Spannungstoleranz.Text = " ";
            //Variable Kabelquerschnitt
            double Querschnitt = Convert.ToDouble(Txt_Spann_Kabelquerschnitt.Text);
            //Variale Spannung
            double Spannung = Convert.ToDouble(Txt_Spann_Spannung.Text);
            //Variable Drehstrom
            double Drehstrom = 173;
            //Variable Wechselstrom
            double Wechselstrom= 200;
            //Variable Kupfer
            double Kupfer = 56;
            // Variable Aluminium
            double Aluminium = 36;
            // Variable Leitwert
            double Leitwert=1;
            //Variablen für die Ergebnisse
            double Ergebniss2 = 0;
            double Ergebniss3 = 0;
            //Variable um das Ergebniss zu Runden
            double Runden;



             

            //Auswahl des Leitwertes des Kabels
            if (rad_Spann_Kupfer.Checked==true)
            {
                Leitwert = Kupfer;
                Stop = 0;
            }
            else if (rad_Spann_Aluminium.Checked==true)
            {
                Leitwert = Aluminium;
                Stop = 0;
            }
            else if (rad_Spann_Aluminium.Checked == false && rad_Spann_Kupfer.Checked == false)
            {
                MessageBox.Show("Bitte Leitwert eingeben", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Stop = 1;
            }

            //Berechnung des Spannungsfall bei Wechselstrom
            
            if (rad_Spannungsfall_Wechsel.Checked == true && Stop == 0)
            {
                Ergebniss2 = Leitwert * Querschnitt * Spannung;
                Ergebniss3 = Berechne(Wechselstrom)/Ergebniss2;
                //Rundung des Ergebnisses
                Runden = Math.Round(Ergebniss3, 2);
                //Ausgabe des Ergebnisses 
                lbl_Ergebniss.Text = "Der Spannungsfall beträgt"+" " + Runden.ToString()+"%";
            }

            //Berechnung des Spannungsfall bei Drehstrom
            else if (rad_Spannungsfall_Drehstrom.Checked == true && Stop == 0)
            {

                Ergebniss2 = Leitwert * Querschnitt * Spannung;
                Ergebniss3 = Berechne2(Drehstrom) / Ergebniss2;
                //Runden des Ergebnisses
                Runden = Math.Round(Ergebniss3, 2);
                //Ausgabe des Ergebnisses
                lbl_Ergebniss.Text = "Der Spannungsfall beträgt" + " " + Runden.ToString() + "%";
            }
             else if (rad_Spannungsfall_Drehstrom.Checked== false && rad_Spannungsfall_Wechsel.Checked == false)
            {
                MessageBox.Show("Bitte Betriebsart eingeben", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Ergebniss3 < 5)
            {
                pic_Daumen_Hoch.Visible = true;
                lbl_Spannungstoleranz.Text = "Der Spannungsfall ist in der Toleranz";
                lbl_Ergebniss.ForeColor = Color.Green;
            }
            else if (Ergebniss3 >5)
            {
                pic_Daumen_Runter.Visible = true;
                lbl_Spannungstoleranz.Text = "Der Spannungsfall ist nicht mehr in der Toleranz";
                lbl_Ergebniss.ForeColor = Color.Red;
            }
        }
    }
}
