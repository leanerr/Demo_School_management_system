namespace DataGrid
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.txtClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(92, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.Red;
            this.btnManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManage.Location = new System.Drawing.Point(92, 116);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(75, 23);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = " Student info";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // txtClasses
            // 
            this.txtClasses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClasses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtClasses.Location = new System.Drawing.Point(92, 167);
            this.txtClasses.Name = "txtClasses";
            this.txtClasses.Size = new System.Drawing.Size(75, 23);
            this.txtClasses.TabIndex = 2;
            this.txtClasses.Text = "Classes";
            this.txtClasses.UseVisualStyleBackColor = false;
            this.txtClasses.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 314);
            this.Controls.Add(this.txtClasses);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button txtClasses;
    }
}