namespace Latihan4_541231135
{
    partial class Form_Agama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodeAgama = new System.Windows.Forms.TextBox();
            this.dgAgama = new System.Windows.Forms.DataGridView();
            this.txtNamaAgama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dbAdmSekolahDataSet = new Latihan4_541231135.dbAdmSekolahDataSet();
            this.tblagamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_agamaTableAdapter = new Latihan4_541231135.dbAdmSekolahDataSetTableAdapters.tbl_agamaTableAdapter();
            this.kodeagamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaagamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblagamaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Agama";
            // 
            // txtKodeAgama
            // 
            this.txtKodeAgama.Location = new System.Drawing.Point(120, 53);
            this.txtKodeAgama.Name = "txtKodeAgama";
            this.txtKodeAgama.Size = new System.Drawing.Size(100, 20);
            this.txtKodeAgama.TabIndex = 1;
            // 
            // dgAgama
            // 
            this.dgAgama.AutoGenerateColumns = false;
            this.dgAgama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeagamaDataGridViewTextBoxColumn,
            this.namaagamaDataGridViewTextBoxColumn});
            this.dgAgama.DataSource = this.tblagamaBindingSource;
            this.dgAgama.Location = new System.Drawing.Point(31, 153);
            this.dgAgama.Name = "dgAgama";
            this.dgAgama.Size = new System.Drawing.Size(283, 178);
            this.dgAgama.TabIndex = 2;
            this.dgAgama.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNamaAgama
            // 
            this.txtNamaAgama.Location = new System.Drawing.Point(120, 78);
            this.txtNamaAgama.Name = "txtNamaAgama";
            this.txtNamaAgama.Size = new System.Drawing.Size(137, 20);
            this.txtNamaAgama.TabIndex = 5;
            this.txtNamaAgama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode Agama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 7;
            this.label3.Tag = "";
            this.label3.Text = "Nama Agama";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 115);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(256, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(94, 115);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 10;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(175, 115);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // dbAdmSekolahDataSet
            // 
            this.dbAdmSekolahDataSet.DataSetName = "dbAdmSekolahDataSet";
            this.dbAdmSekolahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblagamaBindingSource
            // 
            this.tblagamaBindingSource.DataMember = "tbl_agama";
            this.tblagamaBindingSource.DataSource = this.dbAdmSekolahDataSet;
            // 
            // tbl_agamaTableAdapter
            // 
            this.tbl_agamaTableAdapter.ClearBeforeFill = true;
            // 
            // kodeagamaDataGridViewTextBoxColumn
            // 
            this.kodeagamaDataGridViewTextBoxColumn.DataPropertyName = "kode_agama";
            this.kodeagamaDataGridViewTextBoxColumn.HeaderText = "kode_agama";
            this.kodeagamaDataGridViewTextBoxColumn.Name = "kodeagamaDataGridViewTextBoxColumn";
            // 
            // namaagamaDataGridViewTextBoxColumn
            // 
            this.namaagamaDataGridViewTextBoxColumn.DataPropertyName = "nama_agama";
            this.namaagamaDataGridViewTextBoxColumn.HeaderText = "nama_agama";
            this.namaagamaDataGridViewTextBoxColumn.Name = "namaagamaDataGridViewTextBoxColumn";
            // 
            // Form_Agama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(341, 343);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaAgama);
            this.Controls.Add(this.dgAgama);
            this.Controls.Add(this.txtKodeAgama);
            this.Controls.Add(this.label1);
            this.Name = "Form_Agama";
            this.Text = "Form_Agama";
            this.Load += new System.EventHandler(this.Form_Agama_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblagamaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodeAgama;
        private System.Windows.Forms.DataGridView dgAgama;
        private System.Windows.Forms.TextBox txtNamaAgama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private dbAdmSekolahDataSet dbAdmSekolahDataSet;
        private System.Windows.Forms.BindingSource tblagamaBindingSource;
        private dbAdmSekolahDataSetTableAdapters.tbl_agamaTableAdapter tbl_agamaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeagamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaagamaDataGridViewTextBoxColumn;
    }
}