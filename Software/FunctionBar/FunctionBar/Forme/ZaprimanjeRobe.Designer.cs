namespace FunctionBar.Forme
{
    partial class ZaprimanjeRobe
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
            this.btnZaprimi = new System.Windows.Forms.Button();
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStavke = new System.Windows.Forms.Label();
            this.cbFilterNarudzbenice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaprimi.Location = new System.Drawing.Point(65, 579);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.Size = new System.Drawing.Size(116, 52);
            this.btnZaprimi.TabIndex = 3;
            this.btnZaprimi.Text = "Zaprimi";
            this.btnZaprimi.UseVisualStyleBackColor = true;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(65, 83);
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.Size = new System.Drawing.Size(536, 457);
            this.dgvNarudzbenice.TabIndex = 4;
            this.dgvNarudzbenice.SelectionChanged += new System.EventHandler(this.dgvNarudzbenice_SelectionChanged);
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(732, 83);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(558, 457);
            this.dgvStavke.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Narudžbenica";
            // 
            // lblStavke
            // 
            this.lblStavke.AutoSize = true;
            this.lblStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStavke.Location = new System.Drawing.Point(727, 35);
            this.lblStavke.Name = "lblStavke";
            this.lblStavke.Size = new System.Drawing.Size(84, 25);
            this.lblStavke.TabIndex = 7;
            this.lblStavke.Text = "Stavke ";
            // 
            // cbFilterNarudzbenice
            // 
            this.cbFilterNarudzbenice.FormattingEnabled = true;
            this.cbFilterNarudzbenice.Location = new System.Drawing.Point(241, 39);
            this.cbFilterNarudzbenice.Name = "cbFilterNarudzbenice";
            this.cbFilterNarudzbenice.Size = new System.Drawing.Size(170, 21);
            this.cbFilterNarudzbenice.TabIndex = 9;
            this.cbFilterNarudzbenice.SelectedIndexChanged += new System.EventHandler(this.cbFilterNarudzbenice_SelectedIndexChanged);
            // 
            // ZaprimanjeRobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1397, 664);
            this.Controls.Add(this.cbFilterNarudzbenice);
            this.Controls.Add(this.lblStavke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.dgvNarudzbenice);
            this.Controls.Add(this.btnZaprimi);
            this.Name = "ZaprimanjeRobe";
            this.Text = "NarudzbeniceForm";
            this.Load += new System.EventHandler(this.ZaprimanjeRobe_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ZaprimanjeRobe_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZaprimi;
        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStavke;
        private System.Windows.Forms.ComboBox cbFilterNarudzbenice;
    }
}