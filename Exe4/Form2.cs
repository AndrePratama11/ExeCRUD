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
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.exeCRUDDataSet.Pelanggan);

            txtIDP.Enabled = false;
            txtNamaP.Enabled = false;
            txtAlamatP.Enabled = false;
            txtJenisKelP.Enabled = false;

            cmdSimpan.Enabled = false;
        }

        private void cmdTambah_Click(object sender, EventArgs e)
        {
            cmdSimpan.Enabled = true;
            txtIDP.Enabled = true;
            txtNamaP.Enabled = true;
            txtAlamatP.Enabled = true;
            txtJenisKelP.Enabled = true;
            txtIDP.Text = "";
            txtNamaP.Text = "";
            txtAlamatP.Text = "";
            txtJenisKelP.Text = "";
        }

        private void cmdSimpan_Click(object sender, EventArgs e)
        {
            dt = exeCRUDDataSet.Tables["Pelanggan"];
            dr = dt.NewRow();
            dr[0] = txtIDP.Text;
            dr[1] = txtNamaP.Text;
            dr[2] = txtAlamatP.Text;
            dr[3] = txtJenisKelP.Text;

            pelangganTableAdapter.Update(exeCRUDDataSet);

            txtIDP.Text = System.Convert.ToString(dr[0]);
            txtNamaP.Enabled = false;
            txtAlamatP.Enabled = false;
            txtJenisKelP.Enabled = false;

            this.pelangganTableAdapter.Fill(this.exeCRUDDataSet.Pelanggan);

            cmdTambah.Enabled = true;
            cmdSimpan.Enabled = false;
        }

        private void cmdHapus_Click(object sender, EventArgs e)
        {
            string code;
            code = txtIDP.Text;
            dr = exeCRUDDataSet.Tables["Pelanggan"].Rows.Find(code);
            dr.Delete();
            pelangganTableAdapter.Update(exeCRUDDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }
    }
}
