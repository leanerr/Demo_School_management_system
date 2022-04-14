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
    public partial class frmManageClasses : Form
    {
        public frmManageClasses()
        {
            InitializeComponent();
        }
        public void ClearAll()
        {
            txtCID.Clear();
            txtClass.Clear();
          


        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Classes]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DVGClass.Rows.Clear();
            foreach(DataRow item in dt.Rows)
            {
                int n = DVGClass.Rows.Add();
                DVGClass.Rows[n].Cells[0].Value = item["ClassID"].ToString();
                DVGClass.Rows[n].Cells[1].Value = item["Class"].ToString();

            }

        }
        private void frmManageClasses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DVGClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            var SqlQuery = "";
            if(IfClassExist(con,txtClassID.Text))
            {
                SqlQuery = @"UPDATE [Classes] SET [Class] = '" + txtClass.Text + "'WHERE [ClassID] = '" + txtCID.Text + "' ";
            }
            else
            {
                SqlQuery = @"INSERT INTO [dbo].[Classes]([ClassID],[Class]) VALUES  ('"+txtCID.Text+"','"+txtClass.Text+"')";
            }
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            //Read Data
            LoadData();
            ClearAll();

        }

        private bool IfClassExist(SqlConnection con, string text)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Classes] WHERE [ClassID]= '" + txtCID.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
            throw new NotImplementedException();
        }

      /*  private void DVGClass_DoubleClick(object sender, EventArgs e)
        {
            txtCID.Text = DVGClass.SelectedRows[0].Cells[0].Value.ToString();
            txtClass.Text = DVGClass.SelectedRows[0].Cells[1].Value.ToString();
     
        }*/

      /*  private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            var SqlQuery = "";
            if (IfClassExist(con, txtClassID.Text))
            {
                con.Open();
                SqlQuery = @"DELETE FROM [Classes] WHERE [ClassID] = '"+txtCID.Text +"' ";
                  SqlCommand cmd = new SqlCommand(SqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Read Data
                ClearAll();
                LoadData();
            } 
            else
            {
                MessageBox.Show("not exist");
            }
        //}*/

        private void DVGClass_MouseClick(object sender, MouseEventArgs e)
        {
            txtCID.Text = DVGClass.SelectedRows[0].Cells[0].Value.ToString();
            txtClass.Text = DVGClass.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            var SqlQuery = "";
            if (IfClassExist(con, txtClassID.Text))
            {
                con.Open();
                SqlQuery = @"DELETE FROM [Classes] WHERE [ClassID] = '" + txtCID.Text + "' ";
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Read Data
                ClearAll();
                LoadData();
            }
            else
            {
                MessageBox.Show("not exist");
            }
        }
    }
}
