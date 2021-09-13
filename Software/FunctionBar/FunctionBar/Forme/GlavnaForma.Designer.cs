namespace FunctionBar
{
    partial class GlavnaForma
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
            this.uxAktivnaForma = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uxPregledInventura = new System.Windows.Forms.Button();
            this.uxStatistika = new System.Windows.Forms.Button();
            this.uxArtikl = new System.Windows.Forms.Button();
            this.uxInventura = new System.Windows.Forms.Button();
            this.uxZaposlenici = new System.Windows.Forms.Button();
            this.uxNarucivanje = new System.Windows.Forms.Button();
            this.uxZaprimanjeRobe = new System.Windows.Forms.Button();
            this.uxRacuni = new System.Windows.Forms.Button();
            this.uxRezervacije = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxAktivnaForma
            // 
            this.uxAktivnaForma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAktivnaForma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxAktivnaForma.Location = new System.Drawing.Point(-5, 170);
            this.uxAktivnaForma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxAktivnaForma.Name = "uxAktivnaForma";
            this.uxAktivnaForma.Size = new System.Drawing.Size(1738, 594);
            this.uxAktivnaForma.TabIndex = 2;
            this.uxAktivnaForma.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.uxAktivnaForma_HelpRequested);
            this.uxAktivnaForma.Paint += new System.Windows.Forms.PaintEventHandler(this.uxAktivnaForma_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.2F));
            this.tableLayoutPanel1.Controls.Add(this.uxPregledInventura, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxStatistika, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxArtikl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxInventura, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxZaposlenici, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxNarucivanje, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxZaprimanjeRobe, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxRacuni, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxRezervacije, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 118);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // uxPregledInventura
            // 
            this.uxPregledInventura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPregledInventura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPregledInventura.Location = new System.Drawing.Point(1188, 4);
            this.uxPregledInventura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxPregledInventura.Name = "uxPregledInventura";
            this.uxPregledInventura.Size = new System.Drawing.Size(146, 110);
            this.uxPregledInventura.TabIndex = 10;
            this.uxPregledInventura.Text = "Pregled inventura";
            this.uxPregledInventura.UseVisualStyleBackColor = true;
            this.uxPregledInventura.Click += new System.EventHandler(this.uxPregledInventura_Click);
            // 
            // uxStatistika
            // 
            this.uxStatistika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatistika.Location = new System.Drawing.Point(892, 4);
            this.uxStatistika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxStatistika.Name = "uxStatistika";
            this.uxStatistika.Size = new System.Drawing.Size(140, 110);
            this.uxStatistika.TabIndex = 6;
            this.uxStatistika.Text = "Statistika";
            this.uxStatistika.UseVisualStyleBackColor = true;
            this.uxStatistika.Click += new System.EventHandler(this.uxStatistika_Click);
            // 
            // uxArtikl
            // 
            this.uxArtikl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxArtikl.Location = new System.Drawing.Point(4, 4);
            this.uxArtikl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxArtikl.Name = "uxArtikl";
            this.uxArtikl.Size = new System.Drawing.Size(140, 110);
            this.uxArtikl.TabIndex = 7;
            this.uxArtikl.Text = "Artikli";
            this.uxArtikl.UseVisualStyleBackColor = true;
            this.uxArtikl.Click += new System.EventHandler(this.uxArtikl_Click);
            // 
            // uxInventura
            // 
            this.uxInventura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxInventura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInventura.Location = new System.Drawing.Point(1040, 4);
            this.uxInventura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxInventura.Name = "uxInventura";
            this.uxInventura.Size = new System.Drawing.Size(140, 110);
            this.uxInventura.TabIndex = 2;
            this.uxInventura.Text = "Inventura";
            this.uxInventura.UseVisualStyleBackColor = true;
            this.uxInventura.Click += new System.EventHandler(this.uxInventura_Click_1);
            // 
            // uxZaposlenici
            // 
            this.uxZaposlenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxZaposlenici.Location = new System.Drawing.Point(152, 4);
            this.uxZaposlenici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxZaposlenici.Name = "uxZaposlenici";
            this.uxZaposlenici.Size = new System.Drawing.Size(140, 110);
            this.uxZaposlenici.TabIndex = 3;
            this.uxZaposlenici.Text = "Zaposlenici";
            this.uxZaposlenici.UseVisualStyleBackColor = true;
            this.uxZaposlenici.Click += new System.EventHandler(this.uxZaposlenici_Click);
            // 
            // uxNarucivanje
            // 
            this.uxNarucivanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxNarucivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNarucivanje.Location = new System.Drawing.Point(744, 4);
            this.uxNarucivanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxNarucivanje.Name = "uxNarucivanje";
            this.uxNarucivanje.Size = new System.Drawing.Size(140, 110);
            this.uxNarucivanje.TabIndex = 5;
            this.uxNarucivanje.Text = "Naručivanje robe";
            this.uxNarucivanje.UseVisualStyleBackColor = true;
            this.uxNarucivanje.Click += new System.EventHandler(this.uxNarucivanje_Click_1);
            // 
            // uxZaprimanjeRobe
            // 
            this.uxZaprimanjeRobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxZaprimanjeRobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxZaprimanjeRobe.Location = new System.Drawing.Point(596, 4);
            this.uxZaprimanjeRobe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxZaprimanjeRobe.Name = "uxZaprimanjeRobe";
            this.uxZaprimanjeRobe.Size = new System.Drawing.Size(140, 110);
            this.uxZaprimanjeRobe.TabIndex = 9;
            this.uxZaprimanjeRobe.Text = "Narudžbenice";
            this.uxZaprimanjeRobe.UseVisualStyleBackColor = true;
            this.uxZaprimanjeRobe.Click += new System.EventHandler(this.uxZaprimanjeRobe_Click_1);
            // 
            // uxRacuni
            // 
            this.uxRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRacuni.Location = new System.Drawing.Point(448, 4);
            this.uxRacuni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxRacuni.Name = "uxRacuni";
            this.uxRacuni.Size = new System.Drawing.Size(140, 110);
            this.uxRacuni.TabIndex = 8;
            this.uxRacuni.Text = "Računi";
            this.uxRacuni.UseVisualStyleBackColor = true;
            this.uxRacuni.Click += new System.EventHandler(this.uxRacuni_Click);
            // 
            // uxRezervacije
            // 
            this.uxRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRezervacije.Location = new System.Drawing.Point(300, 4);
            this.uxRezervacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxRezervacije.Name = "uxRezervacije";
            this.uxRezervacije.Size = new System.Drawing.Size(140, 110);
            this.uxRezervacije.TabIndex = 4;
            this.uxRezervacije.Text = "Rezervacije";
            this.uxRezervacije.UseVisualStyleBackColor = true;
            this.uxRezervacije.Click += new System.EventHandler(this.uxRezervacije_Click_1);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1723, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uxAktivnaForma);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GlavnaForma";
            this.Text = "Glavna Forma";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uxAktivnaForma;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button uxStatistika;
        private System.Windows.Forms.Button uxArtikl;
        private System.Windows.Forms.Button uxInventura;
        private System.Windows.Forms.Button uxZaposlenici;
        private System.Windows.Forms.Button uxNarucivanje;
        private System.Windows.Forms.Button uxZaprimanjeRobe;
        private System.Windows.Forms.Button uxRacuni;
        private System.Windows.Forms.Button uxRezervacije;
        private System.Windows.Forms.Button uxPregledInventura;
    }
}

