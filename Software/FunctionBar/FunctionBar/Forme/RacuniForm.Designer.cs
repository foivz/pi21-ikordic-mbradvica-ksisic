namespace FunctionBar.Forme
{
    partial class RacuniForm
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
            this.dgvSviRacuni = new System.Windows.Forms.DataGridView();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.btnStorniraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviRacuni
            // 
            this.dgvSviRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviRacuni.Location = new System.Drawing.Point(48, 66);
            this.dgvSviRacuni.Name = "dgvSviRacuni";
            this.dgvSviRacuni.Size = new System.Drawing.Size(439, 447);
            this.dgvSviRacuni.TabIndex = 0;
            this.dgvSviRacuni.SelectionChanged += new System.EventHandler(this.dgvSviRacuni_SelectionChanged);
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(574, 66);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(490, 447);
            this.dgvStavkeRacuna.TabIndex = 1;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniraj.Location = new System.Drawing.Point(161, 551);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(145, 52);
            this.btnStorniraj.TabIndex = 2;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // RacuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1076, 648);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.dgvSviRacuni);
            this.Name = "RacuniForm";
            this.Text = "RacuniForm";
            this.Load += new System.EventHandler(this.RacuniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviRacuni;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Button btnStorniraj;
    }
}