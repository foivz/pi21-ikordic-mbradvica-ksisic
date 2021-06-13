namespace FunctionBar.UC
{
    partial class NaruciArtikl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.uxKoličina = new System.Windows.Forms.TextBox();
            this.uxArtikl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Količina:";
            // 
            // uxKoličina
            // 
            this.uxKoličina.Location = new System.Drawing.Point(166, 41);
            this.uxKoličina.Name = "uxKoličina";
            this.uxKoličina.Size = new System.Drawing.Size(99, 20);
            this.uxKoličina.TabIndex = 5;
            // 
            // uxArtikl
            // 
            this.uxArtikl.FormattingEnabled = true;
            this.uxArtikl.Location = new System.Drawing.Point(26, 41);
            this.uxArtikl.Name = "uxArtikl";
            this.uxArtikl.Size = new System.Drawing.Size(121, 21);
            this.uxArtikl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artikl";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.Red;
            this.btnIzbrisi.Location = new System.Drawing.Point(271, 40);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(32, 21);
            this.btnIzbrisi.TabIndex = 8;
            this.btnIzbrisi.Text = "X";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // NaruciArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxKoličina);
            this.Controls.Add(this.uxArtikl);
            this.Name = "NaruciArtikl";
            this.Size = new System.Drawing.Size(306, 81);
            this.Load += new System.EventHandler(this.NaruciArtikl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxKoličina;
        private System.Windows.Forms.ComboBox uxArtikl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}
