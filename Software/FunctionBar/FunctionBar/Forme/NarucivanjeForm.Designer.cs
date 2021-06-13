namespace FunctionBar.Forme
{
    partial class NarucivanjeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxArtikliKoličina = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnUkloniSve = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIBAN);
            this.groupBox1.Controls.Add(this.txtKontakt);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtOIB);
            this.groupBox1.Controls.Add(this.cbNaziv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o dobavljaču";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(89, 276);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.ReadOnly = true;
            this.txtIBAN.Size = new System.Drawing.Size(213, 29);
            this.txtIBAN.TabIndex = 9;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(89, 221);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.ReadOnly = true;
            this.txtKontakt.Size = new System.Drawing.Size(213, 29);
            this.txtKontakt.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(89, 168);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(213, 29);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(89, 115);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.ReadOnly = true;
            this.txtOIB.Size = new System.Drawing.Size(213, 29);
            this.txtOIB.TabIndex = 6;
            // 
            // cbNaziv
            // 
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(89, 62);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(213, 32);
            this.cbNaziv.TabIndex = 5;
            this.cbNaziv.SelectedIndexChanged += new System.EventHandler(this.cbNaziv_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "IBAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kontakt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "OIB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // uxArtikliKoličina
            // 
            this.uxArtikliKoličina.AutoScroll = true;
            this.uxArtikliKoličina.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uxArtikliKoličina.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uxArtikliKoličina.Location = new System.Drawing.Point(403, 24);
            this.uxArtikliKoličina.Name = "uxArtikliKoličina";
            this.uxArtikliKoličina.Size = new System.Drawing.Size(1167, 540);
            this.uxArtikliKoličina.TabIndex = 9;
            // 
            // btnNaruci
            // 
            this.btnNaruci.BackColor = System.Drawing.SystemColors.Info;
            this.btnNaruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNaruci.Location = new System.Drawing.Point(1176, 584);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(394, 43);
            this.btnNaruci.TabIndex = 12;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = false;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnUkloniSve
            // 
            this.btnUkloniSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkloniSve.Location = new System.Drawing.Point(829, 593);
            this.btnUkloniSve.Name = "btnUkloniSve";
            this.btnUkloniSve.Size = new System.Drawing.Size(151, 43);
            this.btnUkloniSve.TabIndex = 11;
            this.btnUkloniSve.Text = "Ukloni sve artikle";
            this.btnUkloniSve.UseVisualStyleBackColor = true;
            this.btnUkloniSve.Click += new System.EventHandler(this.btnUkloniSve_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(403, 593);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 43);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj artikl";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // NarucivanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1623, 692);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnUkloniSve);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.uxArtikliKoličina);
            this.Controls.Add(this.groupBox1);
            this.Name = "NarucivanjeForm";
            this.Text = "NarucivanjeForm";
            this.Load += new System.EventHandler(this.NarucivanjeForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NarucivanjeForm_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.ComboBox cbNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel uxArtikliKoličina;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnUkloniSve;
        private System.Windows.Forms.Button btnDodaj;
    }
}