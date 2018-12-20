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
    public partial class Hauptanzeige : Form
    {
        public Hauptanzeige()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Weller_Click(object sender, EventArgs e)
        {
            //Aufrufen der Form für den Spannungsfall
            Form Weller = new Weller(); 
            Weller.ShowDialog();
            
        }

        private void Btn_Hafner_Click(object sender, EventArgs e)
        {
            //Aufrufen der Form für die Sicherungsauswahl
            Form Hafner = new Hafner();
            Hafner.ShowDialog();
        }

        private void Btn_Ernst_Click(object sender, EventArgs e)
        {
            //Aufrufen der Form für den Querschnittsberechnung
            Form Ernst = new Ernst();
            Ernst.ShowDialog();

        }
        //Beenden des Programms
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Trackbar_Hintergrundfarbe_Scroll(object sender, EventArgs e)
        {
            Form Hauptanzeige = new Hauptanzeige();

            TrackbarBlue.Value = 255;
            

            Hauptanzeige.BackColor = Color.FromArgb(TrackbarGreen.Value,TrackbarBlue.Value,TrackbarRed.Value);


        }
    }
}
