namespace WinFormsApp1
{
    partial class dodajKupca
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
            ime = new TextBox();
            oib = new TextBox();
            prezime = new TextBox();
            nazad = new Button();
            Dodaj = new Button();
            SuspendLayout();
            // 
            // ime
            // 
            ime.Location = new Point(50, 25);
            ime.Name = "ime";
            ime.Size = new Size(300, 23);
            ime.TabIndex = 0;
            ime.Text = "Unesi ime";
            ime.TextChanged += ime_TextChanged;
            // 
            // oib
            // 
            oib.Location = new Point(50, 125);
            oib.Name = "oib";
            oib.Size = new Size(300, 23);
            oib.TabIndex = 1;
            oib.Text = "Unesi OIB";
            oib.TextChanged += oib_TextChanged;
            // 
            // prezime
            // 
            prezime.Location = new Point(50, 75);
            prezime.Name = "prezime";
            prezime.Size = new Size(300, 23);
            prezime.TabIndex = 2;
            prezime.Text = "Unesi prezime";
            prezime.TextChanged += prezime_TextChanged;
            // 
            // nazad
            // 
            nazad.BackColor = Color.Red;
            nazad.Location = new Point(250, 154);
            nazad.Name = "nazad";
            nazad.Size = new Size(100, 50);
            nazad.TabIndex = 3;
            nazad.Text = "Nazad";
            nazad.UseVisualStyleBackColor = false;
            nazad.Click += nazad_Click;
            // 
            // Dodaj
            // 
            Dodaj.BackColor = SystemColors.MenuHighlight;
            Dodaj.Location = new Point(50, 154);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(100, 50);
            Dodaj.TabIndex = 4;
            Dodaj.Text = "Dodaj";
            Dodaj.UseVisualStyleBackColor = false;
            Dodaj.Click += Dodaj_Click;
            // 
            // dodajKupca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(Dodaj);
            Controls.Add(nazad);
            Controls.Add(prezime);
            Controls.Add(oib);
            Controls.Add(ime);
            Name = "dodajKupca";
            Text = "dodajKupca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ime;
        private TextBox oib;
        private TextBox prezime;
        private Button nazad;
        private Button Dodaj;
    }
}