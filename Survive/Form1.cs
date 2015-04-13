using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Survive
{
    public partial class Form1 : Form
    {
        decimal Time = 12;
        int Days = 1;
        int Hunger = 15;
        int Food = 5;
        int Energy = 25;
        int Hapiness = 50;
        int Thirst = 50;
        string Tijdstip = " 's middags";
        string DaysVar = "dag";
        string FoodVar = "stuks voedsel";
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = Time.ToString() + " Uur " + Tijdstip;
            DayLabel.Text = Days.ToString() + " " + DaysVar + " Overleefd!";
            HungerLabel.Text = Hunger.ToString() + "% Verzadigd";
            Foodlabel.Text = Food.ToString() + FoodVar;
            EnergyLabel.Text = Energy.ToString() + " Energie";
            HapinessLabel.Text = Hapiness.ToString() + "% Blij";
            ThirstLabel.Text = Thirst.ToString() + "% Dorst";
            if (Food >= 2)
            {
                FoodVar = " stuks voedsel";
            }

            if (Food == 1)
            {
                FoodVar = " stuk voedsel";
            }

            if (Food == 0)
            {
                FoodVar = " stuks voedsel";
            }
            if (Hunger <= 0)
            {
                MessageBox.Show("Game Over! Al je voedsel is op.");
                this.Close();
            }
            if (Energy <= 0)
            {
                MessageBox.Show("Game Over! Je hebt geen energie meer.");
                this.Close();

            }
            if (Days >= 2)
            {
                DaysVar = "dagen";
            }
            if (Time >= 0 && Time <= 5)
            {
                Tijdstip = " 's nachts";
            }

            if (Time >= 6 && Time <= 11)
            {
                Tijdstip = " 's ochtends";
            }

            if (Time >= 12 && Time <= 17)
            {
                Tijdstip = " 's middags";
            }

            if (Time >= 18 && Time <= 24)
            {
                Tijdstip = " 's avonds";
            }

            if (Time >= 24)
            {
                Time = 0;
                Days += 1;
            }

            if (Time == 0.60m)
            {
                Time = 1;
            }

            if (Time == 1.60m)
            {
                Time = 2;
            }

            if (Time == 2.60m)
            {
                Time = 3;
            }

            if (Time == 3.60m)
            {
                Time = 4;
            }

            if (Time == 4.60m)
            {
                Time = 5;
            }

            if (Time == 5.60m)
            {
                Time = 6;
            }

            if (Time == 6.60m)
            {
                Time = 7;
            }

            if (Time == 7.60m)
            {
                Time = 8;
            }

            if (Time == 8.60m)
            {
                Time = 9;
            }

            if (Time == 9.60m)
            {
                Time = 10;
            }

            if (Time == 10.60m)
            {
                Time = 11;
            }

            if (Time == 11.60m)
            {
                Time = 12;
            }

            if (Time == 12.60m)
            {
                Time = 13;
            }

            if (Time == 13.60m)
            {
                Time = 14;
            }

            if (Time == 14.60m)
            {
                Time = 15;
            }

            if (Time == 15.60m)
            {
                Time = 16;
            }

            if (Time == 16.60m)
            {
                Time = 17;
            }

            if (Time == 17.60m)
            {
                Time = 18;
            }

            if (Time == 18.60m)
            {
                Time = 19;
            }

            if (Time == 19.60m)
            {
                Time = 20;
            }

            if (Time == 20.60m)
            {
                Time = 21;
            }

            if (Time == 21.60m)
            {
                Time = 22;
            }

            if (Time == 22.60m)
            {
                Time = 23;
            }

            if (Time == 23.60m)
            {
                Time = 24;
            }


        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            Time += 0.15m;
            Hunger -= 1;
            Thirst -= 2;
            Hapiness -= 1;
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void HungerLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (rd.Next(5))
            {
                case 0:
                    MessageBox.Show("Bezig met zoeken...");
                    button1.Enabled = false;
                    Clock.Enabled = false;
                    Time += 1;
                    Thread.Sleep(5000);
                    Clock.Enabled = true;
                    button1.Enabled = true;
                    MessageBox.Show("Je hebt géén voedsel gevonden. Blijdschap -5.");
                    Hapiness -= 5;
                    Energy -= 2;
                    break;
                case 1:
                    MessageBox.Show("Bezig met zoeken...");
                    button1.Enabled = false;
                    Clock.Enabled = false;
                    Time += 1;
                    Thread.Sleep(5000);
                    Clock.Enabled = true;
                    button1.Enabled = true;
                    MessageBox.Show("Je hebt een klein beetje voedsel gevonden. Blijdschap -2. Voedsel + 1");
                    Hapiness -= 2;
                    Food += 1;
                    Energy -= 2;
                    break;
                case 2:
                    MessageBox.Show("Bezig met zoeken...");
                    button1.Enabled = false;
                    Clock.Enabled = false;
                    Time += 1;
                    Thread.Sleep(5000);
                    Clock.Enabled = true;
                    button1.Enabled = true;
                    MessageBox.Show("Je hebt voedsel gevonden. Blijdschap + 1. Voedsel + 3.");
                    Food += 3;
                    Hapiness += 1;
                    Energy -= 2;
                    break;
                case 3:
                    MessageBox.Show("Bezig met zoeken...");
                    button1.Enabled = false;
                    Clock.Enabled = false;
                    Time += 1;
                    Thread.Sleep(5000);
                    Clock.Enabled = true;
                    button1.Enabled = true;
                    MessageBox.Show("Je hebt  veel voedsel gevonden. Blijdschap + 3. Voedsel + 5.");
                    Food += 5;
                    Hapiness += 3;
                    Energy -= 3;
                    break;
                case 4:
                    MessageBox.Show("Bezig met zoeken...");
                    button1.Enabled = false;
                    Clock.Enabled = false;
                    Time += 1;
                    Thread.Sleep(5000);
                    Clock.Enabled = true;
                    button1.Enabled = true;
                    DialogResult dialogResult = MessageBox.Show("Je hebt erg veel voedsel gevonden dit kost veel energie om mee te nemen.\r\nAls ja: Blijdschap + 5. Voedsel + 7. Energie -5.\r\nAls nee: Blijdschap -5. Voedsel + 0. Energie -1.", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Food += 7;
                        Energy -= 5;
                        Hapiness += 5;
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Energy -= 1;
                        Hapiness -= 5;
                        break;
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Food >= 1)
            {
                Food -= 1;
                Hunger += 5;
            }

            else
            {
                MessageBox.Show("Je hebt niet genoeg eten.");
            }
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Time >= 1 && Time <= 17)
            {
                DialogResult dialogResult = MessageBox.Show("Overdag kan je niet goed slapen, toch doen?", "Zeker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Je hebt slecht geslapen! Blijdschap -10. Energie +3");
                    Hapiness -= 10;
                    Energy += 3;
                    Time = 5;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            if (Time >= 18)
            {
                switch (rd.Next(2))
                {
                    case 0:
                        MessageBox.Show("Je hebt slecht geslapen! Blijdschap -10. Energie +3");
                        Hapiness -= 10;
                        Energy += 3;
                        Time = 7;
                        break;
                    case 1:
                        MessageBox.Show("Je hebt heerlijk geslapen. Blijdschap + 10. Energie + 10");
                        Hapiness += 10;
                        Energy += 10;
                        Time += 11;
                        break;
                    case 2:
                        MessageBox.Show("Je hebt lekker geslapen. Blijdscap + 5. Emergie + 8);
                        Hapiness += 5;
                        Energy += 8;
                        Time = 10;
                        break;
                }
            }
        }

        private void EnergyTimer_Tick(object sender, EventArgs e)
        {
            Energy -= 2;
        }
    }
}

      
