
namespace Exe4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tableLayoutPanelTransaksi = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeTrx = new System.Windows.Forms.TextBox();
            this.cbJenisTrx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbHari = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdHapus = new System.Windows.Forms.Button();
            this.cmdSimpan = new System.Windows.Forms.Button();
            this.cmdTambah = new System.Windows.Forms.Button();
            this.bindingNavigatorTransaksi = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exeCRUDDataSet = new Exe4.ExeCRUDDataSet();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new Exe4.ExeCRUDDataSetTableAdapters.TransaksiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTransaksi)).BeginInit();
            this.bindingNavigatorTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTransaksi
            // 
            this.tableLayoutPanelTransaksi.BackColor = System.Drawing.Color.SpringGreen;
            this.tableLayoutPanelTransaksi.ColumnCount = 2;
            this.tableLayoutPanelTransaksi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaksi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaksi.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanelTransaksi.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanelTransaksi.Controls.Add(this.txtKodeTrx, 1, 0);
            this.tableLayoutPanelTransaksi.Controls.Add(this.cbJenisTrx, 1, 1);
            this.tableLayoutPanelTransaksi.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanelTransaksi.Controls.Add(this.cbHari, 1, 2);
            this.tableLayoutPanelTransaksi.Location = new System.Drawing.Point(12, 94);
            this.tableLayoutPanelTransaksi.Name = "tableLayoutPanelTransaksi";
            this.tableLayoutPanelTransaksi.RowCount = 3;
            this.tableLayoutPanelTransaksi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tableLayoutPanelTransaksi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tableLayoutPanelTransaksi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanelTransaksi.Size = new System.Drawing.Size(664, 142);
            this.tableLayoutPanelTransaksi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kode Transaksi";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Jenis Transksi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKodeTrx
            // 
            this.txtKodeTrx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Kode_Transaksi", true));
            this.txtKodeTrx.Location = new System.Drawing.Point(335, 3);
            this.txtKodeTrx.Name = "txtKodeTrx";
            this.txtKodeTrx.Size = new System.Drawing.Size(237, 22);
            this.txtKodeTrx.TabIndex = 4;
            // 
            // cbJenisTrx
            // 
            this.cbJenisTrx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Jenis_Transaksi", true));
            this.cbJenisTrx.FormattingEnabled = true;
            this.cbJenisTrx.Location = new System.Drawing.Point(335, 50);
            this.cbJenisTrx.Name = "cbJenisTrx";
            this.cbJenisTrx.Size = new System.Drawing.Size(237, 24);
            this.cbJenisTrx.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Hari";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbHari
            // 
            this.cbHari.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaksiBindingSource, "Hari", true));
            this.cbHari.FormattingEnabled = true;
            this.cbHari.Location = new System.Drawing.Point(335, 98);
            this.cbHari.Name = "cbHari";
            this.cbHari.Size = new System.Drawing.Size(237, 24);
            this.cbHari.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("News701 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "Data Penjualan Toko Buku";
            // 
            // cmdHapus
            // 
            this.cmdHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHapus.Location = new System.Drawing.Point(491, 266);
            this.cmdHapus.Name = "cmdHapus";
            this.cmdHapus.Size = new System.Drawing.Size(139, 58);
            this.cmdHapus.TabIndex = 14;
            this.cmdHapus.Text = "Hapus";
            this.cmdHapus.UseVisualStyleBackColor = false;
            this.cmdHapus.Click += new System.EventHandler(this.cmdHapus_Click);
            // 
            // cmdSimpan
            // 
            this.cmdSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSimpan.Location = new System.Drawing.Point(306, 266);
            this.cmdSimpan.Name = "cmdSimpan";
            this.cmdSimpan.Size = new System.Drawing.Size(139, 58);
            this.cmdSimpan.TabIndex = 13;
            this.cmdSimpan.Text = "Simpan";
            this.cmdSimpan.UseVisualStyleBackColor = false;
            this.cmdSimpan.Click += new System.EventHandler(this.cmdSimpan_Click);
            // 
            // cmdTambah
            // 
            this.cmdTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTambah.Location = new System.Drawing.Point(130, 266);
            this.cmdTambah.Name = "cmdTambah";
            this.cmdTambah.Size = new System.Drawing.Size(130, 58);
            this.cmdTambah.TabIndex = 12;
            this.cmdTambah.Text = "Tambah";
            this.cmdTambah.UseVisualStyleBackColor = false;
            this.cmdTambah.Click += new System.EventHandler(this.cmdTambah_Click);
            // 
            // bindingNavigatorTransaksi
            // 
            this.bindingNavigatorTransaksi.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigatorTransaksi.BindingSource = this.transaksiBindingSource;
            this.bindingNavigatorTransaksi.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigatorTransaksi.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigatorTransaksi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorTransaksi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigatorTransaksi.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorTransaksi.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigatorTransaksi.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigatorTransaksi.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigatorTransaksi.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigatorTransaksi.Name = "bindingNavigatorTransaksi";
            this.bindingNavigatorTransaksi.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigatorTransaksi.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigatorTransaksi.TabIndex = 15;
            this.bindingNavigatorTransaksi.Text = "bindingNavTransaksi";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // exeCRUDDataSet
            // 
            this.exeCRUDDataSet.DataSetName = "ExeCRUDDataSet";
            this.exeCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Location = new System.Drawing.Point(641, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigatorTransaksi);
            this.Controls.Add(this.cmdHapus);
            this.Controls.Add(this.cmdSimpan);
            this.Controls.Add(this.cmdTambah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanelTransaksi);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanelTransaksi.ResumeLayout(false);
            this.tableLayoutPanelTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTransaksi)).EndInit();
            this.bindingNavigatorTransaksi.ResumeLayout(false);
            this.bindingNavigatorTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTransaksi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKodeTrx;
        private System.Windows.Forms.ComboBox cbJenisTrx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbHari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdHapus;
        private System.Windows.Forms.Button cmdSimpan;
        private System.Windows.Forms.Button cmdTambah;
        private System.Windows.Forms.BindingNavigator bindingNavigatorTransaksi;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private ExeCRUDDataSet exeCRUDDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private ExeCRUDDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}