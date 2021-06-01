namespace FunctionBar.Forme
{
    partial class ArtikliForm
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
            this.btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._PI21_19_DBDataSet = new FunctionBar._PI21_19_DBDataSet();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrsta_artiklaTableAdapter = new FunctionBar._PI21_19_DBDataSetTableAdapters.vrsta_artiklaTableAdapter();
            this.vrstaartiklaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaartiklaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaartiklaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._PI21_19_DBDataSet1 = new FunctionBar._PI21_19_DBDataSet1();
            this.vrstaartiklaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.vrsta_artiklaTableAdapter1 = new FunctionBar._PI21_19_DBDataSet1TableAdapters.vrsta_artiklaTableAdapter();
            this.vrstaartiklaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVrstaArtikla = new System.Windows.Forms.DataGridView();
            this._PI21_19_DBDataSet2 = new FunctionBar._PI21_19_DBDataSet2();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new FunctionBar._PI21_19_DBDataSet2TableAdapters.artiklTableAdapter();
            this.dgvArtikl = new System.Windows.Forms.DataGridView();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.CadetBlue;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(734, 291);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(115, 54);
            this.btn.TabIndex = 2;
            this.btn.Text = "Ažuriraj artikl";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(559, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Unesi novi artikl";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(909, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Izbriši artikl";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // _PI21_19_DBDataSet
            // 
            this._PI21_19_DBDataSet.DataSetName = "_PI21_19_DBDataSet";
            this._PI21_19_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrstaartiklaBindingSource
            // 
            this.vrstaartiklaBindingSource.DataMember = "vrsta_artikla";
            this.vrstaartiklaBindingSource.DataSource = this._PI21_19_DBDataSet;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaartiklaBindingSource1
            // 
            this.vrstaartiklaBindingSource1.DataMember = "vrsta_artikla";
            this.vrstaartiklaBindingSource1.DataSource = this._PI21_19_DBDataSet;
            // 
            // vrstaartiklaBindingSource2
            // 
            this.vrstaartiklaBindingSource2.DataMember = "vrsta_artikla";
            this.vrstaartiklaBindingSource2.DataSource = this._PI21_19_DBDataSet;
            // 
            // vrstaartiklaBindingSource3
            // 
            this.vrstaartiklaBindingSource3.DataMember = "vrsta_artikla";
            this.vrstaartiklaBindingSource3.DataSource = this._PI21_19_DBDataSet;
            // 
            // _PI21_19_DBDataSet1
            // 
            this._PI21_19_DBDataSet1.DataSetName = "_PI21_19_DBDataSet1";
            this._PI21_19_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrstaartiklaBindingSource4
            // 
            this.vrstaartiklaBindingSource4.DataMember = "vrsta_artikla";
            this.vrstaartiklaBindingSource4.DataSource = this._PI21_19_DBDataSet1;
            // 
            // vrsta_artiklaTableAdapter1
            // 
            this.vrsta_artiklaTableAdapter1.ClearBeforeFill = true;
            // 
            // vrstaartiklaBindingSource5
            // 
            this.vrstaartiklaBindingSource5.DataSource = typeof(FunctionBarDb.vrsta_artikla);
            // 
            // dgvVrstaArtikla
            // 
            this.dgvVrstaArtikla.AutoGenerateColumns = false;
            this.dgvVrstaArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.slika});
            this.dgvVrstaArtikla.DataSource = this.vrstaartiklaBindingSource5;
            this.dgvVrstaArtikla.Location = new System.Drawing.Point(12, 12);
            this.dgvVrstaArtikla.Name = "dgvVrstaArtikla";
            this.dgvVrstaArtikla.Size = new System.Drawing.Size(499, 671);
            this.dgvVrstaArtikla.TabIndex = 5;
            this.dgvVrstaArtikla.SelectionChanged += new System.EventHandler(this.dgvVrstaArtikla_SelectionChanged);
            // 
            // _PI21_19_DBDataSet2
            // 
            this._PI21_19_DBDataSet2.DataSetName = "_PI21_19_DBDataSet2";
            this._PI21_19_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "artikl";
            this.artiklBindingSource.DataSource = this._PI21_19_DBDataSet2;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // dgvArtikl
            // 
            this.dgvArtikl.AutoGenerateColumns = false;
            this.dgvArtikl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn1,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgvArtikl.DataSource = this.artiklBindingSource1;
            this.dgvArtikl.Location = new System.Drawing.Point(545, 23);
            this.dgvArtikl.Name = "dgvArtikl";
            this.dgvArtikl.Size = new System.Drawing.Size(321, 194);
            this.dgvArtikl.TabIndex = 6;
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataSource = typeof(FunctionBarDb.artikl);
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 300;
            // 
            // slika
            // 
            this.slika.DataPropertyName = "slika";
            this.slika.HeaderText = "Slika";
            this.slika.Name = "slika";
            this.slika.ReadOnly = true;
            this.slika.Width = 220;
            // 
            // ArtikliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1029, 757);
            this.Controls.Add(this.dgvArtikl);
            this.Controls.Add(this.dgvVrstaArtikla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn);
            this.Name = "ArtikliForm";
            this.Text = "ArtikliForm";
            this.Load += new System.EventHandler(this.ArtikliForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_19_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private _PI21_19_DBDataSet _PI21_19_DBDataSet;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private _PI21_19_DBDataSetTableAdapters.vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource2;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource3;
        private _PI21_19_DBDataSet1 _PI21_19_DBDataSet1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource4;
        private _PI21_19_DBDataSet1TableAdapters.vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter1;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource5;
        private System.Windows.Forms.DataGridView dgvVrstaArtikla;
        private _PI21_19_DBDataSet2 _PI21_19_DBDataSet2;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private _PI21_19_DBDataSet2TableAdapters.artiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.DataGridView dgvArtikl;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
    }
}