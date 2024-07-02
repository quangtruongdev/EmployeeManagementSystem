namespace EmployeeManagementSystem.Forms.Project
{
    partial class AddProject
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
            this.projectLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitBtn = new System.Windows.Forms.Button();
            this.projectNameErrorLabel = new System.Windows.Forms.Label();
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.startDateErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectLabel
            // 
            this.projectLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.Location = new System.Drawing.Point(170, 80);
            this.projectLabel.MinimumSize = new System.Drawing.Size(150, 25);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(150, 25);
            this.projectLabel.TabIndex = 0;
            this.projectLabel.Text = "Create Project";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.projectNameTextBox.Location = new System.Drawing.Point(102, 184);
            this.projectNameTextBox.MinimumSize = new System.Drawing.Size(284, 22);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(298, 22);
            this.projectNameTextBox.TabIndex = 0;
            this.projectNameTextBox.TextChanged += new System.EventHandler(this.projectNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 162);
            this.label2.MinimumSize = new System.Drawing.Size(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Name";
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(102, 256);
            this.projectDescriptionTextBox.MinimumSize = new System.Drawing.Size(284, 22);
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(298, 22);
            this.projectDescriptionTextBox.TabIndex = 1;
            this.projectDescriptionTextBox.TextChanged += new System.EventHandler(this.projectDescriptionTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 234);
            this.label3.MinimumSize = new System.Drawing.Size(284, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Description";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(102, 321);
            this.startDateDateTimePicker.MinimumSize = new System.Drawing.Size(284, 22);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(298, 22);
            this.startDateDateTimePicker.TabIndex = 2;
            this.startDateDateTimePicker.ValueChanged += new System.EventHandler(this.startDateDateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 302);
            this.label4.MinimumSize = new System.Drawing.Size(284, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 375);
            this.label5.MinimumSize = new System.Drawing.Size(284, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Date";
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(102, 394);
            this.endDateDateTimePicker.MinimumSize = new System.Drawing.Size(284, 22);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(298, 22);
            this.endDateDateTimePicker.TabIndex = 3;
            this.endDateDateTimePicker.ValueChanged += new System.EventHandler(this.endDateDateTimePicker_ValueChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Enabled = false;
            this.submitBtn.Location = new System.Drawing.Point(161, 461);
            this.submitBtn.MinimumSize = new System.Drawing.Size(145, 37);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(159, 37);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // projectNameErrorLabel
            // 
            this.projectNameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.projectNameErrorLabel.AutoSize = true;
            this.projectNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.projectNameErrorLabel.Location = new System.Drawing.Point(102, 209);
            this.projectNameErrorLabel.Name = "projectNameErrorLabel";
            this.projectNameErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.projectNameErrorLabel.TabIndex = 5;
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endDateErrorLabel.Location = new System.Drawing.Point(102, 419);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.endDateErrorLabel.TabIndex = 6;
            // 
            // startDateErrorLabel
            // 
            this.startDateErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateErrorLabel.AutoSize = true;
            this.startDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.startDateErrorLabel.Location = new System.Drawing.Point(99, 346);
            this.startDateErrorLabel.Name = "startDateErrorLabel";
            this.startDateErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.startDateErrorLabel.TabIndex = 6;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 593);
            this.Controls.Add(this.startDateErrorLabel);
            this.Controls.Add(this.endDateErrorLabel);
            this.Controls.Add(this.projectNameErrorLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectDescriptionTextBox);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.projectLabel);
            this.MinimumSize = new System.Drawing.Size(524, 640);
            this.Name = "AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label projectNameErrorLabel;
        private System.Windows.Forms.Label endDateErrorLabel;
        private System.Windows.Forms.Label startDateErrorLabel;
    }
}