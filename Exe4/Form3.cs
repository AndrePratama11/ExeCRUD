using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Exe4
{
    public partial class Form3 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.exeCRUDDataSet.Transaksi);

            txtKodeTrx.Enabled = false;
            cbJenisTrx.Enabled = false;
            cbHari.Enabled = false;
            cbJenisTrx.Items.Add("Tunai");
            cbJenisTrx.Items.Add("Debit");
            cbHari.Items.Add("Senin");
            cbHari.Items.Add("Selasa");
            cbHari.Items.Add("Rabu");
            cbHari.Items.Add("Kamis");
            cbHari.Items.Add("Jumat");
            cbHari.Items.Add("Sabtu");
            cbHari.Items.Add("Minggu");

            cmdSimpan.Enabled = false;
        }

        private void cmdTambah_Click(object sender, EventArgs e)
        {
            cmdSimpan.Enabled = true;
            txtKodeTrx.Enabled = true;
            cbJenisTrx.Enabled = true;
            cbHari.Enabled = true;

            txtKodeTrx.Text = "";
            cbJenisTrx.Text = "";
            cbHari.Text = "";

            cmdTambah.Enabled = false;
        }

        private void cmdSimpan_Click(object sender, EventArgs e)
        {
            dt = exeCRUDDataSet.Tables["Transaksi"];
            dr = dt.NewRow();
            dr[0] = txtKodeTrx.Text;
            dr[1] = cbJenisTrx.Text;
            dr[2] = cbHari.Text;

            dt.Rows.Add(dr);

            transaksiTableAdapter.Update(exeCRUDDataSet);
            txtKodeTrx.Text = System.Convert.ToString(dr[0]);
            cbJenisTrx.Enabled = false;
            cbHari.Enabled = false;
            this.transaksiTableAdapter.Fill(this.exeCRUDDataSet.Transaksi);

            cmdTambah.Enabled = true;
            cmdSimpan.Enabled = false;
        }

        private void cmdHapus_Click(object sender, EventArgs e)
        {
            string code;
            code = txtKodeTrx.Text;

            dr = exeCRUDDataSet.Tables["Transaksi"].Rows.Find(code);
            dr.Delete();

            transaksiTableAdapter.Update(exeCRUDDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }
    }
}
