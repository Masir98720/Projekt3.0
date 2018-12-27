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
    public partial class Hafner : Form
    {
        //Gloabe Variable
        double Ring1    = 0;
        double Ring2    = 0;
        double Ring3    = 0;
        double Ring4    = 0;
        double Ring5    = 0;
        double ZusammenfassungRinge =0;
        double Multiplikator;
        double Toleranz;
        double Ergebniss4ringe =0;

        public Hafner()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        //Missclick
        private void Hafner_Load(object sender, EventArgs e)
        {

        }
        //Resett Button
        private void Btn_Sicherung_Reset_Click(object sender, EventArgs e)
        {

        }
        //Form Schließen
        private void Btn_Sicherung_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rad_But_4_Ringe_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = false;
           
            listBox5.Visible = false;
            List_Box_Multiplikator.Visible = true;
            List_Box_Toleranz.Visible = true;
            lblring1.Visible = true;
            lblring2.Visible = true;
            lblring3.Visible = false;
            lblMult.Visible = true;
            LblTolleranz.Visible = true;
            lblring5.Visible = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            
            listBox5.Items.Clear();
            List_Box_Multiplikator.Items.Clear();
            List_Box_Toleranz.Items.Clear();
            //Ring 1 Textauswahl
            listBox1.Items.Add("Schwarz\t0");
            listBox1.Items.Add("Braun\t1");
            listBox1.Items.Add("Rot\t2");
            listBox1.Items.Add("Orange\t3");
            listBox1.Items.Add("Gelb\t4");
            listBox1.Items.Add("Grün\t5");
            listBox1.Items.Add("Blau\t6");
            listBox1.Items.Add("Violett\t7");
            listBox1.Items.Add("Grau\t8");
            listBox1.Items.Add("Weiß\t9");
            //Ring 2 Textauswahl
            listBox2.Items.Add("Schwarz\t0");
            listBox2.Items.Add("Braun\t1");
            listBox2.Items.Add("Rot\t2");
            listBox2.Items.Add("Orange\t3");
            listBox2.Items.Add("Gelb\t4");
            listBox2.Items.Add("Grün\t5");
            listBox2.Items.Add("Blau\t6");
            listBox2.Items.Add("Violett\t7");
            listBox2.Items.Add("Grau\t8");
            listBox2.Items.Add("Weiß\t9");
            //Ring 3 Textauswahl
            listBox3.Items.Add("Schwarz\t0");
            listBox3.Items.Add("Braun\t1");
            listBox3.Items.Add("Rot\t2");
            listBox3.Items.Add("Orange\t3");
            listBox3.Items.Add("Gelb\t4");
            listBox3.Items.Add("Grün\t5");
            listBox3.Items.Add("Blau\t6");
            listBox3.Items.Add("Violett\t7");
            listBox3.Items.Add("Grau\t8");
            listBox3.Items.Add("Weiß\t9");
            //Multiplikator Textauswahl
            List_Box_Multiplikator.Items.Add("Schwarz\tx1\tOhm");
            List_Box_Multiplikator.Items.Add("Braun\tx10\tOhm");
            List_Box_Multiplikator.Items.Add("Rot\tx100\tOhm");
            List_Box_Multiplikator.Items.Add("Orange\tx1\tKOhm");
            List_Box_Multiplikator.Items.Add("Gelb\tx10\tKOhm");
            List_Box_Multiplikator.Items.Add("Grün\tx100\tKOhm");
            List_Box_Multiplikator.Items.Add("Blau\tx1\tMOhm");
            List_Box_Multiplikator.Items.Add("Violett\tx10\tMOhm");
            List_Box_Multiplikator.Items.Add("Grau\tx100\tMohm");
            List_Box_Multiplikator.Items.Add("Weiß\tx1\tGOhm");
            List_Box_Multiplikator.Items.Add("Gold\tx0,1\tOhm");
            List_Box_Multiplikator.Items.Add("Silber\tx0,01\tOhm");
            //Toleranz Textauswahl
            List_Box_Toleranz.Items.Add("Braun\t+/- 1%");
            List_Box_Toleranz.Items.Add("Rot\t+/- 2%");
            List_Box_Toleranz.Items.Add("Grün\t+/- 0,5%");
            List_Box_Toleranz.Items.Add("Blau\t+/- 0,25%");
            List_Box_Toleranz.Items.Add("Violett\t+/- 0,1%");
            List_Box_Toleranz.Items.Add("Grau\t+/- 0,1%");
            List_Box_Toleranz.Items.Add("Gold\t+/- 5%");
            List_Box_Toleranz.Items.Add("Silber\t+/- 10%");

        }

        private void Btn_Sicherung_Berechnen_Click(object sender, EventArgs e)
        {            
            //Variablen erstellen für die Auswahl der Berechnung Ring 1
            if (listBox1.SelectedItem.ToString() == "Schwarz\t0")

            {
                Ring1 = 0;

            }
            else if (listBox1.SelectedItem.ToString() == "Braun\t1")
            {
                Ring1 = 1;          
            }
            else if (listBox1.SelectedItem.ToString() == "Rot\t2")
            {
                Ring1 = 2;          
            }
            else if (listBox1.SelectedItem.ToString() == "Orange\t3")
            {
                Ring1 = 3;
            }
            else if (listBox1.SelectedItem.ToString() == "Gelb\t4")
            {
                Ring1 = 4;
            }
            else if (listBox1.SelectedItem.ToString() == "Grün\t5")
            {
                Ring1 = 5;
            }
            else if (listBox1.SelectedItem.ToString() == "Blau\t6")
            {
                Ring1 = 6;

            }
            else if (listBox1.SelectedItem.ToString() == "Violett\t7")
            {
                Ring1 = 7;
            }
            else if (listBox1.SelectedItem.ToString() == "Grau\t8")
            {
                Ring1 = 8;
            }
            else if (listBox1.SelectedItem.ToString() == "Weiß\t9")
            {
                Ring1 = 9;
            }
            //Variablen erstellen für die Auswahl der Berechnung Ring 2
            if (listBox2.SelectedItem.ToString() == "Schwarz\t0")
            {
                Ring2 = 0;
            }
            else if (listBox2.SelectedItem.ToString() == "Braun\t1")
            {
                Ring2 = 1;
            }
            else if (listBox2.SelectedItem.ToString() == "Rot\t2")
            {
                Ring2 = 2;
            }
            else if (listBox2.SelectedItem.ToString() == "Orange\t3")
            {
                Ring2 = 3;
            }
            else if (listBox2.SelectedItem.ToString() == "Gelb\t4")
            {
                Ring2 = 4;
            }
            else if (listBox2.SelectedItem.ToString() == "Grün\t5")
            {
                Ring2 = 5;
            }
            else if (listBox2.SelectedItem.ToString() == "Blau\t6")
            {
                Ring2 = 6;
            }
            else if (listBox2.SelectedItem.ToString() == "Violett\t7")
            {
                Ring2 = 7;
            }
            else if (listBox2.SelectedItem.ToString() == "Grau\t8")
            {
                Ring2 = 8;
            }
            else if (listBox2.SelectedItem.ToString() == "Weiß\t9")
            {
                Ring2 = 9;
            }
            //Bariablen erstellen für die Auswahl der Berechnung Ring 3
            if (listBox2.SelectedItem.ToString() == "Schwarz\t0")
            {
                Ring3 = 0;
            }
            else if (listBox2.SelectedItem.ToString() == "Braun\t1")
            {
                Ring3 = 1;
            }
            else if (listBox2.SelectedItem.ToString() == "Rot\t2")
            {
                Ring3 = 2;
            }
            else if (listBox2.SelectedItem.ToString() == "Orange\t3")
            {
                Ring3 = 3;
            }
            else if (listBox2.SelectedItem.ToString() == "Gelb\t4")
            {
                Ring3 = 4;
            }
            else if (listBox2.SelectedItem.ToString() == "Grün\t5")
            {
                Ring3 = 5;
            }
            else if (listBox2.SelectedItem.ToString() == "Blau\t6")
            {
                Ring3 = 6;
            }
            else if (listBox2.SelectedItem.ToString() == "Violett\t7")
            {
                Ring3 = 7;
            }
            else if (listBox2.SelectedItem.ToString() == "Grau\t8")
            {
                Ring3 = 8;
            }
            else if (listBox2.SelectedItem.ToString() == "Weiß\t9")
            {
                Ring3 = 9;
            }
            //Variablen erstellen für die Auswahl der Berechnung Multiplikator
            if (List_Box_Multiplikator.SelectedItem.ToString()== "Schwarz\tx1\tOhm")
            {
                Multiplikator = 1;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Braun\tx10\tOhm")
            {
                Multiplikator = 10;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Rot\tx100\tOhm")
            {
                Multiplikator = 100;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Orange\tx1\tKOhm")
            {
                Multiplikator = 1;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Gelb\tx10\tKOhm")
            {
                Multiplikator = 10;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Grün\tx100\tKOhm")
            {
                Multiplikator = 100;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Blau\tx1\tMOhm")
            {
                Multiplikator = 1;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Violett\tx10\tMOhm")
            {
                Multiplikator = 10;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Grau\tx100\tMohm")
            {
                Multiplikator = 100;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Weiß\tx1\tGOhm")
            {
                Multiplikator = 1;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Gold\tx0,1\tOhm")
            {
                Multiplikator = 0.1;
            }
            else if (List_Box_Multiplikator.SelectedItem.ToString() == "Silber\tx0,01\tOhm")
            {
                Multiplikator = 0.01;
            }
            //Variablen erstellen für die Auswahl der Berechnung der Toleranz
            if (List_Box_Toleranz.SelectedItem.ToString()== "Braun\t+/- 1%")
            {
                Toleranz = 1;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Rot\t+/- 2%")
            {
                Toleranz = 2;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Grün\t+/- 0,5%")
            {
                Toleranz = 0.5;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Blau\t+/- 0,25%")
            {
                Toleranz = 0.25;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Violett\t+/- 0,1%")
            {
                Toleranz = 0.1;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Grau\t+/- 0,05%")
            {
                Toleranz = 0.05;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Gold\t+/- 5%")
            {
                Toleranz = 5;
            }
            else if (List_Box_Toleranz.SelectedItem.ToString() == "Silber\t+/- 10%")
            {
                Toleranz = 10;
            }
            Lbl_Ergebnis.Text = "Ring1:" + " "+ Ring1.ToString() + Environment.NewLine + "Ring2:" + " " + Ring2.ToString() + Environment.NewLine + "Ring3:" + " " + Ring3.ToString() + Environment.NewLine + "\tMultiplikator:" + " " + Multiplikator.ToString() + Environment.NewLine + "Toleranz:" + " " + Toleranz.ToString();
        }

        private void Rad_But_5_Ringe_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox5.Visible = false;
            List_Box_Multiplikator.Visible = true;
            List_Box_Toleranz.Visible = true;
            lblring1.Visible = true;
            lblring2.Visible = true;
            lblring3.Visible = true;
            lblMult.Visible = true;
            lblring5.Visible = false;
            LblTolleranz.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            
            listBox5.Items.Clear();
            List_Box_Multiplikator.Items.Clear();
            List_Box_Toleranz.Items.Clear();
            //Ring 1 Textauswahl
            listBox1.Items.Add("Schwarz\t0");
            listBox1.Items.Add("Braun\t1");
            listBox1.Items.Add("Rot\t2");
            listBox1.Items.Add("Orange\t3");
            listBox1.Items.Add("Gelb\t4");
            listBox1.Items.Add("Grün\t5");
            listBox1.Items.Add("Blau\t6");
            listBox1.Items.Add("Violett\t7");
            listBox1.Items.Add("Grau\t8");
            listBox1.Items.Add("Weiß\t9");
            //Ring 2 Textauswahl
            listBox2.Items.Add("Schwarz\t0");
            listBox2.Items.Add("Braun\t1");
            listBox2.Items.Add("Rot\t2");
            listBox2.Items.Add("Orange\t3");
            listBox2.Items.Add("Gelb\t4");
            listBox2.Items.Add("Grün\t5");
            listBox2.Items.Add("Blau\t6");
            listBox2.Items.Add("Violett\t7");
            listBox2.Items.Add("Grau\t8");
            listBox2.Items.Add("Weiß\t9");
            //Ring 3 Textauswahl
            listBox3.Items.Add("Schwarz\t0");
            listBox3.Items.Add("Braun\t1");
            listBox3.Items.Add("Rot\t2");
            listBox3.Items.Add("Orange\t3");
            listBox3.Items.Add("Gelb\t4");
            listBox3.Items.Add("Grün\t5");
            listBox3.Items.Add("Blau\t6");
            listBox3.Items.Add("Violett\t7");
            listBox3.Items.Add("Grau\t8");
            listBox3.Items.Add("Weiß\t9");
            //Multiplikator Textauswahl
            List_Box_Multiplikator.Items.Add("Schwarz\tx1\tOhm");
            List_Box_Multiplikator.Items.Add("Braun\tx10\tOhm");
            List_Box_Multiplikator.Items.Add("Rot\tx100\tOhm");
            List_Box_Multiplikator.Items.Add("Orange\tx1\tKOhm");
            List_Box_Multiplikator.Items.Add("Gelb\tx10\tKOhm");
            List_Box_Multiplikator.Items.Add("Grün\tx100\tKOhm");
            List_Box_Multiplikator.Items.Add("Blau\tx1\tMOhm");
            List_Box_Multiplikator.Items.Add("Violett\tx10\tMOhm");
            List_Box_Multiplikator.Items.Add("Grau\tx100\tMohm");
            List_Box_Multiplikator.Items.Add("Weiß\tx1\tGOhm");
            List_Box_Multiplikator.Items.Add("Gold\tx0,1\tOhm");
            List_Box_Multiplikator.Items.Add("Silber\tx0,01\tOhm");
            //Toleranz Textauswahl
            List_Box_Toleranz.Items.Add("Braun\t+/- 1%");
            List_Box_Toleranz.Items.Add("Rot\t+/- 2%");
            List_Box_Toleranz.Items.Add("Grün\t+/- 0,5%");
            List_Box_Toleranz.Items.Add("Blau\t+/- 0,25%");
            List_Box_Toleranz.Items.Add("Violett\t+/- 0,1%");
            List_Box_Toleranz.Items.Add("Grau\t+/- 0,1%");
            List_Box_Toleranz.Items.Add("Gold\t+/- 5%");
            List_Box_Toleranz.Items.Add("Silber\t+/- 10%");

        }

        private void Rad_But_6_Ringe_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox5.Visible = true;
            List_Box_Multiplikator.Visible = true;
            List_Box_Toleranz.Visible = true;
            lblring1.Visible = true;
            lblring2.Visible = true;
            lblring3.Visible = true;
            lblMult.Visible = true;
            LblTolleranz.Visible = true;
            lblring5.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox5.Items.Clear();
            List_Box_Multiplikator.Items.Clear();
            List_Box_Toleranz.Items.Clear();
            //Ring 1 Textauswahl
            listBox1.Items.Add("Schwarz\t0");
            listBox1.Items.Add("Braun\t1");
            listBox1.Items.Add("Rot\t2");
            listBox1.Items.Add("Orange\t3");
            listBox1.Items.Add("Gelb\t4");
            listBox1.Items.Add("Grün\t5");
            listBox1.Items.Add("Blau\t6");
            listBox1.Items.Add("Violett\t7");
            listBox1.Items.Add("Grau\t8");
            listBox1.Items.Add("Weiß\t9");
            //Ring 2 Textauswahl
            listBox2.Items.Add("Schwarz\t0");
            listBox2.Items.Add("Braun\t1");
            listBox2.Items.Add("Rot\t2");
            listBox2.Items.Add("Orange\t3");
            listBox2.Items.Add("Gelb\t4");
            listBox2.Items.Add("Grün\t5");
            listBox2.Items.Add("Blau\t6");
            listBox2.Items.Add("Violett\t7");
            listBox2.Items.Add("Grau\t8");
            listBox2.Items.Add("Weiß\t9");
            //Ring 3 Textauswahl
            listBox3.Items.Add("Schwarz\t0");
            listBox3.Items.Add("Braun\t1");
            listBox3.Items.Add("Rot\t2");
            listBox3.Items.Add("Orange\t3");
            listBox3.Items.Add("Gelb\t4");
            listBox3.Items.Add("Grün\t5");
            listBox3.Items.Add("Blau\t6");
            listBox3.Items.Add("Violett\t7");
            listBox3.Items.Add("Grau\t8");
            listBox3.Items.Add("Weiß\t9");
            //Multiplikator Textauswahl
            List_Box_Multiplikator.Items.Add("Schwarz\tx1\tOhm");
            List_Box_Multiplikator.Items.Add("Braun\tx10\tOhm");
            List_Box_Multiplikator.Items.Add("Rot\tx100\tOhm");
            List_Box_Multiplikator.Items.Add("Orange\tx1\tKOhm");
            List_Box_Multiplikator.Items.Add("Gelb\tx10\tKOhm");
            List_Box_Multiplikator.Items.Add("Grün\tx100\tKOhm");
            List_Box_Multiplikator.Items.Add("Blau\tx1\tMOhm");
            List_Box_Multiplikator.Items.Add("Violett\tx10\tMOhm");
            List_Box_Multiplikator.Items.Add("Grau\tx100\tMohm");
            List_Box_Multiplikator.Items.Add("Weiß\tx1\tGOhm");
            List_Box_Multiplikator.Items.Add("Gold\tx0,1\tOhm");
            List_Box_Multiplikator.Items.Add("Silber\tx0,01\tOhm");
            //Toleranz Textauswahl
            List_Box_Toleranz.Items.Add("Braun\t+/- 1%");
            List_Box_Toleranz.Items.Add("Rot\t+/- 2%");
            List_Box_Toleranz.Items.Add("Grün\t+/- 0,5%");
            List_Box_Toleranz.Items.Add("Blau\t+/- 0,25%");
            List_Box_Toleranz.Items.Add("Violett\t+/- 0,1%");
            List_Box_Toleranz.Items.Add("Grau\t+/- 0,1%");
            List_Box_Toleranz.Items.Add("Gold\t+/- 5%");
            List_Box_Toleranz.Items.Add("Silber\t+/- 10%");
            //PPM Wert auswahl
            listBox5.Items.Add("Braun\t 100 ppm");
            listBox5.Items.Add("Rot\t 50 ppm");
            listBox5.Items.Add("Orange\t 15 ppm");
            listBox5.Items.Add("Gelb\t 25 ppm");
            listBox5.Items.Add("Blau\t 10 ppm");
            listBox5.Items.Add("Violett\t 5 ppm");
            
        }
    }
}
