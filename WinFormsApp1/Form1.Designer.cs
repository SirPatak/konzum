namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            kupac = new Button();
            Narudzbe = new ListBox();
            dodajnarudzbu = new Button();
            urediNarudzbu = new Button();
            izbrisiNarudzbu = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(50, 25);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 0;
            button1.Text = "artikl";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // kupac
            // 
            kupac.BackColor = SystemColors.Menu;
            kupac.Location = new Point(350, 25);
            kupac.Name = "kupac";
            kupac.Size = new Size(100, 25);
            kupac.TabIndex = 1;
            kupac.Text = "kupac";
            kupac.UseVisualStyleBackColor = false;
            kupac.Click += kupac_Click;
            // 
            // Narudzbe
            // 
            Narudzbe.FormattingEnabled = true;
            Narudzbe.ItemHeight = 15;
            Narudzbe.Location = new Point(50, 100);
            Narudzbe.Name = "Narudzbe";
            Narudzbe.Size = new Size(400, 244);
            Narudzbe.TabIndex = 2;
            Narudzbe.SelectedIndexChanged += Narudzbe_SelectedIndexChanged;
            // 
            // dodajnarudzbu
            // 
            dodajnarudzbu.BackColor = Color.Lime;
            dodajnarudzbu.Location = new Point(456, 100);
            dodajnarudzbu.Name = "dodajnarudzbu";
            dodajnarudzbu.Size = new Size(75, 25);
            dodajnarudzbu.TabIndex = 3;
            dodajnarudzbu.Text = "Dodaj";
            dodajnarudzbu.UseVisualStyleBackColor = false;
            dodajnarudzbu.Click += dodajnarudzbu_Click;
            // 
            // urediNarudzbu
            // 
            urediNarudzbu.BackColor = SystemColors.MenuHighlight;
            urediNarudzbu.Location = new Point(456, 131);
            urediNarudzbu.Name = "urediNarudzbu";
            urediNarudzbu.Size = new Size(75, 25);
            urediNarudzbu.TabIndex = 4;
            urediNarudzbu.Text = "Uredi";
            urediNarudzbu.UseVisualStyleBackColor = false;
            urediNarudzbu.Click += urediNarudzbu_Click;
            // 
            // izbrisiNarudzbu
            // 
            izbrisiNarudzbu.BackColor = Color.Red;
            izbrisiNarudzbu.Location = new Point(456, 162);
            izbrisiNarudzbu.Name = "izbrisiNarudzbu";
            izbrisiNarudzbu.Size = new Size(75, 25);
            izbrisiNarudzbu.TabIndex = 5;
            izbrisiNarudzbu.Text = "Izbriši";
            izbrisiNarudzbu.UseVisualStyleBackColor = false;
            izbrisiNarudzbu.Click += izbrisiNarudzbu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(izbrisiNarudzbu);
            Controls.Add(urediNarudzbu);
            Controls.Add(dodajnarudzbu);
            Controls.Add(Narudzbe);
            Controls.Add(kupac);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button kupac;
        private ListBox Narudzbe;
        private Button dodajnarudzbu;
        private Button urediNarudzbu;
        private Button izbrisiNarudzbu;
    }
}