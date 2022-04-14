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
using System.Security.Cryptography;


namespace DataGrid
{
    public partial class frmManageStudent : Form
    {
        public frmManageStudent()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtID.Clear();
            txtSname.Clear();
            txtFname.Clear();
            txtID.Clear();
            cboClass.Text = "";
            txtSection.Clear();


        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlDataAdapter sda = new SqlDataAdapter("SelectStudent", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            sda.Fill(ds, "a");
            DVGStudent.DataSource = ds.Tables["a"];
        }
        private void frmManageStudent_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            var sqlQuery = "";
           /* if (IfStudentExist(con, txtID.Text))*/
        
                sqlQuery = @"UPDATE [Students] SET SID = '" + txtID.Text + "',StudentName='" + txtSname + "' ,FatherName= '" + txtFname + "' ,Class= '" + cboClass + "' ,Section= '" + txtSection + "', WHERE [SID] = '" + txtID.Text + "' ";
            
           

            { }
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Clear();
            LoadData();
        }
        /*  private bool IfStudentExist(SqlConnection con, string StudentID);
        {      
              SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Students] WHERE [SID]= '" + txtStudentID.Text + "' ", con);
          DataTable dt = new DataTable();
          sda.Fill(dt);
              if (dt.Rows.Count>0)
                  return true;
              else
                  return false;
              }*/

        private void DVGStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Display()
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataTable dt = new DataTable();
            if (txtSearchID.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students WHERE SID LIKE '" + txtSearchID.Text + "%'",con);
                sda.Fill(dt);
      
            }
            else if(txtSearchName.Text.Length >0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students WHERE StudentName Like '"+txtSearchName.Text+ "%' " , con);
                sda.Fill(dt);
            }
            DVGStudent.DataSource = dt;

        }
        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
            if(txtSearchID.Text.Length>0)
            {
                Display();
            }
            else
            {
                LoadData();
            }
        }

        private void frmManageStudent_Load_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            txtSearchID.Text = "";
            if(txtSearchName.Text.Length > 0)
            {
                Display();
            }else
            {
                LoadData();
            }
        }

        private void txtID_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DVGStudent_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = DVGStudent.SelectedRows[0].Cells[0].Value.ToString();
            txtSname.Text = DVGStudent.SelectedRows[0].Cells[1].Value.ToString();
            txtFname.Text = DVGStudent.SelectedRows[0].Cells[2].Value.ToString();
            cboClass.Text = DVGStudent.SelectedRows[0].Cells[3].Value.ToString();
            txtSection.Text = DVGStudent.SelectedRows[0].Cells[4].Value.ToString();

        }
    }
}
