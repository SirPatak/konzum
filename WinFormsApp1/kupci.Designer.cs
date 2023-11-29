namespace WinFormsApp1
{
    partial class kupci
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
            kupciLista = new ListBox();
            izbrisiKupca = new Button();
            urediKupca = new Button();
            dodajkupca = new Button();
            narudzba = new Button();
            artikl = new Button();
            SuspendLayout();
            // 
            // kupciLista
            // 
            kupciLista.FormattingEnabled = true;
            kupciLista.ItemHeight = 15;
            kupciLista.Location = new Point(50, 100);
            kupciLista.Name = "kupciLista";
            kupciLista.Size = new Size(400, 244);
            kupciLista.TabIndex = 0;
            kupciLista.SelectedIndexChanged += kupciLista_SelectedIndexChanged;
            // 
            // izbrisiKupca
            // 
            izbrisiKupca.BackColor = Color.Red;
            izbrisiKupca.Location = new Point(456, 162);
            izbrisiKupca.Name = "izbrisiKupca";
            izbrisiKupca.Size = new Size(75, 25);
            izbrisiKupca.TabIndex = 8;
            izbrisiKupca.Text = "Izbriši";
            izbrisiKupca.UseVisualStyleBackColor = false;
            izbrisiKupca.Click += izbrisiKupca_Click;
            // 
            // urediKupca
            // 
            urediKupca.BackColor = SystemColors.MenuHighlight;
            urediKupca.Location = new Point(456, 131);
            urediKupca.Name = "urediKupca";
            urediKupca.Size = new Size(75, 25);
            urediKupca.TabIndex = 7;
            urediKupca.Text = "Uredi";
            urediKupca.UseVisualStyleBackColor = false;
            urediKupca.Click += urediKupca_Click;
            // 
            // dodajkupca
            // 
            dodajkupca.BackColor = Color.Lime;
            dodajkupca.Location = new Point(456, 100);
            dodajkupca.Name = "dodajkupca";
            dodajkupca.Size = new Size(75, 25);
            dodajkupca.TabIndex = 6;
            dodajkupca.Text = "Dodaj";
            dodajkupca.UseVisualStyleBackColor = false;
            dodajkupca.Click += dodajkupca_Click;
            // 
            // narudzba
            // 
            narudzba.BackColor = SystemColors.Menu;
            narudzba.Location = new Point(350, 25);
            narudzba.Name = "narudzba";
            narudzba.Size = new Size(100, 25);
            narudzba.TabIndex = 10;
            narudzba.Text = "Narudzba";
            narudzba.UseVisualStyleBackColor = false;
            narudzba.Click += narudzba_Click;
            // 
            // artikl
            // 
            artikl.BackColor = SystemColors.Menu;
            artikl.Location = new Point(50, 25);
            artikl.Name = "artikl";
            artikl.Size = new Size(100, 25);
            artikl.TabIndex = 9;
            artikl.Text = "artikl";
            artikl.UseVisualStyleBackColor = false;
            artikl.Click += artikl_Click;
            // 
            // kupci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(narudzba);
            Controls.Add(artikl);
            Controls.Add(izbrisiKupca);
            Controls.Add(urediKupca);
            Controls.Add(dodajkupca);
            Controls.Add(kupciLista);
            Name = "kupci";
            Text = "kupci";
            ResumeLayout(false);
        }

        #endregion

        private ListBox kupciLista;
        private Button izbrisiKupca;
        private Button urediKupca;
        private Button dodajkupca;
        private Button narudzba;
        private Button artikl;
    }
}