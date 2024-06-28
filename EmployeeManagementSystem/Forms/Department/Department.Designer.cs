namespace EmployeeManagementSystem.Forms.Department
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_AddDepartment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // Btn_AddDepartment
            // 
            this.Btn_AddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddDepartment.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddDepartment.Image")));
            this.Btn_AddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddDepartment.Location = new System.Drawing.Point(588, 5);
            this.Btn_AddDepartment.Name = "Btn_AddDepartment";
            this.Btn_AddDepartment.Size = new System.Drawing.Size(200, 45);
            this.Btn_AddDepartment.TabIndex = 1;
            this.Btn_AddDepartment.Text = "Add Department";
            this.Btn_AddDepartment.UseVisualStyleBackColor = true;
            this.Btn_AddDepartment.Click += new System.EventHandler(this.Btn_AddDepartment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 2;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_AddDepartment;
        private System.Windows.Forms.Panel panel2;
    }
}