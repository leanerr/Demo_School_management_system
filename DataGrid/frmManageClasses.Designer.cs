namespace DataGrid
{
    partial class frmManageClasses
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.DVGClass = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtClassID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVGClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-62, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "StudentID";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(77, 106);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 35;
            this.txtClass.Text = "Student Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Class Name";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(77, 70);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 20);
            this.txtCID.TabIndex = 33;
            this.txtCID.Text = "Student";
            // 
            // DVGClass
            // 
            this.DVGClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DVGClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.Class});
            this.DVGClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DVGClass.Location = new System.Drawing.Point(30, 171);
            this.DVGClass.MultiSelect = false;
            this.DVGClass.Name = "DVGClass";
            this.DVGClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DVGClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVGClass.Size = new System.Drawing.Size(306, 235);
            this.DVGClass.TabIndex = 32;
            this.DVGClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DVGClass_MouseClick);
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(261, -8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 10);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUpdate.Location = new System.Drawing.Point(261, 68);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 37;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = false;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtClassID
            // 
            this.txtClassID.AutoSize = true;
            this.txtClassID.Location = new System.Drawing.Point(15, 73);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(43, 13);
            this.txtClassID.TabIndex = 38;
            this.txtClassID.Text = "ClassID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // frmManageClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 418);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.DVGClass);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmManageClasses";
            this.Text = "frmManageClasses";
            this.Load += new System.EventHandler(this.frmManageClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.DataGridView DVGClass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label txtClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.Button btnDelete;
    }
}