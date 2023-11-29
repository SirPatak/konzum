namespace WinFormsApp1
{
    partial class naruciArtikl
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
            naruci = new Button();
            nazad = new Button();
            listaKupaca = new ListBox();
            listaArtikala = new ListBox();
            SuspendLayout();
            // 
            // naruci
            // 
            naruci.BackColor = SystemColors.MenuHighlight;
            naruci.Cursor = Cursors.IBeam;
            naruci.Location = new Point(300, 25);
            naruci.Name = "naruci";
            naruci.Size = new Size(100, 50);
            naruci.TabIndex = 9;
            naruci.Text = "Naruči";
            naruci.UseVisualStyleBackColor = false;
            naruci.Click += naruci_Click;
            // 
            // nazad
            // 
            nazad.BackColor = Color.Red;
            nazad.Cursor = Cursors.IBeam;
            nazad.Location = new Point(300, 81);
            nazad.Name = "nazad";
            nazad.Size = new Size(100, 50);
            nazad.TabIndex = 8;
            nazad.Text = "Nazad";
            nazad.UseVisualStyleBackColor = false;
            nazad.Click += nazad_Click;
            // 
            // listaKupaca
            // 
            listaKupaca.FormattingEnabled = true;
            listaKupaca.ItemHeight = 15;
            listaKupaca.Location = new Point(25, 25);
            listaKupaca.Margin = new Padding(3, 2, 3, 2);
            listaKupaca.Name = "listaKupaca";
            listaKupaca.Size = new Size(250, 139);
            listaKupaca.TabIndex = 10;
            listaKupaca.SelectedIndexChanged += listaKupaca_SelectedIndexChanged;
            // 
            // listaArtikala
            // 
            listaArtikala.FormattingEnabled = true;
            listaArtikala.ItemHeight = 15;
            listaArtikala.Location = new Point(25, 200);
            listaArtikala.Margin = new Padding(3, 2, 3, 2);
            listaArtikala.Name = "listaArtikala";
            listaArtikala.Size = new Size(250, 139);
            listaArtikala.TabIndex = 11;
            listaArtikala.SelectedIndexChanged += listaArtikala_SelectedIndexChanged;
            // 
            // naruciArtikl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(listaArtikala);
            Controls.Add(listaKupaca);
            Controls.Add(naruci);
            Controls.Add(nazad);
            Name = "naruciArtikl";
            Text = "naruciArtikl";
            ResumeLayout(false);
        }

        #endregion

        private Button naruci;
        private Button nazad;
        private ListBox listaKupaca;
        private ListBox listaArtikala;
    }
}