
namespace Exe4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanelPelanggan = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtNamaP = new System.Windows.Forms.TextBox();
            this.txtAlamatP = new System.Windows.Forms.TextBox();
            this.txtJenisKelP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdTambah = new System.Windows.Forms.Button();
            this.cmdSimpan = new System.Windows.Forms.Button();
            this.cmdHapus = new System.Windows.Forms.Button();
            this.bindingNavigatorPelanggan = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exeCRUDDataSet = new Exe4.ExeCRUDDataSet();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelangganTableAdapter = new Exe4.ExeCRUDDataSetTableAdapters.PelangganTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPelanggan)).BeginInit();
            this.bindingNavigatorPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPelanggan
            // 
            this.tableLayoutPanelPelanggan.BackColor = System.Drawing.Color.SpringGreen;
            this.tableLayoutPanelPelanggan.ColumnCount = 2;
            this.tableLayoutPanelPelanggan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPelanggan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPelanggan.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanelPelanggan.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanelPelanggan.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanelPelanggan.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanelPelanggan.Controls.Add(this.txtIDP, 1, 0);
            this.tableLayoutPanelPelanggan.Controls.Add(this.txtNamaP, 1, 1);
            this.tableLayoutPanelPelanggan.Controls.Add(this.txtAlamatP, 1, 2);
            this.tableLayoutPanelPelanggan.Controls.Add(this.txtJenisKelP, 1, 3);
            this.tableLayoutPanelPelanggan.Location = new System.Drawing.Point(12, 95);
            this.tableLayoutPanelPelanggan.Name = "tableLayoutPanelPelanggan";
            this.tableLayoutPanelPelanggan.RowCount = 5;
            this.tableLayoutPanelPelanggan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tableLayoutPanelPelanggan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tableLayoutPanelPelanggan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanelPelanggan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelPelanggan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPelanggan.Size = new System.Drawing.Size(664, 206);
            this.tableLayoutPanelPelanggan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Pelanggan";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama Pelanggan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Alamat";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Jenis Kelamin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDP
            // 
            this.txtIDP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "Id_Pelanggan", true));
            this.txtIDP.Location = new System.Drawing.Point(335, 3);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(237, 22);
            this.txtIDP.TabIndex = 4;
            // 
            // txtNamaP
            // 
            this.txtNamaP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "Nama", true));
            this.txtNamaP.Location = new System.Drawing.Point(335, 43);
            this.txtNamaP.Name = "txtNamaP";
            this.txtNamaP.Size = new System.Drawing.Size(237, 22);
            this.txtNamaP.TabIndex = 5;
            // 
            // txtAlamatP
            // 
            this.txtAlamatP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "Alamat", true));
            this.txtAlamatP.Location = new System.Drawing.Point(335, 84);
            this.txtAlamatP.Name = "txtAlamatP";
            this.txtAlamatP.Size = new System.Drawing.Size(237, 22);
            this.txtAlamatP.TabIndex = 6;
            // 
            // txtJenisKelP
            // 
            this.txtJenisKelP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelangganBindingSource, "Jenis_Kelamin", true));
            this.txtJenisKelP.Location = new System.Drawing.Point(335, 140);
            this.txtJenisKelP.Name = "txtJenisKelP";
            this.txtJenisKelP.Size = new System.Drawing.Size(237, 22);
            this.txtJenisKelP.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("News701 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 38);
            this.label11.TabIndex = 8;
            this.label11.Text = "Data Penjualan Toko Buku";
            // 
            // cmdTambah
            // 
            this.cmdTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTambah.Location = new System.Drawing.Point(144, 338);
            this.cmdTambah.Name = "cmdTambah";
            this.cmdTambah.Size = new System.Drawing.Size(130, 58);
            this.cmdTambah.TabIndex = 9;
            this.cmdTambah.Text = "Tambah";
            this.cmdTambah.UseVisualStyleBackColor = false;
            this.cmdTambah.Click += new System.EventHandler(this.cmdTambah_Click);
            // 
            // cmdSimpan
            // 
            this.cmdSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSimpan.Location = new System.Drawing.Point(309, 338);
            this.cmdSimpan.Name = "cmdSimpan";
            this.cmdSimpan.Size = new System.Drawing.Size(139, 58);
            this.cmdSimpan.TabIndex = 10;
            this.cmdSimpan.Text = "Simpan";
            this.cmdSimpan.UseVisualStyleBackColor = false;
            this.cmdSimpan.Click += new System.EventHandler(this.cmdSimpan_Click);
            // 
            // cmdHapus
            // 
            this.cmdHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHapus.Location = new System.Drawing.Point(482, 338);
            this.cmdHapus.Name = "cmdHapus";
            this.cmdHapus.Size = new System.Drawing.Size(139, 58);
            this.cmdHapus.TabIndex = 11;
            this.cmdHapus.Text = "Hapus";
            this.cmdHapus.UseVisualStyleBackColor = false;
            this.cmdHapus.Click += new System.EventHandler(this.cmdHapus_Click);
            // 
            // bindingNavigatorPelanggan
            // 
            this.bindingNavigatorPelanggan.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigatorPelanggan.BindingSource = this.pelangganBindingSource;
            this.bindingNavigatorPelanggan.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorPelanggan.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigatorPelanggan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorPelanggan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigatorPelanggan.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorPelanggan.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorPelanggan.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorPelanggan.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorPelanggan.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorPelanggan.Name = "bindingNavigatorPelanggan";
            this.bindingNavigatorPelanggan.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorPelanggan.Size = new System.Drawing.Size(837, 27);
            this.bindingNavigatorPelanggan.TabIndex = 12;
            this.bindingNavigatorPelanggan.Text = "bindingNavPelanggan";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // exeCRUDDataSet
            // 
            this.exeCRUDDataSet.DataSetName = "ExeCRUDDataSet";
            this.exeCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 62);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(837, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigatorPelanggan);
            this.Controls.Add(this.cmdHapus);
            this.Controls.Add(this.cmdSimpan);
            this.Controls.Add(this.cmdTambah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanelPelanggan);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanelPelanggan.ResumeLayout(false);
            this.tableLayoutPanelPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPelanggan)).EndInit();
            this.bindingNavigatorPelanggan.ResumeLayout(false);
            this.bindingNavigatorPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPelanggan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.TextBox txtNamaP;
        private System.Windows.Forms.TextBox txtAlamatP;
        private System.Windows.Forms.TextBox txtJenisKelP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdTambah;
        private System.Windows.Forms.Button cmdSimpan;
        private System.Windows.Forms.Button cmdHapus;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPelanggan;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private ExeCRUDDataSet exeCRUDDataSet;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private ExeCRUDDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}