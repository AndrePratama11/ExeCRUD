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
    public partial class Form1 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.exeCRUDDataSet.Karyawan);
            txtIDK.Enabled = false;
            txtNamaK.Enabled = false;
            txtAlamatK.Enabled = false;
            txtJenisKelK.Enabled = false;
            
           
            cmdSimpan.Enabled = false;
        }

        private void cmdTambah_Click(object sender, EventArgs e)
        {
            cmdSimpan.Enabled = true;
            txtIDK.Enabled = true;
            txtNamaK.Enabled = true;
            txtAlamatK.Enabled = true;
            txtJenisKelK.Enabled = true;
        
            
            txtIDK.Text = "";
            txtNamaK.Text = "";
            txtAlamatK.Text = "";
            txtJenisKelK.Text = "";

            cmdTambah.Enabled = false;
        }

        private void cmdSimpan_Click(object sender, EventArgs e)
        {
            dt = exeCRUDDataSet.Tables["Karyawan"];
            dr = dt.NewRow();
            dr[0] = txtIDK.Text;
            dr[1] = txtNamaK.Text;
            dr[2] = txtAlamatK.Text;
            dr[3] = txtJenisKelK.Text;
            dt.Rows.Add(dr);
            karyawanTableAdapter.Update(exeCRUDDataSet);
            
            txtIDK.Text = System.Convert.ToString(dr[0]);
            txtNamaK.Enabled = false;
            txtAlamatK.Enabled = false;
            txtJenisKelK.Enabled = false;
            
            this.karyawanTableAdapter.Fill(this.exeCRUDDataSet.Karyawan);
            
            cmdTambah.Enabled = true;
            cmdSimpan.Enabled = false;
        }

        private void cmdHapus_Click(object sender, EventArgs e)
        {
            string code;
            code = txtIDK.Text;
      
            dr = exeCRUDDataSet.Tables["Karyawan"].Rows.Find(code);
            
            dr.Delete();
            karyawanTableAdapter.Update(exeCRUDDataSet);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }
    }
}
