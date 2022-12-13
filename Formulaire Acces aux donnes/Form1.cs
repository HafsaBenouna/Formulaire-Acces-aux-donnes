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

namespace Formulaire_Acces_aux_donnes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=DESKTOP-UPQQNIA\SQLEXPRESS;Initial Catalog=LIVRE;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void btnnew_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into livre(Nomlivre , Prix) values('" + comboBoxselect.Text + "','" + textBoxprix.Text + "') ";
            btndelete.Enabled = false;
            btnedit.Enabled = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update livre set Nomlivre ='" + comboBoxselect.Text + "' where Prix='" + textBoxprix.Text + "'";
            btnnew.Enabled = false;
            btndelete.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from livre where Nom='" + comboBoxselect.Text + "' ";
            btnnew.Enabled = false;
            btnedit.Enabled = false;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            cnx.Close();
        } 
         private void btnafficher_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from livre ";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridViewlivre.DataSource = dt;
        }

        private void lblNomLivre_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxprix_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void dataGridViewlivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
