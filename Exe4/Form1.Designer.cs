
namespace Exe4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigatorKaryawan = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exeCRUDDataSet = new Exe4.ExeCRUDDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanelKaryawan = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDK = new System.Windows.Forms.TextBox();
            this.txtNamaK = new System.Windows.Forms.TextBox();
            this.txtAlamatK = new System.Windows.Forms.TextBox();
            this.txtJenisKelK = new System.Windows.Forms.TextBox();
            this.cmdTambah = new System.Windows.Forms.Button();
            this.cmdSimpan = new System.Windows.Forms.Button();
            this.cmdHapus = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.karyawanTableAdapter = new Exe4.ExeCRUDDataSetTableAdapters.KaryawanTableAdapter();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelangganTableAdapter = new Exe4.ExeCRUDDataSetTableAdapters.PelangganTableAdapter();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new Exe4.ExeCRUDDataSetTableAdapters.TransaksiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKaryawan)).BeginInit();
            this.bindingNavigatorKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).BeginInit();
            this.tableLayoutPanelKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorKaryawan
            // 
            this.bindingNavigatorKaryawan.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorKaryawan.BindingSource = this.karyawanBindingSource;
            this.bindingNavigatorKaryawan.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKaryawan.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorKaryawan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorKaryawan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorKaryawan.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorKaryawan.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKaryawan.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKaryawan.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKaryawan.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKaryawan.Name = "bindingNavigatorKaryawan";
            this.bindingNavigatorKaryawan.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKaryawan.Size = new System.Drawing.Size(982, 27);
            this.bindingNavigatorKaryawan.TabIndex = 0;
            this.bindingNavigatorKaryawan.Text = "bindingNavKaryawan";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.exeCRUDDataSet;
            // 
            // exeCRUDDataSet
            // 
            this.exeCRUDDataSet.DataSetName = "ExeCRUDDataSet";
            this.exeCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tableLayoutPanelKaryawan
            // 
            this.tableLayoutPanelKaryawan.BackColor = System.Drawing.Color.SpringGreen;
            this.tableLayoutPanelKaryawan.ColumnCount = 2;
            this.tableLayoutPanelKaryawan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelKaryawan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelKaryawan.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelKaryawan.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelKaryawan.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelKaryawan.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanelKaryawan.Controls.Add(this.txtIDK, 1, 0);
            this.tableLayoutPanelKaryawan.Controls.Add(this.txtNamaK, 1, 1);
            this.tableLayoutPanelKaryawan.Controls.Add(this.txtAlamatK, 1, 2);
            this.tableLayoutPanelKaryawan.Controls.Add(this.txtJenisKelK, 1, 3);
            this.tableLayoutPanelKaryawan.Location = new System.Drawing.Point(12, 147);
            this.tableLayoutPanelKaryawan.Name = "tableLayoutPanelKaryawan";
            this.tableLayoutPanelKaryawan.RowCount = 4;
            this.tableLayoutPanelKaryawan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tableLayoutPanelKaryawan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tableLayoutPanelKaryawan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanelKaryawan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelKaryawan.Size = new System.Drawing.Size(664, 206);
            this.tableLayoutPanelKaryawan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Karyawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Karyawan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDK
            // 
            this.txtIDK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Id_Karyawan", true));
            this.txtIDK.Location = new System.Drawing.Point(335, 3);
            this.txtIDK.Name = "txtIDK";
            this.txtIDK.Size = new System.Drawing.Size(237, 22);
            this.txtIDK.TabIndex = 4;
            // 
            // txtNamaK
            // 
            this.txtNamaK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Nama", true));
            this.txtNamaK.Location = new System.Drawing.Point(335, 53);
            this.txtNamaK.Name = "txtNamaK";
            this.txtNamaK.Size = new System.Drawing.Size(237, 22);
            this.txtNamaK.TabIndex = 5;
            // 
            // txtAlamatK
            // 
            this.txtAlamatK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Alamat", true));
            this.txtAlamatK.Location = new System.Drawing.Point(335, 104);
            this.txtAlamatK.Name = "txtAlamatK";
            this.txtAlamatK.Size = new System.Drawing.Size(237, 22);
            this.txtAlamatK.TabIndex = 6;
            // 
            // txtJenisKelK
            // 
            this.txtJenisKelK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Jenis_Kelamin", true));
            this.txtJenisKelK.Location = new System.Drawing.Point(335, 160);
            this.txtJenisKelK.Name = "txtJenisKelK";
            this.txtJenisKelK.Size = new System.Drawing.Size(237, 22);
            this.txtJenisKelK.TabIndex = 7;
            // 
            // cmdTambah
            // 
            this.cmdTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTambah.Location = new System.Drawing.Point(179, 406);
            this.cmdTambah.Name = "cmdTambah";
            this.cmdTambah.Size = new System.Drawing.Size(136, 62);
            this.cmdTambah.TabIndex = 2;
            this.cmdTambah.Text = "Tambah";
            this.cmdTambah.UseVisualStyleBackColor = false;
            this.cmdTambah.Click += new System.EventHandler(this.cmdTambah_Click);
            // 
            // cmdSimpan
            // 
            this.cmdSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSimpan.Location = new System.Drawing.Point(347, 406);
            this.cmdSimpan.Name = "cmdSimpan";
            this.cmdSimpan.Size = new System.Drawing.Size(139, 62);
            this.cmdSimpan.TabIndex = 3;
            this.cmdSimpan.Text = "Simpan";
            this.cmdSimpan.UseVisualStyleBackColor = false;
            this.cmdSimpan.Click += new System.EventHandler(this.cmdSimpan_Click);
            // 
            // cmdHapus
            // 
            this.cmdHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHapus.Location = new System.Drawing.Point(518, 406);
            this.cmdHapus.Name = "cmdHapus";
            this.cmdHapus.Size = new System.Drawing.Size(139, 62);
            this.cmdHapus.TabIndex = 4;
            this.cmdHapus.Text = "Hapus";
            this.cmdHapus.UseVisualStyleBackColor = false;
            this.cmdHapus.Click += new System.EventHandler(this.cmdHapus_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("News701 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 38);
            this.label11.TabIndex = 7;
            this.label11.Text = "Data Penjualan Toko Buku";
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.exeCRUDDataSet;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.exeCRUDDataSet;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(808, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(982, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdHapus);
            this.Controls.Add(this.cmdSimpan);
            this.Controls.Add(this.cmdTambah);
            this.Controls.Add(this.tableLayoutPanelKaryawan);
            this.Controls.Add(this.bindingNavigatorKaryawan);
            this.Name = "Form1";
            this.Text = "Data Penjualan Toko Buku";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKaryawan)).EndInit();
            this.bindingNavigatorKaryawan.ResumeLayout(false);
            this.bindingNavigatorKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).EndInit();
            this.tableLayoutPanelKaryawan.ResumeLayout(false);
            this.tableLayoutPanelKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigatorKaryawan;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKaryawan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDK;
        private System.Windows.Forms.TextBox txtNamaK;
        private System.Windows.Forms.TextBox txtAlamatK;
        private System.Windows.Forms.TextBox txtJenisKelK;
        private System.Windows.Forms.Button cmdTambah;
        private System.Windows.Forms.Button cmdSimpan;
        private System.Windows.Forms.Button cmdHapus;
        private System.Windows.Forms.Label label11;
        private ExeCRUDDataSet exeCRUDDataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private ExeCRUDDataSetTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private ExeCRUDDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private ExeCRUDDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

