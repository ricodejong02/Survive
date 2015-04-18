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
        public decimal Time = 12;

        public bool Vrouw = false;
        public bool Axe = false;
        public bool PickAxe = false;
        public bool Bow = false;

        public int Days = 1;
        public int Hunger = 15;
        public int Food = 5;
        public int Energy = 40;
        public int Hapiness = 50;
        public int Thirst = 50;

        public int Wood = 5;
        public int Stone = 5;
        public int Wool = 0;

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

        #region updater
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
            }
            if (Energy <= 0)
            {
                MessageBox.Show("Game Over! Je hebt geen energie meer.");
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

        #endregion

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Food >= 1)
            {
                Food -= 1;
                Hunger += 2;
                Hapiness += 1;
                Energy += 1;
            }

            else
            {
                MessageBox.Show("Je hebt niet genoeg eten.");
            }
        }

        #region eten
        private void button3_Click(object sender, EventArgs e)
        {
            switch (rd.Next(1))
            {
                case 0:
                    if (Bow == false)
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
                                DialogResult dialogResult = MessageBox.Show("Je hebt erg veel voedsel gevonden dit kost veel energie om mee te nemen.\r\nAls ja: Blijdschap + 5. Voedsel + 7. Energie -5.\r\nAls nee: Blijdschap -5. Voedsel + 0. Energie -1.", "Kies", MessageBoxButtons.YesNo);

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

                    if (Bow == true)
                    {
                        switch (rd.Next(3))
                        {
                            case 0:
                                MessageBox.Show("Bezig met zoeken...");
                                button1.Enabled = false;
                                Clock.Enabled = false;
                                Time += 1;
                                Thread.Sleep(5000);
                                Clock.Enabled = true;
                                button1.Enabled = true;
                                MessageBox.Show("Je hebt een konijn gedood. Blijdschap + 4. Voedsel + 3.");
                                Food += 3;
                                Energy -= 2;
                                Hapiness += 4;
                                break;
                            case 1:
                                MessageBox.Show("Bezig met zoeken...");
                                button1.Enabled = false;
                                Clock.Enabled = false;
                                Time += 1;
                                Thread.Sleep(5000);
                                Clock.Enabled = true;
                                button1.Enabled = true;
                                MessageBox.Show("Je hebt een varken gedood. Blijdschap + 5. Voedsel + 4.");
                                Food += 4;
                                Energy -= 3;
                                Hapiness += 5;
                                break;
                            case 2:
                                MessageBox.Show("Bezig met zoeken...");
                                button1.Enabled = false;
                                Clock.Enabled = false;
                                Time += 1;
                                Thread.Sleep(5000);
                                Clock.Enabled = true;
                                button1.Enabled = true;
                                MessageBox.Show("Je hebt een Koe gedood. Blijdschap + 6. Voedsel + 5.");
                                Food += 5;
                                Energy -= 4;
                                Hapiness += 6;
                                break;
                        }
                        break;
                    }
                    break;
            }
        }
        #endregion

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Time >= 1 && Time <= 17)
            {
                DialogResult dialogResult = MessageBox.Show("Overdag kan je niet goed slapen, toch doen?", "Zeker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Slecht();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            if (Time >= 18)
            {
                if (Hapiness >= 1 && Hapiness <= 20)
                {
                    switch (rd.Next(2))
                    {
                        case 0:
                            Nachtmerrie();
                            break;
                        case 1:
                            Superslecht();
                            break;
                    }
                }

                if (Hapiness >= 21 && Hapiness <= 40)
                {
                    switch (rd.Next(3))
                    {
                        case 0:
                            Nachtmerrie();
                            break;
                        case 1:
                            Superslecht();
                            break;
                        case 2:
                            Slecht();
                            break;
                    }
                }

                if (Hapiness >= 41 && Hapiness <= 60)
                {
                    switch (rd.Next(4))
                    {
                        case 0:
                            Slecht();
                            break;
                        case 1:
                            Normaal();
                            break;
                        case 2:
                            Prima();
                            break;
                        case 3:
                            Lekker();
                            break;
                    }
                }

                if (Hapiness >= 61 && Hapiness <= 80)
                {
                    switch (rd.Next(4))
                    {
                        case 0:
                            Normaal();
                            break;
                        case 1:
                            Prima();
                            break;
                        case 2:
                            Lekker();
                            break;
                        case 3:
                            Heerlijk();
                            break;
                    }
                }

                if (Hapiness >= 81 && Hapiness <= 100)
                {
                    switch (rd.Next(3))
                    {
                        case 0:
                            Prima();
                            break;
                        case 1:
                            Lekker();
                            break;
                        case 2:
                            Heerlijk();
                            break;
                    }
                }

                if (Hapiness >= 101)
                {
                    Heerlijk();
                }
            }
        }

        private void EnergyTimer_Tick(object sender, EventArgs e)
        {
            Energy -= 1;

            if (Vrouw == true)
            {
                Energy -= 1;
                Hapiness += 3;

                if (Food <= 0)
                {
                    MessageBox.Show("je vrouw heeft je verlaten omdat er geen voedsel meer was! je bent een sukkel. Blijdschap - 20. Voedsel - 10.");
                    Hapiness -= 20;
                    Vrouw = false;
                }

                if (Food >= 1)
                {
                    Food -= 2;
                }
            }
        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            switch (rd.Next(2))
            {

                case 0:
                    if (Food >= 10)
                    {
                        MessageBox.Show("je voedsel is gestolen. Voedsel - 10. Blijdschap - 5.");
                        Food -= 10;
                        Hapiness -= 5;
                    }
                    break;

                case 1:
                    if (Vrouw == false)
                    {
                        MessageBox.Show("je hebt een vrouw gevonden! Blijdschap + 10");
                        Hapiness += 10;
                        Vrouw = true;
                    }
                    break;

                case 2:
                    if (Vrouw == true)
                    {
                        MessageBox.Show("je vrouw heeft je verlaten! je bent een sukkel. Blijdschap - 20. Voedsel - 10.");
                        Hapiness -= 20;
                        Vrouw = false;
                        Food -= 10;
                    }
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void Nachtmerrie()
        {
            MessageBox.Show("Je hebt een super slecht geslapen. Blijdschap - 4. Energie + 5.");
            Hapiness -= 4;
            Energy += 5;
            Time = 6;
            Days += 1;
        }

        public void Superslecht()
        {
            MessageBox.Show("Je hebt een super slecht geslapen. Blijdschap - 4. Energie + 5.");
            Hapiness -= 4;
            Energy += 5;
            Time = 6;
            Days += 1;
        }

        public void Slecht()
        {
            MessageBox.Show("Je hebt slecht geslapen! Blijdschap -10. Energie +6");
            Hapiness -= 10;
            Energy += 6;
            Time = 5;
            Days += 1;
        }

        public void Normaal()
        {
            MessageBox.Show("Je hebt geslapen. Energie + 12.");
            Energy += 15;
            Time = 8;
            Days += 1;
        }

        public void Prima()
        {         
            MessageBox.Show("Je hebt prima geslapen. Energie + 15. Blijdschap + 5");
            Hapiness += 5;
            Energy += 15;
            Time = 9;
            Days += 1;
        }

        public void Lekker()
        {
            MessageBox.Show("Je hebt lekker geslapen. Energie + 17. Blijdschap + 7");
            Hapiness += 7;
            Energy += 19;
            Time = 10;
            Days += 1;
        }
        public void Heerlijk()
        {
            MessageBox.Show("Je hebt heerlijk geslapen. Energie + 19. Blijdschap + 10");
            Hapiness += 10;
            Energy += 19;
            Time = 11;
            Days += 1;
        }
    }
}


      
