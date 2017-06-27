using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_V._1._2
{
    public partial class Form1 : Form
    {
        //variable
        bool setVis = false;
        bool equCicked = false;
        UInt16 mode=0;
        bool yx=false;
        bool yxp = false;
        double temp;
        int was = 10;
        int now = 10;
        string[] stringi = { "+ ", "/ ", "- ", "* "};

        //Window
        public Form1()
        {
            InitializeComponent();
            //Główne Okno
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //ODBLOKOWAC
            this.Size = new System.Drawing.Size(445, 430);
            //OPCJE
            panel_option1.Width = 0;
            panel_option1.Location = new Point(2, 33);
            //Panel
            panel_programisty.Location = new Point(900, 65);
            panel_naukowy.Location = new Point(500, 134);
            panel_podstawowy.Location = new Point(3, 134);
            //TEST NAUKOWY
            //this.Size = new System.Drawing.Size(1920, 1080);
            //mode = 2;
            cb_1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_2.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        //ANIMACJE
        private void bt_pods_Click(object sender, EventArgs e)
        {
            panel_podstawowy.Location = new Point(3, 134);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            panel_przel.Location = new Point(552, 562);
            bt_ce.Location = new Point(87, 15);
            bt_del.Location = new Point(257, 15);
            this.Size = new System.Drawing.Size(445, 430);
            label3.Text = "Podstawowy";
            bt_pow.Visible = true;
            bt_1_x.Visible = true;
            bt_pierwiastek.Visible = true;
            lb_row.Visible = true;
            bt_dot.Visible = true;
            tx_obl.Width = 411;
            mode = 0;
        }

        private void bt_nauk_Click(object sender, EventArgs e)
        {
            panel_podstawowy.Location = new Point(3, 134);
            panel_programisty.Location = new Point(550, 328);
            panel_naukowy.Location = new Point(464, 134);
            panel_przel.Location = new Point(552, 562);
            bt_ce.Location = new Point(87, 15);
            bt_del.Location = new Point(257, 15);
            this.Size = new System.Drawing.Size(750, 430);
            label3.Text = "Naukowy";
            bt_pow.Visible = true;
            bt_1_x.Visible = true;
            bt_pierwiastek.Visible = true;
            lb_row.Visible = true;
            bt_dot.Visible = true;
            tx_obl.Width = 411;
            mode = 1;
        }
        private void bt_prog_Click(object sender, EventArgs e)
        {
           
            panel_naukowy.Location = new Point(211, 500);
            panel_programisty.Location = new Point(340, 65);
            panel_przel.Location = new Point(552, 562);
            panel_podstawowy.Location = new Point(-80, 134);
            bt_ce.Location = new Point(87, 15);
            bt_del.Location = new Point(257, 15);
            this.Size = new System.Drawing.Size(550, 430);
            label3.Text = "Programisty";
            bt_pow.Hide();
            bt_1_x.Hide();        
            bt_pierwiastek.Hide();
            bt_dot.Hide();
            lb_row.Visible = true;
            tx_obl.Width = 310;
            mode = 2;
            

        }
        private void bt_obj_Click(object sender, EventArgs e)
        {
            label3.Text = "Objętość";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Milimetry sześcienne",0.000000001));
            cb_1.Items.Add(new Dane("Centymetry sześcienne",0.00000001));
            cb_1.Items.Add(new Dane("Decymetrymetry sześcienne",0.001));
            cb_1.Items.Add(new Dane("metry sześcienne",1));
            cb_1.Items.Add(new Dane("Mililitry",0.00001));
            cb_1.Items.Add(new Dane("Litry", 0.001));

            cb_2.Items.Add(new Dane("Milimetry sześcienne", 0.000000001));
            cb_2.Items.Add(new Dane("Centymetry sześcienne", 0.00000001));
            cb_2.Items.Add(new Dane("Decymetrymetry sześcienne", 0.001));
            cb_2.Items.Add(new Dane("metry sześcienne", 1));
            cb_2.Items.Add(new Dane("Mililitry", 0.00001));
            cb_2.Items.Add(new Dane("Litry", 0.001));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }
        private void bt_dlug_Click(object sender, EventArgs e)
        {
            label3.Text = "Długość";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Nanometry",0.000000001));
            cb_1.Items.Add(new Dane("Mikrometry",0.000001));
            cb_1.Items.Add(new Dane("Milimetry",0.001));
            cb_1.Items.Add(new Dane("Centymetry",0.01));
            cb_1.Items.Add(new Dane("Decymetry",0.1));
            cb_1.Items.Add(new Dane("Metry",1));
            cb_1.Items.Add(new Dane("Kilometry",1000));
            cb_1.Items.Add(new Dane("Mile",1609.344));
            cb_1.Items.Add(new Dane("Mile morskie",1852));

            cb_2.Items.Add(new Dane("Nanometry", 0.000000001));
            cb_2.Items.Add(new Dane("Mikrometry", 0.000001));
            cb_2.Items.Add(new Dane("Milimetry", 0.001));
            cb_2.Items.Add(new Dane("Centymetry", 0.01));
            cb_2.Items.Add(new Dane("Decymetry", 0.1));
            cb_2.Items.Add(new Dane("Metry", 1));
            cb_2.Items.Add(new Dane("Kilometry", 1000));
            cb_2.Items.Add(new Dane("Mile", 1609.344));
            cb_2.Items.Add(new Dane("Mile morskie", 1852));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }
        private void bt_ciez_Click(object sender, EventArgs e)
        {
            label3.Text = "Ciężkość";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Miligramy",0.001));
            cb_1.Items.Add(new Dane("Gramy",1));
            cb_1.Items.Add(new Dane("Dekagramy",10));
            cb_1.Items.Add(new Dane("Kilogramy",1000));
            cb_1.Items.Add(new Dane("Tony", 1000000));

            cb_2.Items.Add(new Dane("Miligramy", 0.001));
            cb_2.Items.Add(new Dane("Gramy", 1));
            cb_2.Items.Add(new Dane("Dekagramy", 10));
            cb_2.Items.Add(new Dane("Kilogramy", 1000));
            cb_2.Items.Add(new Dane("Tony", 1000000));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_temp_Click(object sender, EventArgs e)
        {
            label3.Text = "Temperatura";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Celsjusz",1));
            cb_1.Items.Add(new Dane("Farenheit",1));
            cb_1.Items.Add(new Dane("Kelwin",1));

            cb_2.Items.Add(new Dane("Celsjusz", 1));
            cb_2.Items.Add(new Dane("Farenheit", 1));
            cb_2.Items.Add(new Dane("Kelwin", 1));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_eng_Click(object sender, EventArgs e)
        {
            label3.Text = "Energia";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Dżule",1));
            cb_1.Items.Add(new Dane("Kilodżule",1000));
            cb_2.Items.Add(new Dane("Kalorie", 4.1868));
            cb_2.Items.Add(new Dane("Kilokalorie", 4186.8));

            cb_2.Items.Add(new Dane("Dżule", 1));
            cb_2.Items.Add(new Dane("Kilodżule", 1000));
            cb_2.Items.Add(new Dane("Kalorie", 4.1868));
            cb_2.Items.Add(new Dane("Kilokalorie", 4186.8));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_powie_Click(object sender, EventArgs e)
        {
            label3.Text = "Powierzchnia";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Milimetry kwadratowe",0.000001));
            cb_1.Items.Add(new Dane("Centymetry kwadratowe",0.0001));
            cb_1.Items.Add(new Dane("Decymetry kwadratowe",0.01));
            cb_1.Items.Add(new Dane("Metry kwadratowe",1));
            cb_1.Items.Add(new Dane("Kilometry kwadratowe",100000));
            cb_1.Items.Add(new Dane("Ary",100));
            cb_1.Items.Add(new Dane("Hektary",10000));

            cb_2.Items.Add(new Dane("Milimetry kwadratowe", 0.000001));
            cb_2.Items.Add(new Dane("Centymetry kwadratowe", 0.0001));
            cb_2.Items.Add(new Dane("Decymetry kwadratowe", 0.01));
            cb_2.Items.Add(new Dane("Metry kwadratowe", 1));
            cb_2.Items.Add(new Dane("Kilometry kwadratowe", 100000));
            cb_2.Items.Add(new Dane("Ary", 100));
            cb_2.Items.Add(new Dane("Hektary", 10000));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_time_Click(object sender, EventArgs e)
        {
            label3.Text = "Czas";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Nanosekndy",0.000000001));
            cb_1.Items.Add(new Dane("Mikrosekundy",0.000001));
            cb_1.Items.Add(new Dane("Milisekndy",0.001));
            cb_1.Items.Add(new Dane("Sekundy",1));
            cb_1.Items.Add(new Dane("Minuty",60));
            cb_1.Items.Add(new Dane("Godziny",3600));
            cb_1.Items.Add(new Dane("Dni",86400));
            cb_1.Items.Add(new Dane("Tygodnie",604800));
            cb_1.Items.Add(new Dane("Miesiące", 3024000));
            cb_1.Items.Add(new Dane("Lata", 31190400));

            cb_2.Items.Add(new Dane("Nanosekndy", 0.000000001));
            cb_2.Items.Add(new Dane("Mikrosekundy", 0.000001));
            cb_2.Items.Add(new Dane("Milisekndy", 0.001));
            cb_2.Items.Add(new Dane("Sekundy", 1));
            cb_2.Items.Add(new Dane("Minuty", 60));
            cb_2.Items.Add(new Dane("Godziny", 3600));
            cb_2.Items.Add(new Dane("Dni", 86400));
            cb_2.Items.Add(new Dane("Tygodnie", 604800));
            cb_2.Items.Add(new Dane("Miesiące", 3024000));
            cb_2.Items.Add(new Dane("Lata", 31190400));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_power_Click(object sender, EventArgs e)
        {
            label3.Text = "Moc";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Waty",1));
            cb_1.Items.Add(new Dane("Kilowaty",1000));
            cb_1.Items.Add(new Dane("Megawaty",1000000));

            cb_2.Items.Add(new Dane("Waty", 1));
            cb_2.Items.Add(new Dane("Kilowaty", 1000));
            cb_2.Items.Add(new Dane("Megawaty", 1000000));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_pres_Click(object sender, EventArgs e)
        {
            label3.Text = "Ciśnienie";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Atmosfera",1));
            cb_1.Items.Add(new Dane("Bar",0.986923));
            cb_1.Items.Add(new Dane("Paskale", 0.00009869));
            cb_1.Items.Add(new Dane("Kilopaskale",0.009869));
            cb_1.Items.Add(new Dane("Milimetry słupa rtęci",0.001316));
            cb_1.Items.Add(new Dane("Funt calowy",0.068046));

            cb_2.Items.Add(new Dane("Atmosfera", 1));
            cb_2.Items.Add(new Dane("Bar", 0.986923));
            cb_2.Items.Add(new Dane("Paskale", 0.00009869));
            cb_2.Items.Add(new Dane("Kilopaskale", 0.009869));
            cb_2.Items.Add(new Dane("Milimetry słupa rtęci", 0.001316));
            cb_2.Items.Add(new Dane("Funt calowy", 0.068046));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_velo_Click(object sender, EventArgs e)
        {
            label3.Text = "Prędkość";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            cb_1.Items.Add(new Dane("Centymetry na sekunde",0.01));
            cb_1.Items.Add(new Dane("Metry na sekunde",1));
            cb_1.Items.Add(new Dane("Kilometry na godzine",0.27778));
            cb_1.Items.Add(new Dane("Węzły", 0.5144));
            cb_1.Items.Add(new Dane("Machy", 340.3));

            cb_2.Items.Add(new Dane("Centymetry na sekunde",0.01));
            cb_2.Items.Add(new Dane("Metry na sekunde", 1));
            cb_2.Items.Add(new Dane("Kilometry na godzine", 0.27778));
            cb_2.Items.Add(new Dane("Węzły", 0.5144));
            cb_2.Items.Add(new Dane("Machy", 340.3));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }

        private void bt_kat_Click(object sender, EventArgs e)
        {
            label3.Text = "Kąt";
            panel_przel.Location = new Point(1, 42);
            panel_naukowy.Location = new Point(500, 134);
            panel_programisty.Location = new Point(500, 65);
            bt_ce.Location = new Point(339, 62);
            bt_del.Location = new Point(339, 109);
            this.Size = new System.Drawing.Size(445, 430);
            bt_pow.Hide();
            bt_1_x.Hide();
            bt_pierwiastek.Hide();
            bt_plus.Hide();
            bt_minus.Hide();
            bt_div.Hide();
            bt_multi.Hide();
            bt_equ.Hide();
            lb_row.Hide();
            cb_1.Items.Clear();
            cb_2.Items.Clear();

            cb_1.Items.Add(new Dane("Stopnie",1));
            cb_1.Items.Add(new Dane("Minuta kątowa", 0.0166666667));
            cb_1.Items.Add(new Dane("Sekunda kątowa", 0.0002777778));
            cb_1.Items.Add(new Dane("Radiany", 1));

            cb_2.Items.Add(new Dane("Stopnie", 1));
            cb_2.Items.Add(new Dane("Minuta kątowa", 0.0166666667));
            cb_2.Items.Add(new Dane("Sekunda kątowa", 0.0002777778));
            cb_2.Items.Add(new Dane("Radiany",1));

            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 0;
            mode = 3;
        }
        private void bt_options_Click(object sender, EventArgs e)
        {
            if (!setVis)
            {
                int zmienna = (int)panel_option1.Width;
                bool rob = true;
                
                if (zmienna == 0)
                {

                    do
                    {
                      
                        if (panel_option1.Width <= 220)
                        {
                           // System.Threading.Thread.Sleep(6);
                            this.Refresh();
                            panel_option1.Width += 5;
                            panel_option1.Height = 355;
                        }
                        if (panel_option1.Width == 220)
                        {
                            rob = false;                           
                            panel_option2.AutoScroll = true;
                            
                        }
                    }
                    while (rob);
                }

                if (zmienna == 220)
                {
                    panel_option2.AutoScroll = false;
                    
                    
                    do
                    {
                      
                        if (panel_option1.Width >= 0)
                        {
                            //System.Threading.Thread.Sleep(6);
                            this.Refresh();
                            panel_option1.Width -= 5;
                            panel_option1.Height = 355;
                        }
                        if (panel_option1.Width == 0)
                        {
                            rob = false;
                        }
                    }
                    while (rob);
                }
            }
            else
            {
                setVis = false;
                panel_about.Location = new Point(500,553);
            }
        }

        //WPIS LICZB
        private void bt_1_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "1";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "1";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || OCT.Checked || DEC.Checked|| BIN.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "1";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "1";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "1";

            }
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "2";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "2";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || OCT.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "2";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "2";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "2";

            }
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "3";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "3";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || OCT.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "3";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "3";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "3";

            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "4";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "4";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || OCT.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "4";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "4";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "4";

            }
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "5";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "5";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || OCT.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "5";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "5";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "5";

            }
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "6";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "6";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || OCT.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "6";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "6";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "6";

            }
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "7";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "7";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked||OCT.Checked||DEC.Checked)
                {
                                    if (!equCicked)
                {
                    tx_obl.Text += "7";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "7";
                }
                }
            }

            if (mode == 3)
            {

                tx_1.Text += "7";

            }
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "8";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "8";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "8";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "8";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "8";

            }
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 0)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "9";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "9";
                }
            }
            if (mode == 2)
            {
                if (HEX.Checked || DEC.Checked)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "9";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "9";
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "9";

            }
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            {
                if (mode == 1 || mode == 0)
                {
                    if (!equCicked)
                    {
                        tx_obl.Text += "0";
                    }
                    if (equCicked)
                    {
                        Clear(equCicked);
                        tx_obl.Text += "0";
                    }
                }
                if (mode == 2)
                {
                    if (HEX.Checked || OCT.Checked || DEC.Checked||BIN.Checked)
                    {
                        if (!equCicked)
                        {
                            tx_obl.Text += "0";
                        }
                        if (equCicked)
                        {
                            Clear(equCicked);
                            tx_obl.Text += "0";
                        }
                    }
                }
            }
            if (mode == 3)
            {

                tx_1.Text += "0";

            }
        }

        private void bt_dot_Click(object sender, EventArgs e)
        {
            if (!equCicked)
            {
                if (!tx_obl.Text.Contains("."))
                {
                    if (tx_obl.Text == "")
                    {
                        tx_obl.Text = "0.";
                    }
                    else
                    {
                        tx_obl.Text += ".";
                    }
                }
            }
            if (equCicked)
            {
                Clear(equCicked);
                if (!tx_obl.Text.Contains("."))
                {
                    if (tx_obl.Text == "")
                    {
                        tx_obl.Text = "0.";
                    }
                    else
                    {
                        tx_obl.Text += ".";
                    }
                }
            }
            if (mode == 3)
            {
                if (tx_1.Text == "")
                {
                    tx_1.Text = "0.";
                }
                else
                {
                    tx_1.Text += ".";
                }

            }
        }
    //EDYCJA TEKSTU
        private void bt_c_podst_Click(object sender, EventArgs e)
        {
            tx_obl.Text = "";
            lb_row.Text = "";
            tx_1.Text = "";
            tx_2.Text = "";
        }

        private void bt_ce_Click(object sender, EventArgs e)
        {
            tx_obl.Text = "";
            tx_1.Text = "";
            tx_2.Text = "";
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (tx_obl.Text.Length > 0)
            {
                tx_obl.Text = tx_obl.Text.Remove(tx_obl.Text.LastIndexOf(tx_obl.Text.Last()));
            }
            if (tx_1.Text.Length > 0)
            {
                tx_1.Text = tx_1.Text.Remove(tx_1.Text.LastIndexOf(tx_1.Text.Last()));
            }
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            setVis = true;
            panel_about.Location = new Point(2, 33);
        }

        //OBLICZENIA
        private void bt_1_x_Click(object sender, EventArgs e)
        {
            if (tx_obl.Text == "" || tx_obl.Text == "0")
            {
                tx_obl.Text = "NIE DZIEL PRZEZ ZERO CHOLERO";
            }
            else
            {
                double a = Convert.ToDouble(tx_obl.Text);
                double b = 1 / a;
                lb_row.Text = "1/(" + a + ")=" + b;
                tx_obl.Text = "";
                equCicked = true;
            }
        }

        private void bt_pierwiastek_Click(object sender, EventArgs e)
        {
            if (tx_obl.Text == "" || tx_obl.Text == "0")
            {
                tx_obl.Text = "NIE MA Z ZERA";
            }
            else
            {
                double a = Convert.ToDouble(tx_obl.Text);
                double b = Math.Sqrt(a);
                lb_row.Text = "√(" + a + ")=" + b;
                tx_obl.Text = "";
                equCicked = true;
            }
        }

        private void bt_silnia_Click(object sender, EventArgs e)
        {
            if (tx_obl.Text == "" || tx_obl.Text == "0")
            {
                lb_row.Text = "(0)!=1";
                equCicked = true;
            }
            else
            {
                if (tx_obl.Text.Contains("."))
                {
                    while (tx_obl.Text.Contains("."))
                    {
                        tx_obl.Text = tx_obl.Text.Remove(tx_obl.Text.LastIndexOf(tx_obl.Text.Last()));
                    }
                }

                int a = Convert.ToInt32(tx_obl.Text);
                long b = Silnia(a);
                lb_row.Text = "(" + a + ")!=" + b;
                tx_obl.Text = "";
                equCicked = true;
            }

        }
        private void bt_ln_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Log(a);
            lb_row.Text = "Ln(" + a + ")=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Log10(a);
            lb_row.Text = "Log(" + a + ")=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_sin_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Sin(StoToRad(a));
            lb_row.Text = "Sin(" + a + ")=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_cos_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Cos(StoToRad(a));
            lb_row.Text = "Cos(" + a + ")=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_tan_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Tan(StoToRad(a));
            lb_row.Text = "Tan(" + a + ")=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_sin_1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Asin(StoToRad(a));
            lb_row.Text = "Sin(" + a + ")^-1=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_cos_1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Acos(StoToRad(a));
            lb_row.Text = "Cos(" + a + ")^-1=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_tan_1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Atan(StoToRad(a));
            lb_row.Text = "Tan(" + a + ")^-1=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_exp_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Exp(a);
            lb_row.Text = "Exp(" + a + ")!=" + b;
            tx_obl.Text = "";
            equCicked = true;
        }

        private void bt_pow_y_Click(object sender, EventArgs e)
        {
            yx = true;
            temp = Convert.ToDouble(tx_obl.Text);
            lb_row.Text = "(" + temp + ")^";
            tx_obl.Text = "";
            equCicked = false;
        }

        private void bt_10_x_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Pow(10, a);
            lb_row.Text += b;
            tx_obl.Text = "";
            //equCicked = true;
        }
        private void bt_pi_Click(object sender, EventArgs e)
        {
            lb_row.Text += Math.PI;
            tx_obl.Text = "";
            equCicked = true;
        }
        private void bt_y_pierw_x_Click(object sender, EventArgs e)
        {
            yxp = true;
            temp = Convert.ToDouble(tx_obl.Text);
            lb_row.Text = temp + "√ (";
            tx_obl.Text = "";
            equCicked = false;
            
        }
        private void bt_pow_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tx_obl.Text);
            double b = Math.Pow(a, 2);
            lb_row.Text = "(" + a + ")^2" + b;
            tx_obl.Text = "";
            equCicked = true;
        }
        //METODY
        private long Silnia(int x)
        {
            long wyn = 1;
            for (int y = x; y > 1; y--)
            {
                wyn *= y;
            }
            return wyn;
        }

        private double StoToRad(double x)
        {
            return ((x * Math.PI) / (180));
        }

        private void Clear(bool x)
        {
            if (x)
            {
                lb_row.Text = "";
            }
        }
        //Podstawowe znaki
        private void bt_div_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (string s in stringi)
            {
                if (tx_obl.Text.EndsWith(s))
                {
                    test = true;
                }
            }
            if (!test)
            {
                tx_obl.Text += " / ";
            }
        }

        private void bt_multi_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (string s in stringi)
            {
                if (tx_obl.Text.EndsWith(s))
                {
                    test = true;
                }
            }
            if (!test)
            {
                tx_obl.Text += " * ";
            }
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (string s in stringi)
            {
                if (tx_obl.Text.EndsWith(s))
                {
                    test = true;
                }
            }
            if (!test)
            {
                tx_obl.Text += " - ";
            }
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (string s in stringi)
            {
                if (tx_obl.Text.EndsWith(s))
                {
                    test = true;
                }
            }
            if (!test)
            {
                tx_obl.Text += " + ";
            }
        }


        //OBLICZ
        private void bt_equ_Click(object sender, EventArgs e)
        {
            double liczba;
            string licz = tx_obl.Text;
            double[] numbers = new double[99];
            double wynik;
            string[] signs = new string[99];
            int krokl = 0;
            int krokz = 0;
            //TRYB PODSTAWOWY
            if (mode == 0)
            {
               
                lb_row.Text = licz;
                tx_obl.Text = "";
                String[] wszystko = Regex.Split(licz, " ");
                int ilosc = wszystko.Length;
                foreach (string s in wszystko)
                {

                    if (Double.TryParse(s,out liczba))
                    {
                        numbers[krokl] = liczba;
                        krokl ++;
                    }
                    else
                    {
                        signs[krokz] = s;
                        krokz++;
                    }
                }

                wynik = numbers[0];                
                for (int i = 0; i < krokl; i++)
                {

                        switch (signs[i])
                        {
                            case "+": wynik += numbers[i + 1]; break;
                            case "-": wynik -= numbers[i + 1]; break;
                            case "*": wynik *= numbers[i + 1]; break;
                            case "/": wynik /= numbers[i + 1]; break;
                        }
                    
                }
                lb_row.Text += " = " + wynik;
                equCicked = true;
            }
            //TRYB NAUKOWY
            if (mode == 1)
            {
                if (!yxp && !yx)
                {
                    lb_row.Text = licz;
                    tx_obl.Text = "";
                    String[] wszystko = Regex.Split(licz, " ");
                    int ilosc = wszystko.Length;
                    foreach (string s in wszystko)
                    {

                        if (Double.TryParse(s, out liczba))
                        {
                            numbers[krokl] = liczba;
                            krokl++;
                        }
                        else
                        {
                            signs[krokz] = s;
                            krokz++;
                        }
                    }

                    wynik = numbers[0];
                    for (int i = 0; i < krokl; i++)
                    {

                        switch (signs[i])
                        {
                            case "+": wynik += numbers[i + 1]; break;
                            case "-": wynik -= numbers[i + 1]; break;
                            case "*": wynik *= numbers[i + 1]; break;
                            case "/": wynik /= numbers[i + 1]; break;
                        }

                    }
                    lb_row.Text += " = " + wynik;
                    equCicked = true;
                }

                if (yx)
                {
                    if (Double.TryParse(licz, out liczba))
                    {
                        wynik = Math.Pow(temp, liczba);
                        tx_obl.Text = "";
                        lb_row.Text += liczba + "= " + wynik;
                        equCicked = true;
                        yx = false;


                    }
                }

                if (yxp)
                {
                    if (Double.TryParse(licz, out liczba))
                    {
                        wynik = Math.Pow(liczba, (1 / temp));
                        tx_obl.Text = "";
                        lb_row.Text += liczba + ")= " + wynik;
                        equCicked = true;
                        yxp = false;
                    }
                }
               

                }
            if (mode == 2)
            {
                if (now == 10) {
                    lb_row.Text = licz;
                    tx_obl.Text = "";
                    String[] wszystko = Regex.Split(licz, " ");
                    int ilosc = wszystko.Length;
                    foreach (string s in wszystko)
                    {

                        if (Double.TryParse(s, out liczba))
                        {
                            numbers[krokl] = liczba;
                            krokl++;
                        }
                        else
                        {
                            signs[krokz] = s;
                            krokz++;
                        }
                    }

                    wynik = numbers[0];
                    for (int i = 0; i < krokl; i++)
                    {

                        switch (signs[i])
                        {
                            case "+": wynik += numbers[i + 1]; break;
                            case "-": wynik -= numbers[i + 1]; break;
                            case "*": wynik *= numbers[i + 1]; break;
                            case "/": wynik /= numbers[i + 1]; break;
                        }

                    }
                    lb_row.Text += " = " + wynik;
                    equCicked = true;
                }
                if (now == 2)
                {
                    lb_row.Text = licz;
                    tx_obl.Text = "";
                    String[] wszystko = Regex.Split(licz, " ");
                    int ilosc = wszystko.Length;
                    foreach (string s in wszystko)
                    {

                        if (s=="+"||s=="-"||s=="*"||s=="/")
                        {
                            signs[krokz] = s;
                            krokz++;
                        }
                        else
                        {
                            String number = s;
                            String result = Convert.ToString(Convert.ToInt32(number, 2), 10);
                            numbers[krokl] = Convert.ToDouble(result);
                            krokl++;
                        }
                    }

                    wynik = numbers[0];
                    for (int i = 0; i < krokl; i++)
                    {

                        switch (signs[i])
                        {
                            case "+": wynik += numbers[i + 1]; break;
                            case "-": wynik -= numbers[i + 1]; break;
                            case "*": wynik *= numbers[i + 1]; break;
                            case "/": wynik /= numbers[i + 1]; break;
                        }

                    }
                    String result2 = Convert.ToString(Convert.ToInt32(wynik.ToString(),10), 2);
                    lb_row.Text += " = " + result2;
                    equCicked = true;
                }
                if (now == 8)
                {
                    lb_row.Text = licz;
                    tx_obl.Text = "";
                    String[] wszystko = Regex.Split(licz, " ");
                    int ilosc = wszystko.Length;
                    foreach (string s in wszystko)
                    {

                        if (s != "+" || s != "-" || s != "*" || s != "/")
                        {
                            String number = s;
                            String result = Convert.ToString(Convert.ToInt32(number, 8), 10);
                            numbers[krokl] = Convert.ToDouble(result);
                            krokl++;
                        }
                        else
                        {
                            signs[krokz] = s;
                            krokz++;
                        }
                    }

                    wynik = numbers[0];
                    for (int i = 0; i < krokl; i++)
                    {

                        switch (signs[i])
                        {
                            case "+": wynik += numbers[i + 1]; break;
                            case "-": wynik -= numbers[i + 1]; break;
                            case "*": wynik *= numbers[i + 1]; break;
                            case "/": wynik /= numbers[i + 1]; break;
                        }

                    }
                    String result2 = Convert.ToString(Convert.ToInt32(wynik.ToString(), 10), 8);
                    lb_row.Text += " = " + result2;
                    equCicked = true;
                }
                if (now == 16)
                {
                    lb_row.Text = licz;
                    tx_obl.Text = "";
                    String[] wszystko = Regex.Split(licz, " ");
                    int ilosc = wszystko.Length;
                    foreach (string s in wszystko)
                    {

                        if (s != "+" || s != "-" || s != "*" || s != "/")
                        {
                            String number = s;
                            String result = Convert.ToString(Convert.ToInt32(number, 16), 10);
                            numbers[krokl] = Convert.ToDouble(result);
                            krokl++;
                        }
                        else
                        {
                            signs[krokz] = s;
                            krokz++;
                        }
                    }

                    wynik = numbers[0];
                    for (int i = 0; i < krokl; i++)
                    {

                        switch (signs[i])
                        {
                            case "+": wynik += numbers[i + 1]; break;
                            case "-": wynik -= numbers[i + 1]; break;
                            case "*": wynik *= numbers[i + 1]; break;
                            case "/": wynik /= numbers[i + 1]; break;
                        }

                    }
                    String result2 = Convert.ToString(Convert.ToInt32(wynik.ToString(), 10), 16);
                    lb_row.Text += " = " + result2;
                    equCicked = true;
                }
            
            }


        }
        //             KONWERSJA
        //String number = "100";
        //int fromBase = 16;
        //int toBase = 10;
        //String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);


        //TRYBY PROGRAMISTY
        private void HEX_CheckedChanged(object sender, EventArgs e)
        {
            bt_a.ForeColor = Color.Black;
            bt_b.ForeColor = Color.Black;
            bt_c.ForeColor = Color.Black;
            bt_d.ForeColor = Color.Black;
            bt_e.ForeColor = Color.Black;
            bt_f.ForeColor = Color.Black;
            bt_9.ForeColor = Color.Black;
            bt_8.ForeColor = Color.Black;
            bt_7.ForeColor = Color.Black;
            bt_6.ForeColor = Color.Black;
            bt_5.ForeColor = Color.Black;
            bt_4.ForeColor = Color.Black;
            bt_3.ForeColor = Color.Black;
            bt_2.ForeColor = Color.Black;
            was = now;
            now = 16;

            if (tx_obl.Text != "")
            {
                String number = tx_obl.Text;
                String result = Convert.ToString(Convert.ToInt32(number, was), now);
                tx_obl.Text = result;
            }

        }

        private void OCT_CheckedChanged(object sender, EventArgs e)
        {
            bt_a.ForeColor = Color.DarkGray;
            bt_b.ForeColor = Color.DarkGray;
            bt_c.ForeColor = Color.DarkGray;
            bt_d.ForeColor = Color.DarkGray;
            bt_e.ForeColor = Color.DarkGray;
            bt_f.ForeColor = Color.DarkGray;
            bt_9.ForeColor = Color.DarkGray;
            bt_8.ForeColor = Color.DarkGray;            
            bt_7.ForeColor = Color.Black;
            bt_6.ForeColor = Color.Black;
            bt_5.ForeColor = Color.Black;
            bt_4.ForeColor = Color.Black;
            bt_3.ForeColor = Color.Black;
            bt_2.ForeColor = Color.Black;
            was = now;
            now = 8;

            if (tx_obl.Text != "")
            {
                String number = tx_obl.Text;
                String result = Convert.ToString(Convert.ToInt32(number, was), now);
                tx_obl.Text = result;
            }
        }

        private void DEC_CheckedChanged(object sender, EventArgs e)
        {
            bt_a.ForeColor = Color.DarkGray;
            bt_b.ForeColor = Color.DarkGray;
            bt_c.ForeColor = Color.DarkGray;
            bt_d.ForeColor = Color.DarkGray;
            bt_e.ForeColor = Color.DarkGray;
            bt_f.ForeColor = Color.DarkGray;
            bt_9.ForeColor = Color.Black;
            bt_8.ForeColor = Color.Black;
            bt_7.ForeColor = Color.Black;
            bt_6.ForeColor = Color.Black;
            bt_5.ForeColor = Color.Black;
            bt_4.ForeColor = Color.Black;
            bt_3.ForeColor = Color.Black;
            bt_2.ForeColor = Color.Black;
            was = now;
            now = 10;

            if (tx_obl.Text != "")
            {
                String number = tx_obl.Text;
                String result = Convert.ToString(Convert.ToInt32(number, was), now);
                tx_obl.Text = result;
            }
        }

        private void BIN_CheckedChanged(object sender, EventArgs e)
        {
            bt_a.ForeColor = Color.DarkGray;
            bt_b.ForeColor = Color.DarkGray;
            bt_c.ForeColor = Color.DarkGray;
            bt_d.ForeColor = Color.DarkGray;
            bt_e.ForeColor = Color.DarkGray;
            bt_f.ForeColor = Color.DarkGray;
            bt_9.ForeColor = Color.DarkGray;
            bt_8.ForeColor = Color.DarkGray;
            bt_7.ForeColor = Color.DarkGray;
            bt_6.ForeColor = Color.DarkGray;
            bt_5.ForeColor = Color.DarkGray;
            bt_4.ForeColor = Color.DarkGray;
            bt_3.ForeColor = Color.DarkGray;
            bt_2.ForeColor = Color.DarkGray;           
            was = now;
            now = 2;

            if (tx_obl.Text != "")
            {
                String number = tx_obl.Text;
                String result = Convert.ToString(Convert.ToInt32(number, was), now);
                tx_obl.Text = result;
            }
        }
        //Litery liczb
        private void bt_a_Click(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "A";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "A";
                }
            }
        }

        private void bt_b_Click(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "B";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "B";
                }
            }
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "C";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "C";
                }
            }
        }

        private void bt_d_Click(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "D";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "D";
                }
            }
        }

        private void bt_e_Click(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "E";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "E";
                }
            }
        }

        private void bt_f_Click(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                if (!equCicked)
                {
                    tx_obl.Text += "F";
                }
                if (equCicked)
                {
                    Clear(equCicked);
                    tx_obl.Text += "F";
                }
            }
        }

        private void bt_obl_Click(object sender, EventArgs e)
        {
            double a1;
            double a2;
            double a3;
            //double a4;
            if (cb_1.Text == cb_2.Text)
            {

                tx_2.Text = tx_1.Text;
            }

            if (label3.Text == "Objętość"|| label3.Text == "Długość"|| label3.Text == "Ciężkość" || label3.Text == "Powierzchnia" || label3.Text == "Czas" 
                || label3.Text == "Moc" || label3.Text == "Prędkość" || label3.Text == "Energia" || label3.Text == "Ciśnienie")
            {

                    a1 = Convert.ToDouble(tx_1.Text) * ((Dane)(cb_1.SelectedItem)).Moc();
                    a2 = ((Dane)(cb_2.SelectedItem)).Moc();
                    a3 = (a1 / a2);
                    tx_2.Text = a3 + "";
            }
            if (label3.Text == "Temperatura")
            {
                if (cb_1.Text == "Farenheit" && cb_2.Text == "Celsjusz")
                {
                    a1 = Convert.ToDouble(tx_1.Text);
                    a2 =( (5 * (a1 - 32))/9);
                    tx_2.Text = a2 + "";
                }

                if ( cb_1.Text == "Celsjusz" && cb_2.Text == "Farenheit")
                {
                    a1 = Convert.ToDouble(tx_1.Text);
                    a2 = (32+((9*a1)/5));
                    tx_2.Text = a2 + "";
                }

                if (cb_1.Text == "Farenheit" && cb_2.Text == "Kelwin")
                {
                    a1 = Convert.ToDouble(tx_1.Text);
                    a2 = (((5 * (a1 - 32))/ 9) + 273.15);
                    tx_2.Text = a2 + "";
                }

                if (cb_2.Text == "Kelwin" && cb_1.Text == "Celsjusz")
                {
                    a1 = Convert.ToDouble(tx_1.Text);
                    a2 = a1 + 273.15;
                    tx_2.Text = a2 + "";
                }

                if (cb_2.Text == "Celsjusz" && cb_1.Text == "Kelwin")
                {
                    a1 = Convert.ToDouble(tx_1.Text);
                    a2 = (a1 - 273.15);
                    tx_2.Text = a2 + "";
                }

                if (cb_2.Text == "Farenheit" && cb_1.Text == "Kelwin")
                {
                    a1 = (Convert.ToDouble(tx_1.Text) - 273.15);
                    a2 = (32 + ((9 * a1) / 5));
                    tx_2.Text = a2 + "";
                }

            }

            if (label3.Text == "Kąt")
            {
                if (cb_1.Text == "Radiany")
                {
                    a1 =(((Convert.ToDouble(tx_1.Text))*180)/Math.PI);
                    a2 = ((Dane)(cb_2.SelectedItem)).Moc();
                    a3 = (a1  / a2);
                    tx_2.Text = a3 + "";
                }

                if (cb_2.Text == "Radiany")
                {
                    a1 = Convert.ToDouble(tx_1.Text) * ((Dane)(cb_1.SelectedItem)).Moc();
                    a3 = ((a1 * Math.PI )/ 180);
                    tx_2.Text = a3 + "";
                }
                else
                {
                    a1 = Convert.ToDouble(tx_1.Text) * ((Dane)(cb_1.SelectedItem)).Moc();
                    a2 = ((Dane)(cb_2.SelectedItem)).Moc();
                    a3 = (a1 / a2);
                    tx_2.Text = a3 + "";
                }
            }
        }
        void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                
                switch (e.KeyChar)
                {
                    case (char)42:
                    e.Handled = true;
                    //bt_multi_Click(null, e);
                    tx_obl.Text += " * ";
                    break;
                    case (char)43:
                    e.Handled = true;
                    //bt_plus_Click(null, e);
                    tx_obl.Text += " + ";
                    break;
                    case (char)45:
                    e.Handled = true;
                    //bt_minus_Click(null, e);
                    tx_obl.Text += " - ";
                     break;
                    case (char)47:
                    e.Handled = true;
                    //bt_div_Click(null, e);
                    tx_obl.Text += " / ";
                    break;
                    case '\r':
                    e.Handled = true;
                    bt_equ_Click(null, e);
                    break;                    
            }
            tx_obl.Focus();
            tx_obl.SelectionStart = tx_obl.Text.Length;

        }

    }

}