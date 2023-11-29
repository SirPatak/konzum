namespace WinFormsApp1
{
    partial class listaartikala
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
            izbrisiArtikl = new Button();
            urediArtikl = new Button();
            dodajArtikl = new Button();
            Artikli = new ListBox();
            kupac = new Button();
            narudzba = new Button();
            SuspendLayout();
            // 
            // izbrisiArtikl
            // 
            izbrisiArtikl.BackColor = Color.Red;
            izbrisiArtikl.Location = new Point(456, 162);
            izbrisiArtikl.Name = "izbrisiArtikl";
            izbrisiArtikl.Size = new Size(75, 25);
            izbrisiArtikl.TabIndex = 11;
            izbrisiArtikl.Text = "Izbriši";
            izbrisiArtikl.UseVisualStyleBackColor = false;
            izbrisiArtikl.Click += izbrisiArtikl_Click;
            // 
            // urediArtikl
            // 
            urediArtikl.BackColor = SystemColors.MenuHighlight;
            urediArtikl.Location = new Point(456, 131);
            urediArtikl.Name = "urediArtikl";
            urediArtikl.Size = new Size(75, 25);
            urediArtikl.TabIndex = 10;
            urediArtikl.Text = "Uredi";
            urediArtikl.UseVisualStyleBackColor = false;
            urediArtikl.Click += urediArtikl_Click;
            // 
            // dodajArtikl
            // 
            dodajArtikl.BackColor = Color.Lime;
            dodajArtikl.Location = new Point(456, 100);
            dodajArtikl.Name = "dodajArtikl";
            dodajArtikl.Size = new Size(75, 25);
            dodajArtikl.TabIndex = 9;
            dodajArtikl.Text = "Dodaj";
            dodajArtikl.UseVisualStyleBackColor = false;
            dodajArtikl.Click += dodajArtikl_Click;
            // 
            // Artikli
            // 
            Artikli.FormattingEnabled = true;
            Artikli.ItemHeight = 15;
            Artikli.Location = new Point(50, 100);
            Artikli.Name = "Artikli";
            Artikli.Size = new Size(400, 244);
            Artikli.TabIndex = 8;
            Artikli.SelectedIndexChanged += Artikli_SelectedIndexChanged;
            // 
            // kupac
            // 
            kupac.BackColor = SystemColors.Menu;
            kupac.Location = new Point(50, 25);
            kupac.Name = "kupac";
            kupac.Size = new Size(100, 25);
            kupac.TabIndex = 7;
            kupac.Text = "kupac";
            kupac.UseVisualStyleBackColor = false;
            kupac.Click += kupac_Click;
            // 
            // narudzba
            // 
            narudzba.BackColor = SystemColors.Menu;
            narudzba.Location = new Point(350, 25);
            narudzba.Name = "narudzba";
            narudzba.Size = new Size(100, 25);
            narudzba.TabIndex = 6;
            narudzba.Text = "Narudžba";
            narudzba.UseVisualStyleBackColor = false;
            narudzba.Click += narudzba_Click;
            // 
            // listaartikala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(izbrisiArtikl);
            Controls.Add(urediArtikl);
            Controls.Add(dodajArtikl);
            Controls.Add(Artikli);
            Controls.Add(kupac);
            Controls.Add(narudzba);
            Name = "listaartikala";
            Text = "artikl";
            ResumeLayout(false);
        }

        #endregion

        private Button izbrisiArtikl;
        private Button urediArtikl;
        private Button dodajArtikl;
        private ListBox Artikli;
        private Button kupac;
        private Button narudzba;
    }
}