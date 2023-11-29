namespace WinFormsApp1
{
    partial class dodajArtikl
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
            artikldodaj = new Button();
            nazad = new Button();
            kategorija = new TextBox();
            Barcode = new TextBox();
            nazivArtikla = new TextBox();
            SuspendLayout();
            // 
            // artikldodaj
            // 
            artikldodaj.BackColor = SystemColors.MenuHighlight;
            artikldodaj.Cursor = Cursors.IBeam;
            artikldodaj.Location = new Point(50, 154);
            artikldodaj.Name = "artikldodaj";
            artikldodaj.Size = new Size(100, 50);
            artikldodaj.TabIndex = 14;
            artikldodaj.Text = "Dodaj";
            artikldodaj.UseVisualStyleBackColor = false;
            artikldodaj.Click += artikldodaj_Click;
            // 
            // nazad
            // 
            nazad.BackColor = Color.Red;
            nazad.Cursor = Cursors.IBeam;
            nazad.Location = new Point(250, 154);
            nazad.Name = "nazad";
            nazad.Size = new Size(100, 50);
            nazad.TabIndex = 13;
            nazad.Text = "Nazad";
            nazad.UseVisualStyleBackColor = false;
            nazad.Click += nazad_Click;
            // 
            // kategorija
            // 
            kategorija.Cursor = Cursors.IBeam;
            kategorija.Location = new Point(50, 75);
            kategorija.Name = "kategorija";
            kategorija.Size = new Size(300, 23);
            kategorija.TabIndex = 12;
            kategorija.Text = "Kategorija artikla";
            kategorija.TextChanged += kategorija_TextChanged;
            // 
            // Barcode
            // 
            Barcode.Cursor = Cursors.IBeam;
            Barcode.Location = new Point(50, 125);
            Barcode.Name = "Barcode";
            Barcode.Size = new Size(300, 23);
            Barcode.TabIndex = 11;
            Barcode.Text = "Unesi barcode";
            Barcode.TextChanged += Barcode_TextChanged;
            // 
            // nazivArtikla
            // 
            nazivArtikla.Cursor = Cursors.IBeam;
            nazivArtikla.Location = new Point(50, 25);
            nazivArtikla.Name = "nazivArtikla";
            nazivArtikla.Size = new Size(300, 23);
            nazivArtikla.TabIndex = 10;
            nazivArtikla.Text = "Naziv Artikla";
            nazivArtikla.TextChanged += nazivArtikla_TextChanged;
            // 
            // dodajArtikl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(artikldodaj);
            Controls.Add(nazad);
            Controls.Add(kategorija);
            Controls.Add(Barcode);
            Controls.Add(nazivArtikla);
            Name = "dodajArtikl";
            Text = "dodajArtikl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button artikldodaj;
        private Button nazad;
        private TextBox kategorija;
        private TextBox Barcode;
        private TextBox nazivArtikla;
    }
}