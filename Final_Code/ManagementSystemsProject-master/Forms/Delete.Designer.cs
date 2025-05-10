namespace ManagementSystemsProject.Forms
{
    partial class Delete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncBack = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btncBack);
            this.panel1.Controls.Add(this.btnUpdate1);
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 116);
            this.panel1.TabIndex = 1;
            // 
            // btncBack
            // 
            this.btncBack.Location = new System.Drawing.Point(13, 82);
            this.btncBack.Margin = new System.Windows.Forms.Padding(2);
            this.btncBack.Name = "btncBack";
            this.btncBack.Size = new System.Drawing.Size(68, 22);
            this.btncBack.TabIndex = 10;
            this.btncBack.Text = "Back";
            this.btncBack.UseVisualStyleBackColor = true;
            this.btncBack.Click += new System.EventHandler(this.btncBack_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Location = new System.Drawing.Point(152, 55);
            this.btnUpdate1.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(68, 22);
            this.btnUpdate1.TabIndex = 11;
            this.btnUpdate1.Text = "Delete";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.AutoSize = true;
            this.txtStudentID.Location = new System.Drawing.Point(159, 15);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(61, 13);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.Text = "StudentID: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 387);
            this.dataGridView1.TabIndex = 4;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtStudentID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btncBack;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}