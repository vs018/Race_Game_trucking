using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_trucking
{
    public partial class MainArea : Form
    {
        int truckNo = 0, PlayerNo = 0;
        int gravin = 100, ducker = 100, azad = 100;

        Runner runner = new Runner();
        Player ply = new Player();

        public MainArea()
        {
            InitializeComponent();
            button_race.Visible =false;
        }

        private void truck1_CheckedChanged(object sender, EventArgs e)
        {
            if (truck1.Checked == true) {
                truckNo = 1;
            }
        }

        private void truck2_CheckedChanged(object sender, EventArgs e)
        {
            if (truck2.Checked == true)
            {
                truckNo = 2;
            }
        }

        private void truck3_CheckedChanged(object sender, EventArgs e)
        {
            if (truck3.Checked == true)
            {
                truckNo = 3;
            }
        }

        private void gravin_has_CheckedChanged(object sender, EventArgs e)
        {
            if (gravin_has.Checked == true) {
                PlayerNo = 1;
            }
        }

        private void ducker_has_CheckedChanged(object sender, EventArgs e)
        {
            if (ducker_has.Checked == true)
            {
                PlayerNo = 2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (runner.move(play_truck1)==1) {
                timer1.Stop();
                MessageBox.Show("First truck ");
                if (gravin_has.Text.Contains('-')==true) {
                    gravin=ply.budget(gravin_has.Text, 1, gravin);
                }
                if (ducker_has.Text.Contains('-')==true)
                {
                    ducker = ply.budget(ducker_has.Text, 1, ducker);
                }
                if (azad_has.Text.Contains("-")==true)
                {
                    azad = ply.budget(azad_has.Text, 1,azad);
                }
                play_truck1.Left = 261;
                play_truck2.Left = 261;
                play_truck3.Left = 261;
                play_truck4.Left = 261;

                gravin_has.Text = "Gravin has " + gravin;
                ducker_has.Text = "Ducker has " + ducker;
                azad_has.Text = "Azad has " + azad;
                button_race.Visible = false;

            }
            if (runner.move(play_truck2) == 1)
            {
                timer1.Stop();
                MessageBox.Show("Second truck ");
                if (gravin_has.Text.Contains('-') == true)
                {
                    gravin = ply.budget(gravin_has.Text, 1, gravin);
                }
                if (ducker_has.Text.Contains('-') == true)
                {
                    ducker = ply.budget(ducker_has.Text, 1, ducker);
                }
                if (azad_has.Text.Contains("-") == true)
                {
                    azad = ply.budget(azad_has.Text, 1, azad);
                }
                play_truck1.Left = 261;
                play_truck2.Left = 261;
                play_truck3.Left = 261;
                play_truck4.Left = 261;

                gravin_has.Text = "Gravin has " + gravin;
                ducker_has.Text = "Ducker has " + ducker;
                azad_has.Text = "Azad has " + azad;
                button_race.Visible = false;

            }
            if (runner.move(play_truck3) == 1)
            {
                timer1.Stop();
                MessageBox.Show("Third truck ");
                if (gravin_has.Text.Contains('-') == true)
                {
                    gravin = ply.budget(gravin_has.Text, 1, gravin);
                }
                if (ducker_has.Text.Contains('-') == true)
                {
                    ducker = ply.budget(ducker_has.Text, 1, ducker);
                }
                if (azad_has.Text.Contains("-") == true)
                {
                    azad = ply.budget(azad_has.Text, 1, azad);
                }
                play_truck1.Left = 261;
                play_truck2.Left = 261;
                play_truck3.Left = 261;
                play_truck4.Left = 261;

                gravin_has.Text = "Gravin has " + gravin;
                ducker_has.Text = "Ducker has " + ducker;
                azad_has.Text = "Azad has " + azad;
                button_race.Visible = false;

            }
            if (runner.move(play_truck4) == 1)
            {
                timer1.Stop();
                MessageBox.Show("Forth truck ");

                if (gravin_has.Text.Contains('-') == true)
                {
                    gravin = ply.budget(gravin_has.Text, 1, gravin);
                }
                if (ducker_has.Text.Contains('-') == true)
                {
                    ducker = ply.budget(ducker_has.Text, 1, ducker);
                }
                if (azad_has.Text.Contains("-") == true)
                {
                    azad = ply.budget(azad_has.Text, 1, azad);
                }
                play_truck1.Left = 261;
                play_truck2.Left = 261;
                play_truck3.Left = 261;
                play_truck4.Left = 261;

                gravin_has.Text = "Gravin has " + gravin;
                ducker_has.Text = "Ducker has " + ducker;
                azad_has.Text = "Azad has " + azad;
                button_race.Visible = false;

            }
        }


        private void button_race_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void azad_has_CheckedChanged(object sender, EventArgs e)
        {
            if (azad_has.Checked == true)
            {
                PlayerNo = 3;
            }
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            if (PlayerNo > 0 && truckNo > 0 && !amount_txtbox.Text.Equals(""))
            {
                //then need to set the value
                if (PlayerNo == 1 && gravin >= Convert.ToInt32(amount_txtbox.Text))
                {
                    gravin_has.Text = "Gravin-" + Convert.ToInt32(amount_txtbox.Text) + "-" + truckNo;
                    button_race.Visible = true;
                }
                else if (PlayerNo == 2 && ducker >= Convert.ToInt32(amount_txtbox.Text))
                {
                    ducker_has.Text = "Ducker-" + Convert.ToInt32(amount_txtbox.Text) + "-" + truckNo;
                    button_race.Visible = true;
                }
                else if (PlayerNo == 3 && azad >= Convert.ToInt32(amount_txtbox.Text))
                {
                    azad_has.Text = "Azad-" + Convert.ToInt32(amount_txtbox.Text) + "-" + truckNo;
                    button_race.Visible = true;
                }
                else
                {
                    MessageBox.Show("Must need to fill all details ");
                }

                PlayerNo = 0;
                truckNo = 0;


            }
            else {
                MessageBox.Show("Must need to select   the Player and truck ");
            }
        }

        private void truck4_CheckedChanged(object sender, EventArgs e)
        {
            if (truck4.Checked == true)
            {
                truckNo = 4;
            }
        }
    }
}
