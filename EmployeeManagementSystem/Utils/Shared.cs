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
    }
}
