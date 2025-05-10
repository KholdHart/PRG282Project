namespace ManagementSystemsProject
{
    partial class frmMain
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
            this.pnlProject = new System.Windows.Forms.Panel();
            this.lblStudentMS = new System.Windows.Forms.Label();
            this.pnlCore = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlProject.SuspendLayout();
            this.pnlCore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProject
            // 
            this.pnlProject.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlProject.Controls.Add(this.lblStudentMS);
            this.pnlProject.Location = new System.Drawing.Point(41, 19);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(958, 105);
            this.pnlProject.TabIndex = 0;
            this.pnlProject.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProject_Paint);
            // 
            // lblStudentMS
            // 
            this.lblStudentMS.AutoSize = true;
            this.lblStudentMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMS.Location = new System.Drawing.Point(196, 30);
            this.lblStudentMS.Name = "lblStudentMS";
            this.lblStudentMS.Size = new System.Drawing.Size(568, 46);
            this.lblStudentMS.TabIndex = 0;
            this.lblStudentMS.Text = "Student Management System";
            this.lblStudentMS.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlCore
            // 
            this.pnlCore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlCore.Controls.Add(this.btnExit);
            this.pnlCore.Controls.Add(this.btnGenerate);
            this.pnlCore.Controls.Add(this.btnDelete);
            this.pnlCore.Controls.Add(this.btnUpdate);
            this.pnlCore.Controls.Add(this.btnView);
            this.pnlCore.Controls.Add(this.btnAdd);
            this.pnlCore.Location = new System.Drawing.Point(172, 199);
            this.pnlCore.Name = "pnlCore";
            this.pnlCore.Size = new System.Drawing.Size(700, 427);
            this.pnlCore.TabIndex = 1;
            this.pnlCore.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCore_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(154, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(386, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(154, 278);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(386, 41);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate a Summary Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(154, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(386, 38);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete a Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(154, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(386, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Student Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(154, 107);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(386, 36);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View All Students";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(154, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(386, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 713);
            this.Controls.Add(this.pnlCore);
            this.Controls.Add(this.pnlProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Main";
            this.pnlProject.ResumeLayout(false);
            this.pnlProject.PerformLayout();
            this.pnlCore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProject;
        private System.Windows.Forms.Label lblStudentMS;
        private System.Windows.Forms.Panel pnlCore;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}

