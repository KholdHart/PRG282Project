namespace ManagementSystemsProject.Forms
{
    partial class GenerateForm
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
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAverage = new System.Windows.Forms.DataGridView();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnAvgAge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotal
            // 
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Location = new System.Drawing.Point(15, 12);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.RowHeadersWidth = 51;
            this.dgvTotal.RowTemplate.Height = 24;
            this.dgvTotal.Size = new System.Drawing.Size(376, 322);
            this.dgvTotal.TabIndex = 3;
            this.dgvTotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotal_CellContentClick);
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(15, 426);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(121, 38);
            this.btnBack2.TabIndex = 4;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAverage
            // 
            this.dgvAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAverage.Location = new System.Drawing.Point(433, 12);
            this.dgvAverage.Name = "dgvAverage";
            this.dgvAverage.RowHeadersWidth = 51;
            this.dgvAverage.RowTemplate.Height = 24;
            this.dgvAverage.Size = new System.Drawing.Size(376, 322);
            this.dgvAverage.TabIndex = 6;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(154, 364);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(109, 38);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Total Student";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnAvgAge
            // 
            this.btnAvgAge.Location = new System.Drawing.Point(565, 364);
            this.btnAvgAge.Name = "btnAvgAge";
            this.btnAvgAge.Size = new System.Drawing.Size(109, 38);
            this.btnAvgAge.TabIndex = 8;
            this.btnAvgAge.Text = "Average Age";
            this.btnAvgAge.UseVisualStyleBackColor = true;
            this.btnAvgAge.Click += new System.EventHandler(this.btnAvgAge_Click_1);
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 476);
            this.Controls.Add(this.btnAvgAge);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.dgvAverage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.dgvTotal);
            this.Name = "GenerateForm";
            this.Text = "GenerateForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAverage;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnAvgAge;
    }
}