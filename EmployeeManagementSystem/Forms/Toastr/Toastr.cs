using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;

namespace EmployeeManagementSystem.Forms
{
    public partial class Toastr : Form
    {
        int toastX, toastY;
        public Toastr(string type, string message)
        {
            InitializeComponent();
            lbType.Text = type;
            lbMessage.Text = message;
            switch (type)
            {
                case "Success":
                    toastrBorder.BackColor = Color.FromArgb(57, 155, 53);
                    picIcon.Image = Properties.Resources.success;
                    break;
                case "Error":
                    toastrBorder.BackColor = Color.FromArgb(227, 50, 45);
                    picIcon.Image = Properties.Resources.error;
                    break;
                case "Warning":
                    toastrBorder.BackColor = Color.FromArgb(18, 136, 191);
                    picIcon.Image = Properties.Resources.warning;
                    break;
                case "Info":
                    toastrBorder.BackColor = Color.FromArgb(18, 136, 191);
                    picIcon.Image = Properties.Resources.info;
                    break;
            }

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.BringToFront();
        }

        private void Toastr_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void toastrTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if(toastY <= 760)
            {
                toastrTimer.Stop();
                var hideDelay = new Timer { Interval = 2000 }; // Adjust this value to control how long the toast is visible
                hideDelay.Tick += (s, args) =>
                {
                    hideDelay.Stop();
                    toastrHide.Start();
                };
                hideDelay.Start();
            }
        }

        int y = 100;
        private void toastrHide_Tick(object sender, EventArgs e)
        {
            y--;
            if(y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if(toastY >= 800)
                {
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height + 70;

            this.Location = new Point(toastX, toastY);
        }
    }
}
