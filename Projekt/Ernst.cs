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
    public partial class Ernst : Form
    {
        public Ernst()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        
        private void Btn_Querschnitt_Berechnen_Click(object sender, EventArgs e)
        {
            //Eingabe der Leitungslänge für die Berechnung
            double Leitungslänge;
            Leitungslänge = Convert.ToDouble(txt_Leitungslänge_Quer.Text);
            //Eingabe des Stromes für die Berechnung 
            double Strom;
            Strom = Convert.ToDouble(txt_Strom_Quer.Text);
            //Eingabe des Spannungsfalls
            double Spannungsfall;
            Spannungsfall = Convert.ToDouble(txt_Spann_Quer.Text);
            //Variable für Cosinus
            double Cosinus;
            Cosinus = Convert.ToDouble(Txt_Quer_Cosinus.Text);
            //Variable für das Ergeniss der Rechnung
            double Ergebnis1 = 0;
            double Ergebnis2 = 0;
            double Ergebnis3 = 0;
            //Variablen für Aluminium und Kupfer
            double Kupfer = 56;
            double Aluminium = 36;
            //Variable für den Leitwert
            double Leitwert = 1;
            //Variable für das Runden des Ergebnisses 
            double Runden = 0;
            
            
            if (rad_Kupfer_Quer.Checked == true)
            {
                //Leitwert für Kupfer setzen
                Leitwert = Kupfer;
            }

            else if (rad_Aluminium_Quer.Checked== true)
            {
                //Leitwert für Aluminium setzen
                Leitwert = Aluminium;
            }
 
            //Auswahl der Betruebsart Drehstrom
             if (rad_Drehstrom_Quer.Checked == true )
            {
                
                //Berechnung Des Querschnitts im Drehstrombereich
                Ergebnis1 = Leitungslänge * Strom * 1.732 * Cosinus;
                Ergebnis2 = Leitwert * Spannungsfall;
                Ergebnis3 = Ergebnis1 / Ergebnis2;
                //Das Ergebniss runden
                Runden = Math.Round(Ergebnis3, 2);
                //Ausgabe des Ergebnisses an lbl_quer_ergebnis
                lbl_ergebniss_Querschnittsberechnung.Text = Runden.ToString()+"mm²";
           
            }
            //Auswahl der Betriebsart Wechselstrom
            else if (rad_Wechselstrom_Quer.Checked == true)
            {
                //Berechnung Des Querschnitts im Wechselstrom
                Ergebnis1 = Leitungslänge * Strom * 2 *Cosinus;
                Ergebnis2 = Leitwert * Spannungsfall;
                Ergebnis3 = Ergebnis1 / Ergebnis2;
                //Das Ergebniss runden
                Runden = Math.Round(Ergebnis3, 2);
                //Ausgabe des Ergebnisses an lbl_quer_ergebnis
                lbl_ergebniss_Querschnittsberechnung.Text = Runden.ToString()+"mm²";
            }


        }
        //Unnötig
        private void rad_Aluminium_Quer_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Querschnitt_Close_Click(object sender, EventArgs e)
        {
            // Zum Beenden der Form 
            Close();
        }


        private void Btn_Querschnitt_Reset_Click(object sender, EventArgs e)
        {
            //Alle Werte auf 0 Setzen für eine Neue Eingabe
            txt_Leitungslänge_Quer.Text = "0";
            txt_Spann_Quer.Text = "0";
            txt_Strom_Quer.Text = "0";
        }



        //Missclick
        private void Spannungsfall_Click(object sender, EventArgs e)
        {

        }


        //Missclick
        private void Ernst_Load(object sender, EventArgs e)
        {

        }
    }
}
