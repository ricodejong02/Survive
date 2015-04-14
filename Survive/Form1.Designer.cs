namespace Survive
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.HungerLabel = new System.Windows.Forms.Label();
            this.ThirstLabel = new System.Windows.Forms.Label();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.HapinessLabel = new System.Windows.Forms.Label();
            this.PoopLabel = new System.Windows.Forms.Label();
            this.HygLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Foodlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Dorst = new System.Windows.Forms.Label();
            this.EnergyTimer = new System.Windows.Forms.Timer(this.components);
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1199, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items:";
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 10;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(32, 40);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(13, 20);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "\\";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(32, 60);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(13, 20);
            this.DayLabel.TabIndex = 5;
            this.DayLabel.Text = "\\";
            // 
            // HungerLabel
            // 
            this.HungerLabel.AutoSize = true;
            this.HungerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HungerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HungerLabel.Location = new System.Drawing.Point(32, 80);
            this.HungerLabel.Name = "HungerLabel";
            this.HungerLabel.Size = new System.Drawing.Size(13, 20);
            this.HungerLabel.TabIndex = 5;
            this.HungerLabel.Text = "\\";
            this.HungerLabel.Click += new System.EventHandler(this.HungerLabel_Click);
            // 
            // ThirstLabel
            // 
            this.ThirstLabel.AutoSize = true;
            this.ThirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirstLabel.Location = new System.Drawing.Point(32, 100);
            this.ThirstLabel.Name = "ThirstLabel";
            this.ThirstLabel.Size = new System.Drawing.Size(13, 20);
            this.ThirstLabel.TabIndex = 5;
            this.ThirstLabel.Text = "\\";
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyLabel.Location = new System.Drawing.Point(32, 120);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(13, 20);
            this.EnergyLabel.TabIndex = 5;
            this.EnergyLabel.Text = "\\";
            // 
            // HapinessLabel
            // 
            this.HapinessLabel.AutoSize = true;
            this.HapinessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapinessLabel.Location = new System.Drawing.Point(32, 140);
            this.HapinessLabel.Name = "HapinessLabel";
            this.HapinessLabel.Size = new System.Drawing.Size(13, 20);
            this.HapinessLabel.TabIndex = 5;
            this.HapinessLabel.Text = "\\";
            // 
            // PoopLabel
            // 
            this.PoopLabel.AutoSize = true;
            this.PoopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoopLabel.Location = new System.Drawing.Point(32, 160);
            this.PoopLabel.Name = "PoopLabel";
            this.PoopLabel.Size = new System.Drawing.Size(13, 20);
            this.PoopLabel.TabIndex = 5;
            this.PoopLabel.Text = "\\";
            // 
            // HygLabel
            // 
            this.HygLabel.AutoSize = true;
            this.HygLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HygLabel.Location = new System.Drawing.Point(32, 180);
            this.HygLabel.Name = "HygLabel";
            this.HygLabel.Size = new System.Drawing.Size(13, 20);
            this.HygLabel.TabIndex = 5;
            this.HygLabel.Text = "\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zoek Eten";
            this.toolTip1.SetToolTip(this.button1, "-5 Energie tot -1 Energie\r\n. 0 Voedsel tot 7 Voedsel. -5 Blijdschap tot 5 Blijdsc" +
        "hap.\r\n\r\n");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 5000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Foodlabel
            // 
            this.Foodlabel.AutoSize = true;
            this.Foodlabel.Location = new System.Drawing.Point(1168, 37);
            this.Foodlabel.Name = "Foodlabel";
            this.Foodlabel.Size = new System.Drawing.Size(12, 13);
            this.Foodlabel.TabIndex = 7;
            this.Foodlabel.Text = "/";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 77);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1332, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "/";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 77);
            this.button3.TabIndex = 6;
            this.button3.Text = "Slaap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1463, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Slaap";
            // 
            // Dorst
            // 
            this.Dorst.AutoSize = true;
            this.Dorst.Location = new System.Drawing.Point(1168, 60);
            this.Dorst.Name = "Dorst";
            this.Dorst.Size = new System.Drawing.Size(12, 13);
            this.Dorst.TabIndex = 7;
            this.Dorst.Text = "/";
            // 
            // EnergyTimer
            // 
            this.EnergyTimer.Enabled = true;
            this.EnergyTimer.Interval = 15000;
            this.EnergyTimer.Tick += new System.EventHandler(this.EnergyTimer_Tick);
            // 
            // RandomTimer
            // 
            this.RandomTimer.Enabled = true;
            this.RandomTimer.Interval = 60000;
            this.RandomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dorst);
            this.Controls.Add(this.Foodlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HygLabel);
            this.Controls.Add(this.PoopLabel);
            this.Controls.Add(this.HapinessLabel);
            this.Controls.Add(this.EnergyLabel);
            this.Controls.Add(this.ThirstLabel);
            this.Controls.Add(this.HungerLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label HungerLabel;
        private System.Windows.Forms.Label ThirstLabel;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Label HapinessLabel;
        private System.Windows.Forms.Label PoopLabel;
        private System.Windows.Forms.Label HygLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label Foodlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Dorst;
        private System.Windows.Forms.Timer EnergyTimer;
        private System.Windows.Forms.Timer RandomTimer;
    }
}

