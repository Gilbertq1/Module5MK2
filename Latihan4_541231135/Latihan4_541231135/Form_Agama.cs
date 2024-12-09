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

namespace Latihan4_541231135
{
    public partial class Form_Agama : Form
    {

        private string conStr = "Data Source=LAPTOP-JGL33JAF\\MK2SQLSERVER; " +
    "Initial Catalog=dbAdmSekolah; Integrated Security=True";
        private SqlConnection sqlCon;
        private SqlConnection conn;

        public Form_Agama()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conStr);
            conn = new SqlConnection(conStr);
        }

        private void tampilDataAgama()
        {
        sqlCon.Open();
        SqlCommand sqlCmd = new SqlCommand();
        sqlCmd.Connection = sqlCon;
        sqlCmd.CommandType = CommandType.Text;
        sqlCmd.CommandText = "SELECT * FROM tbl_agama";
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
        sda.Fill(ds, "tbl_agama");
        dgAgama.DataSource = ds;
        dgAgama.DataMember = "tbl_agama";
        sqlCon.Close();
        }

        private void Form_Agama_Load(object sender, EventArgs e)
        {
            tampilDataAgama();
        }

        private void ClearData()
        {
            txtKodeAgama.Clear();
          
            txtNamaAgama.Clear();
        
            txtKodeAgama.Focus();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tbl_Agama " +
            "WHERE kode_agama = '" + txtKodeAgama. Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            tampilDataAgama();
            ClearData();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tbl_agama(kode_agama, nama_agama)" +
            "VALUES ('" + txtKodeAgama.Text + "', '" + txtNamaAgama.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            tampilDataAgama();
            ClearData();

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tbl_Agama SET " +
            "nama_agama = '" + txtNamaAgama. Text + "'" +
            "WHERE kode_agama = '" + txtKodeAgama. Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            tampilDataAgama();
            ClearData();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Form_Agama_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAdmSekolahDataSet.tbl_agama' table. You can move, or remove it, as needed.
            this.tbl_agamaTableAdapter.Fill(this.dbAdmSekolahDataSet.tbl_agama);

        }
    }
}
