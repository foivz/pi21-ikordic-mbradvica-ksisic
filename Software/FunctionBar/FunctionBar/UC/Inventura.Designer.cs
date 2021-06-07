namespace FunctionBar.UC
{
    partial class Inventura
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxIzbrisi = new System.Windows.Forms.Button();
            this.uxRazlika = new System.Windows.Forms.TextBox();
            this.uxStanjeNaSkladistu = new System.Windows.Forms.TextBox();
            this.uxKolicinaUSustavu = new System.Windows.Forms.TextBox();
            this.uxNaziv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Razlika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stanje u skladištu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Količina u sustavu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv artikla";
            // 
            // uxIzbrisi
            // 
            this.uxIzbrisi.BackColor = System.Drawing.Color.Red;
            this.uxIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxIzbrisi.Location = new System.Drawing.Point(520, 27);
            this.uxIzbrisi.Name = "uxIzbrisi";
            this.uxIzbrisi.Size = new System.Drawing.Size(29, 23);
            this.uxIzbrisi.TabIndex = 11;
            this.uxIzbrisi.Text = "X";
            this.uxIzbrisi.UseVisualStyleBackColor = false;
            this.uxIzbrisi.Click += new System.EventHandler(this.uxIzbrisi_Click);
            // 
            // uxRazlika
            // 
            this.uxRazlika.Cursor = System.Windows.Forms.Cursors.Help;
            this.uxRazlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRazlika.Location = new System.Drawing.Point(397, 30);
            this.uxRazlika.Name = "uxRazlika";
            this.uxRazlika.Size = new System.Drawing.Size(100, 20);
            this.uxRazlika.TabIndex = 10;
            this.uxRazlika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxRazlika.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxRazlika_MouseClick);
            // 
            // uxStanjeNaSkladistu
            // 
            this.uxStanjeNaSkladistu.Location = new System.Drawing.Point(265, 30);
            this.uxStanjeNaSkladistu.Name = "uxStanjeNaSkladistu";
            this.uxStanjeNaSkladistu.Size = new System.Drawing.Size(114, 20);
            this.uxStanjeNaSkladistu.TabIndex = 9;
            this.uxStanjeNaSkladistu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxStanjeNaSkladistu.TextChanged += new System.EventHandler(this.uxStanjeNaSkladistu_TextChanged);
            // 
            // uxKolicinaUSustavu
            // 
            this.uxKolicinaUSustavu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uxKolicinaUSustavu.Location = new System.Drawing.Point(145, 30);
            this.uxKolicinaUSustavu.Name = "uxKolicinaUSustavu";
            this.uxKolicinaUSustavu.Size = new System.Drawing.Size(109, 20);
            this.uxKolicinaUSustavu.TabIndex = 8;
            this.uxKolicinaUSustavu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxNaziv
            // 
            this.uxNaziv.FormattingEnabled = true;
            this.uxNaziv.Location = new System.Drawing.Point(15, 29);
            this.uxNaziv.Name = "uxNaziv";
            this.uxNaziv.Size = new System.Drawing.Size(121, 21);
            this.uxNaziv.TabIndex = 7;
            this.uxNaziv.SelectedIndexChanged += new System.EventHandler(this.uxNaziv_SelectedIndexChanged);
            // 
            // Inventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxIzbrisi);
            this.Controls.Add(this.uxRazlika);
            this.Controls.Add(this.uxStanjeNaSkladistu);
            this.Controls.Add(this.uxKolicinaUSustavu);
            this.Controls.Add(this.uxNaziv);
            this.Name = "Inventura";
            this.Size = new System.Drawing.Size(632, 69);
            this.Load += new System.EventHandler(this.Inventura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxIzbrisi;
        private System.Windows.Forms.TextBox uxRazlika;
        private System.Windows.Forms.TextBox uxStanjeNaSkladistu;
        private System.Windows.Forms.TextBox uxKolicinaUSustavu;
        private System.Windows.Forms.ComboBox uxNaziv;
    }
}
