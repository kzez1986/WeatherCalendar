namespace Kalendarz_Pogody
{
    partial class Kalendarz
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.teLublin = new System.Windows.Forms.TextBox();
            this.teTemperatura = new System.Windows.Forms.TextBox();
            this.teWiatr = new System.Windows.Forms.TextBox();
            this.teCiśnienie = new System.Windows.Forms.TextBox();
            this.teWarunki = new System.Windows.Forms.TextBox();
            this.laMiesiącMax = new System.Windows.Forms.Label();
            this.laMiesiącMin = new System.Windows.Forms.Label();
            this.laMieśŚrednia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buOdśwież = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Image = global::Kalendarz_Pogody.Properties.Resources.stopnie;
            this.pictureBox2.Location = new System.Drawing.Point(148, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 73);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // teLublin
            // 
            this.teLublin.BackColor = System.Drawing.Color.Gray;
            this.teLublin.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teLublin.Location = new System.Drawing.Point(27, 7);
            this.teLublin.Name = "teLublin";
            this.teLublin.Size = new System.Drawing.Size(801, 73);
            this.teLublin.TabIndex = 7;
            // 
            // teTemperatura
            // 
            this.teTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.teTemperatura.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teTemperatura.Location = new System.Drawing.Point(28, 158);
            this.teTemperatura.Name = "teTemperatura";
            this.teTemperatura.Size = new System.Drawing.Size(100, 82);
            this.teTemperatura.TabIndex = 8;
            // 
            // teWiatr
            // 
            this.teWiatr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teWiatr.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teWiatr.Location = new System.Drawing.Point(257, 209);
            this.teWiatr.Name = "teWiatr";
            this.teWiatr.Size = new System.Drawing.Size(371, 36);
            this.teWiatr.TabIndex = 9;
            // 
            // teCiśnienie
            // 
            this.teCiśnienie.BackColor = System.Drawing.Color.Yellow;
            this.teCiśnienie.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teCiśnienie.Location = new System.Drawing.Point(257, 158);
            this.teCiśnienie.Name = "teCiśnienie";
            this.teCiśnienie.Size = new System.Drawing.Size(371, 36);
            this.teCiśnienie.TabIndex = 10;
            // 
            // teWarunki
            // 
            this.teWarunki.BackColor = System.Drawing.Color.Red;
            this.teWarunki.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teWarunki.Location = new System.Drawing.Point(28, 261);
            this.teWarunki.Name = "teWarunki";
            this.teWarunki.Size = new System.Drawing.Size(689, 31);
            this.teWarunki.TabIndex = 11;
            // 
            // laMiesiącMax
            // 
            this.laMiesiącMax.AutoSize = true;
            this.laMiesiącMax.BackColor = System.Drawing.Color.White;
            this.laMiesiącMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laMiesiącMax.Location = new System.Drawing.Point(25, 322);
            this.laMiesiącMax.Name = "laMiesiącMax";
            this.laMiesiącMax.Size = new System.Drawing.Size(172, 20);
            this.laMiesiącMax.TabIndex = 12;
            this.laMiesiącMax.Text = "Miesięczne maksimum:";
            // 
            // laMiesiącMin
            // 
            this.laMiesiącMin.AutoSize = true;
            this.laMiesiącMin.BackColor = System.Drawing.Color.White;
            this.laMiesiącMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laMiesiącMin.Location = new System.Drawing.Point(26, 354);
            this.laMiesiącMin.Name = "laMiesiącMin";
            this.laMiesiącMin.Size = new System.Drawing.Size(163, 20);
            this.laMiesiącMin.TabIndex = 13;
            this.laMiesiącMin.Text = "Miesięczne  minimum:";
            // 
            // laMieśŚrednia
            // 
            this.laMieśŚrednia.AutoSize = true;
            this.laMieśŚrednia.BackColor = System.Drawing.Color.White;
            this.laMieśŚrednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laMieśŚrednia.Location = new System.Drawing.Point(25, 380);
            this.laMieśŚrednia.Name = "laMieśŚrednia";
            this.laMieśŚrednia.Size = new System.Drawing.Size(148, 20);
            this.laMieśŚrednia.TabIndex = 14;
            this.laMieśŚrednia.Text = "Miesięczna średnia:";
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buOdśwież
            // 
            this.buOdśwież.Location = new System.Drawing.Point(667, 377);
            this.buOdśwież.Name = "buOdśwież";
            this.buOdśwież.Size = new System.Drawing.Size(134, 23);
            this.buOdśwież.TabIndex = 15;
            this.buOdśwież.Text = "Odśwież dane";
            this.buOdśwież.UseVisualStyleBackColor = true;
            this.buOdśwież.Click += new System.EventHandler(this.buOdśwież_Click);
            // 
            // Kalendarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(851, 412);
            this.Controls.Add(this.buOdśwież);
            this.Controls.Add(this.laMieśŚrednia);
            this.Controls.Add(this.laMiesiącMin);
            this.Controls.Add(this.laMiesiącMax);
            this.Controls.Add(this.teWarunki);
            this.Controls.Add(this.teCiśnienie);
            this.Controls.Add(this.teWiatr);
            this.Controls.Add(this.teTemperatura);
            this.Controls.Add(this.teLublin);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Kalendarz";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Kalendarz_Load);
            this.Shown += new System.EventHandler(this.Kalendarz_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox teLublin;
        private System.Windows.Forms.TextBox teTemperatura;
        private System.Windows.Forms.TextBox teWiatr;
        private System.Windows.Forms.TextBox teCiśnienie;
        private System.Windows.Forms.TextBox teWarunki;
        private System.Windows.Forms.Label laMiesiącMax;
        private System.Windows.Forms.Label laMiesiącMin;
        private System.Windows.Forms.Label laMieśŚrednia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buOdśwież;
    }
}

