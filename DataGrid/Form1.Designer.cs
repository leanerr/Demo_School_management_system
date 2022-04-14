namespace DataGrid
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Section";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(121, 214);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(100, 20);
            this.txtSection.TabIndex = 13;
            this.txtSection.TextChanged += new System.EventHandler(this.txtSection_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(135, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(119, 177);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.TabIndex = 9;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(67, 180);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(32, 13);
            this.Class.TabIndex = 4;
            this.Class.Text = "Class";
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(135, 141);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 3;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(135, 98);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 20);
            this.txtSname.TabIndex = 1;
            this.txtSname.TextChanged += new System.EventHandler(this.txtSname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 367);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "inputData";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label1;
    }
}

