namespace PostGraduateSystem
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
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stud_rb = new System.Windows.Forms.RadioButton();
            this.tech_rb = new System.Windows.Forms.RadioButton();
            this.course_rb = new System.Windows.Forms.RadioButton();
            this.loadInformation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(214, 477);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 28);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stud_rb);
            this.groupBox1.Controls.Add(this.tech_rb);
            this.groupBox1.Controls.Add(this.course_rb);
            this.groupBox1.Location = new System.Drawing.Point(302, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // stud_rb
            // 
            this.stud_rb.AutoSize = true;
            this.stud_rb.Location = new System.Drawing.Point(73, 80);
            this.stud_rb.Margin = new System.Windows.Forms.Padding(4);
            this.stud_rb.Name = "stud_rb";
            this.stud_rb.Size = new System.Drawing.Size(112, 21);
            this.stud_rb.TabIndex = 9;
            this.stud_rb.TabStop = true;
            this.stud_rb.Text = "Students Info";
            this.stud_rb.UseVisualStyleBackColor = true;
            // 
            // tech_rb
            // 
            this.tech_rb.AutoSize = true;
            this.tech_rb.Location = new System.Drawing.Point(73, 52);
            this.tech_rb.Margin = new System.Windows.Forms.Padding(4);
            this.tech_rb.Name = "tech_rb";
            this.tech_rb.Size = new System.Drawing.Size(124, 21);
            this.tech_rb.TabIndex = 1;
            this.tech_rb.TabStop = true;
            this.tech_rb.Text = "Teachears Info";
            this.tech_rb.UseVisualStyleBackColor = true;
            // 
            // course_rb
            // 
            this.course_rb.AutoSize = true;
            this.course_rb.Location = new System.Drawing.Point(73, 23);
            this.course_rb.Margin = new System.Windows.Forms.Padding(4);
            this.course_rb.Name = "course_rb";
            this.course_rb.Size = new System.Drawing.Size(108, 21);
            this.course_rb.TabIndex = 0;
            this.course_rb.TabStop = true;
            this.course_rb.Text = "Courses Info";
            this.course_rb.UseVisualStyleBackColor = true;
            // 
            // loadInformation
            // 
            this.loadInformation.Location = new System.Drawing.Point(375, 164);
            this.loadInformation.Margin = new System.Windows.Forms.Padding(4);
            this.loadInformation.Name = "loadInformation";
            this.loadInformation.Size = new System.Drawing.Size(128, 28);
            this.loadInformation.TabIndex = 12;
            this.loadInformation.Text = "Load Information";
            this.loadInformation.UseVisualStyleBackColor = true;
            this.loadInformation.Click += new System.EventHandler(this.loadInformation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 224);
            this.dataGridView1.TabIndex = 11;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(604, 477);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadInformation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton stud_rb;
        private System.Windows.Forms.RadioButton tech_rb;
        private System.Windows.Forms.RadioButton course_rb;
        private System.Windows.Forms.Button loadInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button1;
    }
}