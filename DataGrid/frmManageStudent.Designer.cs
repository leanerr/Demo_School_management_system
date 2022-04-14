namespace DataGrid
{
    partial class frmManageStudent
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
            this.DVGStudent = new System.Windows.Forms.DataGridView();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DVGStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // DVGStudent
            // 
            this.DVGStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DVGStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DVGStudent.Location = new System.Drawing.Point(265, 104);
            this.DVGStudent.Name = "DVGStudent";
            this.DVGStudent.Size = new System.Drawing.Size(403, 213);
            this.DVGStudent.TabIndex = 25;
            this.DVGStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGStudent_CellContentClick);
            this.DVGStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DVGStudent_MouseClick);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(320, 76);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchID.TabIndex = 27;
            this.txtSearchID.Text = "Student";
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(483, 76);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 29;
            this.txtSearchName.Text = "Student Name";
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "StudentID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Name";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(125, 137);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 20);
            this.txtSname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Father Name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(125, 180);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 17;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(57, 219);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(32, 13);
            this.Class.TabIndex = 18;
            this.Class.Text = "Class";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(109, 216);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Section";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(111, 253);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(100, 20);
            this.txtSection.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 22;
            this.txtID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtID_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Search for students by ID or Name";
            // 
            // frmManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 417);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.DVGStudent);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label1);
            this.Name = "frmManageStudent";
            this.Text = "frmManageStudent";
            this.Load += new System.EventHandler(this.frmManageStudent_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DVGStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DVGStudent;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}