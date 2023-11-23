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
            this.btnShowStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowCourses
            // 
            this.btnShowCourses.Location = new System.Drawing.Point(274, 306);
            this.btnShowCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowCourses.Name = "btnShowCourses";
            this.btnShowCourses.Size = new System.Drawing.Size(113, 37);
            this.btnShowCourses.TabIndex = 1;
            this.btnShowCourses.Text = "Show Courses";
            this.btnShowCourses.UseVisualStyleBackColor = true;
            this.btnShowCourses.Click += new System.EventHandler(this.btnShowCourses_Click);
            // 
            // btnShowPrograms
            // 
            this.btnShowPrograms.Location = new System.Drawing.Point(141, 306);
            this.btnShowPrograms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowPrograms.Name = "btnShowPrograms";
            this.btnShowPrograms.Size = new System.Drawing.Size(113, 37);
            this.btnShowPrograms.TabIndex = 2;
            this.btnShowPrograms.Text = "Show Programs";
            this.btnShowPrograms.UseVisualStyleBackColor = true;
            this.btnShowPrograms.Click += new System.EventHandler(this.btnShowPrograms_Click_1);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(12, 306);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(113, 37);
            this.btnShowStudents.TabIndex = 3;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 412);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnShowPrograms);
            this.Controls.Add(this.btnShowCourses);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnShowStudents;
    }
}

