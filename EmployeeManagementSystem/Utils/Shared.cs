using EmployeeManagementSystem.Forms;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Utils
{
    public class Shared
    {
        public static void ShowMainContent(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        public static void ShowToastr(string type, string message)
        {
            Toastr toastr = new Toastr(type, message);
            toastr.Show();
        }
    }
}
