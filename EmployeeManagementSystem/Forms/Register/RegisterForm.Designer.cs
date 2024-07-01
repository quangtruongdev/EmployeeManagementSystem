namespace EmployeeManagementSystem.Forms.Register
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.PictureContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameContainer = new System.Windows.Forms.Panel();
            this.UsernameError = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordContainer = new System.Windows.Forms.Panel();
            this.PasswordError = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmPasswordContainer = new System.Windows.Forms.Panel();
            this.ConfirmPasswordError = new System.Windows.Forms.Label();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Link_Login = new System.Windows.Forms.Label();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.PictureContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UsernameContainer.SuspendLayout();
            this.PasswordContainer.SuspendLayout();
            this.ConfirmPasswordContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureContainer
            // 
            this.PictureContainer.Controls.Add(this.pictureBox1);
            this.PictureContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureContainer.Location = new System.Drawing.Point(0, 0);
            this.PictureContainer.Name = "PictureContainer";
            this.PictureContainer.Size = new System.Drawing.Size(400, 450);
            this.PictureContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter details to create your account";
            // 
            // UsernameContainer
            // 
            this.UsernameContainer.Controls.Add(this.UsernameError);
            this.UsernameContainer.Controls.Add(this.UsernameInput);
            this.UsernameContainer.Controls.Add(this.label3);
            this.UsernameContainer.Location = new System.Drawing.Point(450, 112);
            this.UsernameContainer.Name = "UsernameContainer";
            this.UsernameContainer.Size = new System.Drawing.Size(300, 60);
            this.UsernameContainer.TabIndex = 3;
            // 
            // UsernameError
            // 
            this.UsernameError.AutoSize = true;
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(3, 41);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.Size = new System.Drawing.Size(0, 16);
            this.UsernameError.TabIndex = 1;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsernameInput.Location = new System.Drawing.Point(0, 16);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(300, 22);
            this.UsernameInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // PasswordContainer
            // 
            this.PasswordContainer.Controls.Add(this.PasswordError);
            this.PasswordContainer.Controls.Add(this.PasswordInput);
            this.PasswordContainer.Controls.Add(this.label5);
            this.PasswordContainer.Location = new System.Drawing.Point(450, 178);
            this.PasswordContainer.Name = "PasswordContainer";
            this.PasswordContainer.Size = new System.Drawing.Size(300, 60);
            this.PasswordContainer.TabIndex = 5;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(3, 41);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(0, 16);
            this.PasswordError.TabIndex = 2;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordInput.Location = new System.Drawing.Point(0, 16);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(300, 22);
            this.PasswordInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // ConfirmPasswordContainer
            // 
            this.ConfirmPasswordContainer.Controls.Add(this.ConfirmPasswordError);
            this.ConfirmPasswordContainer.Controls.Add(this.ConfirmPasswordInput);
            this.ConfirmPasswordContainer.Controls.Add(this.label6);
            this.ConfirmPasswordContainer.Location = new System.Drawing.Point(450, 244);
            this.ConfirmPasswordContainer.Name = "ConfirmPasswordContainer";
            this.ConfirmPasswordContainer.Size = new System.Drawing.Size(300, 60);
            this.ConfirmPasswordContainer.TabIndex = 6;
            // 
            // ConfirmPasswordError
            // 
            this.ConfirmPasswordError.AutoSize = true;
            this.ConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.ConfirmPasswordError.Location = new System.Drawing.Point(4, 41);
            this.ConfirmPasswordError.Name = "ConfirmPasswordError";
            this.ConfirmPasswordError.Size = new System.Drawing.Size(0, 16);
            this.ConfirmPasswordError.TabIndex = 2;
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(0, 16);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(300, 22);
            this.ConfirmPasswordInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Already Registered?";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Link_Login);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(453, 310);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 20);
            this.panel6.TabIndex = 8;
            // 
            // Link_Login
            // 
            this.Link_Login.AutoSize = true;
            this.Link_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.Link_Login.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Link_Login.Location = new System.Drawing.Point(135, 0);
            this.Link_Login.Name = "Link_Login";
            this.Link_Login.Size = new System.Drawing.Size(40, 16);
            this.Link_Login.TabIndex = 8;
            this.Link_Login.Text = "Login";
            this.Link_Login.Click += new System.EventHandler(this.Link_Login_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(450, 336);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(300, 45);
            this.Btn_Register.TabIndex = 9;
            this.Btn_Register.Text = "Sign up";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ConfirmPasswordContainer);
            this.Controls.Add(this.PasswordContainer);
            this.Controls.Add(this.UsernameContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.PictureContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UsernameContainer.ResumeLayout(false);
            this.UsernameContainer.PerformLayout();
            this.PasswordContainer.ResumeLayout(false);
            this.PasswordContainer.PerformLayout();
            this.ConfirmPasswordContainer.ResumeLayout(false);
            this.ConfirmPasswordContainer.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PictureContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel UsernameContainer;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PasswordContainer;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel ConfirmPasswordContainer;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Link_Login;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label UsernameError;
        private System.Windows.Forms.Label PasswordError;
        private System.Windows.Forms.Label ConfirmPasswordError;
    }
}