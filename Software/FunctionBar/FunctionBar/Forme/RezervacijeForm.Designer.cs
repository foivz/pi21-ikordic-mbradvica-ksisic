namespace FunctionBar.Forme
{
    partial class RezervacijeForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumzaprimanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PI21_19_DBDataSet5 = new FunctionBar._PI21_19_DBDataSet5();
            this.rezervacijaTableAdapter = new FunctionBar._PI21_19_DBDataSet5TableAdapters.rezervacijaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Detalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(357, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obriši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(654, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Nova rezervacija";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AutoGenerateColumns = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.datumzaprimanjaDataGridViewTextBoxColumn,
            this.datumrezervacijeDataGridViewTextBoxColumn,
            this.idstolDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn});
            this.dgvRezervacije.DataSource = this.rezervacijaBindingSource;
            this.dgvRezervacije.Location = new System.Drawing.Point(43, 47);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.Size = new System.Drawing.Size(907, 234);
            this.dgvRezervacije.TabIndex = 7;
            this.dgvRezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumzaprimanjaDataGridViewTextBoxColumn
            // 
            this.datumzaprimanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_zaprimanja";
            this.datumzaprimanjaDataGridViewTextBoxColumn.HeaderText = "datum_zaprimanja";
            this.datumzaprimanjaDataGridViewTextBoxColumn.Name = "datumzaprimanjaDataGridViewTextBoxColumn";
            // 
            // datumrezervacijeDataGridViewTextBoxColumn
            // 
            this.datumrezervacijeDataGridViewTextBoxColumn.DataPropertyName = "datum_rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn.HeaderText = "datum_rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn.Name = "datumrezervacijeDataGridViewTextBoxColumn";
            // 
            // idstolDataGridViewTextBoxColumn
            // 
            this.idstolDataGridViewTextBoxColumn.DataPropertyName = "id_stol";
            this.idstolDataGridViewTextBoxColumn.HeaderText = "Stol";
            this.idstolDataGridViewTextBoxColumn.Name = "idstolDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "rezervacija";
            this.rezervacijaBindingSource.DataSource = this._PI21_19_DBDataSet5;
            // 
            // _PI21_19_DBDataSet5
            // 
            this._PI21_19_DBDataSet5.DataSetName = "_PI21_19_DBDataSet5";
            this._PI21_19_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // RezervacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(992, 605);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RezervacijeForm";
            this.Text = "RezervacijeForm";
            this.Load += new System.EventHandler(this.RezervacijeForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.RezervacijeForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private _PI21_19_DBDataSet5 _PI21_19_DBDataSet5;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private _PI21_19_DBDataSet5TableAdapters.rezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzaprimanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
    }
}