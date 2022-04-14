using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 fas = new Form1();
            fas.ShowDialog();
        
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmManageStudent fas = new frmManageStudent();
            fas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageClasses fas = new frmManageClasses();
            fas.ShowDialog();
        }
    }
}
