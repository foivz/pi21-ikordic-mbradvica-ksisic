namespace FunctionBar.Forme
{
    partial class InventuraForm
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
            this.uxArtikli = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxArtikli
            // 
            this.uxArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxArtikli.AutoScroll = true;
            this.uxArtikli.BackColor = System.Drawing.Color.SteelBlue;
            this.uxArtikli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxArtikli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uxArtikli.Location = new System.Drawing.Point(23, 12);
            this.uxArtikli.Name = "uxArtikli";
            this.uxArtikli.Size = new System.Drawing.Size(889, 133);
            this.uxArtikli.TabIndex = 1;
            this.uxArtikli.Click += new System.EventHandler(this.uxArtikli_Click);
            this.uxArtikli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxArtikli_MouseDown);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(16, 572);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(118, 34);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Novi artikl";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.Firebrick;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(403, 572);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(131, 34);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši sve";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(777, 572);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(136, 34);
            this.btnAzuriraj.TabIndex = 4;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // InventuraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(942, 633);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.uxArtikli);
            this.Name = "InventuraForm";
            this.Text = "InventuraForm";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.InventuraForm_HelpRequested);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxArtikli;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}