namespace EmployeeManagementSystem.Forms.Leave
{
    partial class LeaveTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_LeaveTypeName = new System.Windows.Forms.TextBox();
            this.ErrorLeaveName = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave name";
            // 
            // Txt_LeaveTypeName
            // 
            this.Txt_LeaveTypeName.Location = new System.Drawing.Point(16, 33);
            this.Txt_LeaveTypeName.Name = "Txt_LeaveTypeName";
            this.Txt_LeaveTypeName.Size = new System.Drawing.Size(354, 22);
            this.Txt_LeaveTypeName.TabIndex = 1;
            // 
            // ErrorLeaveName
            // 
            this.ErrorLeaveName.AutoSize = true;
            this.ErrorLeaveName.ForeColor = System.Drawing.Color.Red;
            this.ErrorLeaveName.Location = new System.Drawing.Point(16, 62);
            this.ErrorLeaveName.Name = "ErrorLeaveName";
            this.ErrorLeaveName.Size = new System.Drawing.Size(0, 16);
            this.ErrorLeaveName.TabIndex = 2;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(120, 80);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(150, 45);
            this.Btn_Submit.TabIndex = 3;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // LeaveTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.ErrorLeaveName);
            this.Controls.Add(this.Txt_LeaveTypeName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "LeaveTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_LeaveTypeName;
        private System.Windows.Forms.Label ErrorLeaveName;
        private System.Windows.Forms.Button Btn_Submit;
    }
}