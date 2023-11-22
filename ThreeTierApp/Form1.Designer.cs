namespace ThreeTierApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowCourses = new System.Windows.Forms.Button();
            this.btnShowPrograms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowCourses
            // 
            this.btnShowCourses.Location = new System.Drawing.Point(410, 376);
            this.btnShowCourses.Name = "btnShowCourses";
            this.btnShowCourses.Size = new System.Drawing.Size(116, 45);
            this.btnShowCourses.TabIndex = 1;
            this.btnShowCourses.Text = "showcourse";
            this.btnShowCourses.UseVisualStyleBackColor = true;
    //        this.btnShowCourses.Click += new System.EventHandler(this.btnShowCourses_Click_1);
            // 
            // btnShowPrograms
            // 
            this.btnShowPrograms.Location = new System.Drawing.Point(131, 376);
            this.btnShowPrograms.Name = "btnShowPrograms";
            this.btnShowPrograms.Size = new System.Drawing.Size(116, 45);
            this.btnShowPrograms.TabIndex = 2;
            this.btnShowPrograms.Text = "showprogram";
            this.btnShowPrograms.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 507);
            this.Controls.Add(this.btnShowPrograms);
            this.Controls.Add(this.btnShowCourses);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowCourses;
        private System.Windows.Forms.Button btnShowPrograms;
    }
}

