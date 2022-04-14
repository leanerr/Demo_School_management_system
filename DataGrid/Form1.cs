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

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("Form1", con);
                cmd.CommandType = CommandType.StoredProcedure;


                //Parameters students table
                cmd.Parameters.Add("@SID", SqlDbType.NVarChar, 50).Value = txtID.Text;
                cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar, 50).Value = txtSname.Text;
                cmd.Parameters.Add("@FatherName", SqlDbType.NVarChar, 50).Value = txtFname.Text;
                cmd.Parameters.Add("@Class", SqlDbType.NVarChar, 50).Value = cboClass.Text;
                cmd.Parameters.Add("@Section", SqlDbType.NVarChar, 50).Value = txtSection.Text;
           /*     cmd.Parameters.Add("@AdmDate", SqlDbType.NVarChar, 50).Value = txtAdmDate.Text;*/
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
         
        }

        private void txtSection_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdmDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Class_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
