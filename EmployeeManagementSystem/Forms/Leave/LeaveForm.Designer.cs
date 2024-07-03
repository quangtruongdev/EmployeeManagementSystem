namespace EmployeeManagementSystem.Forms.Leave
{
    partial class LeaveForm
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
            this.ErrorName = new System.Windows.Forms.Label();
            this.Cbx_AllEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeaveTypeContainer = new System.Windows.Forms.Panel();
            this.ErrorLeaveType = new System.Windows.Forms.Label();
            this.Cbx_LeaveType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DT_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ErrorDate = new System.Windows.Forms.Label();
            this.DT_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ErrorStatus = new System.Windows.Forms.Label();
            this.Cbx_Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_Reason = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txt_Note = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.LeaveTypeContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ErrorName);
            this.panel1.Controls.Add(this.Cbx_AllEmployees);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 70);
            this.panel1.TabIndex = 0;
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(0, 54);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(0, 16);
            this.ErrorName.TabIndex = 8;
            // 
            // Cbx_AllEmployees
            // 
            this.Cbx_AllEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cbx_AllEmployees.FormattingEnabled = true;
            this.Cbx_AllEmployees.IntegralHeight = false;
            this.Cbx_AllEmployees.ItemHeight = 16;
            this.Cbx_AllEmployees.Location = new System.Drawing.Point(0, 16);
            this.Cbx_AllEmployees.Name = "Cbx_AllEmployees";
            this.Cbx_AllEmployees.Size = new System.Drawing.Size(275, 24);
            this.Cbx_AllEmployees.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // LeaveTypeContainer
            // 
            this.LeaveTypeContainer.Controls.Add(this.ErrorLeaveType);
            this.LeaveTypeContainer.Controls.Add(this.Cbx_LeaveType);
            this.LeaveTypeContainer.Controls.Add(this.label2);
            this.LeaveTypeContainer.Location = new System.Drawing.Point(313, 12);
            this.LeaveTypeContainer.Name = "LeaveTypeContainer";
            this.LeaveTypeContainer.Size = new System.Drawing.Size(275, 70);
            this.LeaveTypeContainer.TabIndex = 1;
            // 
            // ErrorLeaveType
            // 
            this.ErrorLeaveType.AutoSize = true;
            this.ErrorLeaveType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorLeaveType.ForeColor = System.Drawing.Color.Red;
            this.ErrorLeaveType.Location = new System.Drawing.Point(0, 54);
            this.ErrorLeaveType.Name = "ErrorLeaveType";
            this.ErrorLeaveType.Size = new System.Drawing.Size(0, 16);
            this.ErrorLeaveType.TabIndex = 2;
            // 
            // Cbx_LeaveType
            // 
            this.Cbx_LeaveType.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cbx_LeaveType.FormattingEnabled = true;
            this.Cbx_LeaveType.ItemHeight = 16;
            this.Cbx_LeaveType.Location = new System.Drawing.Point(0, 16);
            this.Cbx_LeaveType.Name = "Cbx_LeaveType";
            this.Cbx_LeaveType.Size = new System.Drawing.Size(275, 24);
            this.Cbx_LeaveType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Leave Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DT_StartDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 70);
            this.panel2.TabIndex = 2;
            // 
            // DT_StartDate
            // 
            this.DT_StartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.DT_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_StartDate.Location = new System.Drawing.Point(0, 16);
            this.DT_StartDate.Name = "DT_StartDate";
            this.DT_StartDate.Size = new System.Drawing.Size(275, 22);
            this.DT_StartDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Start Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ErrorDate);
            this.panel3.Controls.Add(this.DT_EndDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(313, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 70);
            this.panel3.TabIndex = 3;
            // 
            // ErrorDate
            // 
            this.ErrorDate.AutoSize = true;
            this.ErrorDate.ForeColor = System.Drawing.Color.Red;
            this.ErrorDate.Location = new System.Drawing.Point(3, 45);
            this.ErrorDate.Name = "ErrorDate";
            this.ErrorDate.Size = new System.Drawing.Size(0, 16);
            this.ErrorDate.TabIndex = 10;
            // 
            // DT_EndDate
            // 
            this.DT_EndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.DT_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_EndDate.Location = new System.Drawing.Point(0, 16);
            this.DT_EndDate.Name = "DT_EndDate";
            this.DT_EndDate.Size = new System.Drawing.Size(275, 22);
            this.DT_EndDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ErrorStatus);
            this.panel4.Controls.Add(this.Cbx_Status);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 70);
            this.panel4.TabIndex = 3;
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.AutoSize = true;
            this.ErrorStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.ErrorStatus.Location = new System.Drawing.Point(0, 54);
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(0, 16);
            this.ErrorStatus.TabIndex = 2;
            // 
            // Cbx_Status
            // 
            this.Cbx_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cbx_Status.FormattingEnabled = true;
            this.Cbx_Status.ItemHeight = 16;
            this.Cbx_Status.Location = new System.Drawing.Point(0, 16);
            this.Cbx_Status.Name = "Cbx_Status";
            this.Cbx_Status.Size = new System.Drawing.Size(275, 24);
            this.Cbx_Status.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Txt_Reason);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(576, 70);
            this.panel5.TabIndex = 4;
            // 
            // Txt_Reason
            // 
            this.Txt_Reason.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_Reason.Location = new System.Drawing.Point(0, 23);
            this.Txt_Reason.Multiline = true;
            this.Txt_Reason.Name = "Txt_Reason";
            this.Txt_Reason.Size = new System.Drawing.Size(576, 47);
            this.Txt_Reason.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reason";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Txt_Note);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(12, 316);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(576, 70);
            this.panel6.TabIndex = 5;
            // 
            // Txt_Note
            // 
            this.Txt_Note.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_Note.Location = new System.Drawing.Point(0, 19);
            this.Txt_Note.Multiline = true;
            this.Txt_Note.Name = "Txt_Note";
            this.Txt_Note.Size = new System.Drawing.Size(576, 51);
            this.Txt_Note.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(382, 403);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(100, 35);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(488, 403);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(100, 35);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Cancel";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LeaveTypeContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.Name = "LeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LeaveTypeContainer.ResumeLayout(false);
            this.LeaveTypeContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cbx_AllEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LeaveTypeContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_LeaveType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DateTimePicker DT_StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_EndDate;
        private System.Windows.Forms.ComboBox Cbx_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Reason;
        private System.Windows.Forms.TextBox Txt_Note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorLeaveType;
        private System.Windows.Forms.Label ErrorStatus;
        private System.Windows.Forms.Label ErrorDate;
    }
}