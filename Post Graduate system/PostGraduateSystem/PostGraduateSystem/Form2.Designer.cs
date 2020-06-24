namespace PostGraduateSystem
{
    partial class Form2
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
            this.Course_Name = new System.Windows.Forms.Label();
            this.dgv_Courses = new System.Windows.Forms.DataGridView();
            this.searchbt = new System.Windows.Forms.Button();
            this.Course_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // Course_Name
            // 
            this.Course_Name.AutoSize = true;
            this.Course_Name.Location = new System.Drawing.Point(105, 82);
            this.Course_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Course_Name.Name = "Course_Name";
            this.Course_Name.Size = new System.Drawing.Size(94, 17);
            this.Course_Name.TabIndex = 10;
            this.Course_Name.Text = "Course Name";
            // 
            // dgv_Courses
            // 
            this.dgv_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Courses.Location = new System.Drawing.Point(166, 238);
            this.dgv_Courses.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Courses.Name = "dgv_Courses";
            this.dgv_Courses.Size = new System.Drawing.Size(380, 209);
            this.dgv_Courses.TabIndex = 9;
            // 
            // searchbt
            // 
            this.searchbt.Location = new System.Drawing.Point(305, 170);
            this.searchbt.Margin = new System.Windows.Forms.Padding(4);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(112, 28);
            this.searchbt.TabIndex = 8;
            this.searchbt.Text = "Search";
            this.searchbt.UseVisualStyleBackColor = true;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // Course_txt
            // 
            this.Course_txt.Location = new System.Drawing.Point(264, 79);
            this.Course_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Course_txt.Name = "Course_txt";
            this.Course_txt.Size = new System.Drawing.Size(187, 22);
            this.Course_txt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Course_Name);
            this.Controls.Add(this.dgv_Courses);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.Course_txt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Course_Name;
        private System.Windows.Forms.DataGridView dgv_Courses;
        private System.Windows.Forms.Button searchbt;
        private System.Windows.Forms.TextBox Course_txt;
        private System.Windows.Forms.Button button1;
    }
}