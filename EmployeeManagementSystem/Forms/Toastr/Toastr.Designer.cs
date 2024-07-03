namespace EmployeeManagementSystem.Forms
{
    partial class Toastr
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
            this.components = new System.ComponentModel.Container();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.toastrBorder = new System.Windows.Forms.Panel();
            this.toastrTimer = new System.Windows.Forms.Timer(this.components);
            this.toastrHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Image = global::EmployeeManagementSystem.Properties.Resources.success;
            this.picIcon.Location = new System.Drawing.Point(25, 21);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(35, 35);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(84, 14);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(115, 22);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "TitleAlertBox";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(85, 45);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(83, 17);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "TextAlertBox";
            // 
            // toastrBorder
            // 
            this.toastrBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toastrBorder.Location = new System.Drawing.Point(-1, 0);
            this.toastrBorder.Name = "toastrBorder";
            this.toastrBorder.Size = new System.Drawing.Size(10, 80);
            this.toastrBorder.TabIndex = 2;
            // 
            // toastrTimer
            // 
            this.toastrTimer.Enabled = true;
            this.toastrTimer.Interval = 20;
            this.toastrTimer.Tick += new System.EventHandler(this.toastrTimer_Tick);
            // 
            // toastrHide
            // 
            this.toastrHide.Interval = 10;
            this.toastrHide.Tick += new System.EventHandler(this.toastrHide_Tick);
            // 
            // Toastr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 80);
            this.Controls.Add(this.toastrBorder);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Toastr";
            this.Text = "Toastr";
            this.Load += new System.EventHandler(this.Toastr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel toastrBorder;
        private System.Windows.Forms.Timer toastrTimer;
        private System.Windows.Forms.Timer toastrHide;
    }
}